
namespace TPExceptions
{
    partial class FrmExceptions
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
            this.gbxDividirPorCero = new System.Windows.Forms.GroupBox();
            this.btnDividirPorCero = new System.Windows.Forms.Button();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gbxDividirDosNumeros = new System.Windows.Forms.GroupBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.tbxDivisor = new System.Windows.Forms.TextBox();
            this.tbxDividendo = new System.Windows.Forms.TextBox();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.gbxExcepciones = new System.Windows.Forms.GroupBox();
            this.btnGenerarExcepcionPersonalizada = new System.Windows.Forms.Button();
            this.btnGenerarExcepcion = new System.Windows.Forms.Button();
            this.gbxDividirPorCero.SuspendLayout();
            this.gbxDividirDosNumeros.SuspendLayout();
            this.gbxExcepciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDividirPorCero
            // 
            this.gbxDividirPorCero.Controls.Add(this.btnDividirPorCero);
            this.gbxDividirPorCero.Controls.Add(this.tbxNumero);
            this.gbxDividirPorCero.Controls.Add(this.lblNumero);
            this.gbxDividirPorCero.Location = new System.Drawing.Point(79, 31);
            this.gbxDividirPorCero.Name = "gbxDividirPorCero";
            this.gbxDividirPorCero.Size = new System.Drawing.Size(270, 169);
            this.gbxDividirPorCero.TabIndex = 0;
            this.gbxDividirPorCero.TabStop = false;
            this.gbxDividirPorCero.Text = "Dividir por Cero";
            // 
            // btnDividirPorCero
            // 
            this.btnDividirPorCero.Location = new System.Drawing.Point(78, 119);
            this.btnDividirPorCero.Name = "btnDividirPorCero";
            this.btnDividirPorCero.Size = new System.Drawing.Size(137, 30);
            this.btnDividirPorCero.TabIndex = 2;
            this.btnDividirPorCero.Text = "Dividir por Cero (0)";
            this.btnDividirPorCero.UseVisualStyleBackColor = true;
            this.btnDividirPorCero.Click += new System.EventHandler(this.btnDividirPorCero_Click);
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(100, 50);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(100, 22);
            this.tbxNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(22, 53);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(58, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // gbxDividirDosNumeros
            // 
            this.gbxDividirDosNumeros.Controls.Add(this.btnDividir);
            this.gbxDividirDosNumeros.Controls.Add(this.tbxDivisor);
            this.gbxDividirDosNumeros.Controls.Add(this.tbxDividendo);
            this.gbxDividirDosNumeros.Controls.Add(this.lblDivisor);
            this.gbxDividirDosNumeros.Controls.Add(this.lblDividendo);
            this.gbxDividirDosNumeros.Location = new System.Drawing.Point(417, 31);
            this.gbxDividirDosNumeros.Name = "gbxDividirDosNumeros";
            this.gbxDividirDosNumeros.Size = new System.Drawing.Size(270, 169);
            this.gbxDividirDosNumeros.TabIndex = 1;
            this.gbxDividirDosNumeros.TabStop = false;
            this.gbxDividirDosNumeros.Text = "Dividir dos Numeros";
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(77, 119);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(90, 30);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "Dividir";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // tbxDivisor
            // 
            this.tbxDivisor.Location = new System.Drawing.Point(98, 66);
            this.tbxDivisor.Name = "tbxDivisor";
            this.tbxDivisor.Size = new System.Drawing.Size(100, 22);
            this.tbxDivisor.TabIndex = 3;
            // 
            // tbxDividendo
            // 
            this.tbxDividendo.Location = new System.Drawing.Point(98, 32);
            this.tbxDividendo.Name = "tbxDividendo";
            this.tbxDividendo.Size = new System.Drawing.Size(100, 22);
            this.tbxDividendo.TabIndex = 2;
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(7, 69);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(51, 17);
            this.lblDivisor.TabIndex = 1;
            this.lblDivisor.Text = "Divisor";
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(7, 35);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(71, 17);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo";
            // 
            // gbxExcepciones
            // 
            this.gbxExcepciones.Controls.Add(this.btnGenerarExcepcionPersonalizada);
            this.gbxExcepciones.Controls.Add(this.btnGenerarExcepcion);
            this.gbxExcepciones.Location = new System.Drawing.Point(79, 246);
            this.gbxExcepciones.Name = "gbxExcepciones";
            this.gbxExcepciones.Size = new System.Drawing.Size(270, 179);
            this.gbxExcepciones.TabIndex = 2;
            this.gbxExcepciones.TabStop = false;
            this.gbxExcepciones.Text = "Excepciones";
            // 
            // btnGenerarExcepcionPersonalizada
            // 
            this.btnGenerarExcepcionPersonalizada.Location = new System.Drawing.Point(78, 97);
            this.btnGenerarExcepcionPersonalizada.Name = "btnGenerarExcepcionPersonalizada";
            this.btnGenerarExcepcionPersonalizada.Size = new System.Drawing.Size(122, 59);
            this.btnGenerarExcepcionPersonalizada.TabIndex = 1;
            this.btnGenerarExcepcionPersonalizada.Text = "Generar Excepción Personalizada";
            this.btnGenerarExcepcionPersonalizada.UseVisualStyleBackColor = true;
            this.btnGenerarExcepcionPersonalizada.Click += new System.EventHandler(this.btnGenerarExcepcionPersonalizada_Click);
            // 
            // btnGenerarExcepcion
            // 
            this.btnGenerarExcepcion.Location = new System.Drawing.Point(78, 31);
            this.btnGenerarExcepcion.Name = "btnGenerarExcepcion";
            this.btnGenerarExcepcion.Size = new System.Drawing.Size(122, 47);
            this.btnGenerarExcepcion.TabIndex = 0;
            this.btnGenerarExcepcion.Text = "Generar Excepción";
            this.btnGenerarExcepcion.UseVisualStyleBackColor = true;
            this.btnGenerarExcepcion.Click += new System.EventHandler(this.btnGenerarExcepcion_Click);
            // 
            // FrmExceptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 445);
            this.Controls.Add(this.gbxExcepciones);
            this.Controls.Add(this.gbxDividirDosNumeros);
            this.Controls.Add(this.gbxDividirPorCero);
            this.Name = "FrmExceptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exceptions";
            this.gbxDividirPorCero.ResumeLayout(false);
            this.gbxDividirPorCero.PerformLayout();
            this.gbxDividirDosNumeros.ResumeLayout(false);
            this.gbxDividirDosNumeros.PerformLayout();
            this.gbxExcepciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDividirPorCero;
        private System.Windows.Forms.GroupBox gbxDividirDosNumeros;
        private System.Windows.Forms.Button btnDividirPorCero;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox tbxDivisor;
        private System.Windows.Forms.TextBox tbxDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.GroupBox gbxExcepciones;
        private System.Windows.Forms.Button btnGenerarExcepcionPersonalizada;
        private System.Windows.Forms.Button btnGenerarExcepcion;
    }
}

