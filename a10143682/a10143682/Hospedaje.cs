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
            tipoHospedaje = new TipoHospedaje(DefinirTipoHospedaje());
        }

        public string DefinirTipoHospedaje ()
        {
            Random aleatorio = new Random();
            string[] tipoHotel = { "Hostel", "Hostal", "Backpacker", "Otros" };               
            int tHIndex = aleatorio.Next(0, tipoHotel.Length);        
            return tipoHotel[tHIndex];
        }

        public double CalcularCostoTipoHospedaje()
        {
            double[] costoHotel = { 400.00, 2000.00, 100.00, 50.00 };          
            string caseSwitch = this.tipoHospedaje.tipoHospedaje;
            switch (caseSwitch)
            {
                case "Hostel":
                    return costoHotel[0];
                    break;
                case "Hostal":
                    return costoHotel[1];
                    break;
                case "Backpacker":
                    return costoHotel[2];
                    break;
                default:
                    return costoHotel[3];
                    break;
            }
        }

        public double CalcularCostoServicio()
        {
            return CalcularCostoTipoHospedaje();
        }
       public string Definirservicio()
        {
            return this.tipoHospedaje.tipoHospedaje;
        }

    }
}
