using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// Data Access Object class for <see cref="PurchaseOrder"/> entities.
/// </summary>
internal class PurchaseOrderDAO {

    private readonly WsysDbContext context;

    /// <summary>
    /// <see cref="PurchaseOrderDAO"/> constructor.
    /// </summary>
    /// <param name="context"></param>
    public PurchaseOrderDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// Retrieves all purchase orders from the database.
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> GetAll(bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => includeDeleted || po.DateDeleted == null)
            .ToList();
    }

    /// <summary>
    /// Retrieves the list of <see cref="PurchaseOrder"/>s whose status is not <see cref="PurchaseOrderStatusEnum.Completed"/>
    /// and whose <see cref="PurchaseOrder.DestinationWarehouseId"/> matches the given <paramref name="warehouse"/>'s own Id
    /// from the database.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <returns></returns>
    public List<PurchaseOrder> GetIncompletePOsForWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        return this.context.PurchaseOrders
            .Where(po => po.DestinationWarehouseId == warehouse.id
                && (includeDeleted || po.DateDeleted == null)
                && po.Status != PurchaseOrderStatusEnum.Completed
            )
            .Include(po => po.OrderedProduct)
                .ThenInclude(product => product.proprietaireProduit)
            .Include(po => po.DestinationWarehouse)
            .ToList();
    }

    /// <summary>
    /// Retrieves a purchase order from the database by its Id. Retuns <see langword="null"/> if none was
    /// found for the given <paramref name="id"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public PurchaseOrder? GetById(int id, bool includeDeleted = false) {
        try {
            return this.context.PurchaseOrders
                .Where(po => po.Id == id && (includeDeleted || po.DateDeleted == null))
                .Include(po => po.OrderedProduct)
                    .ThenInclude(product => product.proprietaireProduit)
                .Include(po => po.DestinationWarehouse)
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve purchase order by Id from the database.", ex);
        }
    }

    /// <summary>
    /// Searches for purchase orders matching the given <paramref name="criterion"/> in the database.
    /// </summary>
    /// <remarks>
    /// Purchase order whose <see cref="PurchaseOrder.DestinationWarehouse">destination warehouse</see>'s name or
    /// whose <see cref="PurchaseOrder.OrderedProduct">Product</see>'s name, UPC code, supplier code or
    /// owner client's name contains the <paramref name="criterion"/> will match.
    /// </remarks>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<PurchaseOrder> Search(string criterion, bool includeDeleted = false) {
        try {
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

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search purchase orders in the database.", ex);
        }
    }

    /// <summary>
    /// Inserts a purchase order in the database.
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder Create(PurchaseOrder po) {
        try {
            _ = this.context.PurchaseOrders.Add(po);
            _ = this.context.SaveChanges();
            return po;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert purchase order in the database.", ex);
        }
    }

    /// <summary>
    /// Updates a purchase order in the database.
    /// </summary>
    /// <param name="po"></param>
    /// <returns></returns>
    public PurchaseOrder Update(PurchaseOrder po) {
        try {
            po.DateModified = DateTime.Now;
            _ = this.context.PurchaseOrders.Update(po);
            _ = this.context.SaveChanges();
            return po;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update purchase order in the database.", ex);
        }
    }

    /// <summary>
    /// Deletes a purchase order from the database.
    /// </summary>
    /// <param name="po"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public PurchaseOrder Delete(PurchaseOrder po, bool softDeletes = true) {
        try {
            if (softDeletes) {
                po.DateDeleted = DateTime.Now;
                _ = this.context.PurchaseOrders.Update(po);
            } else {
                _ = this.context.PurchaseOrders.Remove(po);
            }
            _ = this.context.SaveChanges();
            return po;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete purchase order from the database.", ex);
        }
    }
}
