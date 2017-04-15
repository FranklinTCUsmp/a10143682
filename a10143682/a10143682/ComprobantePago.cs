using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class ComprobantePago
    {
        private TipoComprobante _tipoComprobate;
        private int _idcomprobantePago;
        
        public TipoComprobante tipoComprobate
        {
            get { return _tipoComprobate; }
            set { _tipoComprobate = value; }
        }

        public int idcomprobantePago
        {
            get { return _idcomprobantePago; }
            set { _idcomprobantePago = value; }
        }

        public ComprobantePago( int idcomprobantePago, string tipoComprobate)
        {
            this.idcomprobantePago = idcomprobantePago;
            this.tipoComprobate = new TipoComprobante(tipoComprobate);
        }

    }
}
