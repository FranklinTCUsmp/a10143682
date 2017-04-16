using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace a10143682
{
    class Program
    {
        private List<VentaPaquete> _ventaPaquete;

        public List<VentaPaquete> ventaPaquete
        {
            get { return _ventaPaquete; }
            set { _ventaPaquete = value; }
        }
        public Program()
        {
            ventaPaquete = new List<VentaPaquete>(6);
           
        }
                  
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.ventaPaquete.Add(new VentaPaquete(01));
            Thread.Sleep(120);
            obj.ventaPaquete.Add(new VentaPaquete(02));
            Thread.Sleep(120);
            obj.ventaPaquete.Add(new VentaPaquete(03));
            Thread.Sleep(120);
            obj.ventaPaquete.Add(new VentaPaquete(04));
            Thread.Sleep(120);
            obj.ventaPaquete.Add(new VentaPaquete(05));
            Thread.Sleep(120);
            obj.ventaPaquete.Add(new VentaPaquete(06));
            Thread.Sleep(120);
            foreach (VentaPaquete element in obj.ventaPaquete)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("********************************************");
                Console.WriteLine("********************************************");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("#Numero de Recibo: #### "+ element.comprobantePago.idcomprobantePago);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Medio de Pago: " + element.medioPago.medioPago);
                Console.WriteLine("Tipo de Recibo: " + element.comprobantePago.tipoComprobate.tipoComprobante);
                Console.WriteLine("Cliente: "+element.cliente.nombre+" "+element.cliente.apellido);
                Console.WriteLine("********************************************");
                Console.WriteLine("#Caja: "+element.empleado.idEmpleado);
                Console.WriteLine("Cajero: " + element.empleado.nombre+" "+element.empleado.apellido);
                Console.WriteLine("********************************************");
                Console.WriteLine();
                Console.WriteLine("Paquetes Adquiridos: " + element.paquete.Capacity);
                Console.WriteLine();

                foreach (Paquete elemento1 in element.paquete)
                {
                    Console.WriteLine("Costo Total del paquete adquiridos por concenpto de Hotel: " + elemento1.iservicioTuristicoH.CalcularCostoTuristico());
                    elemento1.iservicioTuristicoH.DefinirservicioTuristico();
                    Console.WriteLine("Costo Total del paquete adquiridos por concenpto de Transporte: " + elemento1.iservicioTuristicoT.CalcularCostoTuristico());
                    elemento1.iservicioTuristicoT.DefinirservicioTuristico();
                    Console.WriteLine("Costo Total del paquete adquiridos por concenpto de Alimentacion: " + elemento1.iservicioTuristicoA.CalcularCostoTuristico());
                    elemento1.iservicioTuristicoA.CalcularCostoTuristico();
                    Console.WriteLine("********************************************");
                    double aux = elemento1.iservicioTuristicoH.CalcularCostoTuristico()+elemento1.iservicioTuristicoT.CalcularCostoTuristico() + elemento1.iservicioTuristicoA.CalcularCostoTuristico();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Costo Total del paquete : " + aux);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine();
                }
               


            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*************Gerente General****************");
            Console.WriteLine("*********Franklin Tello Cardenas************");
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
        }
       


       
    }
}
