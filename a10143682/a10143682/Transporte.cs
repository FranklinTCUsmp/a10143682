using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Transporte : IServicioTuristico
    {
        private CategoriaTransporte _categoriaTransporte;

        public CategoriaTransporte categoriaTransporte
        {
            get { return _categoriaTransporte; }
            set { _categoriaTransporte = value; }
        }

        private TipoTransporte _tipoTransporte;

        public TipoTransporte tipoTransporte
        {
            get { return _tipoTransporte; }
            set { _tipoTransporte = value; }
        }


        public string definirCategoriaTransporte()
        {
            Random aleatorio1 = new Random();
            string[] Definirservicio = { "Vip", "Normal", "Basico" };
            int tHIndex = aleatorio1.Next(0, Definirservicio.Length);
            return Definirservicio[tHIndex];
        }

        public double CalcularCostoCategoriaTransporte()
        {
            double[] costoCategoriaTransporte = { 500.00, 300.00, 100.00 };
            string caseSwitch = this.categoriaTransporte.categoriaTransporte;
            switch (caseSwitch)
            {
                case "Vip":
                    return costoCategoriaTransporte[0];
                    break;
                case "Normal":
                    return costoCategoriaTransporte[1];
                    break;
                default:
                    return costoCategoriaTransporte[2];
                    break;

            }
        }


        public string definirTipoTransporte()
        {
            Random aleatorio2 = new Random();
            string[] Definirservicio = { "Carro Personal", "Bus Turistico", "No Incluido" };
            int tHIndex = aleatorio2.Next(0, Definirservicio.Length);
            return Definirservicio[tHIndex];

        }
        public double CalcularCostoTipoTransporte()
        {
                double[] costoCategoriaTransporte = {500.00,300.00,100.00};
                string caseSwitch = this.categoriaTransporte.categoriaTransporte;
                switch (caseSwitch)
                {
                    case "Carro Personal":
                        return costoCategoriaTransporte[0];
                        break;
                    case "Bus Turistico":
                        return costoCategoriaTransporte[1];
                        break;
                    default:
                        return costoCategoriaTransporte[2];
                        break;
                  
                }
        }

        public Transporte()
        {
            categoriaTransporte = new CategoriaTransporte(definirCategoriaTransporte());
            tipoTransporte = new TipoTransporte(definirTipoTransporte());
        }

        public void DefinirservicioTuristico()
        {
            Console.WriteLine("El Tipo de Transporte es: " + this.tipoTransporte.tipoTransporte);
            Console.WriteLine("El Categoria de Transporte es: " + this.categoriaTransporte.categoriaTransporte);
            Console.WriteLine("********************************************");
        }
        public double CalcularCostoTuristico()
        {
                return CalcularCostoTipoTransporte()+CalcularCostoCategoriaTransporte();
        }
    }
}
