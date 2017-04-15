using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class TipoHospedaje
    {
        private String _tipoHospedaje;

        public String tipoHospedaje
        {
            get { return _tipoHospedaje; }
            set { _tipoHospedaje = value; }
        }
        public TipoHospedaje( string tipoHospedaje)
        {
            this.tipoHospedaje = tipoHospedaje;
        }

    }
}
