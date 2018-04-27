using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFMigrations.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Direccion { get; set; }

        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
    }
}