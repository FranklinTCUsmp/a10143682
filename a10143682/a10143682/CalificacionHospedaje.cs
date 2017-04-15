using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class CalificacionHospedaje
    {
        private int _calificacionHospedaje;

        public int calificacionHospedaje
        {
            get { return _calificacionHospedaje; }
            set { _calificacionHospedaje = value; }
        }
        public CalificacionHospedaje(int calificacionHospedaje)
        {
            this.calificacionHospedaje = calificacionHospedaje;
        }
    }
}
