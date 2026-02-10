using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsForm.Views;

namespace Views
{
    /// <summary>
    /// Formulario para gestión de clientes
    /// </summary>
    public partial class ClientForm : Form, IClientView
    {
        // Eventos
        public event EventHandler AddRequested;
        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;
        public event EventHandler SearchRequested;

        public ClientForm()
        {
            InitializeComponent();

            // Centrar el formulario
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configuración de la grilla
            dgvClients.AutoGenerateColumns = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.MultiSelect = false;
            dgvClients.ReadOnly = true;

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nombre" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Surname", HeaderText = "Apellido" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Correo Electrónico" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "N° Teléfono" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Address", HeaderText = "Direccion" });

            // Conectar eventos
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click; 
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            txtSearch.TextChanged += (s, e) => SearchRequested?.Invoke(this, EventArgs.Empty);
        }

        public void BindClients(IEnumerable<Client> clients)
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = new List<Client>(clients);
        }

        public Guid SelectedId()
        {
            if (dgvClients.CurrentRow?.DataBoundItem is Client c)
                return c.id;

            return Guid.Empty;
        }


        public string searchText() => txtSearch.Text.Trim();

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using var form = new ClientEditForm();

            if (form.ShowDialog(this) == DialogResult.OK)
                AddRequested?.Invoke(this, form.ResultClient);
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow?.DataBoundItem is not Client client)
                return;

            using var form = new ClientEditForm(client);

            if (form.ShowDialog(this) == DialogResult.OK)
                EditRequested?.Invoke(this, form.ResultClient);
        }
        public void Info(string msg) => MessageBox.Show(this, msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void Error(string msg) => MessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        public bool Confirm(string msg)
        {
            var result = MessageBox.Show(
                this,
                msg,
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            return result == DialogResult.Yes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
