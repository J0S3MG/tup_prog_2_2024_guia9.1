using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Models
{
    public class Propietario
    {
        public int DNI { get; set; }
        public string ApeyNom { get; set; }
        public string Email { get; set; }
        public Propietario(int dni, string apeynom, string email)
        {
            DNI = dni;
            ApeyNom = apeynom;
            Email = email;
        }
        public override string ToString()
        {
            string date = $"{DNI} {ApeyNom} {Email}\n\r";
            return date;
        }
    }
}
