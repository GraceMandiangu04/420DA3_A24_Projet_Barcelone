﻿using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;

/// <summary>
/// TODO @PROF : documenter
/// </summary>
internal partial class RoleView : Form {

    private WsysApplication parentApp;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public Role CurrentEntityInstance { get; private set; } = null!;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="application"></param>
    public RoleView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
        this.nameValue.MaxLength = Role.NAME_MAX_LENGTH;
        this.descriptionValue.MaxLength = Role.DESCRIPTION_MAX_LENGTH;
    }


    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un rôle", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un rôle", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un rôle", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(Role instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Deletion, "Supprimer un rôle", "Supprimer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(Role instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.actionButton.Text = actionButtonText;
        // display the current action in the top bar
        this.openedModeValue.Text = Enum.GetName(action);
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
    private void ActivateControls() {
        this.nameValue.Enabled = true;
        this.descriptionValue.Enabled = true;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    private void DeactivateControls() {
        this.nameValue.Enabled = false;
        this.descriptionValue.Enabled = false;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    private void LoadDataInControls(Role role) {
        this.idValue.Text = role.Id.ToString();
        this.nameValue.Text = role.Name;
        this.descriptionValue.Text = role.Description;
        this.dateCreatedValue.Text = role.DateCreated.ToString();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="role"></param>
    private void SaveDataFromControls(Role role) {
        role.Name = this.nameValue.Text.Trim();
        role.Description = this.descriptionValue.Text.Trim();
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        switch (this.CurrentAction) {
            case ViewActionsEnum.Creation:
                this.SaveDataFromControls(this.CurrentEntityInstance);
                this.CurrentEntityInstance = this.parentApp.RoleService.CreateRole(this.CurrentEntityInstance);
                break;
            case ViewActionsEnum.Edition:
                this.SaveDataFromControls(this.CurrentEntityInstance);
                this.CurrentEntityInstance = this.parentApp.RoleService.UpdateRole(this.CurrentEntityInstance);
                break;
            case ViewActionsEnum.Deletion:
                this.CurrentEntityInstance = this.parentApp.RoleService.DeleteRole(this.CurrentEntityInstance);
                break;
            case ViewActionsEnum.Visualization:
                // nothing to do
                break;
            default:
                throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
        }
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }
}
