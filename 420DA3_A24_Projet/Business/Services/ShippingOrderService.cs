using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Domain.Pivots;
using _420DA3_A24_Projet.Business.Domain.Utils;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// TODO @PROF: documenter
/// </summary>
internal class ShippingOrderService {

    private WsysApplication parentApp;
    private ShippingOrderDAO dao;
    private ShippingOrderView view;
    private WsysDbContext context;

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public ShippingOrderService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.context = context;
        this.dao = new ShippingOrderDAO(context);
        this.view = new ShippingOrderView(parentApp);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ShippingOrder? OpenManagementWindowForCreation() {
        ShippingOrder order = (ShippingOrder) FormatterServices.GetUninitializedObject(typeof(ShippingOrder));
        order.CreatorEmployee = this.parentApp.LoginService.LoggedInUser ?? throw new Exception("Un utilisateur doit être connecté pour pouvoir créer un ordre d'Expédition.");
        order.Status = ShippingOrderStatusEnum.New;
        DialogResult result = this.view.OpenForCreation(order);
        return result == DialogResult.OK ? this.CreateOrder(order) : null;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public ShippingOrder OpenManagementWindowForEdition(ShippingOrder order) {

        DialogResult result = this.view.OpenForModification(order);
        return order;

    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public ShippingOrder OpenManagementWindowForDeletion(ShippingOrder order) {
        DialogResult result = this.view.OpenForDeletion(order);
        return order;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public ShippingOrder OpenManagementWindowForDetailsView(ShippingOrder order) {
        DialogResult result = this.view.OpenForDetailsView(order);
        return order;

    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public ShippingOrder? GetById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetUnassignedOrdersByWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        return this.dao.GetUnassignedByWarehouse(warehouse, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="employee"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetProcessingOrdersByEmployee(User employee, bool includeDeleted = false) {
        return this.dao.GetProcessingByEmployee(employee, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="warehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetPackagedOrdersByWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        return this.dao.GetPackagedByWarehouse(warehouse, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> SearchOrders(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="order"></param>
    /// <param name="modifications"></param>
    public void CancelOrderChanges(ShippingOrder order, List<ShippingOrderProductModification> modifications, Adresse? createdAddress = null) {

        foreach (ShippingOrderProductModification modification in modifications) {
            switch (modification.ModificationType) {
                case ShippingOrderProductModificationTypeEnum.Addition:
                    _ = order.ShippingOrderProducts.Remove(modification.ShippingOrderProduct);
                    break;
                case ShippingOrderProductModificationTypeEnum.Modification:
                    modification.ShippingOrderProduct.Quantity = modification.OriginalQuantity;
                    break;
                case ShippingOrderProductModificationTypeEnum.Removal:
                    order.ShippingOrderProducts.Add(modification.ShippingOrderProduct);
                    break;
            }
        }
        if (createdAddress != null) {
            // TODO @PROF: voir comment gérer la suppression de l'adresse créée
            // Une fois le service complété. Normalement, ne devrait pas supprimer par Id...
            this.parentApp.AdresseService.Delete(createdAddress.AdresseId);
        }
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public ShippingOrder CreateOrder(ShippingOrder order) {
        // TODO @PROF: vérifier si EF Core va supporter cette approche avec les ShippingOrderProducts
        // qui n'ont pas de ShippingOrderId encore.
        foreach (ShippingOrderProduct sop in order.ShippingOrderProducts) {

            // ajouter l'association SO <-> produit créé au suivi de EF Core
            _ = this.context.ShippingOrderProducts.Add(sop);

            // mettre à jour la quantité en stock du produit
            sop.Product.qteStock -= sop.Quantity;

            // Créer un ordre de restockage si la qté en stock est < 50% de la qté désirée
            if (sop.Product.qteStock < sop.Product.qteStockVise * 0.5) {
                int quantity = sop.Product.qteStockVise - sop.Product.qteStock;
                PurchaseOrder newPO = new PurchaseOrder(sop.Product.Id, order.SourceClient.EntrepotId, quantity);
                _ = parentApp.PurchaseOrderService.CreatePO(newPO);
            }
        }
        return this.dao.Create(order);

    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="order"></param>
    /// <param name="modifications"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ShippingOrder UpdateOrder(ShippingOrder order, List<ShippingOrderProductModification> modifications) {
        if (order.Status != ShippingOrderStatusEnum.Unassigned && order.Status != ShippingOrderStatusEnum.New) {
            throw new Exception("Seuls les ordres d'expédition non assignés ou nouveaux peuvent être modifiés.");
        }
        foreach (ShippingOrderProductModification sopModif in modifications) {
            switch (sopModif.ModificationType) {
                case ShippingOrderProductModificationTypeEnum.Addition:
                    // Produit ajouté à la commande

                    _ = this.context.ShippingOrderProducts.Add(sopModif.ShippingOrderProduct);

                    // mettre à jour la quantité en stock du produit
                    sopModif.ShippingOrderProduct.Product.qteStock -= sopModif.ShippingOrderProduct.Quantity;
                    _ = this.context.Produits.Update(sopModif.ShippingOrderProduct.Product);

                    // Créer un ordre de restockage si la qté en stock est < 50% de la qté désirée
                    if (sopModif.ShippingOrderProduct.Product.qteStock < sopModif.ShippingOrderProduct.Product.qteStockVise * 0.5) {
                        int quantity = sopModif.ShippingOrderProduct.Product.qteStockVise - sopModif.ShippingOrderProduct.Product.qteStock;
                        PurchaseOrder newPO = new PurchaseOrder(sopModif.ShippingOrderProduct.Product.Id, order.SourceClient.EntrepotId, quantity);
                        _ = this.context.PurchaseOrders.Add(newPO);
                    }
                    break;
                case ShippingOrderProductModificationTypeEnum.Modification:
                    // Quantité de produit dans la commande modifiée

                    if (sopModif.NewQuantity > sopModif.OriginalQuantity) {
                        // quantité augmentée

                        // mettre à jour la quantité en stock du produit
                        sopModif.ShippingOrderProduct.Product.qteStock -= sopModif.NewQuantity - sopModif.OriginalQuantity;

                        // Créer un ordre de restockage si la qté en stock est < 50% de la qté désirée
                        if (sopModif.ShippingOrderProduct.Product.qteStock < sopModif.ShippingOrderProduct.Product.qteStockVise * 0.5) {
                            int quantity = sopModif.ShippingOrderProduct.Product.qteStockVise - sopModif.ShippingOrderProduct.Product.qteStock;
                            PurchaseOrder newPO = new PurchaseOrder(sopModif.ShippingOrderProduct.Product.Id, order.SourceClient.EntrepotId, quantity);
                            _ = this.context.PurchaseOrders.Add(newPO);
                        }
                    } else {
                        // quantité diminuée (ou égale)

                        // mettre à jour la quantité en stock du produit
                        sopModif.ShippingOrderProduct.Product.qteStock += sopModif.OriginalQuantity - sopModif.NewQuantity;
                    }
                    break;
                case ShippingOrderProductModificationTypeEnum.Removal:
                    // produit retiré de la commande

                    _ = this.context.ShippingOrderProducts.Remove(sopModif.ShippingOrderProduct);

                    // mettre à jour la quantité en stock du produit
                    sopModif.ShippingOrderProduct.Product.qteStock += sopModif.ShippingOrderProduct.Quantity;
                    break;
            }
        }
        return this.dao.Update(order);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="order"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ShippingOrder DeleteOrder(ShippingOrder order, bool softDeletes = true) {
        return order.Status != ShippingOrderStatusEnum.Unassigned && order.Status != ShippingOrderStatusEnum.New
            ? throw new Exception("Seuls les ordres d'expédition non assignés ou nouveaux peuvent être supprimés.")
            : this.dao.Delete(order, softDeletes);
    }
}
