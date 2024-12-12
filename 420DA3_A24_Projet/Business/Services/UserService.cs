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
internal class UserService {

    private readonly UserDAO userDAO;
    private readonly UserView userWindow;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="parentApp"></param>
    /// <param name="context"></param>
    public UserService(WsysApplication parentApp, WsysDbContext context) {
        this.userDAO = new UserDAO(context);
        this.userWindow = new UserView(parentApp);
    }


    #region METHODS

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <returns></returns>
    public User? OpenUserManagementWindowForCreation() {
        try {
            User newEmptyUser = (User) FormatterServices.GetUninitializedObject(typeof(User));
            DialogResult result = this.userWindow.OpenForCreation(newEmptyUser);
            return result == DialogResult.OK
                ? this.userWindow.CurrentEntityInstance
                : null;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user creation mode.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToEdit"></param>
    /// <returns></returns>
    public User OpenUserManagementWindowForEdition(User userToEdit) {
        try {
            _ = this.userWindow.OpenForModification(userToEdit);
            return userToEdit;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user edition mode.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToView"></param>
    /// <returns></returns>
    public User OpenUserManagementWindowForVisualization(User userToView) {
        try {
            _ = this.userWindow.OpenForDetailsView(userToView);
            return userToView;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user visualization mode.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="userToDelete"></param>
    /// <returns></returns>
    public bool OpenUserManagementWindowForDeletion(User userToDelete) {
        try {
            DialogResult result = this.userWindow.OpenForDeletion(userToDelete);
            return result == DialogResult.OK;

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to open the user management window in user deletion mode.", ex);
        }
    }



    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public User? GetUserById(int id) {
        try {
            return this.userDAO.GetById(id);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a user by its ID.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public User? GetUserByUsername(string username) {
        try {
            return this.userDAO.GetByUsername(username);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to retrieve a user by its username.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="criterion"></param>
    /// <returns></returns>
    public List<User> SearchUsers(string criterion) {
        try {
            return this.userDAO.Search(criterion);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to search users.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User CreateUserInDatabase(User user) {
        try {
            return this.userDAO.Create(user);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to insert a new user in the database.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User UpdateUserInDatabase(User user) {
        try {
            return this.userDAO.Update(user);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to update a new user in the database.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public User DeleteUserFromDatabase(User user) {
        try {
            return this.userDAO.Delete(user);

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to delete a new user in the database.", ex);
        }
    }

    #endregion

}
