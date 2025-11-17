//Facundo Lucero 30794
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_GrupoB
{
    public class Cplan
    {
        private string codigo;
        private string titulo;
        private float costomensual;
        private static float descuentoanual;

        public void SetCostoMensual(float costo)
        {
            this.costomensual = costo;
        }

        public float GetCostoMensual()
        {
            return costomensual;
        }

        public static float Descuentoanual
        {
            get { return descuentoanual; }
            set { descuentoanual = value; }
        }

        public Cplan(string Codigo, string Titulo)
        {
            this.codigo = Codigo;
            this.titulo = Titulo;
        }


        public float CalcularCosto()
        {
            float Costoanual = this.costomensual * 12;
            return Costoanual;
        }

        public float CalcularCosto(bool anual)
        {
            float costoanual = CalcularCosto();
            if (anual)
            {
                float descuento = (costoanual * Descuentoanual) /  100;
                return (costoanual) - descuento;
            }
            else
            {
                return costoanual;
            }
        }

        public string DarDatos()
        {
            string datos = $"Codigo :  {this.codigo} || Titulo: {this.titulo}|| Coste Mensual: {this.costomensual}";
            return datos;
        }

        public string DarDatos(bool anual)
        {
            if (anual)
            {
                string datosanual = $"Codigo : {this.codigo} || Titulo: {this.titulo}|| Coste Mensual: {this.costomensual} || Costo Anual con descuento: {CalcularCosto(true)}";
                return datosanual;
            }
            else
            {
                return DarDatos();
            }
        }

        public bool MasEconomico(Cplan PlanBarato)
        {
            return this.CalcularCosto() < PlanBarato.CalcularCosto();
        }

        public static float TotalRecaudado(List<Cplan> planes)
        {
            float total = 0;
            foreach (Cplan plan in planes)
            {
                total += plan.CalcularCosto();
            }
            return total;
        }
    }
}
