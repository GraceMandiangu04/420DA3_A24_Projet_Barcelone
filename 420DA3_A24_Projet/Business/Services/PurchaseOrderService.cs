using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// Service class for managing <see cref="PurchaseOrder"/> entities.
/// </summary>
internal class PurchaseOrderService {

    private readonly WsysApplication parentApp;
    private readonly PurchaseOrderDAO dao;
    private readonly PurchaseOrderView view;

    /// <summary>
    /// <see cref="PurchaseOrderService"> constructor.
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public PurchaseOrderService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new PurchaseOrderDAO(context);
        this.view = new PurchaseOrderView(parentApp);
    }

    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">purchase order management window</see> in creation mode.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public PurchaseOrder? OpenManagementWindowForCreation() {
        try {
            PurchaseOrder order = (PurchaseOrder) FormatterServices.GetUninitializedObject(typeof(PurchaseOrder));
            order.Status = PurchaseOrderStatusEnum.New;
            DialogResult result = this.view.OpenForCreation(order);
            return result == DialogResult.OK ? order : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchase order management window in creation mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">purchase order management window</see> in edition mode
    /// for the given <paramref name="order"/>.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForEdition(PurchaseOrder order) {
        try {
            DialogResult result = this.view.OpenForModification(order);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchase order management window in edition mode.", ex);
        }

    }

    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">purchase order management window</see> in deletion mode
    /// for the given <paramref name="order"/>.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public bool OpenManagementWindowForDeletion(PurchaseOrder order) {
        try {
            DialogResult result = this.view.OpenForDeletion(order);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchase order management window in deletion mode.", ex);
        }
    }

    /// <summary>
    /// Opens the <see cref="PurchaseOrderView">purchase order management window</see> in visualization mode
    /// for the given <paramref name="order"/>.
    /// </summary>
    /// <param name="order"></param>
    /// <returns></returns>
    public void OpenManagementWindowForVisualization(PurchaseOrder order) {
        try {
            _ = this.view.OpenForDetailsView(order);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the purchase order management window in visualization mode.", ex);
        }

    }

    /// <summary>
    /// Retrieves a <see cref="PurchaseOrder"/> from the data source by its <see cref="PurchaseOrder.Id"/> value.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public PurchaseOrder? GetPOById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve purchase order Id #{id}.", ex);
        }
    }

    /// <summary>
    /// Retrieves the list of incomplete<see cref="PurchaseOrder"/>s whose destination warehouse is <paramref name="warehouse"/>.
    /// </summary>
    /// <remarks>
    /// Used to retrieve the list of purchase orders whose delivery is expected for the employees working in a specific warehouse.
    /// </remarks>
    /// <param name="warehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> GetIncompletePOsForWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        try {
            return this.dao.GetIncompletePOsForWarehouse(warehouse, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve incomplete purchase orders for warehouse Id #{warehouse.id}.", ex);
        }
    }

    /// <summary>
    /// Searches existing <see cref="PurchaseOrder"/>s in teh data source based on a <paramref name="criterion"/>.
    /// See <see cref="PurchaseOrderDAO.Search(string, bool)"/> for search details.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> Search(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search purchase orders for criterion [{criterion}].", ex);
        }
    }

    /// <summary>
    /// Inserts a newly created <see cref="PurchaseOrder"/> in the data source.
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder CreatePO(PurchaseOrder po) {
        try {
            return this.dao.Create(po);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to create purchase order.", ex);
        }
    }

    /// <summary>
    /// Completes an existing <see cref="PurchaseOrder"/>.
    /// </summary>
    /// <remarks>
    /// The purchase order's status is set to <see cref="PurchaseOrderStatusEnum.Completed"/>, its completeion date is set
    /// to <see cref="DateTime.Now"/>, and the quantity in stock of the purchase order's <see cref="PurchaseOrder.OrderedProduct"/>
    /// is incremented by the purchase order's <see cref="PurchaseOrder.Quantity"/>.<br/>
    /// These modifications are then persisted in the data source.
    /// </remarks>
    /// <param name="po"></param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>
    public PurchaseOrder CompletePurchaseOrder(PurchaseOrder po) {
        try {
            po.MarkCompleted();
            // TODO @PROF: vérifier que le produit est aussi mis à jour
            return this.UpdatePO(po);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to complete purchase order Id #{po.Id}.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="PurchaseOrder"/> in the data source.
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder UpdatePO(PurchaseOrder po) {
        try {
            return this.dao.Update(po);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update purchase order Id #{po.Id}.", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="PurchaseOrder"/> from the data source.
    /// </summary>
    /// <param name="po"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public PurchaseOrder DeletePO(PurchaseOrder po, bool softDeletes = true) {
        try {
            return this.dao.Delete(po, softDeletes);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete purchase order Id #{po.Id}.", ex);
        }
    }

}
