using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal partial class UserView : Form {
    private bool isInitialized = false;
    private readonly WsysApplication parentApp;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public User CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="application"></param>
    public UserView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un utilisateur", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un utilisateur", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un utilisateur", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(User instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un utilisateur", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(User instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.btnAction.Text = actionButtonText;
        // display the current action in the top bar
        this.openendModeValue.Text = Enum.GetName(action);
        // load data from the current instance in the controls
        _ = this.LoadDataInControls(instance);
        // activate or deactivate the editable controls depending on the action
        if (action == ViewActionsEnum.Creation || action == ViewActionsEnum.Edition) {
            this.ActivateControls();
        } else {
            this.DeactivateControls();
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadSelectors();
            this.isInitialized = true;
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void ReloadSelectors() {
        try {
            this.userRolesValues.Items.Clear();
            List<Role> roles = this.parentApp.RoleService.GetAllRoles();
            foreach (Role role in roles) {
                _ = this.userRolesValues.Items.Add(role);
            }

            this.whEmpWarehouseValue.Items.Clear();
            _ = this.whEmpWarehouseValue.Items.Add("None");
            // TODO @PROF: fix this quand le service entrepot sera créé
            List<Entrepot> entrepots = this.parentApp.EntrepotService.GetAllEntrepots();
            foreach (Entrepot entrepot in entrepots) {
                _ = this.whEmpWarehouseValue.Items.Add(entrepot);
            }

        } catch (Exception ex) {
            throw new Exception($"{this.GetType().ShortDisplayName}: Failed to load data in selectors.", ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    private User LoadDataInControls(User user) {
        this.idValue.Value = user.Id;
        this.usernameValue.Text = user.Username;
        this.passwordHashValue.Text = user.PasswordHash;
        this.whEmpWarehouseValue.SelectedItem = user.EmployeeWarehouse is not null
            ? user.EmployeeWarehouse
            : null;
        this.dateCreatedValue.Value = user.DateCreated;
        this.dateModifiedValue.Value = user.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = user.DateDeleted ?? DateTime.Now;
        this.userRolesValues.SelectedItems.Clear();
        foreach (Role role in user.Roles) {
            this.userRolesValues.SelectedItems.Add(role);
        }
        return user;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    private User SaveDataFromControls(User user) {
        user.Username = this.usernameValue.Text;
        user.PasswordHash = this.parentApp.PasswordService.HashPassword(this.passwordValue.Text);
        user.EmployeeWarehouse = this.whEmpWarehouseValue.SelectedItem as Entrepot;
        user.Roles.Clear();
        foreach (Role role in this.userRolesValues.SelectedItems) {
            user.Roles.Add(role);
        }
        return user;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void ActivateControls() {
        this.usernameValue.Enabled = true;
        this.passwordValue.Enabled = true;
        this.whEmpWarehouseValue.Enabled = true;
        this.userRolesValues.Enabled = true;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void DeactivateControls() {
        this.usernameValue.Enabled = false;
        this.passwordValue.Enabled = false;
        this.whEmpWarehouseValue.Enabled = false;
        this.userRolesValues.Enabled = false;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnAction_Click(object sender, EventArgs e) {
        try {

            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.UserService.CreateUserInDatabase(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Edition:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.UserService.UpdateUserInDatabase(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Deletion:
                    this.CurrentEntityInstance = this.parentApp.UserService.DeleteUserFromDatabase(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Visualization:
                    // nothing to do
                    break;
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnCancel_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
