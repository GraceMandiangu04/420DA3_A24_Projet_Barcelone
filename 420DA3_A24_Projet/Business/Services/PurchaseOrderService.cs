using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// TODO @PROF: documenter
/// </summary>
internal class PurchaseOrderService {

    private WsysApplication parentApp;
    private PurchaseOrderDAO dao;
    private PurchaseOrderView view;

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public PurchaseOrderService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new PurchaseOrderDAO(context);
        this.view = new PurchaseOrderView(parentApp);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public PurchaseOrder? GetPOById(int id, bool includeDeleted = false) {
        return this.dao.GetById(id, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="loggedInEmployeeWarehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> GetIncompletePOsForWarehouse(Entrepot loggedInEmployeeWarehouse, bool includeDeleted = false) {
        return this.dao.GetIncompletePOsForWarehouse(loggedInEmployeeWarehouse, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> Search(string criterion, bool includeDeleted = false) {
        return this.dao.Search(criterion, includeDeleted);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder CreatePO(PurchaseOrder po) {
        return this.dao.Create(po);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder UpdatePO(PurchaseOrder po) {
        if (po.Status == PurchaseOrderStatusEnum.Completed) {
            po.CompletionDate = DateTime.Now;
            po.OrderedProduct.qteStock += po.Quantity;
            // TODO @PROF: vérifier que le produit est aussi mis à jour
        }
        return this.dao.Update(po);
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="po"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public PurchaseOrder DeletePO(PurchaseOrder po, bool softDeletes = true) {
        return this.dao.Delete(po, softDeletes);
    }



}
