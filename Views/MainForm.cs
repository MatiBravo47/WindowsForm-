using System;
using System.Windows.Forms;
using Model;
using Controllers;

namespace Views
{
    /// <summary>
    /// Formulario principal con menú de navegación
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly IProductRepository _productRepo;
        private readonly IClientRepository _clientRepo;
        private ClientController _clientController;

        public MainForm(IProductRepository productRepo, IClientRepository clientRepo)
        {
            InitializeComponent();
            _productRepo = productRepo;
            _clientRepo = clientRepo;

            // Centrar el formulario
            this.StartPosition = FormStartPosition.CenterScreen;

            // Conectar eventos de los botones
            btnProducts.Click += BtnProducts_Click;
            btnClients.Click += BtnClients_Click;
            btnExit.Click += (s, e) => this.Close();
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            // Crear y mostrar formulario de productos
            ProductForm productForm = new ProductForm();
            IProductView productView = productForm;

            var productController = new ProductController(_productRepo, productView);
            productController.Init();

            productForm.ShowDialog();
        }

        private void BtnClients_Click(object sender, EventArgs e)
        {
            // Crear y mostrar formulario de clientes
            ClientForm clientForm = new ClientForm();
            IClientView clientView = clientForm;

            _clientController = new ClientController(_clientRepo, clientView);
            _clientController.Init();

            clientForm.ShowDialog(this);
        }
    }
}
