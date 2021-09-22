using NorthwindEF.Entities;
using NorthwindEF.Logic;
using System;
using System.Windows.Forms;

namespace NorthwindEF.Presentation
{
    public partial class FrmNorthwind : Form
    {
        private ShippersLogic shippersLogic = new ShippersLogic();
        private SuppliersLogic suppliersLogic = new SuppliersLogic();
        private enum TipoOperacion { Alta, Modificacion};

        private TipoOperacion tipoOperacionSeleccionada; 

        public FrmNorthwind()
        {
            InitializeComponent();
        }

        private void FrmNorthwind_Load(object sender, EventArgs e)
        {
            dgvTransportes.DataSource = shippersLogic.GetShipperList();
            dgvProveedores.DataSource = suppliersLogic.GetSuppliersList();
        }

        private void btnGuardarTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                var newShipper = new Shippers();
                newShipper.CompanyName = tbxNombreTransporte.Text;
                newShipper.Phone = tbxTelefono.Text;
                
                if (tipoOperacionSeleccionada == TipoOperacion.Alta)
                {                  
                    shippersLogic.Add(newShipper);
                }
                else 
                {
                    var filaSeleccionada = (dgvTransportes.SelectedRows[0]);
                    var idShipper = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                    newShipper.ShipperID = idShipper;
                    shippersLogic.Update(newShipper);

                    HabilitarDeshabilitarGbxTransporte(false);
                    HabilitarDeshabilitarBotonesTransporte(true);
                }

                dgvTransportes.DataSource = shippersLogic.GetShipperList();
                LimpiarControlesTransporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("No se han podido guardar los datos del transporte, ha ocurrido el siguiente error: {0}", ex.Message));
            }
        }

        private void LimpiarControlesTransporte() 
        {
            tbxNombreTransporte.Clear();
            tbxTelefono.Clear();
            tbxNombreTransporte.Focus();
        }

        private void HabilitarDeshabilitarBotonesTransporte(bool enabled) 
        {
            btnAgregarTransporte.Enabled = enabled;
            btnModificarTransporte.Enabled = enabled;
            btnEliminarTransporte.Enabled = enabled;
        }

        private void HabilitarDeshabilitarGbxTransporte(bool enabled) 
        {
            gbxTransporte.Enabled = enabled;        
        }

        private void btnAgregarTransporte_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitarGbxTransporte(true);
            HabilitarDeshabilitarBotonesTransporte(false);
            tipoOperacionSeleccionada = TipoOperacion.Alta;
        }

        private void btnCancelarTransporte_Click(object sender, EventArgs e)
        {
            LimpiarControlesTransporte();
            HabilitarDeshabilitarGbxTransporte(false);
            HabilitarDeshabilitarBotonesTransporte(true);
        }

        private void btnModificarTransporte_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitarGbxTransporte(true);
            HabilitarDeshabilitarBotonesTransporte(false);
            tipoOperacionSeleccionada = TipoOperacion.Modificacion;
            MostrarDatosTransporte();
        }

        private void btnEliminarTransporte_Click(object sender, EventArgs e)
        {
            try
            {
                var filaSeleccionada = (dgvTransportes.SelectedRows[0]);
                var idShipper = Convert.ToInt32(filaSeleccionada.Cells["IDTransporte"].Value);
                shippersLogic.Delete(idShipper);

                dgvTransportes.DataSource = shippersLogic.GetShipperList();
                MessageBox.Show(string.Format("Transporte eliminado con éxito!"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("No se ha podido eliminar el transporte, ha ocurrido el siguiente error: {0}", ex.Message));
            }
        }

        private void MostrarDatosTransporte() 
        {
            try
            {
                var filaSeleccionada = (dgvTransportes.SelectedRows[0]);
                tbxNombreTransporte.Text = filaSeleccionada.Cells["CompanyNameTransporte"].Value.ToString();
                tbxTelefono.Text = filaSeleccionada.Cells["PhoneTransporte"].Value.ToString();
                tbxNombreTransporte.SelectAll();
                tbxNombreTransporte.Focus();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(string.Format("No se han podido mostrar los datos del transporte seleccionado, ha ocurrido el siguiente error: {0}", ex.Message));
            }
        }
    }
}
