using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class ServicioHospedaje
    {
        private string _servicioHospedaje;

        public string servicioHospedaje
        {
            get { return _servicioHospedaje; }
            set { _servicioHospedaje = value; }
        }

        public ServicioHospedaje(string servicioHospedaje)
        {
            this.servicioHospedaje = servicioHospedaje;
        }
    }
}
