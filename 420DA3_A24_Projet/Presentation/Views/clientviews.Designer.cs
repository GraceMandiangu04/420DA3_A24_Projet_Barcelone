using System;
using System.Windows.Forms;
using System.Collections.Generic;
using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.Business.Domain;

namespace _420DA3_A24_Projet.Views {
    public partial class ClientView : Form {
        private readonly ClientService _clientService;

        public ClientView(ClientService clientService) {
            InitializeComponent();
            _clientService = clientService;
            LoadClients();
        }

        private void LoadClients() {
            try {
                List<Client> clients = _clientService.GetAll();
                dgvClients.DataSource = clients;
            } catch (Exception ex) {
                MessageBox.Show("Error loading clients: " + ex.Message);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e) {
            try {
                Client client = new Client {
                    NomCompagnie = txtCompanyName.Text,
                    NomContact = txtContactName.Text,
                    PrenomContact = txtContactFirstName.Text,
                    CourrielContact = txtContactEmail.Text,
                    TelephoneContact = txtContactPhone.Text,
                    EntrepotId = int.Parse(txtWarehouseId.Text)
                };

                _clientService.Create(client);
                MessageBox.Show("Client added successfully!");
                LoadClients();
            } catch (Exception ex) {
                MessageBox.Show("Error adding client: " + ex.Message);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e) {
            if (dgvClients.CurrentRow == null)
                return;

            try {
                Client selectedClient = (Client) dgvClients.CurrentRow.DataBoundItem;
                selectedClient.NomCompagnie = txtCompanyName.Text;
                selectedClient.NomContact = txtContactName.Text;
                selectedClient.PrenomContact = txtContactFirstName.Text;
                selectedClient.CourrielContact = txtContactEmail.Text;
                selectedClient.TelephoneContact = txtContactPhone.Text;
                selectedClient.EntrepotId = int.Parse(txtWarehouseId.Text);

                _clientService.Update(selectedClient);
                MessageBox.Show("Client updated successfully!");
                LoadClients();
            } catch (Exception ex) {
                MessageBox.Show("Error updating client: " + ex.Message);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e) {
            if (dgvClients.CurrentRow == null)
                return;

            try {
                Client selectedClient = (Client) dgvClients.CurrentRow.DataBoundItem;
                _clientService.Delete(selectedClient.Id);
                MessageBox.Show("Client deleted successfully!");
                LoadClients();
            } catch (Exception ex) {
                MessageBox.Show("Error deleting client: " + ex.Message);
            }
        }

        private void dgvClients_SelectionChanged(object sender, EventArgs e) {
            if (dgvClients.CurrentRow == null)
                return;

            Client selectedClient = (Client) dgvClients.CurrentRow.DataBoundItem;
            txtCompanyName.Text = selectedClient.NomCompagnie;
            txtContactName.Text = selectedClient.NomContact;
            txtContactFirstName.Text = selectedClient.PrenomContact;
            txtContactEmail.Text = selectedClient.CourrielContact;
            txtContactPhone.Text = selectedClient.TelephoneContact;
            txtWarehouseId.Text = selectedClient.EntrepotId.ToString();
        }
    }
}
