namespace Views
{
    partial class ProductEditForm
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
            this.labelCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.labelProfitMargin = new System.Windows.Forms.Label();
            this.txtProfitMargin = new System.Windows.Forms.TextBox();
            this.lblPriceCalculated = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCode.Location = new System.Drawing.Point(130, 20);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(51, 16);
            this.labelCode.Text = "Código";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCode.Location = new System.Drawing.Point(30, 40);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(300, 22);
            this.txtCode.TabIndex = 0;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelCost.Location = new System.Drawing.Point(150, 75);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(42, 16);
            this.labelCost.Text = "Costo";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCost.Location = new System.Drawing.Point(30, 95);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(300, 22);
            this.txtCost.TabIndex = 1;
            this.txtCost.TextChanged += new System.EventHandler(this.CalculatePrice);
            // 
            // labelProfitMargin
            // 
            this.labelProfitMargin.AutoSize = true;
            this.labelProfitMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelProfitMargin.Location = new System.Drawing.Point(115, 130);
            this.labelProfitMargin.Name = "labelProfitMargin";
            this.labelProfitMargin.Size = new System.Drawing.Size(130, 16);
            this.labelProfitMargin.Text = "Margen Ganancia %";
            // 
            // txtProfitMargin
            // 
            this.txtProfitMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtProfitMargin.Location = new System.Drawing.Point(30, 150);
            this.txtProfitMargin.Name = "txtProfitMargin";
            this.txtProfitMargin.Size = new System.Drawing.Size(300, 22);
            this.txtProfitMargin.TabIndex = 2;
            this.txtProfitMargin.Text = "30";
            this.txtProfitMargin.TextChanged += new System.EventHandler(this.CalculatePrice);
            // 
            // lblPriceCalculated
            // 
            this.lblPriceCalculated.AutoSize = true;
            this.lblPriceCalculated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPriceCalculated.ForeColor = System.Drawing.Color.Green;
            this.lblPriceCalculated.Location = new System.Drawing.Point(30, 185);
            this.lblPriceCalculated.Name = "lblPriceCalculated";
            this.lblPriceCalculated.Size = new System.Drawing.Size(120, 17);
            this.lblPriceCalculated.Text = "Precio: $0.00";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelName.Location = new System.Drawing.Point(142, 215);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 16);
            this.labelName.Text = "Nombre";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtName.Location = new System.Drawing.Point(30, 235);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 22);
            this.txtName.TabIndex = 3;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelStock.Location = new System.Drawing.Point(150, 270);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(41, 16);
            this.labelStock.Text = "Stock";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtStock.Location = new System.Drawing.Point(30, 290);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(300, 22);
            this.txtStock.TabIndex = 4;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chkActive.Location = new System.Drawing.Point(145, 330);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(63, 20);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "Activo";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(70, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(190, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProductEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 431);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.lblPriceCalculated);
            this.Controls.Add(this.txtProfitMargin);
            this.Controls.Add(this.labelProfitMargin);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.labelCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label labelProfitMargin;
        private System.Windows.Forms.TextBox txtProfitMargin;
        private System.Windows.Forms.Label lblPriceCalculated;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}