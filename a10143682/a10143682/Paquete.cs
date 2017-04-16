using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Paquete 
    {   
        private IServicioTuristico _iservicioTuristicoT;

        public IServicioTuristico iservicioTuristicoT
        {
            get { return _iservicioTuristicoT; }
            set { _iservicioTuristicoT = value; }
        }

        private IServicioTuristico _iservicioTuristicoH;

        public IServicioTuristico iservicioTuristicoH
        {
            get { return _iservicioTuristicoH; }
            set { _iservicioTuristicoH = value; }
        }
    
        public Paquete() :base()
        {
            iservicioTuristicoH = new Hospedaje();
            iservicioTuristicoT = new Transporte();

        }

    }
}
