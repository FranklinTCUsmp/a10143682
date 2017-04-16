using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class TipoTransporte
    {
        private String _tipoTranporte;

        public String tipoTransporte
        {
            get { return _tipoTranporte; }
            set { _tipoTranporte = value; }
        }
        public TipoTransporte(String tipoTransporte)
        {
            this.tipoTransporte = tipoTransporte;
        }

    }
}
