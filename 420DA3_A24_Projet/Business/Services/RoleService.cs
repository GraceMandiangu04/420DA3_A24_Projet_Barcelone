using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.DataAccess.Contexts;
using _420DA3_A24_Projet.DataAccess.DAOs;
using _420DA3_A24_Projet.Presentation.Views;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Runtime.Serialization;

namespace _420DA3_A24_Projet.Business.Services;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal class RoleService {

    private WsysApplication parentApp;
    private RoleDAO dao;
    private RoleView view;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public RoleService(WsysApplication parentApp, WsysDbContext context) {
        this.parentApp = parentApp;
        this.dao = new RoleDAO(context);
        this.view = new RoleView(parentApp);
    }


    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <returns></returns>
    public Role? OpenRoleManagementWindowForCreation() {
        try {
            Role newRole = (Role) FormatterServices.GetUninitializedObject(typeof(Role));
            DialogResult result = this.view.OpenForCreation(newRole);
            return result == DialogResult.OK
                ? this.view.CurrentEntityInstance
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role creation mode.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public Role OpenRoleManagementWindowForEdition(Role instance) {
        try {
            _ = this.view.OpenForModification(instance);
            return instance;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role edition mode.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public Role OpenRoleManagementWindowForVisualization(Role instance) {
        try {
            _ = this.view.OpenForDetailsView(instance);
            return instance;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role visualization mode.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public bool OpenRoleManagementWindowForDeletion(Role instance) {
        try {
            DialogResult result = this.view.OpenForDeletion(instance);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the role management window in role deletion mode.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> GetAllRoles(bool includeDeleted = false) {
        try {
            return this.dao.GetAll(includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve the list of all existing roles.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetById(int id, bool includeDeleted = false) {
        try {
            return this.dao.GetById(id, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a role by its Id.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="roleName"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public Role? GetByName(string roleName, bool includeDeleted = false) {
        try {
            return this.dao.GetByRoleName(roleName, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a role by its name.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <param name="includeDeleted"></param>
    /// <returns></returns>
    public List<Role> SearchRoles(string criterion, bool includeDeleted = false) {
        try {
            return this.dao.Search(criterion, includeDeleted);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search existing roles.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role CreateRole(Role role) {
        try {
            return this.dao.Create(role);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new role in the database.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <returns></returns>
    public Role UpdateRole(Role role) {
        try {
            return this.dao.Update(role);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update a role in the database.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    /// <param name="softDeletes"></param>
    /// <returns></returns>
    public Role DeleteRole(Role role, bool softDeletes = true) {
        try {
            return this.dao.Delete(role, softDeletes);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete a role from the database.", ex);
        }
    }
}
