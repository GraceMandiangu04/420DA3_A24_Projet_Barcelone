namespace _420DA3_A24_Projet.Presentation.Views;

partial class ShippingOrderView {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        this.topBarPanel = new Panel();
        this.openendModeValue = new Label();
        this.openedModeLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.btnAction = new Button();
        this.btnCancel = new Button();
        this.centerTLP = new TableLayoutPanel();
        this.centerLeftPanel = new Panel();
        this.productAddQuantityLabel = new Label();
        this.productAddQuantityValue = new NumericUpDown();
        this.buttonAddProduct = new Button();
        this.productSearchResultsListBox = new ListBox();
        this.productSearchTextBox = new TextBox();
        this.productsManagementLabel = new Label();
        this.buttonCreateAddress = new Button();
        this.addressDisplayTextBox = new TextBox();
        this.adresseDestinationLabel = new Label();
        this.sourceClientLabel = new Label();
        this.sourceClientValue = new ComboBox();
        this.searchClientsTextBox = new TextBox();
        this.statusValue = new ComboBox();
        this.statusLabel = new Label();
        this.idValue = new NumericUpDown();
        this.idLabel = new Label();
        this.centerRightPanel = new Panel();
        this.productChangeQuantityLabel = new Label();
        this.productChangeQuantityValue = new NumericUpDown();
        this.buttonRemoveProduct = new Button();
        this.orderProductsList = new ListBox();
        this.dateShippedValue = new DateTimePicker();
        this.dateShippedLabel = new Label();
        this.dateDeletedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateDeletedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.fulfillerEmployeeLabel = new Label();
        this.fulfillerEmployeeValue = new Label();
        this.creatorEmployeeLabel = new Label();
        this.creatorEmployeeValue = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerTLP.SuspendLayout();
        this.centerLeftPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.productAddQuantityValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        this.centerRightPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.productChangeQuantityValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.openendModeValue);
        this.topBarPanel.Controls.Add(this.openedModeLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(884, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // openendModeValue
        // 
        this.openendModeValue.AutoSize = true;
        this.openendModeValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.openendModeValue.Location = new Point(62, 9);
        this.openendModeValue.Name = "openendModeValue";
        this.openendModeValue.Size = new Size(72, 15);
        this.openendModeValue.TabIndex = 3;
        this.openendModeValue.Text = "Placeholder";
        // 
        // openedModeLabel
        // 
        this.openedModeLabel.AutoSize = true;
        this.openedModeLabel.Location = new Point(12, 9);
        this.openedModeLabel.Name = "openedModeLabel";
        this.openedModeLabel.Size = new Size(44, 15);
        this.openedModeLabel.TabIndex = 2;
        this.openedModeLabel.Text = "Mode :";
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.btnAction);
        this.bottomBarPanel.Controls.Add(this.btnCancel);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 511);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(884, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // btnAction
        // 
        this.btnAction.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.btnAction.Location = new Point(677, 15);
        this.btnAction.Name = "btnAction";
        this.btnAction.Size = new Size(114, 23);
        this.btnAction.TabIndex = 3;
        this.btnAction.Text = "ACTION";
        this.btnAction.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.btnCancel.Location = new Point(797, 15);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new Size(75, 23);
        this.btnCancel.TabIndex = 2;
        this.btnCancel.Text = "Annuler";
        this.btnCancel.UseVisualStyleBackColor = true;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 4;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.Controls.Add(this.centerLeftPanel, 1, 0);
        this.centerTLP.Controls.Add(this.centerRightPanel, 2, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(884, 461);
        this.centerTLP.TabIndex = 2;
        // 
        // centerLeftPanel
        // 
        this.centerLeftPanel.Controls.Add(this.productAddQuantityLabel);
        this.centerLeftPanel.Controls.Add(this.productAddQuantityValue);
        this.centerLeftPanel.Controls.Add(this.buttonAddProduct);
        this.centerLeftPanel.Controls.Add(this.productSearchResultsListBox);
        this.centerLeftPanel.Controls.Add(this.productSearchTextBox);
        this.centerLeftPanel.Controls.Add(this.productsManagementLabel);
        this.centerLeftPanel.Controls.Add(this.buttonCreateAddress);
        this.centerLeftPanel.Controls.Add(this.addressDisplayTextBox);
        this.centerLeftPanel.Controls.Add(this.adresseDestinationLabel);
        this.centerLeftPanel.Controls.Add(this.sourceClientLabel);
        this.centerLeftPanel.Controls.Add(this.sourceClientValue);
        this.centerLeftPanel.Controls.Add(this.searchClientsTextBox);
        this.centerLeftPanel.Controls.Add(this.statusValue);
        this.centerLeftPanel.Controls.Add(this.statusLabel);
        this.centerLeftPanel.Controls.Add(this.idValue);
        this.centerLeftPanel.Controls.Add(this.idLabel);
        this.centerLeftPanel.Dock = DockStyle.Fill;
        this.centerLeftPanel.Location = new Point(45, 3);
        this.centerLeftPanel.Name = "centerLeftPanel";
        this.centerLeftPanel.Size = new Size(394, 455);
        this.centerLeftPanel.TabIndex = 0;
        // 
        // productAddQuantityLabel
        // 
        this.productAddQuantityLabel.Location = new Point(265, 330);
        this.productAddQuantityLabel.Name = "productAddQuantityLabel";
        this.productAddQuantityLabel.Size = new Size(124, 23);
        this.productAddQuantityLabel.TabIndex = 17;
        this.productAddQuantityLabel.Text = "Quantité à ajouter:";
        this.productAddQuantityLabel.TextAlign = ContentAlignment.BottomLeft;
        // 
        // productAddQuantityValue
        // 
        this.productAddQuantityValue.Enabled = false;
        this.productAddQuantityValue.Location = new Point(265, 356);
        this.productAddQuantityValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.productAddQuantityValue.Name = "productAddQuantityValue";
        this.productAddQuantityValue.Size = new Size(124, 23);
        this.productAddQuantityValue.TabIndex = 16;
        this.productAddQuantityValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // buttonAddProduct
        // 
        this.buttonAddProduct.Enabled = false;
        this.buttonAddProduct.Location = new Point(265, 385);
        this.buttonAddProduct.Name = "buttonAddProduct";
        this.buttonAddProduct.Size = new Size(124, 23);
        this.buttonAddProduct.TabIndex = 15;
        this.buttonAddProduct.Text = "Ajouter";
        this.buttonAddProduct.UseVisualStyleBackColor = true;
        this.buttonAddProduct.Click += this.ButtonAddProduct_Click;
        // 
        // productSearchResultsListBox
        // 
        this.productSearchResultsListBox.FormattingEnabled = true;
        this.productSearchResultsListBox.ItemHeight = 15;
        this.productSearchResultsListBox.Location = new Point(5, 330);
        this.productSearchResultsListBox.Name = "productSearchResultsListBox";
        this.productSearchResultsListBox.Size = new Size(254, 124);
        this.productSearchResultsListBox.TabIndex = 14;
        this.productSearchResultsListBox.SelectedIndexChanged += this.ProductSearchResultsListBox_SelectedIndexChanged;
        // 
        // productSearchTextBox
        // 
        this.productSearchTextBox.Location = new Point(5, 301);
        this.productSearchTextBox.Name = "productSearchTextBox";
        this.productSearchTextBox.PlaceholderText = "Recherche de produits";
        this.productSearchTextBox.Size = new Size(254, 23);
        this.productSearchTextBox.TabIndex = 13;
        this.productSearchTextBox.TextChanged += this.ProductSearchTextBox_TextChanged;
        // 
        // productsManagementLabel
        // 
        this.productsManagementLabel.Location = new Point(5, 270);
        this.productsManagementLabel.Margin = new Padding(5);
        this.productsManagementLabel.Name = "productsManagementLabel";
        this.productsManagementLabel.Size = new Size(384, 23);
        this.productsManagementLabel.TabIndex = 12;
        this.productsManagementLabel.Text = "Gestion des produits de l'ordre d'expédition :";
        this.productsManagementLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // buttonCreateAddress
        // 
        this.buttonCreateAddress.Enabled = false;
        this.buttonCreateAddress.Location = new Point(157, 132);
        this.buttonCreateAddress.Name = "buttonCreateAddress";
        this.buttonCreateAddress.Size = new Size(124, 23);
        this.buttonCreateAddress.TabIndex = 11;
        this.buttonCreateAddress.Text = "Créer Adresse";
        this.buttonCreateAddress.UseVisualStyleBackColor = true;
        this.buttonCreateAddress.Click += this.ButtonCreateAddress_Click;
        // 
        // addressDisplayTextBox
        // 
        this.addressDisplayTextBox.Enabled = false;
        this.addressDisplayTextBox.Location = new Point(157, 163);
        this.addressDisplayTextBox.Margin = new Padding(5);
        this.addressDisplayTextBox.Multiline = true;
        this.addressDisplayTextBox.Name = "addressDisplayTextBox";
        this.addressDisplayTextBox.Size = new Size(232, 69);
        this.addressDisplayTextBox.TabIndex = 10;
        // 
        // adresseDestinationLabel
        // 
        this.adresseDestinationLabel.Location = new Point(5, 132);
        this.adresseDestinationLabel.Margin = new Padding(5);
        this.adresseDestinationLabel.Name = "adresseDestinationLabel";
        this.adresseDestinationLabel.Size = new Size(144, 23);
        this.adresseDestinationLabel.TabIndex = 9;
        this.adresseDestinationLabel.Text = "Adresse de destination :";
        this.adresseDestinationLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // sourceClientLabel
        // 
        this.sourceClientLabel.Location = new Point(5, 99);
        this.sourceClientLabel.Margin = new Padding(5);
        this.sourceClientLabel.Name = "sourceClientLabel";
        this.sourceClientLabel.Size = new Size(144, 23);
        this.sourceClientLabel.TabIndex = 8;
        this.sourceClientLabel.Text = "Client source :";
        this.sourceClientLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // sourceClientValue
        // 
        this.sourceClientValue.Enabled = false;
        this.sourceClientValue.FormattingEnabled = true;
        this.sourceClientValue.Location = new Point(157, 99);
        this.sourceClientValue.Margin = new Padding(5, 2, 5, 5);
        this.sourceClientValue.Name = "sourceClientValue";
        this.sourceClientValue.Size = new Size(234, 23);
        this.sourceClientValue.TabIndex = 7;
        // 
        // searchClientsTextBox
        // 
        this.searchClientsTextBox.Enabled = false;
        this.searchClientsTextBox.Location = new Point(157, 72);
        this.searchClientsTextBox.Margin = new Padding(5, 5, 5, 2);
        this.searchClientsTextBox.Name = "searchClientsTextBox";
        this.searchClientsTextBox.PlaceholderText = "Recherche de client";
        this.searchClientsTextBox.Size = new Size(234, 23);
        this.searchClientsTextBox.TabIndex = 6;
        this.searchClientsTextBox.TextChanged += this.SearchClientsTextBox_TextChanged;
        // 
        // statusValue
        // 
        this.statusValue.Enabled = false;
        this.statusValue.FormattingEnabled = true;
        this.statusValue.Location = new Point(157, 39);
        this.statusValue.Margin = new Padding(5);
        this.statusValue.Name = "statusValue";
        this.statusValue.Size = new Size(234, 23);
        this.statusValue.TabIndex = 5;
        // 
        // statusLabel
        // 
        this.statusLabel.Location = new Point(5, 38);
        this.statusLabel.Margin = new Padding(5);
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new Size(144, 23);
        this.statusLabel.TabIndex = 4;
        this.statusLabel.Text = "Statut :";
        this.statusLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(157, 7);
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(234, 23);
        this.idValue.TabIndex = 3;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(5, 5);
        this.idLabel.Margin = new Padding(5);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(144, 23);
        this.idLabel.TabIndex = 2;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // centerRightPanel
        // 
        this.centerRightPanel.Controls.Add(this.productChangeQuantityLabel);
        this.centerRightPanel.Controls.Add(this.productChangeQuantityValue);
        this.centerRightPanel.Controls.Add(this.buttonRemoveProduct);
        this.centerRightPanel.Controls.Add(this.orderProductsList);
        this.centerRightPanel.Controls.Add(this.dateShippedValue);
        this.centerRightPanel.Controls.Add(this.dateShippedLabel);
        this.centerRightPanel.Controls.Add(this.dateDeletedValue);
        this.centerRightPanel.Controls.Add(this.dateModifiedValue);
        this.centerRightPanel.Controls.Add(this.dateCreatedValue);
        this.centerRightPanel.Controls.Add(this.dateDeletedLabel);
        this.centerRightPanel.Controls.Add(this.dateModifiedLabel);
        this.centerRightPanel.Controls.Add(this.dateCreatedLabel);
        this.centerRightPanel.Controls.Add(this.fulfillerEmployeeLabel);
        this.centerRightPanel.Controls.Add(this.fulfillerEmployeeValue);
        this.centerRightPanel.Controls.Add(this.creatorEmployeeLabel);
        this.centerRightPanel.Controls.Add(this.creatorEmployeeValue);
        this.centerRightPanel.Dock = DockStyle.Fill;
        this.centerRightPanel.Location = new Point(445, 3);
        this.centerRightPanel.Name = "centerRightPanel";
        this.centerRightPanel.Size = new Size(394, 455);
        this.centerRightPanel.TabIndex = 1;
        // 
        // productChangeQuantityLabel
        // 
        this.productChangeQuantityLabel.Location = new Point(265, 330);
        this.productChangeQuantityLabel.Name = "productChangeQuantityLabel";
        this.productChangeQuantityLabel.Size = new Size(124, 23);
        this.productChangeQuantityLabel.TabIndex = 40;
        this.productChangeQuantityLabel.Text = "Changer quantité :";
        this.productChangeQuantityLabel.TextAlign = ContentAlignment.BottomLeft;
        // 
        // productChangeQuantityValue
        // 
        this.productChangeQuantityValue.Enabled = false;
        this.productChangeQuantityValue.Location = new Point(265, 356);
        this.productChangeQuantityValue.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.productChangeQuantityValue.Name = "productChangeQuantityValue";
        this.productChangeQuantityValue.Size = new Size(124, 23);
        this.productChangeQuantityValue.TabIndex = 39;
        this.productChangeQuantityValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
        this.productChangeQuantityValue.ValueChanged += this.ProductChangeQuantityValue_ValueChanged;
        // 
        // buttonRemoveProduct
        // 
        this.buttonRemoveProduct.Enabled = false;
        this.buttonRemoveProduct.Location = new Point(265, 301);
        this.buttonRemoveProduct.Name = "buttonRemoveProduct";
        this.buttonRemoveProduct.Size = new Size(126, 23);
        this.buttonRemoveProduct.TabIndex = 37;
        this.buttonRemoveProduct.Text = "Retirer";
        this.buttonRemoveProduct.UseVisualStyleBackColor = true;
        this.buttonRemoveProduct.Click += this.ButtonRemove_Click;
        // 
        // orderProductsList
        // 
        this.orderProductsList.FormattingEnabled = true;
        this.orderProductsList.ItemHeight = 15;
        this.orderProductsList.Location = new Point(5, 301);
        this.orderProductsList.Name = "orderProductsList";
        this.orderProductsList.Size = new Size(254, 154);
        this.orderProductsList.TabIndex = 36;
        this.orderProductsList.SelectedIndexChanged += this.OrderProductsList_SelectedIndexChanged;
        // 
        // dateShippedValue
        // 
        this.dateShippedValue.Enabled = false;
        this.dateShippedValue.Location = new Point(157, 73);
        this.dateShippedValue.Name = "dateShippedValue";
        this.dateShippedValue.Size = new Size(234, 23);
        this.dateShippedValue.TabIndex = 35;
        // 
        // dateShippedLabel
        // 
        this.dateShippedLabel.Location = new Point(5, 73);
        this.dateShippedLabel.Margin = new Padding(5);
        this.dateShippedLabel.Name = "dateShippedLabel";
        this.dateShippedLabel.Size = new Size(144, 23);
        this.dateShippedLabel.TabIndex = 34;
        this.dateShippedLabel.Text = "Date de création :";
        this.dateShippedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Enabled = false;
        this.dateDeletedValue.Location = new Point(157, 172);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(234, 23);
        this.dateDeletedValue.TabIndex = 33;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Enabled = false;
        this.dateModifiedValue.Location = new Point(157, 139);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(234, 23);
        this.dateModifiedValue.TabIndex = 32;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Enabled = false;
        this.dateCreatedValue.Location = new Point(157, 106);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(234, 23);
        this.dateCreatedValue.TabIndex = 31;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(5, 172);
        this.dateDeletedLabel.Margin = new Padding(5);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(144, 23);
        this.dateDeletedLabel.TabIndex = 30;
        this.dateDeletedLabel.Text = "Date de suppression :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(5, 139);
        this.dateModifiedLabel.Margin = new Padding(5);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(144, 23);
        this.dateModifiedLabel.TabIndex = 29;
        this.dateModifiedLabel.Text = "Date de modification :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(5, 106);
        this.dateCreatedLabel.Margin = new Padding(5);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(144, 23);
        this.dateCreatedLabel.TabIndex = 28;
        this.dateCreatedLabel.Text = "Date de création :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // fulfillerEmployeeLabel
        // 
        this.fulfillerEmployeeLabel.Location = new Point(5, 40);
        this.fulfillerEmployeeLabel.Margin = new Padding(5);
        this.fulfillerEmployeeLabel.Name = "fulfillerEmployeeLabel";
        this.fulfillerEmployeeLabel.Size = new Size(144, 23);
        this.fulfillerEmployeeLabel.TabIndex = 27;
        this.fulfillerEmployeeLabel.Text = "Employé créateur :";
        this.fulfillerEmployeeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // fulfillerEmployeeValue
        // 
        this.fulfillerEmployeeValue.Location = new Point(157, 40);
        this.fulfillerEmployeeValue.Margin = new Padding(5);
        this.fulfillerEmployeeValue.Name = "fulfillerEmployeeValue";
        this.fulfillerEmployeeValue.Size = new Size(232, 23);
        this.fulfillerEmployeeValue.TabIndex = 26;
        this.fulfillerEmployeeValue.Text = "PLACEHOLDER";
        this.fulfillerEmployeeValue.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // creatorEmployeeLabel
        // 
        this.creatorEmployeeLabel.Location = new Point(5, 7);
        this.creatorEmployeeLabel.Margin = new Padding(5);
        this.creatorEmployeeLabel.Name = "creatorEmployeeLabel";
        this.creatorEmployeeLabel.Size = new Size(144, 23);
        this.creatorEmployeeLabel.TabIndex = 25;
        this.creatorEmployeeLabel.Text = "Employé créateur :";
        this.creatorEmployeeLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // creatorEmployeeValue
        // 
        this.creatorEmployeeValue.Location = new Point(157, 7);
        this.creatorEmployeeValue.Margin = new Padding(5);
        this.creatorEmployeeValue.Name = "creatorEmployeeValue";
        this.creatorEmployeeValue.Size = new Size(232, 23);
        this.creatorEmployeeValue.TabIndex = 24;
        this.creatorEmployeeValue.Text = "PLACEHOLDER";
        this.creatorEmployeeValue.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // ShippingOrderView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(884, 561);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(900, 600);
        this.Name = "ShippingOrderView";
        this.Text = "Gestion des ordres d'expédition";
        this.topBarPanel.ResumeLayout(false);
        this.topBarPanel.PerformLayout();
        this.bottomBarPanel.ResumeLayout(false);
        this.centerTLP.ResumeLayout(false);
        this.centerLeftPanel.ResumeLayout(false);
        this.centerLeftPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.productAddQuantityValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        this.centerRightPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.productChangeQuantityValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTLP;
    private Button btnAction;
    private Button btnCancel;
    private Label openendModeValue;
    private Label openedModeLabel;
    private Panel centerLeftPanel;
    private NumericUpDown idValue;
    private Label idLabel;
    private ComboBox statusValue;
    private Label statusLabel;
    private ComboBox sourceClientValue;
    private TextBox searchClientsTextBox;
    private Label sourceClientLabel;
    private Label adresseDestinationLabel;
    private Button buttonCreateAddress;
    private TextBox addressDisplayTextBox;
    private Panel centerRightPanel;
    private DateTimePicker dateShippedValue;
    private Label dateShippedLabel;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label fulfillerEmployeeLabel;
    private Label fulfillerEmployeeValue;
    private Label creatorEmployeeLabel;
    private Label creatorEmployeeValue;
    private NumericUpDown productAddQuantityValue;
    private Button buttonAddProduct;
    private ListBox productSearchResultsListBox;
    private TextBox productSearchTextBox;
    private Label productsManagementLabel;
    private Label productAddQuantityLabel;
    private Label productChangeQuantityLabel;
    private NumericUpDown productChangeQuantityValue;
    private Button buttonRemoveProduct;
    private ListBox orderProductsList;
}