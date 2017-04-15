using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Cliente:Persona
    {
        
        private string _idCliente;
        /* Para identificar al cliente usaremos el documento de identidad DNI,         *
         * para actualizaciones se tomará en cuenta diferentes documentos de identidad */

        public string idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }


        public Cliente()
        {
        }
        public Cliente(string idCliente, string nombre, string apellido) : base(nombre, apellido)
        {
            this.idCliente = idCliente;
        }
        
    }
}
