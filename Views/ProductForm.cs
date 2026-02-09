using Controllers;
using Model;
using System; //cosas básicas (EventHandler, Guid, etc.)
using System.Collections.Generic; //listas (List<T>, IEnumerable<T>)
using System.Windows.Forms; //WinForms(Form, DataGridView, botones)

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
            dgv.ReadOnly = true;

            this.AcceptButton = btnSave;




            // DataPropertyName Debe coincidir con el nombre de la propiedad del Product, Así se vincula la grilla con el modelo.
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Code", HeaderText = "Código", Width = 50 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", HeaderText = "Nombre" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Category", HeaderText = "Categoria", Width = 70 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cost", HeaderText = "Costo", Width = 70 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProfitMargin", HeaderText = "%", Width = 40 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Price", HeaderText = "Precio" , Width = 70 });
            dgv.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Stock", HeaderText = "Stock", Width = 40 });            
            dgv.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Active", HeaderText = "Activo" ,Width = 70 });

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
                Category = txtCategory.Text.Trim(),
                Name = txtName.Text.Trim(),

                //texto a decimal /int, si falla pone -1
                Cost = decimal.TryParse(txtCost.Text, out var priceCost) ? priceCost : -1,
                ProfitMargin = decimal.TryParse(txtProfitMargin.Text, out var marginValue) ? marginValue : 0,
                Stock = int.TryParse(txtStock.Text, out var stockValue) ? stockValue : -1,
                
                Active = chkActive.Checked
            };
        }

        public void LoadEditor(Product p)
        {
            _editingId = p?.id;
            txtCode.Text = p?.Code ?? "";
            txtName.Text = p?.Name ?? "";
            txtCategory.Text = p?.Category ?? "";
            txtPrice.Text = p?.Price.ToString() ?? "";
            txtProfitMargin.Text = p?.ProfitMargin.ToString() ?? "30";
            txtCost.Text = p?.Cost.ToString() ?? "";
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
            txtCode.Text = txtName.Text = txtCost.Text = txtProfitMargin.Text = txtPrice.Text = txtStock.Text = "";
            chkActive.Checked = true;
        }

        public void Info(string msg) => MessageBox.Show(this, msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void Error(string msg) => MessageBox.Show(this, msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public bool Confirm(string msg) 
        {
            var result = MessageBox.Show(
                this, // Ventana padre
                msg, // "¿Estás seguro de eliminar...?"
                "Confirmar", // Título de la ventana
                MessageBoxButtons.YesNo, // Botones: Sí y No
                MessageBoxIcon.Question  // Ícono de pregunta
                );
            return result == DialogResult.Yes; 
        }

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
