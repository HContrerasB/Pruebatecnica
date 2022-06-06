using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Apiprueba1.Models
{
    public class Empleado
    {
        [Key]
        public decimal IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public decimal IdGenero { get; set; }
        public decimal IdCuidad { get; set; }
    }
}
