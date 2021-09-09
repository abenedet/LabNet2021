
namespace Transporte
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantidadPasajeros, string tipoTransporte, int numeroTransporte) : base (cantidadPasajeros, tipoTransporte, numeroTransporte)
        {

        }
        
        public override void Avanzar()
        {

        }

        public override void Detenerse()
        {

        }

        public override int CantidadPasajeros()
        {
            return cantidadPasajeros;
        }        

        public override string TipoTransporte()
        {
            return tipoTransporte;
        }

        public override int NumeroTransporte()
        {
            return numeroTransporte;
        }
    }
}
