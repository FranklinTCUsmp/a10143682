using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Hospedaje : IServicioTuristico
    {
        private TipoHospedaje _tipoHospedaje;

        public TipoHospedaje tipoHospedaje
        {
            get { return _tipoHospedaje; }
            set { _tipoHospedaje = value; }
        }

        public Hospedaje()
        {
            _tipoHospedaje = new TipoHospedaje(DefinirTipoHospedaje());
        }

        public string DefinirTipoHospedaje ()
        {
            Random aleatorio = new Random();
            string[] tipoHotel = { "Hostel", "Hostal", "Backpacker", "Otros" };               
            int tHIndex = aleatorio.Next(0, tipoHotel.Length);        
            return tipoHotel[tHIndex];
        }

        public double CalcularCostoServicio()
        {
            return 0.0;
        }
        
    }
}
