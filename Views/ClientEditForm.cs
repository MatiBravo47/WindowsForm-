using System;
using Model;
using System.Windows.Forms;

namespace Views
{
    public partial class ClientEditForm : Form
    {
        private System.Guid? _editingId;

        public Client ResultClient { get; private set; }

        //Nuevo cliente
        public ClientEditForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo cliente";
        }

        //Editar cliente
        public ClientEditForm(Client client) : this()
        {
            _editingId = client?.id;
            txtName.Text = client.Name;
            txtSurname.Text = client.Surname;
            txtEmail.Text = client.Email;
            txtPhone.Text = client.Phone;
            txtAddress.Text = client.Address;
            Text = "Editar cliente";
        }

        private void btnSave_Click(object sender, EventArgs e) 
        {
            ResultClient = new Client
            {
                id = _editingId ?? Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                Surname = txtSurname.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = txtAddress.Text.Trim()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
