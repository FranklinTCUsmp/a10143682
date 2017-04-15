using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class CategoriaHospedaje
    {
        private String _categoriaHospedaje;

        public String categoriaHospedaje
        {
            get { return _categoriaHospedaje; }
            set { _categoriaHospedaje = value; }
        }
        public CategoriaHospedaje( String CategoriaHospedaje)
        {
            this.categoriaHospedaje = CategoriaHospedaje;
        }
    }
}
