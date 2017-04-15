using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado obj = new Empleado("Hos0001", "Franklin" , "Tello");
            Cliente obj2 = new Cliente("Clien0001", "Enzo", "Tello");
            Console.WriteLine("ID:   "+ obj.idEmpleado +"              Nombre:  " +obj.nombre + " " + obj.apellido);
            Console.WriteLine("ID:   " + obj2.idCliente + "              Nombre:  " + obj2.nombre + " " + obj.apellido);
        } 
    }
}
