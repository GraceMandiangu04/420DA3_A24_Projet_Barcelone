using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Domain.Pivots;
using _420DA3_A24_Projet.Business.Domain.Utils;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using Project_Utilities.Exceptions;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service class for managing <see cref="ShippingOrder"/> entities.
/// </summary>
internal class ShippingOrderService {

    private readonly WsysApplication parentApp;
    private readonly ShippingOrderDAO dao;
    private readonly ShippingOrderView view;
    private readonly WsysDbContext context;

    /// <summary>
    /// <see cref="ShippingOrderService"> constructor.
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
    /// Opens the <see cref="ShippingOrderView">shipping order management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ShippingOrder? OpenManagementWindowForCreation() {
        try {
            ShippingOrder order = (ShippingOrder) FormatterServices.GetUninitializedObject(typeof(ShippingOrder));
            order.CreatorEmployee = this.parentApp.LoginService.LoggedInUser ?? throw new Exception("A user must be logged in to create a shipping order.");
            order.Status = ShippingOrderStatusEnum.New;
            DialogResult result = this.view.OpenForCreation(order);
            return result == DialogResult.OK ? order : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipping order management window in creation mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="ShippingOrderView">shipping order management window</see> in edition mode
    /// for the given <paramref name="order"/>.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForEdition(ShippingOrder order) {
        try {
            DialogResult result = this.view.OpenForModification(order);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipping order management window in edition mode.", ex);
        }

    }

    /// <summary>
    /// Opens the <see cref="ShippingOrderView">shipping order management window</see> in deletion mode
    /// for the given <paramref name="order"/>.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForDeletion(ShippingOrder order) {
        try {
            DialogResult result = this.view.OpenForDeletion(order);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipping order management window in deletion mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="ShippingOrderView">shipping order management window</see> in visualization mode
    /// for the given <paramref name="order"/>.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public ShippingOrder OpenManagementWindowForVisualization(ShippingOrder order) {
        try {
            _ = this.view.OpenForDetailsView(order);
            return order;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the shipping order management window in visualization mode.", ex);
        }

    }

    /// <summary>
    /// Assigns a given <paramref name="order"/> to a given <paramref name="user"/> (warehouse employee) for fulfillment.
    /// </summary>
    /// <param name="order"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    public ShippingOrder AssignOrderTo(ShippingOrder order, User user) {
        try {
            if (order.Status != ShippingOrderStatusEnum.Unassigned) {
                throw new ValidationException("A shipping order must have the status 'Unassigned' to be assigned to a user.");
            }
            order.AssignToFulfillerEmployee(user);
            return this.UpdateOrder(order);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to assign shipping order Id #{order.Id} to user [{user.Username}].", ex);
        }
    }

    /// <summary>
    /// Marks a given <paramref name="order"/> as packaged.
    /// </summary>
    /// <remarks>
    /// The creation of a shipment for the order is required as part of the process.
    /// </remarks>
    /// <param name="order"></param>
    /// <returns></returns>
    /// <exception cref="ValidationException"></exception>
    /// <exception cref="Exception"></exception>
    public ShippingOrder MarkOrderAsPackaged(ShippingOrder order) {
        try {
            if (order.Status != ShippingOrderStatusEnum.Processing) {
                throw new ValidationException("A shipping order must have the status 'Processing' to be marked as packaged.");
            }
            // TODO @PROF: fix this when shipment creation window will be done
            Expedition shipment = this.parentApp.ExpeditionService.OpenManagementWindowForCreation() 
                ?? throw new Exception("You must create a shipment to mark a shipping order as packaged.");
            order.MarkAsPackaged(shipment);
            return this.UpdateOrder(order);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to mark shipping order Id #{order.Id} as packaged.", ex);
        }
    }

    /// <summary>
    /// Marks a given <paramref name="order"/> as shipped.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    /// <exception cref="ValidationException"></exception>
    /// <exception cref="Exception"></exception>
    public ShippingOrder MarkOrderAsShipped(ShippingOrder order) {
        try {
            if (order.Status != ShippingOrderStatusEnum.Packaged) {
                throw new ValidationException("A shipping order must have the status 'Packaged' to be marked as shipped.");
            }
            order.MarkAsShipped();
            return this.UpdateOrder(order);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to mark shipping order Id #{order.Id} as shipped (Shipment Id #{order.Shipment?.ExpeditionId}).", ex);
        }
    }


    /// <summary>
    /// Returns the <see cref="ShippingOrder"/> whose <see cref="ShippingOrder.Id"/> 
    /// matches the given <paramref name="id"/> in the data source.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public ShippingOrder? GetById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve shipping order Id #{id}.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="ShippingOrder"/> whose 
    /// <see cref="ShippingOrder.SourceClient">Client</see>'s <see cref="Client.Entrepot">Warehouse</see> 
    /// matches the given <paramref name="warehouse"/> and whose <see cref="ShippingOrder.Status">Status</see>
    /// is <see cref="ShippingOrderStatusEnum.Unassigned"/> in the data source.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetUnassignedOrdersByWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        try {
            return this.dao.GetUnassignedByWarehouse(warehouse, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve unassigned shipping orders for warehouse Id #{warehouse.id}.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="ShippingOrder"/> whose 
    /// <see cref="ShippingOrder.FulfillerEmployee">fulfiller employee</see> matches the given 
    /// <paramref name="employee"/> and whose <see cref="ShippingOrder.Status">Status</see>
    /// is <see cref="ShippingOrderStatusEnum.Processing"/> in the data source.
    /// </summary>
    /// <param name="employee"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetProcessingOrdersByEmployee(User employee, bool includeDeleted = false) {
        try {
            return this.dao.GetProcessingByEmployee(employee, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve processing shipping orders for user Id #{employee.Id}.", ex);
        }
    }

    /// <summary>
    /// Returns the list of every <see cref="ShippingOrder"/> whose 
    /// <see cref="ShippingOrder.SourceClient">Client</see>'s <see cref="Client.Entrepot">Warehouse</see> 
    /// matches the given <paramref name="warehouse"/> and whose <see cref="ShippingOrder.Status">Status</see>
    /// is <see cref="ShippingOrderStatusEnum.Packaged"/> in the data source.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetPackagedOrdersByWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        try {
            return this.dao.GetPackagedByWarehouse(warehouse, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve packaged shipping orders for warehouse Id #{warehouse.id}.", ex);
        }
    }

    /// <summary>
    /// Returns the list of <see cref="ShippingOrder"/>s from the data source that match the given <paramref name="criterion"/>.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> SearchOrders(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search shipping orders for criterion [{criterion}].", ex);
        }
    }

    /// <summary>
    /// Cancels changes made to a <see cref="ShippingOrder"/> by the user in the user interface.
    /// </summary>
    /// <param name="order"></param>
    /// <param name="modifications"></param>
    public void CancelOrderChanges(ShippingOrder order, List<ShippingOrderProductModification> modifications, Adresse? createdAddress = null) {
        try {
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

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to cancel shipping orders changes for shipping order Id #{order.Id}.", ex);
        }

    }

    /// <summary>
    /// Inserts a <see cref="ShippingOrder"/> in the data source.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public ShippingOrder CreateOrder(ShippingOrder order) {
        try {
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

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create shipping order.", ex);
        }
    }

    /// <summary>
    /// Modifies a <see cref="ShippingOrder"/> based on a given list of <see cref="ShippingOrderProductModification">modifications</see>
    /// from the user interface.
    /// </summary>
    /// <param name="order"></param>
    /// <param name="modifications"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ShippingOrder ModifyOrder(ShippingOrder order, List<ShippingOrderProductModification> modifications) {
        try {
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
            return this.UpdateOrder(order);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to modify shipping order Id #{order.Id}.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="ShippingOrder"/> in the data source.
    /// </summary>
    /// <param name="order"></param>
    /// <param name="modifications"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ShippingOrder UpdateOrder(ShippingOrder order) {
        try {
            return this.dao.Update(order);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update shipping order Id# {order.Id}.", ex);
        }
    }



    /// <summary>
    /// Deletes a <see cref="ShippingOrder"/> from the data source.
    /// </summary>
    /// <param name="order"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public ShippingOrder DeleteOrder(ShippingOrder order, bool softDeletes = true) {
        try {
            return order.Status != ShippingOrderStatusEnum.Unassigned && order.Status != ShippingOrderStatusEnum.New
                ? throw new Exception("Seuls les ordres d'expédition non assignés ou nouveaux peuvent être supprimés.")
                : this.dao.Delete(order, softDeletes);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete shipping order Id# {order.Id}.", ex);
        }
    }
}
