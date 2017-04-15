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

        public VentaPaquete(int idcomprobantePago, string tipoComprobate, String medioPago)
        {
            this.comprobantePago = new ComprobantePago( idcomprobantePago,  tipoComprobate);
            this.medioPago = new MedioPago(medioPago);
        }
       
    }
}
