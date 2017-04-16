using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
   
    class Alimentacion : IServicioTuristico
    {
        private CategoriaAlimentacion _categoriaAlimentacion;

        public CategoriaAlimentacion categoriaAlimentacion
        {
            get { return _categoriaAlimentacion; }
            set { _categoriaAlimentacion = value; }
        }

        public string DefinirTipoAlimentacion()
        {
            Random aleatorio = new Random();
            string[] tipoAlimento = { "Cocina Italiana","Cocina Española","Cocina China",
                                    "Cocina Tailandesa","Cocina Nuevo Latino"};
            int tHIndex = aleatorio.Next(0, tipoAlimento.Length);
            return tipoAlimento[tHIndex];
        }

        public double CalcularCostoCategoriaAlimentacion()
        {
            double[] costoCategoriaAlimentacion = { 200.00, 190.00, 170.00, 160.00, 150.00 };
            string caseSwitch = this.categoriaAlimentacion.categoriaAlimentacion;
            switch (caseSwitch)
            {
                case "Cocina Italiana":
                    return costoCategoriaAlimentacion[0];
                    break;
                case "Cocina Nuevo Latino":
                    return costoCategoriaAlimentacion[1];
                    break;
                case "Cocina China":
                    return costoCategoriaAlimentacion[2];
                    break;
                case "Cocina Tailandesa":
                    return costoCategoriaAlimentacion[3];
                    break;
                default:
                    return costoCategoriaAlimentacion[4];
                    break;
            }
        }
        public Alimentacion()
        {
            categoriaAlimentacion = new CategoriaAlimentacion(DefinirTipoAlimentacion());

        }

        public double CalcularCostoTuristico()
        {
            return CalcularCostoCategoriaAlimentacion();
        }

        public void DefinirservicioTuristico()
        {
            Console.WriteLine("El Categoria de Hopedaje es: " + this.categoriaAlimentacion.categoriaAlimentacion);
            Console.WriteLine("********************************************");

        }
    }
}
