using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace _420DA3_A24_Projet.DataAccess.DAOs;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal class UserDAO {

    private readonly WsysDbContext context;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="context"></param>
    public UserDAO(WsysDbContext context) {
        this.context = context;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public User? GetById(int id, bool includeDeleted = false) {
        try {
            return this.context.Users
                .Where(user => user.Id == id && (includeDeleted || user.DateDeleted == null))
                .Include(user => user.Roles)
                .Include(user => user.EmployeeWarehouse)
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve user Id #{id}.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="username"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public User? GetByUsername(string username, bool includeDeleted = false) {
        try {
            return this.context.Users
                .Where(user => user.Username == username && (includeDeleted || user.DateDeleted == null))
                .Include(user => user.Roles)
                .Include(user => user.EmployeeWarehouse)
                .SingleOrDefault();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve user with username [{username}].", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<User> Search(string criterion, bool includeDeleted = false) {
        try {
            return this.context.Users
                .Where(user => (
                    user.Id.ToString().Contains(criterion)
                    || user.Username.ToLower().Contains(criterion.ToLower())
                ) && (includeDeleted || user.DateDeleted == null))
                .Include(user => user.Roles)
                .Include(user => user.EmployeeWarehouse)
                .ToList();

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search user with criterion [{criterion}].", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User Create(User user) {
        try {
            _ = this.context.Users.Add(user);
            _ = this.context.SaveChanges();
            return user;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert user in database.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User Update(User user) {
        DateTime? originalDateModified = user.DateModified;
        try {
            user.DateModified = DateTime.Now;
            _ = this.context.Users.Update(user);
            _ = this.context.SaveChanges();
            return user;

        } catch (Exception ex) {
            // revert date modified
            user.DateModified = originalDateModified;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update user in database.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public User Delete(User user, bool softDeletes = true) {
        DateTime? originalDateDelated = user.DateDeleted;
        try {
            if (softDeletes) {
                user.DateDeleted = DateTime.Now;
                _ = this.context.Users.Update(user);

            } else {
                _ = this.context.Users.Remove(user);
            }
            _ = this.context.SaveChanges();
            return user;

        } catch (Exception ex) {
            // revert date deleted
            user.DateModified = originalDateDelated;
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete user from database.", ex);
        }
    }


}
