using System;
using System.Windows.Forms;
using System.Collections.Generic;
using _420DA3_A24_Projet.Business.Services;
using _420DA3_A24_Projet.Business.Domain;
using System.Xml.Linq;

namespace _420DA3_A24_Projet.Views {
    public partial class SupplierView : Form {
        private readonly FournisseurService _supplierService;

        public SupplierView(FournisseurService supplierService) {
            InitializeComponent();
            _supplierService = supplierService;
            LoadSuppliers();
        }

        private void LoadSuppliers() {
            try {
                List<Fournisseur> suppliers = _supplierService.GetAll();
                dgvSuppliers.DataSource = suppliers;
            } catch (Exception ex) {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e) {
            try {
                Fournisseur supplier = new Fournisseur {
                    Nom = txtName.Text,
                    NomContact = txtContactName.Text,
                    PrenomContact = txtContactFirstName.Text,
                    CourrielContact = txtContactEmail.Text,
                    TelephoneContact = txtContactPhone.Text
                };

                _supplierService.Create(supplier);
                MessageBox.Show("Supplier added successfully!");
                LoadSuppliers();
            } catch (Exception ex) {
                MessageBox.Show("Error adding supplier: " + ex.Message);
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e) {
            if (dgvSuppliers.CurrentRow == null)
                return;

            try {
                Fournisseur selectedSupplier = (Fournisseur) dgvSuppliers.CurrentRow.DataBoundItem;
                selectedSupplier.Nom = txtName.Text;
                selectedSupplier.NomContact = txtContactName.Text;
                selectedSupplier.PrenomContact = txtContactFirstName.Text;
                selectedSupplier.CourrielContact = txtContactEmail.Text;
                selectedSupplier.TelephoneContact = txtContactPhone.Text;

                _supplierService.Update(selectedSupplier);
                MessageBox.Show("Supplier updated successfully!");
                LoadSuppliers();
            } catch (Exception ex) {
                MessageBox.Show("Error updating supplier: " + ex.Message);
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e) {
            if (dgvSuppliers.CurrentRow == null)
                return;

            try {
                Fournisseur selectedSupplier = (Fournisseur) dgvSuppliers.CurrentRow.DataBoundItem;
                _supplierService.Delete(selectedSupplier.Id);
                MessageBox.Show("Supplier deleted successfully!");
                LoadSuppliers();
            } catch (Exception ex) {
                MessageBox.Show("Error deleting supplier: " + ex.Message);
            }
        }

        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e) {
            if (dgvSuppliers.CurrentRow == null)
                return;

            Fournisseur selectedSupplier = (Fournisseur) dgvSuppliers.CurrentRow.DataBoundItem;
            txtName.Text = selectedSupplier.Nom;
            txtContactName.Text = selectedSupplier.NomContact;
            txtContactFirstName.Text = selectedSupplier.PrenomContact;
            txtContactEmail.Text = selectedSupplier.CourrielContact;
            txtContactPhone.Text = selectedSupplier.TelephoneContact;
        }
    }
}
