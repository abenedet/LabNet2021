using System;
using System.Windows.Forms;
using TPExceptions.Exceptions;

namespace TPExceptions
{
    public partial class FrmExceptions : Form
    {
        public FrmExceptions()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                ManejoExceptions.Dividir(Convert.ToInt32(tbxDividendo.Text), Convert.ToInt32(tbxDivisor.Text));

            }
            catch (FormatException ex)
            {
                MessageBox.Show(string.Format("{0} Seguro ingresó una letra o no ingresó nada!", ex.Message));
            }
        }

        private void btnDividirPorCero_Click(object sender, EventArgs e)
        {
            try
            {
                ManejoExceptions.Dividir(Convert.ToInt32(tbxNumero.Text), 0);

            }
            catch (FormatException ex)
            {
                MessageBox.Show(string.Format("{0} Seguro ingresó una letra o no ingresó nada!", ex.Message));
            }

        }

        private void btnGenerarExcepcion_Click(object sender, EventArgs e)
        {
            ManejoExceptions.ThrowException();
        }

        private void btnGenerarExcepcionPersonalizada_Click(object sender, EventArgs e)
        {
            try
            {
                ManejoExceptions.ThrowCustomException();
            }
            catch (CustomException ex)
            {
                MessageBox.Show(string.Format("Ha ocurrido la siguiente excepción personalizada: {0}", ex.Message));
            }
        }
    }
}
