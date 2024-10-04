using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Models
{
    internal class EvaluacionParametrica: Evaluacion
    {
        public double ValMin { get; private set; }
        public double ValMax { get; private set; }
        public double ValTol { get; private set; }
        public double ValMed { get; set; }
        public string Unidad { get; private set; }
        #region Metodos
        public EvaluacionParametrica(string nom, string des, double min, double max, string uni, double tole) : base(nom, des)
        {
            ValMin = min;
            ValMax = max;
            Unidad = uni;
            ValTol = tole;
        }
        public override TipoAprobacion Evaluar()
        {   //No hace falta la variable intemedia simon podemos retornar el TipoAprobacion directamente. return TipoAprobacion.loquesea
            TipoAprobacion simon = TipoAprobacion.Indefinido;

            if (ValMed < ValMin)
            {
                simon = TipoAprobacion.NoAprobado;
            }
            else if (ValMed > ValMin && ValMed <= ValMax)
            {
                simon = TipoAprobacion.Parcial;
            }
            else
            {
                simon = TipoAprobacion.Aprobado;
            }
            return simon;

        }
        public override string ToString()
        {                   //Con el base traemos el ToString defiinido en Evaluacion.
            string date = $"{base.ToString()} {Unidad} {Evaluar()}\n\r";
            return date;
        }
        #endregion
    }
}
