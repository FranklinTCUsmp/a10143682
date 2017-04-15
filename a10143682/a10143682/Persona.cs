using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Persona
    {
        private String _nombre;
        private String _apellido;
        // No se considera el sexo por ser irrelevante en el caso en mi abstraccion

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public String apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        public Persona()
        {

        }
        public Persona(string nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
