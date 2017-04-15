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

        private int _idpaquete;

        public int idpaquete
        {
            get { return _idpaquete; }
            set { _idpaquete = value; }
        }

        public Paquete(int idpaquete) :base()
        {
            this.idpaquete = idpaquete;
            _iservicioTuristico = new Hospedaje();
        }

    }
}
