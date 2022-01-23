using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    internal class ISR
    {
        decimal[,] TablaDatos = new decimal[21, 5];
        public decimal[,] CargarTabla(string ArchivoFile)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Tichs\Documents\" + ArchivoFile + ".csv");
            string arch = sr.ReadToEnd();
            string[] campos = new string[105];
            campos = arch.Split(',');
            int i = 0;
            for (int j = 0; j < 21; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    TablaDatos[j, k] = decimal.Parse(campos[i++]);
                }

            }
            return TablaDatos;
        }
        public void Calcular(decimal SueldoMensual)
        {
            decimal SueldoQuince = SueldoMensual / 2;
            decimal excedente, porcentaje, calculo, total;

            for (int i = 0; i < 21; i++)
            {
                if (TablaDatos[i, 0] <= SueldoQuince && TablaDatos[i, 1] >= SueldoQuince)
                {
                    excedente = SueldoQuince - TablaDatos[i, 0];
                    porcentaje = excedente * (TablaDatos[i, 3] / 100);
                    calculo = porcentaje + TablaDatos[i, 2];
                    total = calculo + TablaDatos[i, 4];
                    Console.WriteLine("" + total);
                    break;
                }
            }
            }
            public void Presentacion()
            {
                Console.WriteLine("Nombre del archivo");
                string ArchivoFile = Console.ReadLine();
                CargarTabla(ArchivoFile);
                Console.WriteLine("Sueldo Mensual");
                decimal SueldoMensual = decimal.Parse(Console.ReadLine());
                Calcular(SueldoMensual);
                Console.WriteLine("ISR A PAGAR");

            }

        }
    } 

