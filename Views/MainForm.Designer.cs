namespace Views
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(64, 24);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(258, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Sistema de Ventas";
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.LightBlue;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProducts.Location = new System.Drawing.Point(90, 98);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(195, 49);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Productos";
            this.btnProducts.UseVisualStyleBackColor = false;
            // 
            // btnClients
            // 
            this.btnClients.BackColor = System.Drawing.Color.LightGreen;
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClients.Location = new System.Drawing.Point(90, 162);
            this.btnClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(195, 49);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Clientes";
            this.btnClients.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(128, 252);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // labelSubtitle
            // 
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSubtitle.Location = new System.Drawing.Point(98, 61);
            this.labelSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Size = new System.Drawing.Size(213, 17);
            this.labelSubtitle.TabIndex = 4;
            this.labelSubtitle.Text = "Selecciona una opción del menú";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 325);
            this.Controls.Add(this.labelSubtitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sistema de Ventas - Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelSubtitle;
    }
}