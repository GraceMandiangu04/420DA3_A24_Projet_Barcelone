using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using _420DA3_A24_Projet.Business.Domain.Pivots;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class ShippingOrderView : Form {

    private WsysApplication parentApp;
    private bool isInitialized = false;

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
    private void PreOpenSetup(ShippingOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
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

        this.orderProductsList.Items.Clear();
        this.orderProductsList.SelectedItem = null;
        this.orderProductsList.SelectedItems.Clear();
        foreach (ShippingOrderProduct product in order.ShippingOrderProducts) {
            _ = this.orderProductsList.Items.Add(product);
        }

        return order;
    }

    private ShippingOrder GetDataFromControls(ShippingOrder order) {
        Client? sourceClient = this.sourceClientValue.SelectedItem as Client;
        order.SourceClient = sourceClient is null
            ? throw new Exception("Veuillez sélectionner un client source.")
            : sourceClient;

        // TODO @PROF: vérifier la possibilité de faire créer les entités-pivot en même
        // temps que l'ordre d'expédition initial => possible Ids manquants

        return order;
    }

    private void SearchClientsTextBox_TextChanged(object sender, EventArgs e) {
        // TODO @PROF: compléter quand les services requis seront ajoutés
        _ = MessageBox.Show("Fonctionnalité pas encore implémentée (service manquant)");
    }

    private void ButtonCreateAddress_Click(object sender, EventArgs e) {
        // TODO @PROF: compléter quand les services requis seront ajoutés
        _ = MessageBox.Show("Fonctionnalité pas encore implémentée (service manquant)");
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

    }

    private void ProductChangeQuantityValue_ValueChanged(object sender, EventArgs e) {

    }
}
