using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Models
{
    public abstract class Evaluacion
    {
        public string Nombre { get; private set; }
        public string Desc { get; private set; }
        public Evaluacion(string nom, string des)
        {
            Nombre = nom;
            Desc = des;
        }
        public abstract TipoAprobacion Evaluar(); //metodo abstracto que utiliza el enum.
        public override string ToString()
        {
            string date = $"{Nombre} {Desc}\n\r";
            return date;
        }
    }
}
