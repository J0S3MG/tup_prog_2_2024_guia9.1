using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Models
{
    public class EvaluacionSimple: Evaluacion
    {
        public bool HaVerificado { get; set; }
        public EvaluacionSimple(string nom, string des) : base(nom, des)
        {
        }
        public override TipoAprobacion Evaluar()//Creamos un metodo que retorna el enum TipoAprobacion
        {
            TipoAprobacion simon = TipoAprobacion.NoAprobado;//Creamos una Variable que sea el enum.
            if (HaVerificado == true)
            {
                simon = TipoAprobacion.Aprobado;
            }
            return simon;
        }
        public override string ToString()
        {                    //Con el base traemos el ToString defiinido en Evaluacion.
            string date = $"{base.ToString()} {Evaluar()}";
            return date;
        }
    }
}
