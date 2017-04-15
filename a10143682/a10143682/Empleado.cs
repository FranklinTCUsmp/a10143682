﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Empleado : Persona
    {
        private string _idEmpleado;

        public string idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }


        public Empleado()
        {        
        }
        public Empleado(string idEmpleado , string nombre, string apellido) : base(nombre, apellido)
        {
           this.idEmpleado = idEmpleado;
        }
    }
}
