using System;
using System.Windows.Forms;

namespace TPExceptions.Exceptions
{
    public class ManejoExceptions
    {
        public static void Dividir(decimal dividendo, decimal divisor) 
        {
            try
            {
                decimal resultado = dividendo / divisor;
                MessageBox.Show(string.Format("El resultado de dividir {0} por {1} es: {2}", dividendo, divisor, resultado));

            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(string.Format("No se puede dividir por cero: {0} Solo Chuck Norris lo hace!", ex.Message));
            }
            catch (Exception ex) 
            {
                MessageBox.Show(string.Format("Se ha producido la siguiente excepcion: {0}.", ex.Message));
            }
            finally
            {
                MessageBox.Show("La operación ha finalizado");
            }        
        
        }

        public static void ThrowCustomException() 
        {
            throw new CustomException();
        }

        public static void ThrowException() 
        {
            try
            {
                DateTime? fechaNull = null;
                string fecha = fechaNull.Value.ToString("dd/MM/yyyy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Se ha producido la siguiente excepción: {0} {1} Tipo de Excepción: {2}", ex.Message, Environment.NewLine, ex.GetType()));
            }       
        
        }

    }
}
