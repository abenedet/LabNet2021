
namespace Transporte
{
    public abstract class TransportePublico
    {
        public int CantidadPasajeros { get; set; }

        public string TipoTransporte { get; set; }

        public int NumeroTransporte { get; set; }

        public TransportePublico(int cantidadPasajeros, string tipoTransporte, int numeroTransporte)
        {
            this.CantidadPasajeros = cantidadPasajeros;
            this.TipoTransporte = tipoTransporte;
            this.NumeroTransporte = numeroTransporte;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();

    }
}
