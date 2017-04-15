using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class TipoComprobante
    {
        private String _tipoComprobante;

        public String tipoComprobante
        {
            get { return _tipoComprobante; }
            set { _tipoComprobante = value; }
        }

        public TipoComprobante(String tipoComprobante)
        {
            this.tipoComprobante = tipoComprobante;
        }


    }
}
