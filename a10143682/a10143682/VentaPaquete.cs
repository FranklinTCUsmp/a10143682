using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class VentaPaquete
    {
        private MedioPago _medioPago;
        private ComprobantePago _comprobantePago;
        private Paquete _paquete;

        

        public MedioPago medioPago
        {
            get { return _medioPago; }

            set {
                _medioPago = value;
            }
        }
        public ComprobantePago comprobantePago
        {
            get { return _comprobantePago; }
            set { _comprobantePago = value; }
        }
        public Paquete paquete
        {
            get { return _paquete; }
            set { _paquete = value; }
        }


        public VentaPaquete(int idcomprobantePago, string tipoComprobate, String medioPago, int idpaquete)
        {
            this.comprobantePago = new ComprobantePago( idcomprobantePago,  tipoComprobate);
            this.medioPago = new MedioPago(medioPago);
            _paquete = new Paquete(idpaquete);
        }



        public string DefinirNombre()
        {
            Random aleatorio = new Random();
            string[] nombre = { "Alberto","Andrés","Antonio","Benjamin","Bruno","Bryan","Cristian","David",
                                    "Dylan","Dylan","Eduardo","Enrique","Óscar","Fabián","Felipe","Fernando"};
            int nombreIndex = aleatorio.Next(0, nombre.Length);
            return nombre[nombreIndex];
        }
        public string DefinirApellido()
        {
            Random aleatorio = new Random();
            string[] apellido = { "Alberto","Andrés","Antonio","Benjamin","Bruno","Bryan","Cristian","David",
                                    "Dylan","Dylan","Eduardo","Enrique","Óscar","Fabián","Felipe","Fernando"};
            int apellidoIndex = aleatorio.Next(0, apellido.Length);
            return apellido[apellidoIndex];
        }

    }
}
