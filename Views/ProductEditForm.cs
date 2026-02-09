using System;
using System.Windows.Forms;
using Model;

namespace Views
{
    public partial class ProductEditForm : Form
    {
        public Product Product { get; private set; }
        public bool Saved { get; private set; }

        public ProductEditForm(Product product, bool isNew)
        {
            InitializeComponent();

            Product = product;
            this.Text = isNew ? "Nuevo Producto" : "Editar Producto";

            // Cargar datos
            LoadProduct();

            // Enfocar primer campo
            txtCode.Focus();

            // Manejar Escape
            this.KeyPreview = true;
            this.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    e.Handled = true;
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            };
        }

        private void LoadProduct()
        {
            txtCode.Text = Product.Code ?? "";
            txtCost.Text = Product.Cost.ToString();
            txtProfitMargin.Text = Product.ProfitMargin.ToString();
            txtName.Text = Product.Name ?? "";
            txtStock.Text = Product.Stock.ToString();
            chkActive.Checked = Product.Active;

            CalculatePrice(null, null);
        }

        private void CalculatePrice(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCost.Text, out var cost) &&
                decimal.TryParse(txtProfitMargin.Text, out var margin))
            {
                decimal price = cost * (1 + margin / 100);
                lblPriceCalculated.Text = $"Precio: ${price:F2}";
            }
            else
            {
                lblPriceCalculated.Text = "Precio: $0.00";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Actualizar el producto con los datos del formulario
            Product.Code = txtCode.Text.Trim();
            Product.Name = txtName.Text.Trim();
            Product.Cost = decimal.TryParse(txtCost.Text, out var cost) ? cost : 0;
            Product.ProfitMargin = decimal.TryParse(txtProfitMargin.Text, out var margin) ? margin : 0;
            Product.Stock = int.TryParse(txtStock.Text, out var stock) ? stock : 0;
            Product.Active = chkActive.Checked;

            Saved = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Saved = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
