using System; //cosas básicas (EventHandler, Guid, etc.)
using System.Collections.Generic; //listas (List<T>, IEnumerable<T>)
using System.Windows.Forms; //WinForms(Form, DataGridView, botones)
using Model;

namespace Views
{
    public partial class ProductForm : Form, IProductView
    {
        //avisos al controller:
        public event EventHandler AddRequested;
        public event EventHandler EditRequested;
        public event EventHandler DeleteRequested;
        public event EventHandler SaveRequested;
        public event EventHandler CancelRequested;
        public event EventHandler SearchChanged;
        public event EventHandler SearchRequested;

        /*
        Guarda el ID del producto que se está editando
        Es nullable(Guid?) porque:
            null → creando nuevo producto
            tiene valor → editando uno existente
        */
        private Guid? _editingId;

        public ProductForm()
        {
            InitializeComponent();

            // Centrar el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //Configuracion tabla de productos
            dgv.AutoGenerateColumns = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;

            // DataPropertyName Debe coincidir con el nombre de la propiedad del Product, Así se vincula la grilla con el modelo.
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Code", HeaderText = "Código" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nombre" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Precio" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Stock", HeaderText = "Stock" });
            dgv.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Active", HeaderText = "Activo" });

            //Cuando el usuario hace click se ejecuta el evento correspondiente.
            btnAdd.Click += (s, e) => AddRequested?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditRequested?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteRequested?.Invoke(this, EventArgs.Empty);
            btnSave.Click += (s, e) => SaveRequested?.Invoke(this, EventArgs.Empty);
            btnCancel.Click += (s, e) => CancelRequested?.Invoke(this, EventArgs.Empty);

            //Cada vez que el usuario escribe → se notifica al controller.
            txtSearch.TextChanged += (s, e) => SearchRequested?.Invoke(this, EventArgs.Empty);

            ExitEditMode();
        }

        //Recibe productos del controller
        //Los muestra en el DataGridView
        public void BindProducts(IEnumerable<Product> products)
        {
            dgv.DataSource = null;
            dgv.DataSource = new List<Product>(products);
        }

        //Crea un Product usando los datos ingresados en la UI:
        public Product ReadEditor()
        {
            return new Product
            {
                id = _editingId ?? Guid.NewGuid(),

                //Trim() Quita espacios al inicio y al final.
                Code = txtCode.Text.Trim(),
                Name = txtName.Text.Trim(),

                //texto a decimal /int, si falla pone -1
                Price = decimal.TryParse(txtPrice.Text, out var priceValue) ? priceValue : -1,
                Stock = int.TryParse(txtStock.Text, out var stockValue) ? stockValue : -1,
                
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
