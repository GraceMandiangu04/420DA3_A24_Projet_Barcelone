using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// TODO @PROF: documenter
/// </summary>
internal class PurchaseOrderDAO {

    private readonly WsysDbContext context;

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="context"></param>
    public PurchaseOrderDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> GetAll(bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => includeDeleted || po.DateDeleted == null)
            .ToList();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="loggedInEmployeeWarehouse"></param>
    /// <returns></returns>
    public List<PurchaseOrder> GetIncompletePOsForWarehouse(Entrepot loggedInEmployeeWarehouse, bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => po.DestinationWarehouseId == loggedInEmployeeWarehouse.id
                && (includeDeleted || po.DateDeleted == null)
                && po.Status != PurchaseOrderStatusEnum.Completed
            )
            .Include(po => po.OrderedProduct)
                .ThenInclude(product => product.proprietaireProduit)
            .Include(po => po.DestinationWarehouse)
            .ToList();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public PurchaseOrder? GetById(int id, bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => po.Id == id && (includeDeleted || po.DateDeleted == null))
            .Include(po => po.OrderedProduct)
                .ThenInclude(product => product.proprietaireProduit)
            .Include(po => po.DestinationWarehouse)
            .SingleOrDefault();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> Search(string criterion, bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Include(po => po.OrderedProduct)
                .ThenInclude(product => product.proprietaireProduit)
            .Include(po => po.DestinationWarehouse)
            .Where(po => (
                    po.Id.ToString().Contains(criterion)
                    || po.OrderedProduct.nomproduit.ToLower().Contains(criterion.ToLower())
                    || po.OrderedProduct.codeUpcinternational.ToLower().Contains(criterion.ToLower())
                    || po.OrderedProduct.codeProduitFournisseur.ToLower().Contains(criterion.ToLower())
                    || po.OrderedProduct.proprietaireProduit.NomCompagnie.ToLower().Contains(criterion.ToLower())
                    || po.DestinationWarehouse.nomEntrepot.ToLower().Contains(criterion.ToLower())
                ) && (includeDeleted || po.DateDeleted == null))
            .ToList();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder Create(PurchaseOrder po) {
        _ = this.context.PurchaseOrders.Add(po);
        _ = this.context.SaveChanges();
        return po;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder Update(PurchaseOrder po) {
        po.DateModified = DateTime.Now;
        _ = this.context.PurchaseOrders.Update(po);
        _ = this.context.SaveChanges();
        return po;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="po"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public PurchaseOrder Delete(PurchaseOrder po, bool softDeletes = true) {
        if (softDeletes) {
            po.DateDeleted = DateTime.Now;
            _ = this.context.PurchaseOrders.Update(po);
        } else {
            _ = this.context.PurchaseOrders.Remove(po);
        }
        _ = this.context.SaveChanges();
        return po;
    }
}
