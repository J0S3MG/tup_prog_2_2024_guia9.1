using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador.Models
{
    public enum TipoAprobacion //Es un Enumerador, sirve para crear Cajas con Etiquetas dentro. 
    {//Cada Caja tiene asociado un numero y dentro guarda una Etiqueta que es un texto.
        NoAprobado, //En este caso la Caja es O y su Etiqueta es NoAprobado. 
        Parcial,
        Aprobado,
        Indefinido
    }
}
