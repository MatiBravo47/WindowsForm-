using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

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
        public event EventHandler SaveRequested;
        public event EventHandler CancelRequested;
        public event EventHandler SearchRequested;

        private Guid? _editingId;

        public ClientForm()
        {
            InitializeComponent();

            // Centrar el formulario
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configuración de la grilla
            dgvClients.AutoGenerateColumns = false;
            dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClients.MultiSelect = false;

            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nombre" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Email", HeaderText = "Email" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Phone", HeaderText = "Celular" });
            dgvClients.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Address", HeaderText = "Direccion" });

            // Conectar eventos
            btnAdd.Click += (s, e) => AddRequested?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditRequested?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            btnSave.Click += (s, e) => SaveRequested?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            txtSearch.TextChanged += (s, e) => SearchRequested?.Invoke(this, EventArgs.Empty);

            ExitEditMode();
        }

        public void BindClients(IEnumerable<Client> clients)
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = new List<Client>(clients);
        }

        //Lee los datos del formulario
        public Client ReadEditor()
        {
            return new Client
            {
                id = _editingId ?? Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()

            };
        }

        // Carga datos en el formulario
        public void LoadEditor(Client c)
        {
            _editingId = c?.id;
            txtName.Text = c?.Name ?? "";
            txtEmail.Text = c?.Email ?? "";
            txtPhone.Text = c?.Phone ?? "";
            txtAddress.Text = c?.Address ?? "";
        }

        public Guid SelectedId()
        {
            if (dgvClients.CurrentRow?.DataBoundItem is Client c)
                return c.id;
            return Guid.Empty;
        }

        public string searchText() => txtSearch.Text.Trim();

        public void EnterEditMode(bool isNew)
        {
            pnlEditor.Enabled = true;
            dgvClients.Enabled = false;
            txtName.Focus();
        }

        public void ExitEditMode()
        {
            pnlEditor.Enabled = false;
            dgvClients.Enabled = true;
            _editingId = null;
            txtName.Text = "";
        }

        public void Info(string msg) => MessageBox.Show(this, msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void Error(string msg) => MessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
