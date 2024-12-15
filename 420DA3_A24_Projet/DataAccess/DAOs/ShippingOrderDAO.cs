using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// Data Access Object class for <see cref="ShippingOrder"/> entities.
/// </summary>
internal class ShippingOrderDAO {

    private readonly WsysDbContext context;

    /// <summary>
    /// <see cref="ShippingOrderDAO"/> constructor.
    /// </summary>
    /// <param name="context"></param>
    public ShippingOrderDAO(WsysDbContext context) {
        this.context = context;
    }


    /// <summary>
    /// Retrieves from the database the list of every <see cref="ShippingOrder"/> whose 
    /// <see cref="ShippingOrder.SourceClient">Client</see>'s <see cref="Client.Entrepot">Warehouse</see> 
    /// matches the given <paramref name="warehouse"/> and whose <see cref="ShippingOrder.Status">Status</see>
    /// is <see cref="ShippingOrderStatusEnum.Unassigned"/>.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetUnassignedByWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        try {
            return this.context.ShippingOrders
                .Include(so => so.SourceClient)
                    .ThenInclude(client => client.Entrepot)
                .Include(so => so.CreatorEmployee)
                .Include(so => so.DestinationAddress)
                .Include(so => so.ShippingOrderProducts)
                    .ThenInclude(sop => sop.Product)
                .Where(so => so.Status == ShippingOrderStatusEnum.Unassigned
                    && so.SourceClient.Entrepot.id == warehouse.id
                    && (includeDeleted || so.DateDeleted == null)
                )
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve unassigned shipping orders by warehouse from the database.", ex);
        }
    }


    /// <summary>
    /// Retrieves from the database the list of every <see cref="ShippingOrder"/> whose 
    /// <see cref="ShippingOrder.FulfillerEmployee">fulfiller employee</see> matches the given 
    /// <paramref name="employee"/> and whose <see cref="ShippingOrder.Status">Status</see>
    /// is <see cref="ShippingOrderStatusEnum.Processing"/>.
    /// </summary>
    /// <param name="employee"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetProcessingByEmployee(User employee, bool includeDeleted = false) {
        try {
            return this.context.ShippingOrders
                .Include(so => so.SourceClient)
                    .ThenInclude(client => client.Entrepot)
                .Include(so => so.CreatorEmployee)
                .Include(so => so.DestinationAddress)
                .Include(so => so.FulfillerEmployee)
                .Include(so => so.ShippingOrderProducts)
                    .ThenInclude(sop => sop.Product)
                .Where(so => so.Status == ShippingOrderStatusEnum.Processing
                    && so.FulfillerEmployee != null
                    && so.FulfillerEmployee.Id == employee.Id
                    && (includeDeleted || so.DateDeleted == null)
                )
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve processing shipping orders by fulfiller employee from the database.", ex);
        }
    }

    /// <summary>
    /// Retrieves from the database the list of every <see cref="ShippingOrder"/> whose 
    /// <see cref="ShippingOrder.SourceClient">Client</see>'s <see cref="Client.Entrepot">Warehouse</see> 
    /// matches the given <paramref name="warehouse"/> and whose <see cref="ShippingOrder.Status">Status</see>
    /// is <see cref="ShippingOrderStatusEnum.Packaged"/>.
    /// </summary>
    /// <param name="warehouse"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> GetPackagedByWarehouse(Entrepot warehouse, bool includeDeleted = false) {
        try {
            return this.context.ShippingOrders
                .Include(so => so.SourceClient)
                    .ThenInclude(client => client.Entrepot)
                .Include(so => so.CreatorEmployee)
                .Include(so => so.DestinationAddress)
                .Include(so => so.Shipment)
                .Include(so => so.ShippingOrderProducts)
                    .ThenInclude(sop => sop.Product)
                .Where(so => so.Status == ShippingOrderStatusEnum.Packaged
                    && so.SourceClient.Entrepot.id == warehouse.id
                    && (includeDeleted || so.DateDeleted == null)
                )
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve packaged shipping orders by warehouse from the database.", ex);
        }
    }

    /// <summary>
    /// Retrieves from the database the <see cref="ShippingOrder"/> whose 
    /// <see cref="ShippingOrder.Id"/> matches the given <paramref name="id"/>.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public ShippingOrder? GetById(int id, bool includeDeleted = false) {
        try {
            return this.context.ShippingOrders
                .Include(so => so.SourceClient)
                    .ThenInclude(client => client.Entrepot)
                .Include(so => so.CreatorEmployee)
                .Include(so => so.DestinationAddress)
                .Include(so => so.Shipment)
                .Include(so => so.FulfillerEmployee)
                .Include(so => so.ShippingOrderProducts)
                    .ThenInclude(sop => sop.Product)
                .Where(so => so.Id == id
                    && (includeDeleted || so.DateDeleted == null)
                )
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve shipping order by Id from the database.", ex);
        }
    }

    /// <summary>
    /// Retrieves from the database the list of every <see cref="ShippingOrder"/> that matches a given <paramref name="criterion"/>.
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<ShippingOrder> Search(string criterion, bool includeDeleted = false) {
        try {
            return this.context.ShippingOrders
                .Include(so => so.SourceClient)
                    .ThenInclude(client => client.Entrepot)
                .Include(so => so.CreatorEmployee)
                .Include(so => so.DestinationAddress)
                .Include(so => so.Shipment)
                .Include(so => so.ShippingOrderProducts)
                    .ThenInclude(sop => sop.Product)
                .Where(so =>
                        so.Id.ToString().Contains(criterion)
                        || so.Status.ToString().ToLower().Contains(criterion.ToLower())
                        || so.SourceClient.NomCompagnie.ToLower().Contains(criterion.ToLower())
                        || so.DestinationAddress.Destinataire.ToLower().Contains(criterion.ToLower())
                        || so.ShippingOrderProducts.Any(sop => sop.Product.Id.ToString().Contains(criterion))
                        || so.ShippingOrderProducts.Any(sop => sop.Product.nomproduit.ToLower().Contains(criterion.ToLower()))
                        || ((so.Shipment == null || so.Shipment.CodeSuivi.ToLower().Contains(criterion.ToLower()))
                    && (includeDeleted || so.DateDeleted == null))
                )
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search shipping orders in the database.", ex);
        }
    }

    /// <summary>
    /// Inserts a <see cref="ShippingOrder"/> in the database.
    /// </summary>
    /// <param name="shippingOrder"></param>
    /// <returns></returns>
    public ShippingOrder Create(ShippingOrder shippingOrder) {
        try {
            _ = this.context.ShippingOrders.Add(shippingOrder);
            _ = this.context.SaveChanges();
            return shippingOrder;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert shipping order in the database.", ex);
        }
    }

    /// <summary>
    /// Updates a <see cref="ShippingOrder"/> in the database.
    /// </summary>
    /// <param name="shippingOrder"></param>
    /// <returns></returns>
    public ShippingOrder Update(ShippingOrder shippingOrder) {
        try {
            shippingOrder.DateModified = DateTime.Now;
            _ = this.context.ShippingOrders.Update(shippingOrder);
            _ = this.context.SaveChanges();
            return shippingOrder;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update shipping order in the database.", ex);
        }
    }

    /// <summary>
    /// Deletes a <see cref="ShippingOrder"/> from the database.
    /// </summary>
    /// <param name="shippingOrder"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public ShippingOrder Delete(ShippingOrder shippingOrder, bool softDeletes = true) {
        try {
            if (softDeletes) {
                shippingOrder.DateDeleted = DateTime.Now;
                _ = this.context.ShippingOrders.Update(shippingOrder);
            } else {
                _ = this.context.ShippingOrders.Remove(shippingOrder);
            }
            _ = this.context.SaveChanges();
            return shippingOrder;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete shipping order from the database.", ex);
        }
    }

}
