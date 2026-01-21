using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace Views
{
    public partial class ProductForm : Form, IProductView
    {
        public event EventHandler AddRequested;
        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;
        public event EventHandler SaveRequested;
        public event EventHandler CancelRequested;
        public event EventHandler SearchChanged;
        public event EventHandler SearchRequested;

        private Guid? _editingId;

        public ProductForm()
        {
            InitializeComponent();

            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Code", HeaderText = "Código" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nombre" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Precio" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Stock", HeaderText = "Stock" });
            dgv.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Active", HeaderText = "Activo" });

            btnAdd.Click += (s, e) => AddRequested?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditRequested?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            btnSave.Click += (s, e) => SaveRequested?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);
            txtSearch.TextChanged += (s, e) => SearchChanged?.Invoke(this, EventArgs.Empty);

            ExitEditMode();
        }

        public void BindProducts(IEnumerable<Product> products)
        {
            dgv.DataSource = null;
            dgv.DataSource = new List<Product>(products);
        }

        public Product ReadEditor()
        {
            return new Product
            {
                id = _editingId ?? Guid.NewGuid(),
                Code = txtCode.Text.Trim(),
                Name = txtName.Text.Trim(),
                Price = decimal.TryParse(txtPrice.Text, out var pr) ? pr : -1,
                Stock = int.TryParse(txtStock.Text, out var st) ? st : -1,
                Active = chkActive.Checked
            };
        }

        public void LoadEditor(Product p)
        {
            _editingId = p?.id;
            txtCode.Text = p?.Code ?? "";
            txtName.Text = p?.Name ?? "";
            txtPrice.Text = p?.Price.ToString() ?? "";
            txtStock.Text = p?.Stock.ToString() ?? "";
            chkActive.Checked = p?.Active ?? true;
        }

        public Guid? SelectedId()
        {
            if (dgv.CurrentRow?.DataBoundItem is Product p) return p.id;
            return null;
        }

        public string SearchText() => txtSearch.Text;

        public void EnterEditMode(bool isNew)
        {
            pnlEditor.Enabled = true;
            dgv.Enabled = false;
            txtCode.Focus();
        }

        public void ExitEditMode()
        {
            pnlEditor.Enabled = false;
            dgv.Enabled = true;
            _editingId = null;
            txtCode.Text = txtName.Text = txtPrice.Text = txtStock.Text = "";
            chkActive.Checked = true;
        }

        public void Info(string msg) => MessageBox.Show(this, msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void Error(string msg) => MessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        Guid IProductView.SelectedId()
        {
            if (dgv.CurrentRow?.DataBoundItem is Product p)
                return p.id;
            return Guid.Empty;
        }

        public string searchText()
        {
            return txtSearch.Text.Trim();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
