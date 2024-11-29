namespace _420DA3_A24_Projet.Presentation;

partial class AdminMainMenu {
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
        this.bottomBarPanel = new Panel();
        this.buttonLogout = new Button();
        this.centerTableLayoutPanel = new TableLayoutPanel();
        this.purchaseOrderMainPanel = new Panel();
        this.purchaseOrderManagementLabel = new Label();
        this.shipmentMainPanel = new Panel();
        this.shipmentManagementLabel = new Label();
        this.shipOrderMainPanel = new Panel();
        this.soSearchResults = new ListBox();
        this.tableLayoutPanel3 = new TableLayoutPanel();
        this.panel1 = new Panel();
        this.buttonDeleteSO = new Button();
        this.buttonEditSO = new Button();
        this.buttonViewSO = new Button();
        this.soSearchTextBox = new TextBox();
        this.tableLayoutPanel2 = new TableLayoutPanel();
        this.buttonCreateSO = new Button();
        this.shipOrderManagementLabel = new Label();
        this.addressMainPanel = new Panel();
        this.addressManagementLabel = new Label();
        this.warehouseMainPanel = new Panel();
        this.warehouseManagementLabel = new Label();
        this.supplierMainPanel = new Panel();
        this.supplierManagementLabel = new Label();
        this.productMainPanel = new Panel();
        this.productManagementLabel = new Label();
        this.clientMainPanel = new Panel();
        this.clientManagementLabel = new Label();
        this.roleMainPanel = new Panel();
        this.roleManagementLabel = new Label();
        this.userMainPanel = new Panel();
        this.userSearchResults = new ListBox();
        this.userSearchTextBox = new TextBox();
        this.tableLayoutPanel1 = new TableLayoutPanel();
        this.userActionButtonsPanel = new Panel();
        this.buttonDeleteUser = new Button();
        this.buttonEditUser = new Button();
        this.buttonViewUser = new Button();
        this.createUserTLP = new TableLayoutPanel();
        this.buttonCreateUser = new Button();
        this.userManagementLabel = new Label();
        this.bottomBarPanel.SuspendLayout();
        this.centerTableLayoutPanel.SuspendLayout();
        this.purchaseOrderMainPanel.SuspendLayout();
        this.shipmentMainPanel.SuspendLayout();
        this.shipOrderMainPanel.SuspendLayout();
        this.tableLayoutPanel3.SuspendLayout();
        this.panel1.SuspendLayout();
        this.tableLayoutPanel2.SuspendLayout();
        this.addressMainPanel.SuspendLayout();
        this.warehouseMainPanel.SuspendLayout();
        this.supplierMainPanel.SuspendLayout();
        this.productMainPanel.SuspendLayout();
        this.clientMainPanel.SuspendLayout();
        this.roleMainPanel.SuspendLayout();
        this.userMainPanel.SuspendLayout();
        this.tableLayoutPanel1.SuspendLayout();
        this.userActionButtonsPanel.SuspendLayout();
        this.createUserTLP.SuspendLayout();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(1005, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.buttonLogout);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 544);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1005, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // buttonLogout
        // 
        this.buttonLogout.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonLogout.Location = new Point(869, 6);
        this.buttonLogout.Name = "buttonLogout";
        this.buttonLogout.Size = new Size(124, 32);
        this.buttonLogout.TabIndex = 0;
        this.buttonLogout.Text = "DÉCONNEXION";
        this.buttonLogout.UseVisualStyleBackColor = true;
        this.buttonLogout.Click += this.ButtonLogout_Click;
        // 
        // centerTableLayoutPanel
        // 
        this.centerTableLayoutPanel.ColumnCount = 5;
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        this.centerTableLayoutPanel.Controls.Add(this.purchaseOrderMainPanel, 4, 1);
        this.centerTableLayoutPanel.Controls.Add(this.shipmentMainPanel, 3, 1);
        this.centerTableLayoutPanel.Controls.Add(this.shipOrderMainPanel, 2, 1);
        this.centerTableLayoutPanel.Controls.Add(this.addressMainPanel, 1, 1);
        this.centerTableLayoutPanel.Controls.Add(this.warehouseMainPanel, 0, 1);
        this.centerTableLayoutPanel.Controls.Add(this.supplierMainPanel, 4, 0);
        this.centerTableLayoutPanel.Controls.Add(this.productMainPanel, 3, 0);
        this.centerTableLayoutPanel.Controls.Add(this.clientMainPanel, 2, 0);
        this.centerTableLayoutPanel.Controls.Add(this.roleMainPanel, 1, 0);
        this.centerTableLayoutPanel.Controls.Add(this.userMainPanel, 0, 0);
        this.centerTableLayoutPanel.Dock = DockStyle.Fill;
        this.centerTableLayoutPanel.Location = new Point(0, 50);
        this.centerTableLayoutPanel.Name = "centerTableLayoutPanel";
        this.centerTableLayoutPanel.RowCount = 2;
        this.centerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.centerTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        this.centerTableLayoutPanel.Size = new Size(1005, 494);
        this.centerTableLayoutPanel.TabIndex = 2;
        // 
        // purchaseOrderMainPanel
        // 
        this.purchaseOrderMainPanel.Controls.Add(this.purchaseOrderManagementLabel);
        this.purchaseOrderMainPanel.Dock = DockStyle.Fill;
        this.purchaseOrderMainPanel.Location = new Point(807, 250);
        this.purchaseOrderMainPanel.Name = "purchaseOrderMainPanel";
        this.purchaseOrderMainPanel.Size = new Size(195, 241);
        this.purchaseOrderMainPanel.TabIndex = 9;
        // 
        // purchaseOrderManagementLabel
        // 
        this.purchaseOrderManagementLabel.Dock = DockStyle.Top;
        this.purchaseOrderManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.purchaseOrderManagementLabel.Location = new Point(0, 0);
        this.purchaseOrderManagementLabel.Name = "purchaseOrderManagementLabel";
        this.purchaseOrderManagementLabel.Size = new Size(195, 23);
        this.purchaseOrderManagementLabel.TabIndex = 0;
        this.purchaseOrderManagementLabel.Text = "Gestion des ordres de restockage";
        this.purchaseOrderManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipmentMainPanel
        // 
        this.shipmentMainPanel.Controls.Add(this.shipmentManagementLabel);
        this.shipmentMainPanel.Dock = DockStyle.Fill;
        this.shipmentMainPanel.Location = new Point(606, 250);
        this.shipmentMainPanel.Name = "shipmentMainPanel";
        this.shipmentMainPanel.Size = new Size(195, 241);
        this.shipmentMainPanel.TabIndex = 8;
        // 
        // shipmentManagementLabel
        // 
        this.shipmentManagementLabel.Dock = DockStyle.Top;
        this.shipmentManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.shipmentManagementLabel.Location = new Point(0, 0);
        this.shipmentManagementLabel.Name = "shipmentManagementLabel";
        this.shipmentManagementLabel.Size = new Size(195, 23);
        this.shipmentManagementLabel.TabIndex = 0;
        this.shipmentManagementLabel.Text = "Gestion des expéditions";
        this.shipmentManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // shipOrderMainPanel
        // 
        this.shipOrderMainPanel.Controls.Add(this.soSearchResults);
        this.shipOrderMainPanel.Controls.Add(this.tableLayoutPanel3);
        this.shipOrderMainPanel.Controls.Add(this.soSearchTextBox);
        this.shipOrderMainPanel.Controls.Add(this.tableLayoutPanel2);
        this.shipOrderMainPanel.Controls.Add(this.shipOrderManagementLabel);
        this.shipOrderMainPanel.Dock = DockStyle.Fill;
        this.shipOrderMainPanel.Location = new Point(405, 250);
        this.shipOrderMainPanel.Name = "shipOrderMainPanel";
        this.shipOrderMainPanel.Size = new Size(195, 241);
        this.shipOrderMainPanel.TabIndex = 7;
        // 
        // soSearchResults
        // 
        this.soSearchResults.Dock = DockStyle.Fill;
        this.soSearchResults.FormattingEnabled = true;
        this.soSearchResults.ItemHeight = 15;
        this.soSearchResults.Location = new Point(0, 86);
        this.soSearchResults.Name = "soSearchResults";
        this.soSearchResults.Size = new Size(195, 75);
        this.soSearchResults.TabIndex = 6;
        this.soSearchResults.SelectedIndexChanged += this.SoSearchResults_SelectedIndexChanged;
        // 
        // tableLayoutPanel3
        // 
        this.tableLayoutPanel3.ColumnCount = 3;
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
        this.tableLayoutPanel3.Dock = DockStyle.Bottom;
        this.tableLayoutPanel3.Location = new Point(0, 161);
        this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        this.tableLayoutPanel3.RowCount = 1;
        this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel3.Size = new Size(195, 80);
        this.tableLayoutPanel3.TabIndex = 5;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.buttonDeleteSO);
        this.panel1.Controls.Add(this.buttonEditSO);
        this.panel1.Controls.Add(this.buttonViewSO);
        this.panel1.Dock = DockStyle.Fill;
        this.panel1.Location = new Point(37, 5);
        this.panel1.Margin = new Padding(0, 5, 0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new Size(120, 75);
        this.panel1.TabIndex = 0;
        // 
        // buttonDeleteSO
        // 
        this.buttonDeleteSO.Dock = DockStyle.Top;
        this.buttonDeleteSO.Enabled = false;
        this.buttonDeleteSO.Location = new Point(0, 46);
        this.buttonDeleteSO.Name = "buttonDeleteSO";
        this.buttonDeleteSO.Size = new Size(120, 23);
        this.buttonDeleteSO.TabIndex = 2;
        this.buttonDeleteSO.Text = "Supprimer";
        this.buttonDeleteSO.UseVisualStyleBackColor = true;
        this.buttonDeleteSO.Click += this.ButtonDeleteSO_Click;
        // 
        // buttonEditSO
        // 
        this.buttonEditSO.Dock = DockStyle.Top;
        this.buttonEditSO.Enabled = false;
        this.buttonEditSO.Location = new Point(0, 23);
        this.buttonEditSO.Name = "buttonEditSO";
        this.buttonEditSO.Size = new Size(120, 23);
        this.buttonEditSO.TabIndex = 1;
        this.buttonEditSO.Text = "Modifier";
        this.buttonEditSO.UseVisualStyleBackColor = true;
        this.buttonEditSO.Click += this.ButtonEditSO_Click;
        // 
        // buttonViewSO
        // 
        this.buttonViewSO.Dock = DockStyle.Top;
        this.buttonViewSO.Enabled = false;
        this.buttonViewSO.Location = new Point(0, 0);
        this.buttonViewSO.Name = "buttonViewSO";
        this.buttonViewSO.Size = new Size(120, 23);
        this.buttonViewSO.TabIndex = 0;
        this.buttonViewSO.Text = "Voir Détails";
        this.buttonViewSO.UseVisualStyleBackColor = true;
        this.buttonViewSO.Click += this.ButtonViewSO_Click;
        // 
        // soSearchTextBox
        // 
        this.soSearchTextBox.Dock = DockStyle.Top;
        this.soSearchTextBox.Location = new Point(0, 63);
        this.soSearchTextBox.Name = "soSearchTextBox";
        this.soSearchTextBox.PlaceholderText = "Rechercher ordre d'expédition";
        this.soSearchTextBox.Size = new Size(195, 23);
        this.soSearchTextBox.TabIndex = 4;
        this.soSearchTextBox.TextChanged += this.SoSearchTextBox_TextChanged;
        // 
        // tableLayoutPanel2
        // 
        this.tableLayoutPanel2.ColumnCount = 3;
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        this.tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel2.Controls.Add(this.buttonCreateSO, 1, 0);
        this.tableLayoutPanel2.Dock = DockStyle.Top;
        this.tableLayoutPanel2.Location = new Point(0, 23);
        this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        this.tableLayoutPanel2.RowCount = 1;
        this.tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel2.Size = new Size(195, 40);
        this.tableLayoutPanel2.TabIndex = 2;
        // 
        // buttonCreateSO
        // 
        this.buttonCreateSO.Dock = DockStyle.Bottom;
        this.buttonCreateSO.Location = new Point(25, 14);
        this.buttonCreateSO.Name = "buttonCreateSO";
        this.buttonCreateSO.Size = new Size(144, 23);
        this.buttonCreateSO.TabIndex = 0;
        this.buttonCreateSO.Text = "Créer Ordre Expédition";
        this.buttonCreateSO.UseVisualStyleBackColor = true;
        this.buttonCreateSO.Click += this.ButtonCreateSO_Click;
        // 
        // shipOrderManagementLabel
        // 
        this.shipOrderManagementLabel.Dock = DockStyle.Top;
        this.shipOrderManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.shipOrderManagementLabel.Location = new Point(0, 0);
        this.shipOrderManagementLabel.Name = "shipOrderManagementLabel";
        this.shipOrderManagementLabel.Size = new Size(195, 23);
        this.shipOrderManagementLabel.TabIndex = 0;
        this.shipOrderManagementLabel.Text = "Gestion des ordres d'expédition";
        this.shipOrderManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // addressMainPanel
        // 
        this.addressMainPanel.Controls.Add(this.addressManagementLabel);
        this.addressMainPanel.Dock = DockStyle.Fill;
        this.addressMainPanel.Location = new Point(204, 250);
        this.addressMainPanel.Name = "addressMainPanel";
        this.addressMainPanel.Size = new Size(195, 241);
        this.addressMainPanel.TabIndex = 6;
        // 
        // addressManagementLabel
        // 
        this.addressManagementLabel.Dock = DockStyle.Top;
        this.addressManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.addressManagementLabel.Location = new Point(0, 0);
        this.addressManagementLabel.Name = "addressManagementLabel";
        this.addressManagementLabel.Size = new Size(195, 23);
        this.addressManagementLabel.TabIndex = 0;
        this.addressManagementLabel.Text = "Gestion des addresses";
        this.addressManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // warehouseMainPanel
        // 
        this.warehouseMainPanel.Controls.Add(this.warehouseManagementLabel);
        this.warehouseMainPanel.Dock = DockStyle.Fill;
        this.warehouseMainPanel.Location = new Point(3, 250);
        this.warehouseMainPanel.Name = "warehouseMainPanel";
        this.warehouseMainPanel.Size = new Size(195, 241);
        this.warehouseMainPanel.TabIndex = 5;
        // 
        // warehouseManagementLabel
        // 
        this.warehouseManagementLabel.Dock = DockStyle.Top;
        this.warehouseManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.warehouseManagementLabel.Location = new Point(0, 0);
        this.warehouseManagementLabel.Name = "warehouseManagementLabel";
        this.warehouseManagementLabel.Size = new Size(195, 23);
        this.warehouseManagementLabel.TabIndex = 0;
        this.warehouseManagementLabel.Text = "Gestion des entrepôts";
        this.warehouseManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // supplierMainPanel
        // 
        this.supplierMainPanel.Controls.Add(this.supplierManagementLabel);
        this.supplierMainPanel.Dock = DockStyle.Fill;
        this.supplierMainPanel.Location = new Point(807, 3);
        this.supplierMainPanel.Name = "supplierMainPanel";
        this.supplierMainPanel.Size = new Size(195, 241);
        this.supplierMainPanel.TabIndex = 4;
        // 
        // supplierManagementLabel
        // 
        this.supplierManagementLabel.Dock = DockStyle.Top;
        this.supplierManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.supplierManagementLabel.Location = new Point(0, 0);
        this.supplierManagementLabel.Name = "supplierManagementLabel";
        this.supplierManagementLabel.Size = new Size(195, 23);
        this.supplierManagementLabel.TabIndex = 0;
        this.supplierManagementLabel.Text = "Gestion des fournisseurs";
        this.supplierManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // productMainPanel
        // 
        this.productMainPanel.Controls.Add(this.productManagementLabel);
        this.productMainPanel.Dock = DockStyle.Fill;
        this.productMainPanel.Location = new Point(606, 3);
        this.productMainPanel.Name = "productMainPanel";
        this.productMainPanel.Size = new Size(195, 241);
        this.productMainPanel.TabIndex = 3;
        // 
        // productManagementLabel
        // 
        this.productManagementLabel.Dock = DockStyle.Top;
        this.productManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.productManagementLabel.Location = new Point(0, 0);
        this.productManagementLabel.Name = "productManagementLabel";
        this.productManagementLabel.Size = new Size(195, 23);
        this.productManagementLabel.TabIndex = 0;
        this.productManagementLabel.Text = "Gestion des produits";
        this.productManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // clientMainPanel
        // 
        this.clientMainPanel.Controls.Add(this.clientManagementLabel);
        this.clientMainPanel.Dock = DockStyle.Fill;
        this.clientMainPanel.Location = new Point(405, 3);
        this.clientMainPanel.Name = "clientMainPanel";
        this.clientMainPanel.Size = new Size(195, 241);
        this.clientMainPanel.TabIndex = 2;
        // 
        // clientManagementLabel
        // 
        this.clientManagementLabel.Dock = DockStyle.Top;
        this.clientManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.clientManagementLabel.Location = new Point(0, 0);
        this.clientManagementLabel.Name = "clientManagementLabel";
        this.clientManagementLabel.Size = new Size(195, 23);
        this.clientManagementLabel.TabIndex = 0;
        this.clientManagementLabel.Text = "Gestion des clients";
        this.clientManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // roleMainPanel
        // 
        this.roleMainPanel.Controls.Add(this.roleManagementLabel);
        this.roleMainPanel.Dock = DockStyle.Fill;
        this.roleMainPanel.Location = new Point(204, 3);
        this.roleMainPanel.Name = "roleMainPanel";
        this.roleMainPanel.Size = new Size(195, 241);
        this.roleMainPanel.TabIndex = 1;
        // 
        // roleManagementLabel
        // 
        this.roleManagementLabel.Dock = DockStyle.Top;
        this.roleManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.roleManagementLabel.Location = new Point(0, 0);
        this.roleManagementLabel.Name = "roleManagementLabel";
        this.roleManagementLabel.Size = new Size(195, 23);
        this.roleManagementLabel.TabIndex = 0;
        this.roleManagementLabel.Text = "Gestion des rôles";
        this.roleManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // userMainPanel
        // 
        this.userMainPanel.Controls.Add(this.userSearchResults);
        this.userMainPanel.Controls.Add(this.userSearchTextBox);
        this.userMainPanel.Controls.Add(this.tableLayoutPanel1);
        this.userMainPanel.Controls.Add(this.createUserTLP);
        this.userMainPanel.Controls.Add(this.userManagementLabel);
        this.userMainPanel.Dock = DockStyle.Fill;
        this.userMainPanel.Location = new Point(3, 3);
        this.userMainPanel.Name = "userMainPanel";
        this.userMainPanel.Size = new Size(195, 241);
        this.userMainPanel.TabIndex = 0;
        // 
        // userSearchResults
        // 
        this.userSearchResults.Dock = DockStyle.Fill;
        this.userSearchResults.FormattingEnabled = true;
        this.userSearchResults.ItemHeight = 15;
        this.userSearchResults.Location = new Point(0, 86);
        this.userSearchResults.Name = "userSearchResults";
        this.userSearchResults.Size = new Size(195, 75);
        this.userSearchResults.TabIndex = 4;
        this.userSearchResults.SelectedIndexChanged += this.UserSearchResults_SelectedIndexChanged;
        // 
        // userSearchTextBox
        // 
        this.userSearchTextBox.Dock = DockStyle.Top;
        this.userSearchTextBox.Location = new Point(0, 63);
        this.userSearchTextBox.Name = "userSearchTextBox";
        this.userSearchTextBox.PlaceholderText = "Rechercher un utilisateur";
        this.userSearchTextBox.Size = new Size(195, 23);
        this.userSearchTextBox.TabIndex = 3;
        this.userSearchTextBox.TextChanged += this.UserSearchTextBox_TextChanged;
        // 
        // tableLayoutPanel1
        // 
        this.tableLayoutPanel1.ColumnCount = 3;
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.tableLayoutPanel1.Controls.Add(this.userActionButtonsPanel, 1, 0);
        this.tableLayoutPanel1.Dock = DockStyle.Bottom;
        this.tableLayoutPanel1.Location = new Point(0, 161);
        this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        this.tableLayoutPanel1.RowCount = 1;
        this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.tableLayoutPanel1.Size = new Size(195, 80);
        this.tableLayoutPanel1.TabIndex = 2;
        // 
        // userActionButtonsPanel
        // 
        this.userActionButtonsPanel.Controls.Add(this.buttonDeleteUser);
        this.userActionButtonsPanel.Controls.Add(this.buttonEditUser);
        this.userActionButtonsPanel.Controls.Add(this.buttonViewUser);
        this.userActionButtonsPanel.Dock = DockStyle.Fill;
        this.userActionButtonsPanel.Location = new Point(37, 5);
        this.userActionButtonsPanel.Margin = new Padding(0, 5, 0, 0);
        this.userActionButtonsPanel.Name = "userActionButtonsPanel";
        this.userActionButtonsPanel.Size = new Size(120, 75);
        this.userActionButtonsPanel.TabIndex = 0;
        // 
        // buttonDeleteUser
        // 
        this.buttonDeleteUser.Dock = DockStyle.Top;
        this.buttonDeleteUser.Enabled = false;
        this.buttonDeleteUser.Location = new Point(0, 46);
        this.buttonDeleteUser.Name = "buttonDeleteUser";
        this.buttonDeleteUser.Size = new Size(120, 23);
        this.buttonDeleteUser.TabIndex = 2;
        this.buttonDeleteUser.Text = "Supprimer";
        this.buttonDeleteUser.UseVisualStyleBackColor = true;
        this.buttonDeleteUser.Click += this.ButtonDeleteUser_Click;
        // 
        // buttonEditUser
        // 
        this.buttonEditUser.Dock = DockStyle.Top;
        this.buttonEditUser.Enabled = false;
        this.buttonEditUser.Location = new Point(0, 23);
        this.buttonEditUser.Name = "buttonEditUser";
        this.buttonEditUser.Size = new Size(120, 23);
        this.buttonEditUser.TabIndex = 1;
        this.buttonEditUser.Text = "Modifier";
        this.buttonEditUser.UseVisualStyleBackColor = true;
        this.buttonEditUser.Click += this.ButtonEditUser_Click;
        // 
        // buttonViewUser
        // 
        this.buttonViewUser.Dock = DockStyle.Top;
        this.buttonViewUser.Enabled = false;
        this.buttonViewUser.Location = new Point(0, 0);
        this.buttonViewUser.Name = "buttonViewUser";
        this.buttonViewUser.Size = new Size(120, 23);
        this.buttonViewUser.TabIndex = 0;
        this.buttonViewUser.Text = "Voir Détails";
        this.buttonViewUser.UseVisualStyleBackColor = true;
        this.buttonViewUser.Click += this.ButtonViewUser_Click;
        // 
        // createUserTLP
        // 
        this.createUserTLP.ColumnCount = 3;
        this.createUserTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createUserTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        this.createUserTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.createUserTLP.Controls.Add(this.buttonCreateUser, 1, 0);
        this.createUserTLP.Dock = DockStyle.Top;
        this.createUserTLP.Location = new Point(0, 23);
        this.createUserTLP.Name = "createUserTLP";
        this.createUserTLP.RowCount = 1;
        this.createUserTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.createUserTLP.Size = new Size(195, 40);
        this.createUserTLP.TabIndex = 1;
        // 
        // buttonCreateUser
        // 
        this.buttonCreateUser.Dock = DockStyle.Bottom;
        this.buttonCreateUser.Location = new Point(40, 14);
        this.buttonCreateUser.Name = "buttonCreateUser";
        this.buttonCreateUser.Size = new Size(114, 23);
        this.buttonCreateUser.TabIndex = 0;
        this.buttonCreateUser.Text = "Créer Utilisateur";
        this.buttonCreateUser.UseVisualStyleBackColor = true;
        this.buttonCreateUser.Click += this.ButtonCreateUser_Click;
        // 
        // userManagementLabel
        // 
        this.userManagementLabel.Dock = DockStyle.Top;
        this.userManagementLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.userManagementLabel.Location = new Point(0, 0);
        this.userManagementLabel.Name = "userManagementLabel";
        this.userManagementLabel.Size = new Size(195, 23);
        this.userManagementLabel.TabIndex = 0;
        this.userManagementLabel.Text = "Gestion des utilisateurs";
        this.userManagementLabel.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // AdminMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1005, 594);
        this.Controls.Add(this.centerTableLayoutPanel);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "AdminMainMenu";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Menu Principal Administrateur";
        this.WindowState = FormWindowState.Maximized;
        this.bottomBarPanel.ResumeLayout(false);
        this.centerTableLayoutPanel.ResumeLayout(false);
        this.purchaseOrderMainPanel.ResumeLayout(false);
        this.shipmentMainPanel.ResumeLayout(false);
        this.shipOrderMainPanel.ResumeLayout(false);
        this.shipOrderMainPanel.PerformLayout();
        this.tableLayoutPanel3.ResumeLayout(false);
        this.panel1.ResumeLayout(false);
        this.tableLayoutPanel2.ResumeLayout(false);
        this.addressMainPanel.ResumeLayout(false);
        this.warehouseMainPanel.ResumeLayout(false);
        this.supplierMainPanel.ResumeLayout(false);
        this.productMainPanel.ResumeLayout(false);
        this.clientMainPanel.ResumeLayout(false);
        this.roleMainPanel.ResumeLayout(false);
        this.userMainPanel.ResumeLayout(false);
        this.userMainPanel.PerformLayout();
        this.tableLayoutPanel1.ResumeLayout(false);
        this.userActionButtonsPanel.ResumeLayout(false);
        this.createUserTLP.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTableLayoutPanel;
    private Panel userMainPanel;
    private Label userManagementLabel;
    private Panel purchaseOrderMainPanel;
    private Label purchaseOrderManagementLabel;
    private Panel shipmentMainPanel;
    private Label shipmentManagementLabel;
    private Panel shipOrderMainPanel;
    private Label shipOrderManagementLabel;
    private Panel addressMainPanel;
    private Label addressManagementLabel;
    private Panel warehouseMainPanel;
    private Label warehouseManagementLabel;
    private Panel supplierMainPanel;
    private Label supplierManagementLabel;
    private Panel productMainPanel;
    private Label productManagementLabel;
    private Panel clientMainPanel;
    private Label clientManagementLabel;
    private Panel roleMainPanel;
    private Label roleManagementLabel;
    private Button buttonLogout;
    private TableLayoutPanel createUserTLP;
    private Button buttonCreateUser;
    private TableLayoutPanel tableLayoutPanel1;
    private ListBox userSearchResults;
    private TextBox userSearchTextBox;
    private Panel userActionButtonsPanel;
    private Button buttonDeleteUser;
    private Button buttonEditUser;
    private Button buttonViewUser;
    private ListBox soSearchResults;
    private TableLayoutPanel tableLayoutPanel3;
    private Panel panel1;
    private Button buttonDeleteSO;
    private Button buttonEditSO;
    private Button buttonViewSO;
    private TextBox soSearchTextBox;
    private TableLayoutPanel tableLayoutPanel2;
    private Button buttonCreateSO;
}