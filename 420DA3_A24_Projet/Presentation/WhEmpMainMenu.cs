using _420DA3_A24_Projet.Business;
using _420DA3_A24_Projet.Business.Domain;
using Project_Utilities.Exceptions;

namespace _420DA3_A24_Projet.Presentation;

/// <summary>
/// Main menu window for users with the warehouse employee <see cref="Role"/>.
/// </summary>
internal partial class WhEmpMainMenu : Form {

    private WsysApplication parentApp;
    private bool doAutoRefreshLists = false;
    private Task? timer;

    /// <summary>
    /// WhEmpMainMenu constructor.
    /// </summary>
    /// <param name="application"></param>
    public WhEmpMainMenu(WsysApplication application) {
        this.parentApp = application;
        this.InitializeComponent();
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <returns></returns>
    public DialogResult ShowWhEmpMainMenu() {
        // synchronously load the different lists in the window
        // each list loading operation is asynchronous
        Task.WaitAll(
            this.RefreshUnassignedSOListAsync(),
            this.RefreshProcessingSOListAsync(),
            this.RefreshPackagedSOListAsync(),
            this.RefreshExpectedPOListAsync()
        );

        // Start the timer infinite looping task that reloads the lists every minute
        this.timer = this.StartRefreshAllListsTimer();
        DialogResult result = this.ShowDialog();

        // stop the timer task when the window is closed.
        this.timer.Dispose();
        return result;
    }



    #region Thread-safe UI methods

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void ShowUnassignedSOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.ShowUnassignedSOListLoader);
            return;
        }
        this.unassSORefreshImage.Visible = true;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void HideUnassignedSOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.HideUnassignedSOListLoader);
            return;
        }
        this.unassSORefreshImage.Visible = false;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <param name="orders"></param>
    private void LoadUnassignedSOList(List<ShippingOrder> orders) {
        if (this.InvokeRequired) {
            _ = this.Invoke(this.LoadUnassignedSOList, orders);
            return;
        }
        ShippingOrder? selectedOrder = this.unassignedSOListBox.SelectedItem as ShippingOrder;
        this.unassignedSOListBox.SelectedItem = null;
        this.unassignedSOListBox.SelectedIndex = -1;
        this.unassignedSOListBox.Items.Clear();
        this.unassignedSOListBox.Items.AddRange(orders.ToArray());
        if (selectedOrder is not null && this.unassignedSOListBox.Items.Contains(selectedOrder)) {
            this.unassignedSOListBox.SelectedItem = selectedOrder;
        }

        this.HideUnassignedSOListLoader();
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void ShowProcessingSOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.ShowProcessingSOListLoader);
            return;
        }
        this.processSORefreshImage.Visible = true;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void HideProcessingSOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.HideProcessingSOListLoader);
            return;
        }
        this.processSORefreshImage.Visible = false;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <param name="orders"></param>
    private void LoadProcessingSOList(List<ShippingOrder> orders) {
        if (this.InvokeRequired) {
            _ = this.Invoke(this.LoadProcessingSOList, orders);
            return;
        }
        ShippingOrder? selectedOrder = this.processingSOListBox.SelectedItem as ShippingOrder;
        this.processingSOListBox.SelectedItem = null;
        this.processingSOListBox.SelectedIndex = -1;
        this.processingSOListBox.Items.Clear();
        this.processingSOListBox.Items.AddRange(orders.ToArray());
        if (selectedOrder is not null && this.processingSOListBox.Items.Contains(selectedOrder)) {
            this.processingSOListBox.SelectedItem = selectedOrder;
        }

        this.HideProcessingSOListLoader();
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void ShowPackagedSOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.ShowPackagedSOListLoader);
            return;
        }
        this.packagedSORefreshImage.Visible = true;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void HidePackagedSOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.HidePackagedSOListLoader);
            return;
        }
        this.packagedSORefreshImage.Visible = false;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <param name="orders"></param>
    private void LoadPackagedSOList(List<ShippingOrder> orders) {
        if (this.InvokeRequired) {
            _ = this.Invoke(this.LoadPackagedSOList, orders);
            return;
        }
        ShippingOrder? selectedOrder = this.packagedSOListBox.SelectedItem as ShippingOrder;
        this.packagedSOListBox.SelectedItem = null;
        this.packagedSOListBox.SelectedIndex = -1;
        this.packagedSOListBox.Items.Clear();
        this.packagedSOListBox.Items.AddRange(orders.ToArray());
        if (selectedOrder is not null && this.packagedSOListBox.Items.Contains(selectedOrder)) {
            this.packagedSOListBox.SelectedItem = selectedOrder;
        }

        this.HidePackagedSOListLoader();
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void ShowExpectedPOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.ShowExpectedPOListLoader);
            return;
        }
        this.expectedPORefreshImage.Visible = true;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void HideExpectedPOListLoader() {
        if (this.InvokeRequired) {
            this.Invoke(this.HideExpectedPOListLoader);
            return;
        }
        this.expectedPORefreshImage.Visible = false;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <param name="orders"></param>
    private void LoadExpectedPOList(List<PurchaseOrder> orders) {
        if (this.InvokeRequired) {
            _ = this.Invoke(this.LoadExpectedPOList, orders);
            return;
        }
        PurchaseOrder? selectedOrder = this.expectedPOListBox.SelectedItem as PurchaseOrder;
        this.expectedPOListBox.SelectedItem = null;
        this.expectedPOListBox.SelectedIndex = -1;
        this.expectedPOListBox.Items.Clear();
        this.expectedPOListBox.Items.AddRange(orders.ToArray());
        if (selectedOrder is not null && this.expectedPOListBox.Items.Contains(selectedOrder)) {
            this.expectedPOListBox.SelectedItem = selectedOrder;
        }

        this.HideExpectedPOListLoader();
    }


    #endregion



    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ValidationException"></exception>
    private async Task RefreshUnassignedSOListAsync() {
        Task task = Task.Run(() => {
            this.ShowUnassignedSOListLoader();

            User connectedUser = this.parentApp.LoginService.LoggedInUser
                ?? throw new ValidationException($"A user must be logged in to refresh the unassigned shipping order list.");
            if (!connectedUser.IsWarehouseEmployee()) {
                throw new ValidationException($"The logged in user must be a warehouse employee to refresh the unassigned shipping order list.");
            }
            Entrepot entrepotEmploye = connectedUser.EmployeeWarehouse
                ?? throw new ValidationException($"The logged in warehouse employee must have an assigned working warehouse to refresh the unassigned shipping order list.");

            List<ShippingOrder> unassignedOrders = this.parentApp.ShippingOrderService.GetUnassignedOrdersByWarehouse(entrepotEmploye);
            this.LoadUnassignedSOList(unassignedOrders);

        });
        await task;
        return;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ValidationException"></exception>
    private async Task RefreshProcessingSOListAsync() {
        Task task = Task.Run(() => {
            this.ShowProcessingSOListLoader();

            User connectedUser = this.parentApp.LoginService.LoggedInUser
                ?? throw new ValidationException($"A user must be logged in to refresh the processing shipping order list.");
            if (!connectedUser.IsWarehouseEmployee()) {
                throw new ValidationException($"The logged in user must be a warehouse employee to refresh the processing shipping order list.");
            }

            List<ShippingOrder> processingOrders = this.parentApp.ShippingOrderService.GetProcessingOrdersByEmployee(connectedUser);
            this.LoadProcessingSOList(processingOrders);

        });
        await task;
        return;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ValidationException"></exception>
    private async Task RefreshPackagedSOListAsync() {
        Task task = Task.Run(() => {
            this.ShowPackagedSOListLoader();

            User connectedUser = this.parentApp.LoginService.LoggedInUser
                ?? throw new ValidationException($"A user must be logged in to refresh the packaged shipping order list.");
            if (!connectedUser.IsWarehouseEmployee()) {
                throw new ValidationException($"The logged in user must be a warehouse employee to refresh the packaged shipping order list.");
            }
            Entrepot entrepotEmploye = connectedUser.EmployeeWarehouse
                ?? throw new ValidationException($"The logged in warehouse employee must have an assigned working warehouse to refresh the packaged shipping order list.");

            List<ShippingOrder> packagedOrders = this.parentApp.ShippingOrderService.GetPackagedOrdersByWarehouse(entrepotEmploye);
            this.LoadPackagedSOList(packagedOrders);

        });
        await task;
        return;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <returns></returns>
    /// <exception cref="ValidationException"></exception>
    private async Task RefreshExpectedPOListAsync() {
        Task task = Task.Run(() => {
            this.ShowExpectedPOListLoader();

            User connectedUser = this.parentApp.LoginService.LoggedInUser
                ?? throw new ValidationException($"A user must be logged in to refresh the packaged shipping order list.");
            if (!connectedUser.IsWarehouseEmployee()) {
                throw new ValidationException($"The logged in user must be a warehouse employee to refresh the packaged shipping order list.");
            }
            Entrepot entrepotEmploye = connectedUser.EmployeeWarehouse
                ?? throw new ValidationException($"The logged in warehouse employee must have an assigned working warehouse to refresh the packaged shipping order list.");

            List<PurchaseOrder> expectedPOs = this.parentApp.PurchaseOrderService.GetIncompletePOsForWarehouse(entrepotEmploye);
            this.LoadExpectedPOList(expectedPOs);

        });
        await task;
        return;
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    /// <returns></returns>
    private async Task StartRefreshAllListsTimer() {
        PeriodicTimer minuteTimer = new PeriodicTimer(new TimeSpan(0, 1, 0));
        while (await minuteTimer.WaitForNextTickAsync()) {
            Task.WhenAll(
                this.RefreshUnassignedSOListAsync(),
                this.RefreshProcessingSOListAsync(),
                this.RefreshPackagedSOListAsync(),
                this.RefreshExpectedPOListAsync()
            )
            .Wait();
        }
    }

    /// <summary>
    /// TODO @PROF: documenter.
    /// </summary>
    private void CloseAbnormally() {
        this.DialogResult = DialogResult.OK;
    }

    private async void ButtonRefreshUnassignedSOs_Click(object sender, EventArgs e) {
        try {
            await this.RefreshUnassignedSOListAsync();

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void UnassignedSOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedOrder = this.unassignedSOListBox.SelectedItem as ShippingOrder;
        this.buttonAssignToMe.Enabled = selectedOrder != null;
    }

    private async void ButtonRefreshProcessingSOs_Click(object sender, EventArgs e) {
        try {
            await this.RefreshProcessingSOListAsync();

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ProcessingSOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedOrder = this.processingSOListBox.SelectedItem as ShippingOrder;
        this.buttonMarkPackaged.Enabled = selectedOrder != null;
    }

    private async void ButtonRefreshPackagedSOs_Click(object sender, EventArgs e) {
        try {
            await this.RefreshPackagedSOListAsync();

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void PackagedSOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        ShippingOrder? selectedOrder = this.packagedSOListBox.SelectedItem as ShippingOrder;
        this.buttonMarkShipped.Enabled = selectedOrder != null;
    }

    private async void ButtonRefreshExpectedPOs_Click(object sender, EventArgs e) {
        try {
            await this.RefreshExpectedPOListAsync();

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ExpectedPOListBox_SelectedIndexChanged(object sender, EventArgs e) {
        PurchaseOrder? selectedOrder = this.expectedPOListBox.SelectedItem as PurchaseOrder;
        this.buttonMarkReceived.Enabled = selectedOrder != null;
    }

    private void ButtonAssignToMe_Click(object sender, EventArgs e) {
        try {
            ShippingOrder? selectedOrder = this.unassignedSOListBox.SelectedItem as ShippingOrder 
                ?? throw new Exception("Please select an unassigned shipping order first.");
            User connectedUser = this.parentApp.LoginService.LoggedInUser
                ?? throw new ValidationException($"A user must be logged in to assign the order to himself.");
            if (!connectedUser.IsWarehouseEmployee()) {
                throw new ValidationException($"The logged in user must be a warehouse employee to refresh the packaged shipping order list.");
            }

            _ = this.parentApp.ShippingOrderService.AssignOrderTo(selectedOrder, connectedUser);
            this.unassignedSOListBox.Items.Remove(selectedOrder);
            Task task = this.RefreshProcessingSOListAsync();

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonMarkPackaged_Click(object sender, EventArgs e) {
        try {
            ShippingOrder? selectedOrder = this.processingSOListBox.SelectedItem as ShippingOrder
                ?? throw new Exception("Please select an processing shipping order first.");

            _ = this.parentApp.ShippingOrderService.MarkOrderAsPackaged(selectedOrder);
            this.processingSOListBox.Items.Remove(selectedOrder);
            Task task = this.RefreshPackagedSOListAsync();

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    private void ButtonMarkShipped_Click(object sender, EventArgs e) {
        try {
            ShippingOrder? selectedOrder = this.packagedSOListBox.SelectedItem as ShippingOrder
                ?? throw new Exception("Please select an packaged shipping order first.");

            _ = this.parentApp.ShippingOrderService.MarkOrderAsShipped(selectedOrder);
            this.packagedSOListBox.Items.Remove(selectedOrder);

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonMarkReceived_Click(object sender, EventArgs e) {
        try {
            PurchaseOrder? selectedOrder = this.expectedPOListBox.SelectedItem as PurchaseOrder
                ?? throw new Exception("Please select an expected purchase order first.");

            _ = this.parentApp.PurchaseOrderService.CompletePurchaseOrder(selectedOrder);
            this.expectedPOListBox.Items.Remove(selectedOrder);

        } catch (ValidationException ex) {
            this.parentApp.HandleException(ex);
            this.CloseAbnormally();

        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }
    }

    private void ButtonLogout_Click(object sender, EventArgs e) {
        this.DialogResult = DialogResult.None;
    }
}
