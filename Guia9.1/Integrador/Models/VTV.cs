using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Models
{
    public class VTV: IComparable
    {
        List<Evaluacion> evaluaciones = new List<Evaluacion>();
        public Propietario Pro { get; private set; }
        public string Patente { get; private set; }
        public DateTime Fecha { get; private set; }

        #region Propiedades Largas 
        public int CantEvas
        {
            get
            {
                return evaluaciones.Count;
            }
        }
        //declaro un indexador con un indice int que devuelve una Evaluacion
        public Evaluacion this[int idx]//le paso el indice
        {
            get
            {
                Evaluacion eva = null;//creo la variable a retornar
                if (idx >= 0 && idx < CantEvas)//si el indice es mayor o igual a cero y menor que la cantidad de evaluaciones...
                {
                    eva = evaluaciones[idx];//entonces me guardo la evaluacion en ese indice.
                }
                return eva;//retorno la evaluacion.
            }
        }
        public TipoAprobacion Aprobacion
        {
            get
            {
                TipoAprobacion simon = TipoAprobacion.Indefinido;
                for (int i = 0; i < CantEvas; i++)
                {
                    Evaluacion eva = this[i];
                    simon = eva.Evaluar();
                }
                return simon;
            }
        }
        #endregion

        #region Metodos 
        public VTV(string patente, Propietario pro, DateTime fecha)
        {
            Patente = patente;
            Pro = pro;
            Fecha = fecha;
        }
        public string[] EmitirComprobante()//hago un metodo que me retorna un vector de string
        {
            string[] comprobantes = new string[CantEvas];
            for (int i = 0; i < CantEvas; i++)
            {
                Evaluacion eva = this[i];//uso el indexador antes definido
                string ver = eva.ToString();//traigo el metodo Ver de cada evaluacion.
                comprobantes[i] = ver;//lo guardo en la pos del arreglo.
            }
            return comprobantes;
        }
        public override string ToString()
        {
            string date = $"{Pro.ToString()} {Fecha} {Patente}";
            return date;
        }
        public int CompareTo(object obj)
        {
            VTV rick = obj as VTV;
            if( rick != null)
                return Patente.CompareTo(rick.Patente);
            return 1;
        }
        #endregion
    }
}
