using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class Poliza
    {
        public DateTime fechaInicio;
        public DateTime tipoDePeriodo;
        public int tipoPeriodo;
        public int periodo;
        public int suma;
        public DateTime fechaNacimiento;
        public string genero;

        public static void Calcular(DateTime fecInicioVig, int tipoPeri, int periodos, int sumaAseg, DateTime fechNac, decimal gene)
        {
            PolizaResultado pool = new PolizaResultado();
            DateTime fechaInicio = fecInicioVig;
            //int tipoDePeriodo = tipoPeri;
            //int periodo = periodos;
            //int suma = sumaAseg;
            DateTime fechaNacimiento = fechNac;

            decimal[,] operacion = new decimal[11, 4]

                {{0,20,1,0.05m},
                {21,30,1,0.1m},
                {31,40,1,0.4m},
                {41,50,1,0.5m},
                {61,110,1,0.85m},
                {0,20,2,0.5m},
                {21,30,2,0.1m},
                {31,40,2,0.4m},
                {41,50,2,0.55m},
                {51,60,2,0.7m},
                {61,110,2,0.9m},
                };

            //decimal factores;
            decimal edad = 28;
            decimal genero1 = 1;
            decimal factores = 0;
            for (int i = 0; i <= 11; i++)
            {
                if (operacion[i, 2] == genero1 && edad >= operacion[i, 0] && edad <= operacion[i, 1])
                {
                    factores = operacion[i, 3];
                    break;
                }
            }

            if (tipoPeri == 1)
            {
                pool.Prima = sumaAseg * factores * (periodos * 365) / 360;
                Console.WriteLine("Prima va a pagar " + pool.Prima + "pesos");
                DateTime finPoliza = fecInicioVig.AddDays(periodos * 365);
                Console.WriteLine("La poliza finalizara el:" + finPoliza);
            }

            if (tipoPeri == 2)
            {
                pool.Prima = sumaAseg * factores * (periodos * 30) / 360;
                Console.WriteLine("Prima va a pagar " + pool.Prima + "pesos");
                DateTime finPoliza = fecInicioVig.AddDays(periodos * 30);
                Console.WriteLine("La poliza finalizara el:" + finPoliza);
            }

            if (tipoPeri == 3)
            {
                pool.Prima = sumaAseg * factores * (periodos) / 360;
                Console.WriteLine("Prima va a pagar " + pool.Prima + "pesos");
                DateTime finPoliza = fecInicioVig.AddDays(periodos);
                Console.WriteLine("La poliza finalizara el:" + finPoliza);
            }

        }
                public void presentacion()
                {
            Console.WriteLine("Proporciona la fecha de inicio de Vigencia: ");
            DateTime fecInicioVig = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("Proporciona tipo de periodo (1 año), (2 mes), (3 día):");
            int tipoPeri = int.Parse(Console.ReadLine());

            Console.WriteLine("Proporciona para cuanto tiempo requieres la póliza:");
            int periodos = int.Parse(Console.ReadLine());

            Console.WriteLine("Proporciona la suma asegurada:");
            int sumaAseg = int.Parse(Console.ReadLine());

            Console.WriteLine("Proporciona la fecha de Nacimiento del asegurado:");
            DateTime fechNac = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Proporciona el género del asegurado:");
            decimal gene = decimal.Parse(Console.ReadLine());

            Calcular(fecInicioVig, tipoPeri, periodos, sumaAseg, fechNac, gene);
        }
        //Console.ReadKey();
    }
}





