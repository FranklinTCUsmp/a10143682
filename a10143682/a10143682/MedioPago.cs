using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a10143682
{
    class MedioPago
    {
        private String _medioPago;

        public String medioPago
        {
            get { return _medioPago; }
            set { _medioPago = value; }
        }
        public MedioPago(string medioPago)
        {
            this.medioPago = medioPago;
        }

    }
}
