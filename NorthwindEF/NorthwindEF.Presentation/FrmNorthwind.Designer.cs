
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
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            this.btnEj1 = new System.Windows.Forms.Button();
            this.btnEj2 = new System.Windows.Forms.Button();
            this.btnEj3 = new System.Windows.Forms.Button();
            this.btnEj4 = new System.Windows.Forms.Button();
            this.btnEj5 = new System.Windows.Forms.Button();
            this.btnEj6 = new System.Windows.Forms.Button();
            this.btnEj7 = new System.Windows.Forms.Button();
            this.btnEj8 = new System.Windows.Forms.Button();
            this.btnEj9 = new System.Windows.Forms.Button();
            this.btnEj10 = new System.Windows.Forms.Button();
            this.btnEj11 = new System.Windows.Forms.Button();
            this.btnEj12 = new System.Windows.Forms.Button();
            this.gbxProductos = new System.Windows.Forms.GroupBox();
            this.rbtnMayusculas = new System.Windows.Forms.RadioButton();
            this.rbtnMinusculas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.gbxProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultados
            // 
            this.dgvResultados.AllowUserToAddRows = false;
            this.dgvResultados.AllowUserToDeleteRows = false;
            this.dgvResultados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultados.Location = new System.Drawing.Point(26, 253);
            this.dgvResultados.Name = "dgvResultados";
            this.dgvResultados.ReadOnly = true;
            this.dgvResultados.RowHeadersWidth = 51;
            this.dgvResultados.RowTemplate.Height = 24;
            this.dgvResultados.Size = new System.Drawing.Size(968, 204);
            this.dgvResultados.TabIndex = 0;
            // 
            // btnEj1
            // 
            this.btnEj1.Location = new System.Drawing.Point(26, 12);
            this.btnEj1.Name = "btnEj1";
            this.btnEj1.Size = new System.Drawing.Size(162, 35);
            this.btnEj1.TabIndex = 1;
            this.btnEj1.Text = "(1)Objeto Customer";
            this.btnEj1.UseVisualStyleBackColor = true;
            this.btnEj1.Click += new System.EventHandler(this.btnEj1_Click);
            // 
            // btnEj2
            // 
            this.btnEj2.Location = new System.Drawing.Point(26, 53);
            this.btnEj2.Name = "btnEj2";
            this.btnEj2.Size = new System.Drawing.Size(162, 47);
            this.btnEj2.TabIndex = 2;
            this.btnEj2.Text = "(2)Productos Sin Stock";
            this.btnEj2.UseVisualStyleBackColor = true;
            this.btnEj2.Click += new System.EventHandler(this.btnEj2_Click);
            // 
            // btnEj3
            // 
            this.btnEj3.Location = new System.Drawing.Point(26, 115);
            this.btnEj3.Name = "btnEj3";
            this.btnEj3.Size = new System.Drawing.Size(162, 45);
            this.btnEj3.TabIndex = 3;
            this.btnEj3.Text = "(3)Productos CON stock y costo > 3";
            this.btnEj3.UseVisualStyleBackColor = true;
            this.btnEj3.Click += new System.EventHandler(this.btnEj3_Click);
            // 
            // btnEj4
            // 
            this.btnEj4.Location = new System.Drawing.Point(26, 179);
            this.btnEj4.Name = "btnEj4";
            this.btnEj4.Size = new System.Drawing.Size(162, 48);
            this.btnEj4.TabIndex = 4;
            this.btnEj4.Text = "(4)Customers Region WA";
            this.btnEj4.UseVisualStyleBackColor = true;
            this.btnEj4.Click += new System.EventHandler(this.btnEj4_Click);
            // 
            // btnEj5
            // 
            this.btnEj5.Location = new System.Drawing.Point(314, 12);
            this.btnEj5.Name = "btnEj5";
            this.btnEj5.Size = new System.Drawing.Size(162, 47);
            this.btnEj5.TabIndex = 5;
            this.btnEj5.Text = "(5)Primer Producto con ID = 789";
            this.btnEj5.UseVisualStyleBackColor = true;
            this.btnEj5.Click += new System.EventHandler(this.btnEj5_Click);
            // 
            // btnEj6
            // 
            this.btnEj6.Location = new System.Drawing.Point(20, 104);
            this.btnEj6.Name = "btnEj6";
            this.btnEj6.Size = new System.Drawing.Size(162, 35);
            this.btnEj6.TabIndex = 6;
            this.btnEj6.Text = "(6)Mostrar Productos";
            this.btnEj6.UseVisualStyleBackColor = true;
            this.btnEj6.Click += new System.EventHandler(this.btnEj6_Click);
            // 
            // btnEj7
            // 
            this.btnEj7.Location = new System.Drawing.Point(613, 12);
            this.btnEj7.Name = "btnEj7";
            this.btnEj7.Size = new System.Drawing.Size(176, 68);
            this.btnEj7.TabIndex = 7;
            this.btnEj7.Text = "(7)Customer Region WA   y fecha orden > 01/01/1997";
            this.btnEj7.UseVisualStyleBackColor = true;
            this.btnEj7.Click += new System.EventHandler(this.btnEj7_Click);
            // 
            // btnEj8
            // 
            this.btnEj8.Location = new System.Drawing.Point(613, 102);
            this.btnEj8.Name = "btnEj8";
            this.btnEj8.Size = new System.Drawing.Size(176, 60);
            this.btnEj8.TabIndex = 8;
            this.btnEj8.Text = "(8)Primeros 3 Customers de Region WA";
            this.btnEj8.UseVisualStyleBackColor = true;
            this.btnEj8.Click += new System.EventHandler(this.btnEj8_Click);
            // 
            // btnEj9
            // 
            this.btnEj9.Location = new System.Drawing.Point(613, 172);
            this.btnEj9.Name = "btnEj9";
            this.btnEj9.Size = new System.Drawing.Size(176, 62);
            this.btnEj9.TabIndex = 9;
            this.btnEj9.Text = "(9) Productos ordenados por Nombre";
            this.btnEj9.UseVisualStyleBackColor = true;
            this.btnEj9.Click += new System.EventHandler(this.btnEj9_Click);
            // 
            // btnEj10
            // 
            this.btnEj10.Location = new System.Drawing.Point(832, 12);
            this.btnEj10.Name = "btnEj10";
            this.btnEj10.Size = new System.Drawing.Size(162, 68);
            this.btnEj10.TabIndex = 10;
            this.btnEj10.Text = "(10)Productos ordenados por Unit in Stok de > a <";
            this.btnEj10.UseVisualStyleBackColor = true;
            this.btnEj10.Click += new System.EventHandler(this.btnEj10_Click);
            // 
            // btnEj11
            // 
            this.btnEj11.Location = new System.Drawing.Point(832, 102);
            this.btnEj11.Name = "btnEj11";
            this.btnEj11.Size = new System.Drawing.Size(162, 58);
            this.btnEj11.TabIndex = 11;
            this.btnEj11.Text = "(11)Categorias asociadas a Productos";
            this.btnEj11.UseVisualStyleBackColor = true;
            this.btnEj11.Click += new System.EventHandler(this.btnEj11_Click);
            // 
            // btnEj12
            // 
            this.btnEj12.Location = new System.Drawing.Point(832, 172);
            this.btnEj12.Name = "btnEj12";
            this.btnEj12.Size = new System.Drawing.Size(162, 55);
            this.btnEj12.TabIndex = 12;
            this.btnEj12.Text = "(12)Primer elemento de la lista Productos";
            this.btnEj12.UseVisualStyleBackColor = true;
            this.btnEj12.Click += new System.EventHandler(this.btnEj12_Click);
            // 
            // gbxProductos
            // 
            this.gbxProductos.Controls.Add(this.rbtnMinusculas);
            this.gbxProductos.Controls.Add(this.rbtnMayusculas);
            this.gbxProductos.Controls.Add(this.btnEj6);
            this.gbxProductos.Location = new System.Drawing.Point(314, 75);
            this.gbxProductos.Name = "gbxProductos";
            this.gbxProductos.Size = new System.Drawing.Size(204, 159);
            this.gbxProductos.TabIndex = 13;
            this.gbxProductos.TabStop = false;
            this.gbxProductos.Text = "Productos";
            // 
            // rbtnMayusculas
            // 
            this.rbtnMayusculas.AutoSize = true;
            this.rbtnMayusculas.Location = new System.Drawing.Point(7, 22);
            this.rbtnMayusculas.Name = "rbtnMayusculas";
            this.rbtnMayusculas.Size = new System.Drawing.Size(103, 21);
            this.rbtnMayusculas.TabIndex = 7;
            this.rbtnMayusculas.TabStop = true;
            this.rbtnMayusculas.Text = "Mayúsculas";
            this.rbtnMayusculas.UseVisualStyleBackColor = true;
            // 
            // rbtnMinusculas
            // 
            this.rbtnMinusculas.AutoSize = true;
            this.rbtnMinusculas.Location = new System.Drawing.Point(7, 64);
            this.rbtnMinusculas.Name = "rbtnMinusculas";
            this.rbtnMinusculas.Size = new System.Drawing.Size(99, 21);
            this.rbtnMinusculas.TabIndex = 8;
            this.rbtnMinusculas.TabStop = true;
            this.rbtnMinusculas.Text = "Minúsculas";
            this.rbtnMinusculas.UseVisualStyleBackColor = true;
            // 
            // FrmNorthwind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 486);
            this.Controls.Add(this.gbxProductos);
            this.Controls.Add(this.btnEj12);
            this.Controls.Add(this.btnEj11);
            this.Controls.Add(this.btnEj10);
            this.Controls.Add(this.btnEj9);
            this.Controls.Add(this.btnEj8);
            this.Controls.Add(this.btnEj7);
            this.Controls.Add(this.btnEj5);
            this.Controls.Add(this.btnEj4);
            this.Controls.Add(this.btnEj3);
            this.Controls.Add(this.btnEj2);
            this.Controls.Add(this.btnEj1);
            this.Controls.Add(this.dgvResultados);
            this.Name = "FrmNorthwind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.FrmNorthwind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.gbxProductos.ResumeLayout(false);
            this.gbxProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultados;
        private System.Windows.Forms.Button btnEj1;
        private System.Windows.Forms.Button btnEj2;
        private System.Windows.Forms.Button btnEj3;
        private System.Windows.Forms.Button btnEj4;
        private System.Windows.Forms.Button btnEj5;
        private System.Windows.Forms.Button btnEj6;
        private System.Windows.Forms.Button btnEj7;
        private System.Windows.Forms.Button btnEj8;
        private System.Windows.Forms.Button btnEj9;
        private System.Windows.Forms.Button btnEj10;
        private System.Windows.Forms.Button btnEj11;
        private System.Windows.Forms.Button btnEj12;
        private System.Windows.Forms.GroupBox gbxProductos;
        private System.Windows.Forms.RadioButton rbtnMinusculas;
        private System.Windows.Forms.RadioButton rbtnMayusculas;
    }
}

