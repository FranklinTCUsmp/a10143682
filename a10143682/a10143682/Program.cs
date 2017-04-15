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
            Empleado obj = new Empleado("Caja1", "Franklin", "Tello");
            Cliente obj2 = new Cliente("Clien0001", "Enzo", "Tello");
            VentaPaquete obj3 = new VentaPaquete(1000, "Factura", "Tarjeta",01);


            

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Personal Responsable:");
            Console.WriteLine("ID: " + obj.idEmpleado +"   "+ "Nombre: " + obj.nombre + " " + obj.apellido);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Datos de Cliente");
            Console.WriteLine("ID: " + obj2.idCliente + " - Nombre: " + obj2.nombre + " " + obj.apellido);
            Console.WriteLine("Numero de recibo: " + obj3.comprobantePago.idcomprobantePago);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Condiciones de Pago:");
            Console.WriteLine("Medio de pago: " + obj3.medioPago.medioPago);
            Console.WriteLine("Tipo de recivo  " + obj3.comprobantePago.tipoComprobate.tipoComprobante);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" "+obj3.paquete.idpaquete);
            Console.WriteLine("" + obj3.paquete.iservicioTuristico.Definirservicio());
            Console.WriteLine(" " + obj3.paquete.iservicioTuristico.CalcularCostoServicio());


            //Parts.Find (x => x.PartName.Contains ("asiento"))   parts.Exists(x => x.PartId == 1444));
            /*
             *Telefono _fonoDestino = _Telefonos.Find( t => t.Numero == numero);

            Llamada _llamada = new Llamada(_fonoDestino);
             *
             */

        }
    }
}
