
namespace Transporte
{
    public abstract class TransportePublico
    {
        public int cantidadPasajeros { get; set; }

        public string tipoTransporte { get; set; }

        public int numeroTransporte { get; set; }

        public TransportePublico(int cantidadPasajeros, string tipoTransporte, int numeroTransporte)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.tipoTransporte = tipoTransporte;
            this.numeroTransporte = numeroTransporte;
        }

        public TransportePublico(int cantidadPasajeros)
        {

        }

        public abstract void Avanzar();
        public abstract void Detenerse();
        public abstract int CantidadPasajeros();
        public abstract string TipoTransporte();
        public abstract int NumeroTransporte();
    }
}
