using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace a10143682
{
    class VentaPaquete
    {
        private MedioPago _medioPago;
        private ComprobantePago _comprobantePago;
        private List<Paquete> _paquete;
        private Empleado _empleado;
        private Cliente _cliente;




        public MedioPago medioPago
        {
            get { return _medioPago; }

            set {
                _medioPago = value;
            }
        }
        public ComprobantePago comprobantePago
        {
            get { return _comprobantePago; }
            set { _comprobantePago = value; }
        }
        public List<Paquete> paquete
        {
            get { return _paquete; }
            set { _paquete = value; }
        }

        public Empleado empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }


        public Cliente cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public VentaPaquete()
        {
                
        }
      



        public string DefinirNombreE()
        {
            Random aleatorio = new Random();
            // Fuente http://www.significado-de-nombres.com/nombres-para-bebes-ninos-y-ninas/
            string[] nombreE = { "Andrés","Benjamin","Bruno","Cristian","David",
                                    "Dylan","Eduardo","Fabián","Felipe"};
            int nombreIndex = aleatorio.Next(0, nombreE.Length);
            return nombreE[nombreIndex];
        }
        public string DefinirNombreC()
        {
            Random aleatorio = new Random();
            // Fuente http://www.significado-de-nombres.com/nombres-para-bebes-ninos-y-ninas/
            string[] nombreC = { "Alberto","Antonio","Bryan",
                                    "Enrique","Óscar","Fernando"};
            int nombreIndex = aleatorio.Next(0, nombreC.Length);
            return nombreC[nombreIndex];
        }
        public string DefinirApellidoE()
        {
            Random aleatorio = new Random();
            // Fuente http://zonaj.net/noticia/1175/16/los-10-apellidos-mas-comunes-en-algunos-paises-del-mundo/
            string[] apellido = { "García","Fernández","González","Rodríguez","López","Martínez","Sánchez","Pérez","Martín","Gómez"};
            int apellidoIndex = aleatorio.Next(0, apellido.Length);
            return apellido[apellidoIndex];
        }
        public string DefinirApellidoC()
        {
            Random aleatorio = new Random();
            // Fuente http://zonaj.net/noticia/1175/16/los-10-apellidos-mas-comunes-en-algunos-paises-del-mundo/
            string[] apellido = { "García", "Fernández", "González", "Rodríguez", "López", "Martínez", "Sánchez", "Pérez", "Martín", "Gómez" };
            int apellidoIndex = aleatorio.Next(0, apellido.Length);
            return apellido[apellidoIndex];
        }

        public void GenerarCodEmpleado()
        {
            this.empleado.idEmpleado = "Caja"+this.empleado.nombre.ToUpper()+this.empleado.apellido.ToUpper();
        }
        public void GenerarCodCliente()
        {
            Random aleatorio = new Random();
            this.cliente.idCliente = Convert.ToString( aleatorio.Next(81520450, 92141225));
        }
        /*  public int GenerarIdComprobante()
          {
              int idIdComprobante = 0;
              int nombreIndex = aleatorio.Next(0, nombre.Length);
              return nombre[nombreIndex];
          }*/

        public string TipoComprobante()
        {
            Random aleatorio2 = new Random();
            string[] tipoComprobante = { "Factura", "Boleta"};
            int tipoComprobanteIndex = aleatorio2.Next(0, tipoComprobante.Length);
            return tipoComprobante[tipoComprobanteIndex];
        }

        public string MedioPago()
        {
            Random aleatorio3 = new Random();
            string[] medioPago = { "Tarjeta Debito", "Tarjeta Credito", "Efectivo" };
            int medioPagoIndex = aleatorio3.Next(0, medioPago.Length);
            return medioPago[medioPagoIndex];
        }

        public int idpaquete()
        {
            Random aleatorio4 = new Random();
            return aleatorio4.Next(1,3);
        }

        public VentaPaquete(int idcomprobantePago)
        {
            this.comprobantePago = new ComprobantePago(idcomprobantePago, TipoComprobante());
            this.medioPago = new MedioPago(MedioPago());
            int aux = idpaquete();
            paquete  = new List<Paquete>(aux);
            for (int i = 0; i < aux; i++)
            {
                Thread.Sleep(120);
                paquete.Add(new Paquete());
            }
            empleado = new Empleado(DefinirNombreE(),DefinirApellidoE());
            cliente  = new Cliente(DefinirNombreC(),DefinirApellidoC());
            GenerarCodEmpleado();
            GenerarCodCliente();

        }

    }
}
