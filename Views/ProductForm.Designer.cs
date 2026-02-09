
namespace Views
{
    partial class ProductForm
    {

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtProfitMargin = new System.Windows.Forms.TextBox();
            this.LabelProfitMargin = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(46, 76);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(669, 440);
            this.dgv.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(169, 44);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(68, 391);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(750, 166);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(750, 120);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 31);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(750, 76);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 31);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(168, 391);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlEditor
            // 
            this.pnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditor.Controls.Add(this.txtSize);
            this.pnlEditor.Controls.Add(this.lblText);
            this.pnlEditor.Controls.Add(this.txtColor);
            this.pnlEditor.Controls.Add(this.lblColor);
            this.pnlEditor.Controls.Add(this.txtCategory);
            this.pnlEditor.Controls.Add(this.lblCategory);
            this.pnlEditor.Controls.Add(this.txtProfitMargin);
            this.pnlEditor.Controls.Add(this.LabelProfitMargin);
            this.pnlEditor.Controls.Add(this.txtCost);
            this.pnlEditor.Controls.Add(this.label1);
            this.pnlEditor.Controls.Add(this.labelPrice);
            this.pnlEditor.Controls.Add(this.btnCancel);
            this.pnlEditor.Controls.Add(this.labelName);
            this.pnlEditor.Controls.Add(this.labelCodigo);
            this.pnlEditor.Controls.Add(this.labelStock);
            this.pnlEditor.Controls.Add(this.chkActive);
            this.pnlEditor.Controls.Add(this.btnSave);
            this.pnlEditor.Controls.Add(this.txtStock);
            this.pnlEditor.Controls.Add(this.txtPrice);
            this.pnlEditor.Controls.Add(this.txtName);
            this.pnlEditor.Controls.Add(this.txtCode);
            this.pnlEditor.Location = new System.Drawing.Point(847, 76);
            this.pnlEditor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(301, 440);
            this.pnlEditor.TabIndex = 7;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(126, 116);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(39, 20);
            this.txtSize.TabIndex = 18;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(123, 96);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(36, 17);
            this.lblText.TabIndex = 17;
            this.lblText.Text = "Talle";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(177, 116);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(95, 20);
            this.txtColor.TabIndex = 16;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(174, 96);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(44, 17);
            this.lblColor.TabIndex = 15;
            this.lblColor.Text = "Color";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(29, 116);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(91, 20);
            this.txtCategory.TabIndex = 14;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(26, 96);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(75, 17);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Categoria";
            // 
            // txtProfitMargin
            // 
            this.txtProfitMargin.Location = new System.Drawing.Point(29, 214);
            this.txtProfitMargin.Name = "txtProfitMargin";
            this.txtProfitMargin.Size = new System.Drawing.Size(242, 20);
            this.txtProfitMargin.TabIndex = 3;
            // 
            // LabelProfitMargin
            // 
            this.LabelProfitMargin.AutoSize = true;
            this.LabelProfitMargin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProfitMargin.Location = new System.Drawing.Point(27, 194);
            this.LabelProfitMargin.Name = "LabelProfitMargin";
            this.LabelProfitMargin.Size = new System.Drawing.Size(78, 17);
            this.LabelProfitMargin.TabIndex = 12;
            this.LabelProfitMargin.Text = "Porcentaje";
            this.LabelProfitMargin.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(30, 160);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(242, 20);
            this.txtCost.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Costo";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(27, 247);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 17);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Precio";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(27, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 17);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Nombre";
            this.labelName.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(26, 6);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(58, 17);
            this.labelCodigo.TabIndex = 7;
            this.labelCodigo.Text = "Codigo";
            this.labelCodigo.Click += new System.EventHandler(this.labelCodigo_Click);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStock.Location = new System.Drawing.Point(27, 298);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(43, 17);
            this.labelStock.TabIndex = 6;
            this.labelStock.Text = "Stock";
            this.labelStock.Click += new System.EventHandler(this.label1_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActive.Location = new System.Drawing.Point(115, 367);
            this.chkActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(69, 21);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Activo";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(29, 325);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(242, 22);
            this.txtStock.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(29, 265);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(242, 22);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(30, 68);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(242, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(30, 24);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(242, 22);
            this.txtCode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(46, 45);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(118, 17);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Buscar producto:";
            this.labelSearch.Click += new System.EventHandler(this.labelSearch_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(52, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(112, 25);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Productos";
            this.labelTitle.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 626);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgv);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductForm";
            this.Text = "CRUD PRODUCTOS";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtSearch;
        
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.CheckBox chkActive;
        
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label LabelProfitMargin;
        private System.Windows.Forms.TextBox txtProfitMargin;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblColor;
    }
}

