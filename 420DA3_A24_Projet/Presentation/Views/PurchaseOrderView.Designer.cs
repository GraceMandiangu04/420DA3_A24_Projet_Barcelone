namespace _420DA3_A24_Projet.Presentation.Views;

partial class PurchaseOrderView {
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
        this.centerTLP = new TableLayoutPanel();
        this.centerPanel = new Panel();
        this.idLabel = new Label();
        this.idValue = new NumericUpDown();
        this.statusLabel = new Label();
        this.statusValue = new ComboBox();
        this.destWarehouseLabel = new Label();
        this.productLabel = new Label();
        this.quantityLabel = new Label();
        this.completionDateLabel = new Label();
        this.dateCreatedLabel = new Label();
        this.dateModifiedLabel = new Label();
        this.dateDeletedLabel = new Label();
        this.warehouseValue = new ComboBox();
        this.productSearch = new TextBox();
        this.productSearchResults = new ListBox();
        this.quantityValue = new NumericUpDown();
        this.completionDateValue = new DateTimePicker();
        this.dateCreatedValue = new DateTimePicker();
        this.dateModifiedValue = new DateTimePicker();
        this.dateDeletedValue = new DateTimePicker();
        this.centerTLP.SuspendLayout();
        this.centerPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).BeginInit();
        ((System.ComponentModel.ISupportInitialize) this.quantityValue).BeginInit();
        this.SuspendLayout();
        // 
        // topBarPanel
        // 
        this.topBarPanel.Dock = DockStyle.Top;
        this.topBarPanel.Location = new Point(0, 0);
        this.topBarPanel.Name = "topBarPanel";
        this.topBarPanel.Size = new Size(604, 50);
        this.topBarPanel.TabIndex = 0;
        // 
        // bottomBarPanel
        // 
        this.bottomBarPanel.Dock = DockStyle.Bottom;
        this.bottomBarPanel.Location = new Point(0, 461);
        this.bottomBarPanel.Name = "bottomBarPanel";
        this.bottomBarPanel.Size = new Size(604, 50);
        this.bottomBarPanel.TabIndex = 1;
        // 
        // centerTLP
        // 
        this.centerTLP.ColumnCount = 3;
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 550F));
        this.centerTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        this.centerTLP.Controls.Add(this.centerPanel, 1, 0);
        this.centerTLP.Dock = DockStyle.Fill;
        this.centerTLP.Location = new Point(0, 50);
        this.centerTLP.Name = "centerTLP";
        this.centerTLP.RowCount = 1;
        this.centerTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        this.centerTLP.Size = new Size(604, 411);
        this.centerTLP.TabIndex = 2;
        // 
        // centerPanel
        // 
        this.centerPanel.Controls.Add(this.dateDeletedValue);
        this.centerPanel.Controls.Add(this.dateModifiedValue);
        this.centerPanel.Controls.Add(this.dateCreatedValue);
        this.centerPanel.Controls.Add(this.completionDateValue);
        this.centerPanel.Controls.Add(this.quantityValue);
        this.centerPanel.Controls.Add(this.productSearchResults);
        this.centerPanel.Controls.Add(this.productSearch);
        this.centerPanel.Controls.Add(this.warehouseValue);
        this.centerPanel.Controls.Add(this.dateDeletedLabel);
        this.centerPanel.Controls.Add(this.dateModifiedLabel);
        this.centerPanel.Controls.Add(this.dateCreatedLabel);
        this.centerPanel.Controls.Add(this.completionDateLabel);
        this.centerPanel.Controls.Add(this.quantityLabel);
        this.centerPanel.Controls.Add(this.productLabel);
        this.centerPanel.Controls.Add(this.destWarehouseLabel);
        this.centerPanel.Controls.Add(this.statusValue);
        this.centerPanel.Controls.Add(this.statusLabel);
        this.centerPanel.Controls.Add(this.idValue);
        this.centerPanel.Controls.Add(this.idLabel);
        this.centerPanel.Dock = DockStyle.Fill;
        this.centerPanel.Location = new Point(30, 3);
        this.centerPanel.Name = "centerPanel";
        this.centerPanel.Size = new Size(544, 405);
        this.centerPanel.TabIndex = 0;
        // 
        // idLabel
        // 
        this.idLabel.Location = new Point(3, 21);
        this.idLabel.Margin = new Padding(3);
        this.idLabel.Name = "idLabel";
        this.idLabel.Size = new Size(252, 23);
        this.idLabel.TabIndex = 0;
        this.idLabel.Text = "Id :";
        this.idLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // idValue
        // 
        this.idValue.Enabled = false;
        this.idValue.Location = new Point(261, 23);
        this.idValue.Maximum = new decimal(new int[] { -1294967296, 0, 0, 0 });
        this.idValue.Name = "idValue";
        this.idValue.Size = new Size(280, 23);
        this.idValue.TabIndex = 1;
        // 
        // statusLabel
        // 
        this.statusLabel.Location = new Point(3, 50);
        this.statusLabel.Margin = new Padding(3);
        this.statusLabel.Name = "statusLabel";
        this.statusLabel.Size = new Size(252, 23);
        this.statusLabel.TabIndex = 2;
        this.statusLabel.Text = "Status :";
        this.statusLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // statusValue
        // 
        this.statusValue.Enabled = false;
        this.statusValue.FormattingEnabled = true;
        this.statusValue.Location = new Point(261, 51);
        this.statusValue.Name = "statusValue";
        this.statusValue.Size = new Size(280, 23);
        this.statusValue.TabIndex = 3;
        // 
        // destWarehouseLabel
        // 
        this.destWarehouseLabel.Location = new Point(3, 79);
        this.destWarehouseLabel.Margin = new Padding(3);
        this.destWarehouseLabel.Name = "destWarehouseLabel";
        this.destWarehouseLabel.Size = new Size(252, 23);
        this.destWarehouseLabel.TabIndex = 4;
        this.destWarehouseLabel.Text = "Destination warehouse :";
        this.destWarehouseLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // productLabel
        // 
        this.productLabel.Location = new Point(3, 107);
        this.productLabel.Margin = new Padding(3);
        this.productLabel.Name = "productLabel";
        this.productLabel.Size = new Size(252, 23);
        this.productLabel.TabIndex = 5;
        this.productLabel.Text = "Product :";
        this.productLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // quantityLabel
        // 
        this.quantityLabel.Location = new Point(3, 235);
        this.quantityLabel.Margin = new Padding(3);
        this.quantityLabel.Name = "quantityLabel";
        this.quantityLabel.Size = new Size(252, 23);
        this.quantityLabel.TabIndex = 6;
        this.quantityLabel.Text = "Quantity ordered :";
        this.quantityLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // completionDateLabel
        // 
        this.completionDateLabel.Location = new Point(3, 271);
        this.completionDateLabel.Margin = new Padding(3, 10, 3, 10);
        this.completionDateLabel.Name = "completionDateLabel";
        this.completionDateLabel.Size = new Size(252, 23);
        this.completionDateLabel.TabIndex = 7;
        this.completionDateLabel.Text = "Completion date :";
        this.completionDateLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateCreatedLabel
        // 
        this.dateCreatedLabel.Location = new Point(3, 307);
        this.dateCreatedLabel.Margin = new Padding(3);
        this.dateCreatedLabel.Name = "dateCreatedLabel";
        this.dateCreatedLabel.Size = new Size(252, 23);
        this.dateCreatedLabel.TabIndex = 8;
        this.dateCreatedLabel.Text = "Date created :";
        this.dateCreatedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateModifiedLabel
        // 
        this.dateModifiedLabel.Location = new Point(3, 336);
        this.dateModifiedLabel.Margin = new Padding(3);
        this.dateModifiedLabel.Name = "dateModifiedLabel";
        this.dateModifiedLabel.Size = new Size(252, 23);
        this.dateModifiedLabel.TabIndex = 9;
        this.dateModifiedLabel.Text = "Date last modified :";
        this.dateModifiedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // dateDeletedLabel
        // 
        this.dateDeletedLabel.Location = new Point(3, 365);
        this.dateDeletedLabel.Margin = new Padding(3);
        this.dateDeletedLabel.Name = "dateDeletedLabel";
        this.dateDeletedLabel.Size = new Size(252, 23);
        this.dateDeletedLabel.TabIndex = 10;
        this.dateDeletedLabel.Text = "Date deleted :";
        this.dateDeletedLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // warehouseValue
        // 
        this.warehouseValue.FormattingEnabled = true;
        this.warehouseValue.Location = new Point(261, 79);
        this.warehouseValue.Name = "warehouseValue";
        this.warehouseValue.Size = new Size(280, 23);
        this.warehouseValue.TabIndex = 11;
        // 
        // productSearch
        // 
        this.productSearch.Location = new Point(261, 108);
        this.productSearch.Name = "productSearch";
        this.productSearch.PlaceholderText = "Search products";
        this.productSearch.Size = new Size(280, 23);
        this.productSearch.TabIndex = 12;
        // 
        // productSearchResults
        // 
        this.productSearchResults.FormattingEnabled = true;
        this.productSearchResults.ItemHeight = 15;
        this.productSearchResults.Location = new Point(261, 137);
        this.productSearchResults.Name = "productSearchResults";
        this.productSearchResults.Size = new Size(280, 94);
        this.productSearchResults.TabIndex = 13;
        // 
        // quantityValue
        // 
        this.quantityValue.Location = new Point(261, 237);
        this.quantityValue.Name = "quantityValue";
        this.quantityValue.Size = new Size(280, 23);
        this.quantityValue.TabIndex = 14;
        // 
        // completionDateValue
        // 
        this.completionDateValue.Location = new Point(261, 271);
        this.completionDateValue.Name = "completionDateValue";
        this.completionDateValue.Size = new Size(280, 23);
        this.completionDateValue.TabIndex = 15;
        // 
        // dateCreatedValue
        // 
        this.dateCreatedValue.Location = new Point(261, 307);
        this.dateCreatedValue.Name = "dateCreatedValue";
        this.dateCreatedValue.Size = new Size(280, 23);
        this.dateCreatedValue.TabIndex = 16;
        // 
        // dateModifiedValue
        // 
        this.dateModifiedValue.Location = new Point(261, 336);
        this.dateModifiedValue.Name = "dateModifiedValue";
        this.dateModifiedValue.Size = new Size(280, 23);
        this.dateModifiedValue.TabIndex = 17;
        // 
        // dateDeletedValue
        // 
        this.dateDeletedValue.Location = new Point(261, 365);
        this.dateDeletedValue.Name = "dateDeletedValue";
        this.dateDeletedValue.Size = new Size(280, 23);
        this.dateDeletedValue.TabIndex = 18;
        // 
        // PurchaseOrderView
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(604, 511);
        this.Controls.Add(this.centerTLP);
        this.Controls.Add(this.bottomBarPanel);
        this.Controls.Add(this.topBarPanel);
        this.MinimumSize = new Size(600, 550);
        this.Name = "PurchaseOrderView";
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Text = "PO Management Window";
        this.centerTLP.ResumeLayout(false);
        this.centerPanel.ResumeLayout(false);
        this.centerPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize) this.idValue).EndInit();
        ((System.ComponentModel.ISupportInitialize) this.quantityValue).EndInit();
        this.ResumeLayout(false);
    }

    #endregion

    private Panel topBarPanel;
    private Panel bottomBarPanel;
    private TableLayoutPanel centerTLP;
    private Panel centerPanel;
    private NumericUpDown idValue;
    private Label idLabel;
    private Label destWarehouseLabel;
    private ComboBox statusValue;
    private Label statusLabel;
    private Label quantityLabel;
    private Label productLabel;
    private Label dateDeletedLabel;
    private Label dateModifiedLabel;
    private Label dateCreatedLabel;
    private Label completionDateLabel;
    private NumericUpDown quantityValue;
    private ListBox productSearchResults;
    private TextBox productSearch;
    private ComboBox warehouseValue;
    private DateTimePicker completionDateValue;
    private DateTimePicker dateDeletedValue;
    private DateTimePicker dateModifiedValue;
    private DateTimePicker dateCreatedValue;
}