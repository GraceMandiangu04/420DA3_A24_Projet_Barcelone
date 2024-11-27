using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Presentation;
internal partial class AdminMainMenu : Form {

    /// <summary>
    /// Valeur générique pour indiquer qu'aucun élément n'est sélectionné dans une liste.
    /// À ajouter à vos listes pour offrir l'option "Aucun" aux utilisateurs.
    /// </summary>
    private static object listNoneSelectedValue = "Aucun";

    private WsysApplication parentApp;

    public AdminMainMenu(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    public DialogResult ShowAdminMainMenu() {
        return this.ShowDialog();
    }

    private void ButtonLogout_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.None;
    }


    #region GESTION DES UTILISATEURS

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    /// <param name="results"></param>
    private void UpdateUserSearchResults(List<User> results) {
        this.userSearchResults.Items.Clear();
        this.userSearchResults.Items.Add(listNoneSelectedValue);
        this.userSearchResults.Items.AddRange(results.ToArray());
        this.userSearchResults.Refresh();
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void ActivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = true;
        this.buttonEditUser.Enabled = true;
        this.buttonViewUser.Enabled = true;
    }

    /// <summary>
    /// TODO @PROF: documenter
    /// </summary>
    private void DeactivateUserActionButtons() {
        this.buttonDeleteUser.Enabled = false;
        this.buttonEditUser.Enabled = false;
        this.buttonViewUser.Enabled = false;
    }

    private void ButtonCreateUser_Click(object sender, EventArgs e) {
        try {
            User? userCree = this.parentApp.UserService.OpenUserManagementWindowForCreation();
            if (userCree != null) {
                this.userSearchResults.Items.Add(userCree);
                this.userSearchResults.SelectedItem = userCree;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UserSearchTextBox_TextChanged(object sender, EventArgs e) {
        string searchCriterion = this.userSearchTextBox.Text.Trim();
        List<User> results = this.parentApp.UserService.SearchUsers(searchCriterion);
        this.UpdateUserSearchResults(results);
    }

    private void UserSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
        User? selectedUSer = this.userSearchResults.SelectedItem as User;
        if (selectedUSer != null) {
            this.ActivateUserActionButtons();
        } else {
            this.DeactivateUserActionButtons();
        }
    }

    private void ButtonViewUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            User? userCree = this.parentApp.UserService.OpenUserManagementWindowForVisualization(selectedUser);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonEditUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            User? userCree = this.parentApp.UserService.OpenUserManagementWindowForEdition(selectedUser);

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonDeleteUser_Click(object sender, EventArgs e) {
        try {
            User selectedUser = (User) this.userSearchResults.SelectedItem;
            bool supprimeAvecSucces = this.parentApp.UserService.OpenUserManagementWindowForDeletion(selectedUser);

            if (supprimeAvecSucces) {
                this.userSearchResults.Items.Remove(selectedUser);
                this.userSearchResults.SelectedItem = listNoneSelectedValue;
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    #endregion


}
