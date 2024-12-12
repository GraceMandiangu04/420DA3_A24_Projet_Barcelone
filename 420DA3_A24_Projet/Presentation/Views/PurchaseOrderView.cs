using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Project_Utilities.Enums;

namespace _420DA3_A24_Projet.Presentation.Views;
internal partial class PurchaseOrderView : Form {
    private bool isInitialized = false;
    private readonly WsysApplication parentApp;

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public ViewActionsEnum CurrentAction { get; private set; }
    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    public PurchaseOrder CurrentEntityInstance { get; private set; } = null!;

    public PurchaseOrderView(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }


    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForCreation(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Creation, "Création d'un ordre de restockage", "Créer");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDetailsView(PurchaseOrder instance) {
        this.PreOpenSetup(instance, ViewActionsEnum.Visualization, "Détails d'un ordre de restockage", "OK");
        return this.ShowDialog();
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForModification(PurchaseOrder instance) {
        throw new InvalidOperationException("La modification d'ordres de restockage n'est pas autorisée.");
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <returns></returns>
    public DialogResult OpenForDeletion(PurchaseOrder instance) {
        throw new InvalidOperationException("La suppression d'ordres de restockage n'est pas autorisée.");
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="action"></param>
    /// <param name="windowTitle"></param>
    /// <param name="actionButtonText"></param>
    private void PreOpenSetup(PurchaseOrder instance, ViewActionsEnum action, string windowTitle, string actionButtonText) {
        // load selectors with items if not loaded
        this.Initialize();
        // remember what the current action is
        this.CurrentAction = action;
        // remember which instance we are currently working with
        this.CurrentEntityInstance = instance;
        // Change window title
        this.Text = windowTitle;
        // change action button text
        this.actionButton.Text = actionButtonText;
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
        this.statusValue.Items.Clear();
        foreach (string statusString in Enum.GetNames<PurchaseOrderStatusEnum>()) {
            _ = this.statusValue.Items.Add(statusString);
        }
        this.warehouseValue.Items.Clear();
        // TODO @PROF: fix this quand le service entrepot sera créé
        foreach (Entrepot entrepot in this.parentApp.EntrepotService.GetAllEntrepots()) {
            _ = this.warehouseValue.Items.Add(entrepot);
        }
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="pOrder"></param>
    /// <returns></returns>
    private PurchaseOrder LoadDataInControls(PurchaseOrder pOrder) {
        this.idValue.Value = pOrder.Id;
        this.statusValue.SelectedItem = Enum.GetName(pOrder.Status);

        this.warehouseValue.SelectedItem = null;
        this.warehouseValue.SelectedIndex = -1;
        this.warehouseValue.SelectedItem = pOrder.DestinationWarehouse is not null
            ? pOrder.DestinationWarehouse
            : null;

        this.productSearchResults.SelectedItem = null;
        this.productSearchResults.SelectedIndex = -1;
        this.productSearchResults.Items.Clear();
        if (pOrder.OrderedProduct is not null) {
            _ = this.productSearchResults.Items.Add(pOrder.OrderedProduct);
            this.productSearchResults.SelectedItem = pOrder.OrderedProduct;
            this.quantityValue.Maximum = pOrder.OrderedProduct.qteStock;
        }

        this.quantityValue.Value = pOrder.Quantity;

        if (pOrder.CompletionDate is not null) {
            this.completionDateValue.Value = (DateTime) pOrder.CompletionDate;
            this.completionDateValue.Show();
        } else {
            this.completionDateValue.Value = DateTime.Now;
            this.completionDateValue.Hide();
        }

        this.dateCreatedValue.Value = pOrder.DateCreated;
        this.dateModifiedValue.Value = pOrder.DateModified ?? DateTime.Now;
        this.dateDeletedValue.Value = pOrder.DateDeleted ?? DateTime.Now;
        return pOrder;
    }

    /// <summary>
    /// TODO @PROF : documenter
    /// </summary>
    /// <param name="pOrder"></param>
    /// <returns></returns>
    private PurchaseOrder SaveDataFromControls(PurchaseOrder pOrder) {
        if (this.statusValue.SelectedItem is null) {
            throw new Exception("Please select a status for the purchase order.");
        }
        if (this.warehouseValue.SelectedItem is null) {
            throw new Exception("Please select a destination warehouse for the purchase order.");
        }
        if (this.productSearchResults.SelectedItem is null) {
            throw new Exception("Please select a product for the purchase order.");
        }
        if (this.quantityValue.Value <= 0) {
            throw new Exception("The product quantity must be greater than 0.");
        }

        pOrder.Status = Enum.Parse<PurchaseOrderStatusEnum>((string) this.statusValue.SelectedItem);
        pOrder.DestinationWarehouse = (Entrepot) this.warehouseValue.SelectedItem;
        pOrder.OrderedProduct = (Produit) this.productSearchResults.SelectedItem;
        pOrder.Quantity = (int) this.quantityValue.Value;
        return pOrder;
    }

    private void ActivateControls() {
        this.warehouseValue.Enabled = true;
        this.productSearch.Enabled = true;
        this.productSearchResults.Enabled = true;
        this.quantityValue.Enabled = true;
    }

    private void DeactivateControls() {
        this.warehouseValue.Enabled = false;
        this.productSearch.Enabled = false;
        this.productSearchResults.Enabled = false;
        this.quantityValue.Enabled = false;
    }

    private void CancelButton_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.Cancel;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        try {
            switch (this.CurrentAction) {
                case ViewActionsEnum.Creation:
                    _ = this.SaveDataFromControls(this.CurrentEntityInstance);
                    this.CurrentEntityInstance = this.parentApp.PurchaseOrderService.CreatePO(this.CurrentEntityInstance);
                    break;
                case ViewActionsEnum.Visualization:
                    // nothing to do
                    break;
                case ViewActionsEnum.Edition:
                case ViewActionsEnum.Deletion:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not supported for [{this.CurrentEntityInstance.GetType().ShortDisplayName}].");
                default:
                    throw new NotImplementedException($"The view action [{Enum.GetName(this.CurrentAction)}] is not implemented in [{this.GetType().ShortDisplayName}].");
            }
            this.DialogResult = DialogResult.OK;

        } catch (Exception ex) { 
            this.parentApp.HandleException(ex);
        }
    }

    private void ProductSearch_TextChanged(object sender, EventArgs e) {
        try {
            // TODO @PROF: fix this quand le service produits sera créé
            List<Produit> searchResults = this.parentApp.ProduitService.Search(this.productSearch.Text.Trim());
            this.productSearchResults.SelectedItem = null;
            this.productSearchResults.SelectedIndex = -1;
            this.productSearchResults.Items.Clear();
            foreach (Produit produit in searchResults) {
                _ = this.productSearchResults.Items.Add(produit);
                if (this.CurrentEntityInstance.OrderedProduct == produit) {
                    this.productSearchResults.SelectedItem = produit;
                }
            }

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }
}
