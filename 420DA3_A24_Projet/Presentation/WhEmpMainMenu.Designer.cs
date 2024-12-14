namespace _420DA3_A24_Projet.Presentation;

partial class WhEmpMainMenu {
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhEmpMainMenu));
        this.topBarPanel = new Panel();
        this.userHeaderLabel = new Label();
        this.bottomBarPanel = new Panel();
        this.creditsLink = new LinkLabel();
        this.creditsLabel = new Label();
        this.buttonLogout = new Button();
        this.centerTLP = new TableLayoutPanel();
        this.unassignedSoPanel = new Panel();
        this.unassignedSOListBox = new ListBox();
        this.unassSOActionTLP = new TableLayoutPanel();
        this.unassSOActionPanel = new Panel();
        this.buttonAssignToMe = new Button();
        this.unassSORefreshTLP = new TableLayoutPanel();
        this.unassSORefreshPanel = new Panel();
        this.buttonRefreshUnassignedSOs = new Button();
        this.unassSORefreshImage = new PictureBox();
        this.unassignedSOHeader = new Label();
        this.processingSOPanel = new Panel();
        this.processingSOListBox = new ListBox();
        this.processSOActionTLP = new TableLayoutPanel();
        this.processSOActionPanel = new Panel();
        this.buttonMarkPackaged = new Button();
        this.processSORefreshTLP = new TableLayoutPanel();
        this.processSORefreshPanel = new Panel();
        this.buttonRefreshProcessingSOs = new Button();
        this.processSORefreshImage = new PictureBox();
        this.processSOHeader = new Label();
        this.packagedSOPanel = new Panel();
        this.packagedSOListBox = new ListBox();
        this.packagedSOActionTLP = new TableLayoutPanel();
        this.packagedSOActionPanel = new Panel();
        this.buttonMarkShipped = new Button();
        this.packagedSORefreshTLP = new TableLayoutPanel();
        this.packagedSORefreshPanel = new Panel();
        this.buttonRefreshPackagedSOs = new Button();
        this.packagedSORefreshImage = new PictureBox();
        this.packagedSOHeader = new Label();
        this.expectedPOPanel = new Panel();
        this.expectedPOListBox = new ListBox();
        this.expectedPOActionTLP = new TableLayoutPanel();
        this.expectedPOActionPanel = new Panel();
        this.buttonMarkReceived = new Button();
        this.expectedPORefreshTLP = new TableLayoutPanel();
        this.expectedPORefreshPanel = new Panel();
        this.buttonRefreshExpectedPOs = new Button();
        this.expectedPORefreshImage = new PictureBox();
        this.expectedPOHeader = new Label();
        this.topBarPanel.SuspendLayout();
        this.bottomBarPanel.SuspendLayout();
        this.centerTLP.SuspendLayout();
        this.unassignedSoPanel.SuspendLayout();
        this.unassSOActionTLP.SuspendLayout();
        this.unassSOActionPanel.SuspendLayout();
        this.unassSORefreshTLP.SuspendLayout();
        this.unassSORefreshPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.unassSORefreshImage).BeginInit();
        this.processingSOPanel.SuspendLayout();
        this.processSOActionTLP.SuspendLayout();
        this.processSOActionPanel.SuspendLayout();
        this.processSORefreshTLP.SuspendLayout();
        this.processSORefreshPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.processSORefreshImage).BeginInit();
        this.packagedSOPanel.SuspendLayout();
        this.packagedSOActionTLP.SuspendLayout();
        this.packagedSOActionPanel.SuspendLayout();
        this.packagedSORefreshTLP.SuspendLayout();
        this.packagedSORefreshPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.packagedSORefreshImage).BeginInit();
        this.expectedPOPanel.SuspendLayout();
        this.expectedPOActionTLP.SuspendLayout();
        this.expectedPOActionPanel.SuspendLayout();
        this.expectedPORefreshTLP.SuspendLayout();
        this.expectedPORefreshPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.expectedPORefreshImage).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Controls.Add(this.userHeaderLabel);
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Padding = new Padding(2);
        this.topBarPanel.Size = new Size(1356, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // userHeaderLabel
        // 
        this.userHeaderLabel.Dock = DockStyle.Bottom;
        this.userHeaderLabel.Location = new Point(2, 28);
        this.userHeaderLabel.Name = "userHeaderLabel";
        this.userHeaderLabel.Size = new Size(1352, 20);
        this.userHeaderLabel.TabIndex = 0;
        this.userHeaderLabel.Text = "PLACEHOLDER";
        this.userHeaderLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Controls.Add(this.creditsLink);
        this.bottomBarPanel.Controls.Add(this.creditsLabel);
        this.bottomBarPanel.Controls.Add(this.buttonLogout);
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 603);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(1356, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // creditsLink
        // 
        this.creditsLink.AutoSize = true;
        this.creditsLink.Location = new Point(12, 26);
        this.creditsLink.Name = "creditsLink";
        this.creditsLink.Size = new Size(247, 15);
        this.creditsLink.TabIndex = 3;
        this.creditsLink.TabStop = true;
        this.creditsLink.Text = "https://www.flaticon.com/free-icons/loading";
        // 
        // creditsLabel
        // 
        this.creditsLabel.Anchor =  AnchorStyles.Bottom | AnchorStyles.Left;
        this.creditsLabel.AutoSize = true;
        this.creditsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
        this.creditsLabel.Location = new Point(12, 6);
        this.creditsLabel.Name = "creditsLabel";
        this.creditsLabel.Size = new Size(326, 15);
        this.creditsLabel.TabIndex = 2;
        this.creditsLabel.Text = "Loading icons created by Krystsina Mikhailouskaya - Flaticon";
        // 
        // buttonLogout
        // 
        this.buttonLogout.Anchor =  AnchorStyles.Bottom | AnchorStyles.Right;
        this.buttonLogout.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonLogout.Location = new Point(1220, 6);
        this.buttonLogout.Name = "buttonLogout";
        this.buttonLogout.Size = new Size(124, 32);
        this.buttonLogout.TabIndex = 1;
        this.buttonLogout.Text = "DÉCONNEXION";
        this.buttonLogout.UseVisualStyleBackColor = true;
        this.buttonLogout.Click += this.ButtonLogout_Click;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 6;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        this.centerTLP.Controls.Add(this.unassignedSoPanel, 1, 0);
        this.centerTLP.Controls.Add(this.processingSOPanel, 2, 0);
        this.centerTLP.Controls.Add(this.packagedSOPanel, 3, 0);
        this.centerTLP.Controls.Add(this.expectedPOPanel, 4, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(1356, 553);
        this.centerTLP.TabIndex = 2;
        // 
        // unassignedSoPanel
        // 
        this.unassignedSoPanel.Controls.Add(this.unassignedSOListBox);
        this.unassignedSoPanel.Controls.Add(this.unassSOActionTLP);
        this.unassignedSoPanel.Controls.Add(this.unassSORefreshTLP);
        this.unassignedSoPanel.Controls.Add(this.unassignedSOHeader);
        this.unassignedSoPanel.Dock = DockStyle.Fill;
        this.unassignedSoPanel.Location = new Point(23, 3);
        this.unassignedSoPanel.Name = "unassignedSoPanel";
        this.unassignedSoPanel.Size = new Size(323, 547);
        this.unassignedSoPanel.TabIndex = 0;
        // 
        // unassignedSOListBox
        // 
        this.unassignedSOListBox.Dock = DockStyle.Fill;
        this.unassignedSOListBox.FormattingEnabled = true;
        this.unassignedSOListBox.ItemHeight = 15;
        this.unassignedSOListBox.Location = new Point(0, 75);
        this.unassignedSOListBox.Name = "unassignedSOListBox";
        this.unassignedSOListBox.Size = new Size(323, 432);
        this.unassignedSOListBox.TabIndex = 4;
        this.unassignedSOListBox.SelectedIndexChanged += this.UnassignedSOListBox_SelectedIndexChanged;
        // 
        // unassSOActionTLP
        // 
        this.unassSOActionTLP.ColumnCount = 3;
        this.unassSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.unassSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.unassSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.unassSOActionTLP.Controls.Add(this.unassSOActionPanel, 1, 0);
        this.unassSOActionTLP.Dock = DockStyle.Bottom;
        this.unassSOActionTLP.Location = new Point(0, 507);
        this.unassSOActionTLP.Name = "unassSOActionTLP";
        this.unassSOActionTLP.RowCount = 1;
        this.unassSOActionTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.unassSOActionTLP.Size = new Size(323, 40);
        this.unassSOActionTLP.TabIndex = 3;
        // 
        // unassSOActionPanel
        // 
        this.unassSOActionPanel.Controls.Add(this.buttonAssignToMe);
        this.unassSOActionPanel.Dock = DockStyle.Fill;
        this.unassSOActionPanel.Location = new Point(64, 3);
        this.unassSOActionPanel.Name = "unassSOActionPanel";
        this.unassSOActionPanel.Size = new Size(194, 34);
        this.unassSOActionPanel.TabIndex = 0;
        // 
        // buttonAssignToMe
        // 
        this.buttonAssignToMe.Enabled = false;
        this.buttonAssignToMe.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonAssignToMe.Location = new Point(3, 8);
        this.buttonAssignToMe.Name = "buttonAssignToMe";
        this.buttonAssignToMe.Size = new Size(188, 23);
        this.buttonAssignToMe.TabIndex = 0;
        this.buttonAssignToMe.Text = "Assign To Me";
        this.buttonAssignToMe.UseVisualStyleBackColor = true;
        this.buttonAssignToMe.Click += this.ButtonAssignToMe_Click;
        // 
        // unassSORefreshTLP
        // 
        this.unassSORefreshTLP.ColumnCount = 3;
        this.unassSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.unassSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.unassSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.unassSORefreshTLP.Controls.Add(this.unassSORefreshPanel, 1, 0);
        this.unassSORefreshTLP.Controls.Add(this.unassSORefreshImage, 2, 0);
        this.unassSORefreshTLP.Dock = DockStyle.Top;
        this.unassSORefreshTLP.Location = new Point(0, 35);
        this.unassSORefreshTLP.Name = "unassSORefreshTLP";
        this.unassSORefreshTLP.RowCount = 1;
        this.unassSORefreshTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.unassSORefreshTLP.Size = new Size(323, 40);
        this.unassSORefreshTLP.TabIndex = 1;
        // 
        // unassSORefreshPanel
        // 
        this.unassSORefreshPanel.Controls.Add(this.buttonRefreshUnassignedSOs);
        this.unassSORefreshPanel.Dock = DockStyle.Fill;
        this.unassSORefreshPanel.Location = new Point(64, 3);
        this.unassSORefreshPanel.Name = "unassSORefreshPanel";
        this.unassSORefreshPanel.Size = new Size(194, 34);
        this.unassSORefreshPanel.TabIndex = 0;
        // 
        // buttonRefreshUnassignedSOs
        // 
        this.buttonRefreshUnassignedSOs.Location = new Point(3, 8);
        this.buttonRefreshUnassignedSOs.Name = "buttonRefreshUnassignedSOs";
        this.buttonRefreshUnassignedSOs.Size = new Size(188, 23);
        this.buttonRefreshUnassignedSOs.TabIndex = 0;
        this.buttonRefreshUnassignedSOs.Text = "Refresh List";
        this.buttonRefreshUnassignedSOs.UseVisualStyleBackColor = true;
        this.buttonRefreshUnassignedSOs.Click += this.ButtonRefreshUnassignedSOs_Click;
        // 
        // unassSORefreshImage
        // 
        this.unassSORefreshImage.Image = (Image) resources.GetObject("unassSORefreshImage.Image");
        this.unassSORefreshImage.Location = new Point(264, 3);
        this.unassSORefreshImage.Name = "unassSORefreshImage";
        this.unassSORefreshImage.Size = new Size(56, 34);
        this.unassSORefreshImage.TabIndex = 1;
        this.unassSORefreshImage.TabStop = false;
        // 
        // unassignedSOHeader
        // 
        this.unassignedSOHeader.Dock = DockStyle.Top;
        this.unassignedSOHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.unassignedSOHeader.Location = new Point(0, 0);
        this.unassignedSOHeader.Name = "unassignedSOHeader";
        this.unassignedSOHeader.Size = new Size(323, 35);
        this.unassignedSOHeader.TabIndex = 0;
        this.unassignedSOHeader.Text = "Unassigned Shipping Orders";
        this.unassignedSOHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // processingSOPanel
        // 
        this.processingSOPanel.Controls.Add(this.processingSOListBox);
        this.processingSOPanel.Controls.Add(this.processSOActionTLP);
        this.processingSOPanel.Controls.Add(this.processSORefreshTLP);
        this.processingSOPanel.Controls.Add(this.processSOHeader);
        this.processingSOPanel.Dock = DockStyle.Fill;
        this.processingSOPanel.Location = new Point(352, 3);
        this.processingSOPanel.Name = "processingSOPanel";
        this.processingSOPanel.Size = new Size(323, 547);
        this.processingSOPanel.TabIndex = 1;
        // 
        // processingSOListBox
        // 
        this.processingSOListBox.Dock = DockStyle.Fill;
        this.processingSOListBox.FormattingEnabled = true;
        this.processingSOListBox.ItemHeight = 15;
        this.processingSOListBox.Location = new Point(0, 75);
        this.processingSOListBox.Name = "processingSOListBox";
        this.processingSOListBox.Size = new Size(323, 432);
        this.processingSOListBox.TabIndex = 8;
        this.processingSOListBox.SelectedIndexChanged += this.ProcessingSOListBox_SelectedIndexChanged;
        // 
        // processSOActionTLP
        // 
        this.processSOActionTLP.ColumnCount = 3;
        this.processSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.processSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.processSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.processSOActionTLP.Controls.Add(this.processSOActionPanel, 1, 0);
        this.processSOActionTLP.Dock = DockStyle.Bottom;
        this.processSOActionTLP.Location = new Point(0, 507);
        this.processSOActionTLP.Name = "processSOActionTLP";
        this.processSOActionTLP.RowCount = 1;
        this.processSOActionTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.processSOActionTLP.Size = new Size(323, 40);
        this.processSOActionTLP.TabIndex = 7;
        // 
        // processSOActionPanel
        // 
        this.processSOActionPanel.Controls.Add(this.buttonMarkPackaged);
        this.processSOActionPanel.Dock = DockStyle.Fill;
        this.processSOActionPanel.Location = new Point(64, 3);
        this.processSOActionPanel.Name = "processSOActionPanel";
        this.processSOActionPanel.Size = new Size(194, 34);
        this.processSOActionPanel.TabIndex = 0;
        // 
        // buttonMarkPackaged
        // 
        this.buttonMarkPackaged.Enabled = false;
        this.buttonMarkPackaged.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonMarkPackaged.Location = new Point(3, 8);
        this.buttonMarkPackaged.Name = "buttonMarkPackaged";
        this.buttonMarkPackaged.Size = new Size(188, 23);
        this.buttonMarkPackaged.TabIndex = 0;
        this.buttonMarkPackaged.Text = "Mark As Packaged";
        this.buttonMarkPackaged.UseVisualStyleBackColor = true;
        this.buttonMarkPackaged.Click += this.ButtonMarkPackaged_Click;
        // 
        // processSORefreshTLP
        // 
        this.processSORefreshTLP.ColumnCount = 3;
        this.processSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.processSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.processSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.processSORefreshTLP.Controls.Add(this.processSORefreshPanel, 1, 0);
        this.processSORefreshTLP.Controls.Add(this.processSORefreshImage, 2, 0);
        this.processSORefreshTLP.Dock = DockStyle.Top;
        this.processSORefreshTLP.Location = new Point(0, 35);
        this.processSORefreshTLP.Name = "processSORefreshTLP";
        this.processSORefreshTLP.RowCount = 1;
        this.processSORefreshTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.processSORefreshTLP.Size = new Size(323, 40);
        this.processSORefreshTLP.TabIndex = 6;
        // 
        // processSORefreshPanel
        // 
        this.processSORefreshPanel.Controls.Add(this.buttonRefreshProcessingSOs);
        this.processSORefreshPanel.Dock = DockStyle.Fill;
        this.processSORefreshPanel.Location = new Point(64, 3);
        this.processSORefreshPanel.Name = "processSORefreshPanel";
        this.processSORefreshPanel.Size = new Size(194, 34);
        this.processSORefreshPanel.TabIndex = 0;
        // 
        // buttonRefreshProcessingSOs
        // 
        this.buttonRefreshProcessingSOs.Location = new Point(3, 8);
        this.buttonRefreshProcessingSOs.Name = "buttonRefreshProcessingSOs";
        this.buttonRefreshProcessingSOs.Size = new Size(188, 23);
        this.buttonRefreshProcessingSOs.TabIndex = 0;
        this.buttonRefreshProcessingSOs.Text = "Refresh List";
        this.buttonRefreshProcessingSOs.UseVisualStyleBackColor = true;
        this.buttonRefreshProcessingSOs.Click += this.ButtonRefreshProcessingSOs_Click;
        // 
        // processSORefreshImage
        // 
        this.processSORefreshImage.Image = (Image) resources.GetObject("processSORefreshImage.Image");
        this.processSORefreshImage.Location = new Point(264, 3);
        this.processSORefreshImage.Name = "processSORefreshImage";
        this.processSORefreshImage.Size = new Size(56, 34);
        this.processSORefreshImage.TabIndex = 2;
        this.processSORefreshImage.TabStop = false;
        // 
        // processSOHeader
        // 
        this.processSOHeader.Dock = DockStyle.Top;
        this.processSOHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.processSOHeader.Location = new Point(0, 0);
        this.processSOHeader.Name = "processSOHeader";
        this.processSOHeader.Size = new Size(323, 35);
        this.processSOHeader.TabIndex = 5;
        this.processSOHeader.Text = "Shipping Orders In Process";
        this.processSOHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // packagedSOPanel
        // 
        this.packagedSOPanel.Controls.Add(this.packagedSOListBox);
        this.packagedSOPanel.Controls.Add(this.packagedSOActionTLP);
        this.packagedSOPanel.Controls.Add(this.packagedSORefreshTLP);
        this.packagedSOPanel.Controls.Add(this.packagedSOHeader);
        this.packagedSOPanel.Dock = DockStyle.Fill;
        this.packagedSOPanel.Location = new Point(681, 3);
        this.packagedSOPanel.Name = "packagedSOPanel";
        this.packagedSOPanel.Size = new Size(323, 547);
        this.packagedSOPanel.TabIndex = 2;
        // 
        // packagedSOListBox
        // 
        this.packagedSOListBox.Dock = DockStyle.Fill;
        this.packagedSOListBox.FormattingEnabled = true;
        this.packagedSOListBox.ItemHeight = 15;
        this.packagedSOListBox.Location = new Point(0, 75);
        this.packagedSOListBox.Name = "packagedSOListBox";
        this.packagedSOListBox.Size = new Size(323, 432);
        this.packagedSOListBox.TabIndex = 8;
        this.packagedSOListBox.SelectedIndexChanged += this.PackagedSOListBox_SelectedIndexChanged;
        // 
        // packagedSOActionTLP
        // 
        this.packagedSOActionTLP.ColumnCount = 3;
        this.packagedSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.packagedSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.packagedSOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.packagedSOActionTLP.Controls.Add(this.packagedSOActionPanel, 1, 0);
        this.packagedSOActionTLP.Dock = DockStyle.Bottom;
        this.packagedSOActionTLP.Location = new Point(0, 507);
        this.packagedSOActionTLP.Name = "packagedSOActionTLP";
        this.packagedSOActionTLP.RowCount = 1;
        this.packagedSOActionTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.packagedSOActionTLP.Size = new Size(323, 40);
        this.packagedSOActionTLP.TabIndex = 7;
        // 
        // packagedSOActionPanel
        // 
        this.packagedSOActionPanel.Controls.Add(this.buttonMarkShipped);
        this.packagedSOActionPanel.Dock = DockStyle.Fill;
        this.packagedSOActionPanel.Location = new Point(64, 3);
        this.packagedSOActionPanel.Name = "packagedSOActionPanel";
        this.packagedSOActionPanel.Size = new Size(194, 34);
        this.packagedSOActionPanel.TabIndex = 0;
        // 
        // buttonMarkShipped
        // 
        this.buttonMarkShipped.Enabled = false;
        this.buttonMarkShipped.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonMarkShipped.Location = new Point(3, 8);
        this.buttonMarkShipped.Name = "buttonMarkShipped";
        this.buttonMarkShipped.Size = new Size(188, 23);
        this.buttonMarkShipped.TabIndex = 0;
        this.buttonMarkShipped.Text = "Mark As Shipped";
        this.buttonMarkShipped.UseVisualStyleBackColor = true;
        this.buttonMarkShipped.Click += this.ButtonMarkShipped_Click;
        // 
        // packagedSORefreshTLP
        // 
        this.packagedSORefreshTLP.ColumnCount = 3;
        this.packagedSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.packagedSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.packagedSORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.packagedSORefreshTLP.Controls.Add(this.packagedSORefreshPanel, 1, 0);
        this.packagedSORefreshTLP.Controls.Add(this.packagedSORefreshImage, 2, 0);
        this.packagedSORefreshTLP.Dock = DockStyle.Top;
        this.packagedSORefreshTLP.Location = new Point(0, 35);
        this.packagedSORefreshTLP.Name = "packagedSORefreshTLP";
        this.packagedSORefreshTLP.RowCount = 1;
        this.packagedSORefreshTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.packagedSORefreshTLP.Size = new Size(323, 40);
        this.packagedSORefreshTLP.TabIndex = 6;
        // 
        // packagedSORefreshPanel
        // 
        this.packagedSORefreshPanel.Controls.Add(this.buttonRefreshPackagedSOs);
        this.packagedSORefreshPanel.Dock = DockStyle.Fill;
        this.packagedSORefreshPanel.Location = new Point(64, 3);
        this.packagedSORefreshPanel.Name = "packagedSORefreshPanel";
        this.packagedSORefreshPanel.Size = new Size(194, 34);
        this.packagedSORefreshPanel.TabIndex = 0;
        // 
        // buttonRefreshPackagedSOs
        // 
        this.buttonRefreshPackagedSOs.Location = new Point(3, 8);
        this.buttonRefreshPackagedSOs.Name = "buttonRefreshPackagedSOs";
        this.buttonRefreshPackagedSOs.Size = new Size(188, 23);
        this.buttonRefreshPackagedSOs.TabIndex = 0;
        this.buttonRefreshPackagedSOs.Text = "Refresh List";
        this.buttonRefreshPackagedSOs.UseVisualStyleBackColor = true;
        this.buttonRefreshPackagedSOs.Click += this.ButtonRefreshPackagedSOs_Click;
        // 
        // packagedSORefreshImage
        // 
        this.packagedSORefreshImage.Image = (Image) resources.GetObject("packagedSORefreshImage.Image");
        this.packagedSORefreshImage.Location = new Point(264, 3);
        this.packagedSORefreshImage.Name = "packagedSORefreshImage";
        this.packagedSORefreshImage.Size = new Size(56, 34);
        this.packagedSORefreshImage.TabIndex = 2;
        this.packagedSORefreshImage.TabStop = false;
        // 
        // packagedSOHeader
        // 
        this.packagedSOHeader.Dock = DockStyle.Top;
        this.packagedSOHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.packagedSOHeader.Location = new Point(0, 0);
        this.packagedSOHeader.Name = "packagedSOHeader";
        this.packagedSOHeader.Size = new Size(323, 35);
        this.packagedSOHeader.TabIndex = 5;
        this.packagedSOHeader.Text = "Packaged Shipping Orders";
        this.packagedSOHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // expectedPOPanel
        // 
        this.expectedPOPanel.Controls.Add(this.expectedPOListBox);
        this.expectedPOPanel.Controls.Add(this.expectedPOActionTLP);
        this.expectedPOPanel.Controls.Add(this.expectedPORefreshTLP);
        this.expectedPOPanel.Controls.Add(this.expectedPOHeader);
        this.expectedPOPanel.Dock = DockStyle.Fill;
        this.expectedPOPanel.Location = new Point(1010, 3);
        this.expectedPOPanel.Name = "expectedPOPanel";
        this.expectedPOPanel.Size = new Size(323, 547);
        this.expectedPOPanel.TabIndex = 3;
        // 
        // expectedPOListBox
        // 
        this.expectedPOListBox.Dock = DockStyle.Fill;
        this.expectedPOListBox.FormattingEnabled = true;
        this.expectedPOListBox.ItemHeight = 15;
        this.expectedPOListBox.Location = new Point(0, 75);
        this.expectedPOListBox.Name = "expectedPOListBox";
        this.expectedPOListBox.Size = new Size(323, 432);
        this.expectedPOListBox.TabIndex = 8;
        this.expectedPOListBox.SelectedIndexChanged += this.ExpectedPOListBox_SelectedIndexChanged;
        // 
        // expectedPOActionTLP
        // 
        this.expectedPOActionTLP.ColumnCount = 3;
        this.expectedPOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.expectedPOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.expectedPOActionTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.expectedPOActionTLP.Controls.Add(this.expectedPOActionPanel, 1, 0);
        this.expectedPOActionTLP.Dock = DockStyle.Bottom;
        this.expectedPOActionTLP.Location = new Point(0, 507);
        this.expectedPOActionTLP.Name = "expectedPOActionTLP";
        this.expectedPOActionTLP.RowCount = 1;
        this.expectedPOActionTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.expectedPOActionTLP.Size = new Size(323, 40);
        this.expectedPOActionTLP.TabIndex = 7;
        // 
        // expectedPOActionPanel
        // 
        this.expectedPOActionPanel.Controls.Add(this.buttonMarkReceived);
        this.expectedPOActionPanel.Dock = DockStyle.Fill;
        this.expectedPOActionPanel.Location = new Point(64, 3);
        this.expectedPOActionPanel.Name = "expectedPOActionPanel";
        this.expectedPOActionPanel.Size = new Size(194, 34);
        this.expectedPOActionPanel.TabIndex = 0;
        // 
        // buttonMarkReceived
        // 
        this.buttonMarkReceived.Enabled = false;
        this.buttonMarkReceived.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        this.buttonMarkReceived.Location = new Point(3, 8);
        this.buttonMarkReceived.Name = "buttonMarkReceived";
        this.buttonMarkReceived.Size = new Size(188, 23);
        this.buttonMarkReceived.TabIndex = 0;
        this.buttonMarkReceived.Text = "Mark As Received";
        this.buttonMarkReceived.UseVisualStyleBackColor = true;
        this.buttonMarkReceived.Click += this.ButtonMarkReceived_Click;
        // 
        // expectedPORefreshTLP
        // 
        this.expectedPORefreshTLP.ColumnCount = 3;
        this.expectedPORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.expectedPORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
        this.expectedPORefreshTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.expectedPORefreshTLP.Controls.Add(this.expectedPORefreshPanel, 1, 0);
        this.expectedPORefreshTLP.Controls.Add(this.expectedPORefreshImage, 2, 0);
        this.expectedPORefreshTLP.Dock = DockStyle.Top;
        this.expectedPORefreshTLP.Location = new Point(0, 35);
        this.expectedPORefreshTLP.Name = "expectedPORefreshTLP";
        this.expectedPORefreshTLP.RowCount = 1;
        this.expectedPORefreshTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.expectedPORefreshTLP.Size = new Size(323, 40);
        this.expectedPORefreshTLP.TabIndex = 6;
        // 
        // expectedPORefreshPanel
        // 
        this.expectedPORefreshPanel.Controls.Add(this.buttonRefreshExpectedPOs);
        this.expectedPORefreshPanel.Dock = DockStyle.Fill;
        this.expectedPORefreshPanel.Location = new Point(64, 3);
        this.expectedPORefreshPanel.Name = "expectedPORefreshPanel";
        this.expectedPORefreshPanel.Size = new Size(194, 34);
        this.expectedPORefreshPanel.TabIndex = 0;
        // 
        // buttonRefreshExpectedPOs
        // 
        this.buttonRefreshExpectedPOs.Location = new Point(3, 8);
        this.buttonRefreshExpectedPOs.Name = "buttonRefreshExpectedPOs";
        this.buttonRefreshExpectedPOs.Size = new Size(188, 23);
        this.buttonRefreshExpectedPOs.TabIndex = 0;
        this.buttonRefreshExpectedPOs.Text = "Refresh List";
        this.buttonRefreshExpectedPOs.UseVisualStyleBackColor = true;
        this.buttonRefreshExpectedPOs.Click += this.ButtonRefreshExpectedPOs_Click;
        // 
        // expectedPORefreshImage
        // 
        this.expectedPORefreshImage.Image = (Image) resources.GetObject("expectedPORefreshImage.Image");
        this.expectedPORefreshImage.Location = new Point(264, 3);
        this.expectedPORefreshImage.Name = "expectedPORefreshImage";
        this.expectedPORefreshImage.Size = new Size(56, 34);
        this.expectedPORefreshImage.TabIndex = 2;
        this.expectedPORefreshImage.TabStop = false;
        // 
        // expectedPOHeader
        // 
        this.expectedPOHeader.Dock = DockStyle.Top;
        this.expectedPOHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
        this.expectedPOHeader.Location = new Point(0, 0);
        this.expectedPOHeader.Name = "expectedPOHeader";
        this.expectedPOHeader.Size = new Size(323, 35);
        this.expectedPOHeader.TabIndex = 5;
        this.expectedPOHeader.Text = "Expected Purchase Orders";
        this.expectedPOHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // WhEmpMainMenu
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1356, 653);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.Name = "WhEmpMainMenu";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "Warehouse Employee Main Menu";
        this.WindowState = FormWindowState.Maximized;
        this.topBarPanel.ResumeLayout(false);
        this.bottomBarPanel.ResumeLayout(false);
        this.bottomBarPanel.PerformLayout();
        this.centerTLP.ResumeLayout(false);
        this.unassignedSoPanel.ResumeLayout(false);
        this.unassSOActionTLP.ResumeLayout(false);
        this.unassSOActionPanel.ResumeLayout(false);
        this.unassSORefreshTLP.ResumeLayout(false);
        this.unassSORefreshPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.unassSORefreshImage).EndInit();
        this.processingSOPanel.ResumeLayout(false);
        this.processSOActionTLP.ResumeLayout(false);
        this.processSOActionPanel.ResumeLayout(false);
        this.processSORefreshTLP.ResumeLayout(false);
        this.processSORefreshPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.processSORefreshImage).EndInit();
        this.packagedSOPanel.ResumeLayout(false);
        this.packagedSOActionTLP.ResumeLayout(false);
        this.packagedSOActionPanel.ResumeLayout(false);
        this.packagedSORefreshTLP.ResumeLayout(false);
        this.packagedSORefreshPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.packagedSORefreshImage).EndInit();
        this.expectedPOPanel.ResumeLayout(false);
        this.expectedPOActionTLP.ResumeLayout(false);
        this.expectedPOActionPanel.ResumeLayout(false);
        this.expectedPORefreshTLP.ResumeLayout(false);
        this.expectedPORefreshPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) this.expectedPORefreshImage).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTLP;
    private Panel unassignedSoPanel;
    private Panel processingSOPanel;
    private Panel packagedSOPanel;
    private Panel expectedPOPanel;
    private TableLayoutPanel unassSORefreshTLP;
    private Panel unassSORefreshPanel;
    private Button buttonRefreshUnassignedSOs;
    private Label unassignedSOHeader;
    private ListBox unassignedSOListBox;
    private TableLayoutPanel unassSOActionTLP;
    private Panel unassSOActionPanel;
    private Button buttonAssignToMe;
    private Label userHeaderLabel;
    private Button buttonLogout;
    private ListBox processingSOListBox;
    private TableLayoutPanel processSOActionTLP;
    private Panel processSOActionPanel;
    private Button buttonMarkPackaged;
    private TableLayoutPanel processSORefreshTLP;
    private Panel processSORefreshPanel;
    private Button buttonRefreshProcessingSOs;
    private Label processSOHeader;
    private ListBox packagedSOListBox;
    private TableLayoutPanel packagedSOActionTLP;
    private Panel packagedSOActionPanel;
    private Button buttonMarkShipped;
    private TableLayoutPanel packagedSORefreshTLP;
    private Panel packagedSORefreshPanel;
    private Button buttonRefreshPackagedSOs;
    private Label packagedSOHeader;
    private ListBox expectedPOListBox;
    private TableLayoutPanel expectedPOActionTLP;
    private Panel expectedPOActionPanel;
    private Button buttonMarkReceived;
    private TableLayoutPanel expectedPORefreshTLP;
    private Panel expectedPORefreshPanel;
    private Button buttonRefreshExpectedPOs;
    private Label expectedPOHeader;
    private LinkLabel creditsLink;
    private Label creditsLabel;
    private PictureBox unassSORefreshImage;
    private PictureBox processSORefreshImage;
    private PictureBox packagedSORefreshImage;
    private PictureBox expectedPORefreshImage;
}