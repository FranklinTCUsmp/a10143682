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

        private CategoriaHospedaje _categoriaHospedaje;

        public CategoriaHospedaje categoriaHospedaje
        {
            get { return _categoriaHospedaje; }
            set { _categoriaHospedaje = value; }
        }
        private ServicioHospedaje _servicioHospedaje;

        public ServicioHospedaje servicioHospedaje
        {
            get { return _servicioHospedaje; }
            set { _servicioHospedaje = value; }
        }


        public string DefinirCategoriaHospedaje()
        {   // Asumi una categoria diferente por estar leyendo otros  documentos, disculpe
            Random aleatorio = new Random();
            string[] tipoCategoriaHospedaje = { "*****","****","***","**","*"};
            int tHIndex = aleatorio.Next(0, tipoCategoriaHospedaje.Length);
            return tipoCategoriaHospedaje[tHIndex];
        }

        public string DefinirTipoHospedaje ()
        {
            Random aleatorio = new Random();
            string[] tipoHotel = { "Hostel", "Hostal", "Backpacker", "Otros" };               
            int tHIndex = aleatorio.Next(0, tipoHotel.Length);        
            return tipoHotel[tHIndex];
        }

        public string Definirservicio()
        {
            Random aleatorio = new Random();
            string[] Definirservicio = { "Lavanderia", "Planchado", "Room Service", "Otros" };
            int tHIndex = aleatorio.Next(0, Definirservicio.Length);
            return Definirservicio[tHIndex];
        }


        public double CalcularCostoTipoHospedaje()
        {   if (tipoHospedaje.Equals("Sin Categoria"))
            {
                double[] costSinCategorial = { 2000.00, 100.00, 50.00 };
                string caseSwitch = this.tipoHospedaje.tipoHospedaje;
                switch (caseSwitch)
                {
                    case "Hostel":
                        return costSinCategorial[0];
                        break;
                    case "Hostal":
                        return costSinCategorial[1];
                        break;
                    case "Backpacker":
                        return costSinCategorial[2];
                        break;
                    default:
                        return costSinCategorial[3];
                        break;
                }
            }
                
            else
            {
                double[] costoHotel = { 1200, 1000.00, 800.00, 600.00, 400.00 };
                string caseSwitch = this.tipoHospedaje.tipoHospedaje;
                switch (caseSwitch)
                {
                    case "*****":
                        return costoHotel[0];
                        break;
                    case "****":
                        return costoHotel[1];
                        break;
                    case "***":
                        return costoHotel[2];
                        break;
                    case "**":
                        return costoHotel[2];
                        break;
                    default:
                        return costoHotel[3];
                        break;
                }




            }

            
            
        }

         
        
        public Hospedaje()
             {
                tipoHospedaje = new TipoHospedaje(DefinirTipoHospedaje());
                if (tipoHospedaje.Equals("Hotel"))
                {
                    categoriaHospedaje = new CategoriaHospedaje(DefinirCategoriaHospedaje());
                }
                else
                {
                    categoriaHospedaje = new CategoriaHospedaje("Sin Categoria");
                }

                servicioHospedaje = new ServicioHospedaje(Definirservicio());
             }

        public double CalcularCostoTuristico()
        {
            return CalcularCostoTipoHospedaje();
        }

        public void DefinirservicioTuristico()
        {
            Console.WriteLine("El Tipo de Hopedaje es: "+this.tipoHospedaje.tipoHospedaje);
            Console.WriteLine("El Categoria de Hopedaje es: "+this.categoriaHospedaje.categoriaHospedaje);
            Console.WriteLine("El Servicio de Hopedaje es: " + this.servicioHospedaje.servicioHospedaje);
            Console.WriteLine("********************************************");

        }

    }
}
