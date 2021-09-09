
namespace Transporte
{
    public class Omnibus : TransportePublico
    {
        public Omnibus(int cantidadPasajeros, string tipoTransporte, int numeroTransporte) : base(cantidadPasajeros, tipoTransporte, numeroTransporte)
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
            return this.numeroTransporte;
        }
    }
}
