
namespace Transporte
{
    partial class FormAgregarTransporte
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTipoTransporte = new System.Windows.Forms.Label();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.cbxTipoTransporte = new System.Windows.Forms.ComboBox();
            this.tbxCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvTransporte = new System.Windows.Forms.DataGridView();
            this.gbxTransporte = new System.Windows.Forms.GroupBox();
            this.NumeroTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoTransporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).BeginInit();
            this.gbxTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTipoTransporte
            // 
            this.lblTipoTransporte.AutoSize = true;
            this.lblTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTransporte.Location = new System.Drawing.Point(6, 55);
            this.lblTipoTransporte.Name = "lblTipoTransporte";
            this.lblTipoTransporte.Size = new System.Drawing.Size(148, 17);
            this.lblTipoTransporte.TabIndex = 3;
            this.lblTipoTransporte.Text = "Tipo de Transporte";
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(6, 109);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(172, 17);
            this.lblCantidadPasajeros.TabIndex = 4;
            this.lblCantidadPasajeros.Text = "Cantidad de Pasajeros";
            // 
            // cbxTipoTransporte
            // 
            this.cbxTipoTransporte.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxTipoTransporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxTipoTransporte.FormattingEnabled = true;
            this.cbxTipoTransporte.Items.AddRange(new object[] {
            "Seleccione..",
            "Taxi",
            "Omnibus"});
            this.cbxTipoTransporte.Location = new System.Drawing.Point(225, 48);
            this.cbxTipoTransporte.Name = "cbxTipoTransporte";
            this.cbxTipoTransporte.Size = new System.Drawing.Size(186, 24);
            this.cbxTipoTransporte.TabIndex = 0;
            // 
            // tbxCantidadPasajeros
            // 
            this.tbxCantidadPasajeros.Location = new System.Drawing.Point(225, 104);
            this.tbxCantidadPasajeros.MaxLength = 3;
            this.tbxCantidadPasajeros.Name = "tbxCantidadPasajeros";
            this.tbxCantidadPasajeros.Size = new System.Drawing.Size(186, 22);
            this.tbxCantidadPasajeros.TabIndex = 1;
            this.tbxCantidadPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCantidadPasajeros_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(458, 160);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 32);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvTransporte
            // 
            this.dgvTransporte.AllowUserToAddRows = false;
            this.dgvTransporte.AllowUserToDeleteRows = false;
            this.dgvTransporte.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroTransporte,
            this.TipoTransporte,
            this.CantidadPasajeros});
            this.dgvTransporte.Location = new System.Drawing.Point(33, 250);
            this.dgvTransporte.MultiSelect = false;
            this.dgvTransporte.Name = "dgvTransporte";
            this.dgvTransporte.ReadOnly = true;
            this.dgvTransporte.RowHeadersVisible = false;
            this.dgvTransporte.RowHeadersWidth = 51;
            this.dgvTransporte.RowTemplate.Height = 24;
            this.dgvTransporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransporte.Size = new System.Drawing.Size(574, 385);
            this.dgvTransporte.TabIndex = 6;
            this.dgvTransporte.TabStop = false;
            // 
            // gbxTransporte
            // 
            this.gbxTransporte.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxTransporte.Controls.Add(this.lblTipoTransporte);
            this.gbxTransporte.Controls.Add(this.btnAgregar);
            this.gbxTransporte.Controls.Add(this.cbxTipoTransporte);
            this.gbxTransporte.Controls.Add(this.lblCantidadPasajeros);
            this.gbxTransporte.Controls.Add(this.tbxCantidadPasajeros);
            this.gbxTransporte.Location = new System.Drawing.Point(33, 12);
            this.gbxTransporte.Name = "gbxTransporte";
            this.gbxTransporte.Size = new System.Drawing.Size(574, 205);
            this.gbxTransporte.TabIndex = 7;
            this.gbxTransporte.TabStop = false;
            // 
            // NumeroTransporte
            // 
            this.NumeroTransporte.DataPropertyName = "NumeroTransporte";
            this.NumeroTransporte.HeaderText = "N°";
            this.NumeroTransporte.MaxInputLength = 3;
            this.NumeroTransporte.MinimumWidth = 6;
            this.NumeroTransporte.Name = "NumeroTransporte";
            this.NumeroTransporte.ReadOnly = true;
            this.NumeroTransporte.Width = 80;
            // 
            // TipoTransporte
            // 
            this.TipoTransporte.DataPropertyName = "TipoTransporte";
            this.TipoTransporte.HeaderText = "Tipo Transporte";
            this.TipoTransporte.MinimumWidth = 6;
            this.TipoTransporte.Name = "TipoTransporte";
            this.TipoTransporte.ReadOnly = true;
            this.TipoTransporte.Width = 200;
            // 
            // CantidadPasajeros
            // 
            this.CantidadPasajeros.DataPropertyName = "CantidadPasajeros";
            this.CantidadPasajeros.HeaderText = "Cantidad Pasajeros";
            this.CantidadPasajeros.MaxInputLength = 3;
            this.CantidadPasajeros.MinimumWidth = 6;
            this.CantidadPasajeros.Name = "CantidadPasajeros";
            this.CantidadPasajeros.ReadOnly = true;
            this.CantidadPasajeros.Width = 180;
            // 
            // FormAgregarTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 650);
            this.Controls.Add(this.gbxTransporte);
            this.Controls.Add(this.dgvTransporte);
            this.Name = "FormAgregarTransporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transporte";
            this.Load += new System.EventHandler(this.FormTransporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransporte)).EndInit();
            this.gbxTransporte.ResumeLayout(false);
            this.gbxTransporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipoTransporte;
        private System.Windows.Forms.Label lblCantidadPasajeros;
        private System.Windows.Forms.ComboBox cbxTipoTransporte;
        private System.Windows.Forms.TextBox tbxCantidadPasajeros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvTransporte;
        private System.Windows.Forms.GroupBox gbxTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTransporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPasajeros;
    }
}

