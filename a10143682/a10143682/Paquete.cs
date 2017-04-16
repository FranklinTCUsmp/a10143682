using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Paquete 
    {   
        private IServicioTuristico _iservicioTuristico;

        public IServicioTuristico iservicioTuristico
        {
            get { return _iservicioTuristico; }
            set { _iservicioTuristico = value; }
        }
        public Paquete() :base()
        {
            _iservicioTuristico = new Hospedaje();
        }

    }
}
