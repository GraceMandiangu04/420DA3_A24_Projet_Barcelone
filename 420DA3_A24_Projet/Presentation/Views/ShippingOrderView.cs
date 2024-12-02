using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Domain.Pivots;
using _420DA3_A24_Projet.Business.Domain.Utils;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ShippingOrderView : Form {

    private WsysApplication parentApp;
    private bool isInitialized = false;
    private List<ShippingOrderProductModification> modifications = new List<ShippingOrderProductModification>();
    private bool hasCreatedAnAddress = false;

    public ViewActionsEnum CurrentAction { get; private set; }
    public ShippingOrder CurrentEntityInstance { get; private set; } = null!;

    public ShippingOrderView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un utilisateur", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un utilisateur", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(ShippingOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Edition, "Modifier un utilisateur", "Enregistrer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(ShippingOrder instance) {
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
    private void PreOpenSetup(ShippingOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // clear the modifications list
        this.modifications.Clear();
        // reset the address creation flag
        this.hasCreatedAnAddress = false;
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
        if (action == ViewActionsEnum.Creation) {
            this.ActivateControlsForCreation();
        } else if (action == ViewActionsEnum.Edition) {
            this.ActivateControlsForEdition();
        } else {
            this.DeactivateControls();
        }
    }

    private void Initialize() {
        if (!this.isInitialized) {
            this.ReloadStatusComboBox();
            this.isInitialized = true;
        }
    }

    private void ReloadStatusComboBox() {
        this.statusValue.Items.Clear();
        this.statusValue.Items.AddRange(Enum.GetNames(typeof(ShippingOrderStatusEnum)));
    }

    private void ActivateControlsForCreation() {
        this.searchClientsTextBox.Enabled = true;
        this.sourceClientValue.Enabled = true;
        this.buttonCreateAddress.Enabled = true;
        this.productSearchTextBox.Enabled = true;
        this.productSearchResultsListBox.Enabled = true;
        this.orderProductsList.Enabled = true;
    }

    private void ActivateControlsForEdition() {
        this.searchClientsTextBox.Enabled = false;
        this.sourceClientValue.Enabled = false;
        this.buttonCreateAddress.Enabled = false;
        this.productSearchTextBox.Enabled = true;
        this.productSearchResultsListBox.Enabled = true;
        this.orderProductsList.Enabled = true;
    }

    private void DeactivateControls() {
        this.searchClientsTextBox.Enabled = false;
        this.sourceClientValue.Enabled = false;
        this.buttonCreateAddress.Enabled = false;
        this.productSearchTextBox.Enabled = false;
        this.productSearchResultsListBox.Enabled = false;
        this.orderProductsList.Enabled = false;
    }

    private ShippingOrder LoadDataInControls(ShippingOrder order) {
        this.idValue.Value = order.Id;
        this.statusValue.SelectedItem = Enum.GetName(order.Status);
        this.searchClientsTextBox.Clear();
        this.sourceClientValue.Items.Clear();
        this.sourceClientValue.SelectedItem = null;
        if (order.SourceClient != null) {
            _ = this.sourceClientValue.Items.Add(order.SourceClient);
            this.sourceClientValue.SelectedItem = order.SourceClient;
        }
        this.addressDisplayTextBox.Clear();
        if (order.DestinationAddress != null) {
            this.addressDisplayTextBox.Text = order.DestinationAddress.ToString();
        }
        this.creatorEmployeeValue.Text = order.CreatorEmployee != null ? order.CreatorEmployee.Username : "Aucun";
        this.fulfillerEmployeeValue.Text = order.FulfillerEmployee != null ? order.FulfillerEmployee.Username : "Aucun";
        this.dateShippedValue.Value = order.ShippingDate ?? DateTime.Now;
        this.dateCreatedValue.Value = order.DateCreated;
        this.dateModifiedValue.Value = order.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = order.DateDeleted ?? DateTime.Now;

        this.ReloadOrderProductsListBox(order);

        return order;
    }

    private void ReloadOrderProductsListBox(ShippingOrder order) {
        this.orderProductsList.Items.Clear();
        this.orderProductsList.SelectedItem = null;
        this.orderProductsList.SelectedItems.Clear();
        foreach (ShippingOrderProduct product in order.ShippingOrderProducts) {
            _ = this.orderProductsList.Items.Add(product);
        }
    }

    private ShippingOrder GetDataFromControls(ShippingOrder order) {
        Client? sourceClient = this.sourceClientValue.SelectedItem as Client;
        order.SourceClient = sourceClient is null
            ? throw new Exception("Veuillez sélectionner un client source.")
            : sourceClient;
        return order;
    }

    private void SearchClientsTextBox_TextChanged(object sender, EventArgs e) {
        // TODO @PROF: compléter quand les services requis seront ajoutés
        _ = MessageBox.Show("Fonctionnalité pas encore implémentée (service manquant)");
    }

    private void ButtonCreateAddress_Click(object sender, EventArgs e) {
        _ = MessageBox.Show("Fonctionnalité pas encore implémentée");
        // TODO @PROF: compléter quand les services requis seront ajoutés
        // pas de fonctionnalité pour faire ouvrir la fenêtre de création d'adresse créée a date
        // this.parentApp.AdresseService.
        // this.hasCreatedAnAddress = true;
    }

    private void ProductSearchTextBox_TextChanged(object sender, EventArgs e) {
        // TODO @PROF: compléter quand les services requis seront ajoutés
        _ = MessageBox.Show("Fonctionnalité pas encore implémentée (service manquant)");
    }

    private void ProductSearchResultsListBox_SelectedIndexChanged(object sender, EventArgs e) {
        Produit? selectedProduct = this.productSearchResultsListBox.SelectedItem as Produit;
        if (selectedProduct is null) {
            this.productAddQuantityValue.Enabled = false;
            this.buttonAddProduct.Enabled = false;
        } else {
            this.productAddQuantityValue.Maximum = selectedProduct.qteStock;
            this.productAddQuantityValue.Enabled = false;
            this.buttonAddProduct.Enabled = false;
        }
    }

    private void ButtonAddProduct_Click(object sender, EventArgs e) {
        try {

            // TODO @PROF: logiquement, ces opérations devraient être dans la couche métier
            // pas dans la couche de présentation. Déplacer si le temps le permet.
            Produit? selectedProduct = this.productSearchResultsListBox.SelectedItem as Produit;
            int quantity = (int) this.productAddQuantityValue.Value;
            if (selectedProduct is not null && quantity > 0) {
                ShippingOrderProduct newProductAssociation = new ShippingOrderProduct(selectedProduct.Id, quantity);
                this.CurrentEntityInstance.ShippingOrderProducts.Add(newProductAssociation);

                ShippingOrderProductModification? existingModification =
                    this.modifications.Find(mod => mod.ShippingOrderProduct == newProductAssociation);
                if (existingModification is not null) {
                    existingModification.OriginalQuantity = 0;
                    existingModification.NewQuantity = quantity;
                    existingModification.ModificationType = ShippingOrderProductModificationTypeEnum.Addition;

                } else {
                    this.modifications.Add(
                        new ShippingOrderProductModification(
                            newProductAssociation,
                            ShippingOrderProductModificationTypeEnum.Addition
                        )
                    );
                }
                this.ReloadOrderProductsListBox(this.CurrentEntityInstance);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void OrderProductsList_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrderProduct? selectedShippingOrderProduct = this.orderProductsList.SelectedItem as ShippingOrderProduct;
        if (selectedShippingOrderProduct is null) {
            this.productChangeQuantityValue.Enabled = false;
            this.buttonRemoveProduct.Enabled = false;
        } else {
            this.productChangeQuantityValue.Maximum = selectedShippingOrderProduct.Product.qteStock;
            this.productChangeQuantityValue.Enabled = false;
            this.buttonRemoveProduct.Enabled = false;
        }
    }

    private void ButtonRemove_Click(object sender, EventArgs e) {
        try {

            // TODO @PROF: logiquement, ces opérations devraient être dans la couche métier
            // pas dans la couche de présentation. Déplacer si le temps le permet.
            ShippingOrderProduct? selectedShippingOrderProduct = this.orderProductsList.SelectedItem as ShippingOrderProduct;
            if (selectedShippingOrderProduct is not null) {
                _ = this.CurrentEntityInstance.ShippingOrderProducts.Remove(selectedShippingOrderProduct);

                ShippingOrderProductModification? existingModification =
                    this.modifications.Find(mod => mod.ShippingOrderProduct == selectedShippingOrderProduct);
                if (existingModification is not null) {
                    existingModification.OriginalQuantity = selectedShippingOrderProduct.Quantity;
                    existingModification.NewQuantity = 0;
                    existingModification.ModificationType = ShippingOrderProductModificationTypeEnum.Removal;
                } else {
                    this.modifications.Add(new ShippingOrderProductModification(selectedShippingOrderProduct, ShippingOrderProductModificationTypeEnum.Removal));
                }
                this.ReloadOrderProductsListBox(this.CurrentEntityInstance);
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ProductChangeQuantityValue_ValueChanged(object sender, EventArgs e) {
        try {

            // TODO @PROF: logiquement, ces opérations devraient être dans la couche métier
            // pas dans la couche de présentation. Déplacer si le temps le permet.
            ShippingOrderProduct? selectedShippingOrderProduct =
                this.orderProductsList.SelectedItem as ShippingOrderProduct;

            int newQuantity = (int) this.productChangeQuantityValue.Value;

            if (selectedShippingOrderProduct is not null) {

                ShippingOrderProductModification? existingModification =
                    this.modifications.Find(mod => mod.ShippingOrderProduct == selectedShippingOrderProduct);

                if (existingModification is null) {

                    ShippingOrderProductModification modification =
                        new ShippingOrderProductModification(
                            selectedShippingOrderProduct,
                            ShippingOrderProductModificationTypeEnum.Modification
                            );

                    modification.OriginalQuantity = selectedShippingOrderProduct.Quantity;
                    modification.NewQuantity = newQuantity;
                    this.modifications.Add(modification);

                } else {
                    switch (existingModification.ModificationType) {
                        case ShippingOrderProductModificationTypeEnum.Addition:
                        case ShippingOrderProductModificationTypeEnum.Modification:
                            existingModification.NewQuantity = newQuantity;
                            // NOTE: do not replace the old quantity here since we are simply modyfying
                            // a modification. The original quantity is still the same.
                            break;
                        case ShippingOrderProductModificationTypeEnum.Removal:
                            // this should not happen. If modification is removal, the product should not be selectable
                            // in the list to allow its quantity to be changed... Yet, just to play safe:
                            throw new InvalidOperationException("Cannot change quantity of a product that is being removed.");
                        default:
                            throw new InvalidOperationException("Unknown modification type.");
                    }
                    existingModification.NewQuantity = newQuantity;
                }
                selectedShippingOrderProduct.Quantity = newQuantity;
                // TODO @PROF: check mise à jour de l'affichage de la quantité dans la liste
                this.orderProductsList.Refresh();
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void BtnCancel_Click(object sender, EventArgs e) {
        try {
            if (this.hasCreatedAnAddress) {
                // undo the address creation and any order modifications
                this.parentApp.ShippingOrderService.CancelOrderChanges(this.CurrentEntityInstance, this.modifications, this.CurrentEntityInstance.DestinationAddress);
            } else {
                // undo the order modifications (but no address was created)
                this.parentApp.ShippingOrderService.CancelOrderChanges(this.CurrentEntityInstance, this.modifications);
            }
            this.DialogResult = DialogResult.Cancel;

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void BtnAction_Click(object sender, EventArgs e) {
        try {
            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    this.DoCreateAction();
                    break;
                case ViewActionsEnum.Edition:
                    this.DoEditionAction();
                    break;
                case ViewActionsEnum.Deletion:
                    this.DoDeletionAction();
                    break;
                case ViewActionsEnum.Visualization:
                default:
                    // nothing here
                    break;
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void DoCreateAction() {
        this.CurrentEntityInstance = this.GetDataFromControls(this.CurrentEntityInstance);
        this.CurrentEntityInstance = this.parentApp.ShippingOrderService.CreateOrder(this.CurrentEntityInstance);
    }

    private void DoEditionAction() {
        // NOTE: on ne devrait pas pouvoir changer le client d'un ordre d'expédition
        // une fois qu'il est créé. C'est pourquoi on ne récupère pas les données du client.
        this.CurrentEntityInstance = this.parentApp.ShippingOrderService.UpdateOrder(this.CurrentEntityInstance, this.modifications);
    }

    private void DoDeletionAction() {
        this.CurrentEntityInstance = this.parentApp.ShippingOrderService.DeleteOrder(this.CurrentEntityInstance);
    }


}
