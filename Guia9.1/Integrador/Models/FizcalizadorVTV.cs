using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Models
{
    public class FizcalizadorVTV
    {
        public List<VTV> verificaciones = new List<VTV>();

        public int CantVeri
        {
            get
            {
                return verificaciones.Count;
            }
        }
        public VTV this[int idx]
        {
            get
            {
                VTV v = null;
                if(idx > 0 && idx <= CantVeri)
                {
                    v = verificaciones[idx];
                }
                return v;
            }
        }

        public VTV AgregarVTV(string pat,Propietario pro,DateTime fecha)
        {
            VTV rick = new VTV(pat,pro,fecha);
            verificaciones.Add(rick);
            return rick;
        }
        public List<VTV> VerXPatente(string pat)
        {

        }
    }
}
