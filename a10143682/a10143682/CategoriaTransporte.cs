using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class CategoriaTransporte
    {
        private string _categoriaTransporte;

        public string categoriaTransporte
        {
            get { return _categoriaTransporte; }
            set { _categoriaTransporte = value; }
        }

        public CategoriaTransporte(string categoriaTransporte)
        {
            this.categoriaTransporte = categoriaTransporte;
        }

    }
}
