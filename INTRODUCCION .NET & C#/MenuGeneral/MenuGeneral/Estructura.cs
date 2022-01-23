using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    
        struct PolizaResultado
        {
            public DateTime FechaTermino;
            public decimal Prima;
            public PolizaResultado(DateTime fechT, decimal pri)
            {
                this.FechaTermino = fechT;
                this.Prima = pri;

            }
        }
    }

