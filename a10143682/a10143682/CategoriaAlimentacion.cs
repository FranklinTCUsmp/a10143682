using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class CategoriaAlimentacion
    {
        private string _categoriaAlimentacion;

        public string categoriaAlimentacion
        {
            get { return _categoriaAlimentacion; }
            set { _categoriaAlimentacion = value; }
        }
        public CategoriaAlimentacion(String categoriaAlimentacion)
        {
            this.categoriaAlimentacion = categoriaAlimentacion;
        }
    }
}
