//Facundo Lucero 30794
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_GrupoB
{
    public class CEjecutora
    {
        public static void Main()
        { 
            Console.WriteLine("INGRESE EL PORCENTAJE DE DESCUENTO POR PAGO ANUAL");
            float descuento = float.Parse(Console.ReadLine());
            Cplan.Descuentoanual = descuento;

            List<Cplan> planes = new List<Cplan>();
            Console.WriteLine("INGRESE EL TITULO DEL PLAN A BUSCAR");
            string titulo = Console.ReadLine().ToUpper();
            while (titulo != "FIN")
            {
                Console.WriteLine("INGRESE EL CODIGO DEL PLAN");
                string codigo = Console.ReadLine();
                Console.WriteLine("INGRESE EL COSTO MENSUAL DEL PLAN");
                float costomensual = float.Parse(Console.ReadLine());
                Cplan plan = new Cplan(codigo, titulo);
                plan.SetCostoMensual (costomensual);
                planes.Add(plan);
                Console.WriteLine("INGRESE OTRO TITULO DE PLAN O FIN PARA FINALIZAR");
                titulo = Console.ReadLine().ToUpper();
            }
            if (planes.Count > 0)
            {
                Cplan PlanMasEconomico = planes[0];
                foreach(Cplan plan in planes)
                {
                    if(plan.MasEconomico(PlanMasEconomico))
                    {
                        PlanMasEconomico = plan;
                    }
                }
                Console.WriteLine($"Los datos del plan mas economico son:{PlanMasEconomico.DarDatos()}");
                Console.WriteLine($"El costo anual del plan mas economico es :{PlanMasEconomico.CalcularCosto()}");
                Console.WriteLine($"El costo anual con descuento del plan mas economico es :{PlanMasEconomico.CalcularCosto(true)}");
                Console.WriteLine($"El total recaudado por todos los planes es:{ Cplan.TotalRecaudado(planes)}");


            }
            else
            {
                Console.WriteLine("No se ingreso ningun plan");
            }
        }
    }
}
