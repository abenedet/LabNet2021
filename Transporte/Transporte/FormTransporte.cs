using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Transporte
{
    public partial class FormAgregarTransporte : Form
    {
        private List<TransportePublico> transportes = new List<TransportePublico>
        {

        };

        public FormAgregarTransporte()
        {
            InitializeComponent();

        }

        private void tbxCantidadPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)|| (char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
        }

        private void FormTransporte_Load(object sender, EventArgs e)
        {
            cbxTipoTransporte.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var tipoTransporteSeleccionado = cbxTipoTransporte.SelectedItem.ToString();
                var cantidadTotalTransportesPorTipo = CantidadTotalTransportesPorTipo(tipoTransporteSeleccionado);

                if (cantidadTotalTransportesPorTipo < 5)
                {
                    var idxTipoTransporteSeleccionado = cbxTipoTransporte.SelectedIndex;
                    var cantidadPasajeros = Convert.ToInt32(tbxCantidadPasajeros.Text);
                    var numeroTransporte = cantidadTotalTransportesPorTipo + 1;

                    if (idxTipoTransporteSeleccionado == 1)
                    {
                        var taxi = new Taxi(cantidadPasajeros, tipoTransporteSeleccionado, numeroTransporte);
                        transportes.Add(taxi);
                    }
                    else
                    {
                        var omnibus = new Omnibus(cantidadPasajeros, tipoTransporteSeleccionado, numeroTransporte);
                        transportes.Add(omnibus);
                    }

                    dgvTransporte.DataSource = transportes.OrderBy(x=>x.TipoTransporte()).ToList();

                    tbxCantidadPasajeros.Focus();
                    tbxCantidadPasajeros.SelectAll();
                }
                else
                {
                    MessageBox.Show(string.Format("Sólo se permite un máximo de 5 transportes de tipo {0}", tipoTransporteSeleccionado), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private int CantidadTotalTransportesPorTipo(string tipoTransporte) 
        {
            var cantidadTotalTransportesPorTipo = transportes.Where(t => t.TipoTransporte() == tipoTransporte)
                                                        .Select(t => t.TipoTransporte())
                                                        .Count();

            return cantidadTotalTransportesPorTipo;
        }

        private bool ValidarCampos() 
        {
            var campoValido = true;

            if (cbxTipoTransporte.SelectedIndex == 0)
            {
                MessageBox.Show(string.Format("Debe seleccionar un elemento de la lista {0}", lblTipoTransporte.Text), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                campoValido = false;
            }

            if (string.IsNullOrEmpty(tbxCantidadPasajeros.Text))
            {
                MessageBox.Show(string.Format("El campo {0} es obligatorio", lblCantidadPasajeros.Text), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                campoValido = false;
            }           

            return campoValido;
        }
      
    }
}
