
namespace NorthwindEF.Presentation
{
    partial class FrmNorthwind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabsGeneral = new System.Windows.Forms.TabControl();
            this.tabTransportes = new System.Windows.Forms.TabPage();
            this.gbxTransporte = new System.Windows.Forms.GroupBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.tbxNombreTransporte = new System.Windows.Forms.TextBox();
            this.lblTelefonoTransporte = new System.Windows.Forms.Label();
            this.lblNombreTransporte = new System.Windows.Forms.Label();
            this.btnCancelarTransporte = new System.Windows.Forms.Button();
            this.btnGuardarTransporte = new System.Windows.Forms.Button();
            this.btnEliminarTransporte = new System.Windows.Forms.Button();
            this.btnModificarTransporte = new System.Windows.Forms.Button();
            this.btnAgregarTransporte = new System.Windows.Forms.Button();
            this.dgvTransportes = new System.Windows.Forms.DataGridView();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.IDTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsGeneral.SuspendLayout();
            this.tabTransportes.SuspendLayout();
            this.gbxTransporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).BeginInit();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsGeneral
            // 
            this.tabsGeneral.Controls.Add(this.tabTransportes);
            this.tabsGeneral.Controls.Add(this.tabProveedores);
            this.tabsGeneral.Location = new System.Drawing.Point(12, 39);
            this.tabsGeneral.Name = "tabsGeneral";
            this.tabsGeneral.SelectedIndex = 0;
            this.tabsGeneral.Size = new System.Drawing.Size(1083, 395);
            this.tabsGeneral.TabIndex = 0;
            // 
            // tabTransportes
            // 
            this.tabTransportes.BackColor = System.Drawing.Color.Azure;
            this.tabTransportes.Controls.Add(this.gbxTransporte);
            this.tabTransportes.Controls.Add(this.btnEliminarTransporte);
            this.tabTransportes.Controls.Add(this.btnModificarTransporte);
            this.tabTransportes.Controls.Add(this.btnAgregarTransporte);
            this.tabTransportes.Controls.Add(this.dgvTransportes);
            this.tabTransportes.Location = new System.Drawing.Point(4, 25);
            this.tabTransportes.Name = "tabTransportes";
            this.tabTransportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransportes.Size = new System.Drawing.Size(1075, 366);
            this.tabTransportes.TabIndex = 1;
            this.tabTransportes.Text = "Transportes";
            // 
            // gbxTransporte
            // 
            this.gbxTransporte.Controls.Add(this.tbxTelefono);
            this.gbxTransporte.Controls.Add(this.tbxNombreTransporte);
            this.gbxTransporte.Controls.Add(this.lblTelefonoTransporte);
            this.gbxTransporte.Controls.Add(this.lblNombreTransporte);
            this.gbxTransporte.Controls.Add(this.btnCancelarTransporte);
            this.gbxTransporte.Controls.Add(this.btnGuardarTransporte);
            this.gbxTransporte.Enabled = false;
            this.gbxTransporte.Location = new System.Drawing.Point(7, 22);
            this.gbxTransporte.Name = "gbxTransporte";
            this.gbxTransporte.Size = new System.Drawing.Size(415, 312);
            this.gbxTransporte.TabIndex = 4;
            this.gbxTransporte.TabStop = false;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(33, 168);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(343, 22);
            this.tbxTelefono.TabIndex = 1;
            // 
            // tbxNombreTransporte
            // 
            this.tbxNombreTransporte.Location = new System.Drawing.Point(33, 76);
            this.tbxNombreTransporte.Name = "tbxNombreTransporte";
            this.tbxNombreTransporte.Size = new System.Drawing.Size(343, 22);
            this.tbxNombreTransporte.TabIndex = 0;
            // 
            // lblTelefonoTransporte
            // 
            this.lblTelefonoTransporte.AutoSize = true;
            this.lblTelefonoTransporte.Location = new System.Drawing.Point(30, 135);
            this.lblTelefonoTransporte.Name = "lblTelefonoTransporte";
            this.lblTelefonoTransporte.Size = new System.Drawing.Size(64, 17);
            this.lblTelefonoTransporte.TabIndex = 5;
            this.lblTelefonoTransporte.Text = "Teléfono";
            // 
            // lblNombreTransporte
            // 
            this.lblNombreTransporte.AutoSize = true;
            this.lblNombreTransporte.Location = new System.Drawing.Point(30, 43);
            this.lblNombreTransporte.Name = "lblNombreTransporte";
            this.lblNombreTransporte.Size = new System.Drawing.Size(132, 17);
            this.lblNombreTransporte.TabIndex = 4;
            this.lblNombreTransporte.Text = "Nombre Transporte";
            // 
            // btnCancelarTransporte
            // 
            this.btnCancelarTransporte.Location = new System.Drawing.Point(209, 252);
            this.btnCancelarTransporte.Name = "btnCancelarTransporte";
            this.btnCancelarTransporte.Size = new System.Drawing.Size(105, 30);
            this.btnCancelarTransporte.TabIndex = 3;
            this.btnCancelarTransporte.Text = "Cancelar";
            this.btnCancelarTransporte.UseVisualStyleBackColor = true;
            this.btnCancelarTransporte.Click += new System.EventHandler(this.btnCancelarTransporte_Click);
            // 
            // btnGuardarTransporte
            // 
            this.btnGuardarTransporte.Location = new System.Drawing.Point(78, 252);
            this.btnGuardarTransporte.Name = "btnGuardarTransporte";
            this.btnGuardarTransporte.Size = new System.Drawing.Size(105, 30);
            this.btnGuardarTransporte.TabIndex = 2;
            this.btnGuardarTransporte.Text = "Guardar";
            this.btnGuardarTransporte.UseVisualStyleBackColor = true;
            this.btnGuardarTransporte.Click += new System.EventHandler(this.btnGuardarTransporte_Click);
            // 
            // btnEliminarTransporte
            // 
            this.btnEliminarTransporte.Location = new System.Drawing.Point(689, 274);
            this.btnEliminarTransporte.Name = "btnEliminarTransporte";
            this.btnEliminarTransporte.Size = new System.Drawing.Size(105, 30);
            this.btnEliminarTransporte.TabIndex = 3;
            this.btnEliminarTransporte.Text = "Eliminar";
            this.btnEliminarTransporte.UseVisualStyleBackColor = true;
            this.btnEliminarTransporte.Click += new System.EventHandler(this.btnEliminarTransporte_Click);
            // 
            // btnModificarTransporte
            // 
            this.btnModificarTransporte.Location = new System.Drawing.Point(569, 274);
            this.btnModificarTransporte.Name = "btnModificarTransporte";
            this.btnModificarTransporte.Size = new System.Drawing.Size(105, 30);
            this.btnModificarTransporte.TabIndex = 2;
            this.btnModificarTransporte.Text = "Modificar";
            this.btnModificarTransporte.UseVisualStyleBackColor = true;
            this.btnModificarTransporte.Click += new System.EventHandler(this.btnModificarTransporte_Click);
            // 
            // btnAgregarTransporte
            // 
            this.btnAgregarTransporte.Location = new System.Drawing.Point(448, 274);
            this.btnAgregarTransporte.Name = "btnAgregarTransporte";
            this.btnAgregarTransporte.Size = new System.Drawing.Size(105, 30);
            this.btnAgregarTransporte.TabIndex = 1;
            this.btnAgregarTransporte.Text = "Agregar";
            this.btnAgregarTransporte.UseVisualStyleBackColor = true;
            this.btnAgregarTransporte.Click += new System.EventHandler(this.btnAgregarTransporte_Click);
            // 
            // dgvTransportes
            // 
            this.dgvTransportes.AllowUserToAddRows = false;
            this.dgvTransportes.AllowUserToDeleteRows = false;
            this.dgvTransportes.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTransportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDTransporte,
            this.CompanyNameTransporte,
            this.PhoneTransporte});
            this.dgvTransportes.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTransportes.Location = new System.Drawing.Point(448, 40);
            this.dgvTransportes.Name = "dgvTransportes";
            this.dgvTransportes.ReadOnly = true;
            this.dgvTransportes.RowHeadersVisible = false;
            this.dgvTransportes.RowHeadersWidth = 51;
            this.dgvTransportes.RowTemplate.Height = 24;
            this.dgvTransportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransportes.Size = new System.Drawing.Size(621, 227);
            this.dgvTransportes.TabIndex = 0;
            // 
            // tabProveedores
            // 
            this.tabProveedores.Controls.Add(this.dgvProveedores);
            this.tabProveedores.Location = new System.Drawing.Point(4, 25);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProveedores.Size = new System.Drawing.Size(1075, 366);
            this.tabProveedores.TabIndex = 2;
            this.tabProveedores.Text = "Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.CompanyNameProveedor,
            this.ContactName,
            this.ContactTitle,
            this.Adress,
            this.City,
            this.Region,
            this.PostalCode,
            this.Country,
            this.PhoneProveedor,
            this.Fax,
            this.HomePage,
            this.Products});
            this.dgvProveedores.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProveedores.Location = new System.Drawing.Point(18, 40);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidth = 51;
            this.dgvProveedores.RowTemplate.Height = 24;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(1029, 291);
            this.dgvProveedores.TabIndex = 1;
            // 
            // IDTransporte
            // 
            this.IDTransporte.DataPropertyName = "ShipperID";
            this.IDTransporte.HeaderText = "Id Transporte";
            this.IDTransporte.MinimumWidth = 6;
            this.IDTransporte.Name = "IDTransporte";
            this.IDTransporte.ReadOnly = true;
            this.IDTransporte.Visible = false;
            this.IDTransporte.Width = 125;
            // 
            // CompanyNameTransporte
            // 
            this.CompanyNameTransporte.DataPropertyName = "CompanyName";
            this.CompanyNameTransporte.HeaderText = "Nombre Transporte";
            this.CompanyNameTransporte.MinimumWidth = 6;
            this.CompanyNameTransporte.Name = "CompanyNameTransporte";
            this.CompanyNameTransporte.ReadOnly = true;
            this.CompanyNameTransporte.Width = 300;
            // 
            // PhoneTransporte
            // 
            this.PhoneTransporte.DataPropertyName = "Phone";
            this.PhoneTransporte.HeaderText = "Teléfono";
            this.PhoneTransporte.MinimumWidth = 6;
            this.PhoneTransporte.Name = "PhoneTransporte";
            this.PhoneTransporte.ReadOnly = true;
            this.PhoneTransporte.Width = 125;
            // 
            // SupplierID
            // 
            this.SupplierID.DataPropertyName = "SupplierID";
            this.SupplierID.HeaderText = "Id Proveedor";
            this.SupplierID.MinimumWidth = 6;
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            this.SupplierID.Visible = false;
            this.SupplierID.Width = 125;
            // 
            // CompanyNameProveedor
            // 
            this.CompanyNameProveedor.DataPropertyName = "CompanyName";
            this.CompanyNameProveedor.HeaderText = "Nombre Compañía";
            this.CompanyNameProveedor.MinimumWidth = 6;
            this.CompanyNameProveedor.Name = "CompanyNameProveedor";
            this.CompanyNameProveedor.ReadOnly = true;
            this.CompanyNameProveedor.Width = 125;
            // 
            // ContactName
            // 
            this.ContactName.DataPropertyName = "ContactName";
            this.ContactName.HeaderText = "Nombre Contacto";
            this.ContactName.MinimumWidth = 6;
            this.ContactName.Name = "ContactName";
            this.ContactName.ReadOnly = true;
            this.ContactName.Width = 125;
            // 
            // ContactTitle
            // 
            this.ContactTitle.DataPropertyName = "ContactTitle";
            this.ContactTitle.HeaderText = "Título Contacto";
            this.ContactTitle.MinimumWidth = 6;
            this.ContactTitle.Name = "ContactTitle";
            this.ContactTitle.ReadOnly = true;
            this.ContactTitle.Width = 125;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Address";
            this.Adress.HeaderText = "Dirección";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Ciudad";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // Region
            // 
            this.Region.DataPropertyName = "Region";
            this.Region.HeaderText = "Región";
            this.Region.MinimumWidth = 6;
            this.Region.Name = "Region";
            this.Region.ReadOnly = true;
            this.Region.Width = 125;
            // 
            // PostalCode
            // 
            this.PostalCode.DataPropertyName = "PostalCode";
            this.PostalCode.HeaderText = "Código Postal";
            this.PostalCode.MinimumWidth = 6;
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.ReadOnly = true;
            this.PostalCode.Width = 125;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.HeaderText = "País";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 125;
            // 
            // PhoneProveedor
            // 
            this.PhoneProveedor.DataPropertyName = "Phone";
            this.PhoneProveedor.HeaderText = "Teléfono";
            this.PhoneProveedor.MinimumWidth = 6;
            this.PhoneProveedor.Name = "PhoneProveedor";
            this.PhoneProveedor.ReadOnly = true;
            this.PhoneProveedor.Width = 125;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.MinimumWidth = 6;
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            this.Fax.Width = 125;
            // 
            // HomePage
            // 
            this.HomePage.DataPropertyName = "HomePage";
            this.HomePage.HeaderText = "Home Page";
            this.HomePage.MinimumWidth = 6;
            this.HomePage.Name = "HomePage";
            this.HomePage.ReadOnly = true;
            this.HomePage.Width = 125;
            // 
            // Products
            // 
            this.Products.DataPropertyName = "Products";
            this.Products.HeaderText = "Products";
            this.Products.MinimumWidth = 6;
            this.Products.Name = "Products";
            this.Products.ReadOnly = true;
            this.Products.Visible = false;
            this.Products.Width = 125;
            // 
            // FrmNorthwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 486);
            this.Controls.Add(this.tabsGeneral);
            this.Name = "FrmNorthwind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.FrmNorthwind_Load);
            this.tabsGeneral.ResumeLayout(false);
            this.tabTransportes.ResumeLayout(false);
            this.gbxTransporte.ResumeLayout(false);
            this.gbxTransporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportes)).EndInit();
            this.tabProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsGeneral;
        private System.Windows.Forms.TabPage tabTransportes;
        private System.Windows.Forms.DataGridView dgvTransportes;
        private System.Windows.Forms.GroupBox gbxTransporte;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.TextBox tbxNombreTransporte;
        private System.Windows.Forms.Label lblTelefonoTransporte;
        private System.Windows.Forms.Label lblNombreTransporte;
        private System.Windows.Forms.Button btnCancelarTransporte;
        private System.Windows.Forms.Button btnGuardarTransporte;
        private System.Windows.Forms.Button btnEliminarTransporte;
        private System.Windows.Forms.Button btnModificarTransporte;
        private System.Windows.Forms.Button btnAgregarTransporte;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Region;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
    }
}

