using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudioEF.Models
{
    public class Fotografos
    {
        [Key]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int FotografoId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public String Nombres { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public String Apellidos { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(11, ErrorMessage = "Este campo no puede tener menos de 11 caracteres.")]         
        public String Cedula { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public String Direccion { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(10, ErrorMessage = "Este campo no puede tener menos de 10 caracteres.")]
        [MaxLength(11, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        [Phone(ErrorMessage = "Ingrese su numero de telefono")]
        public String Telefono { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(10, ErrorMessage = "Este campo no puede tener menos de 10 caracteres.")]
        [MaxLength(11, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public String Celular { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public String Sexo { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal Sueldo { get; set; }

        public Fotografos()
        {
            FotografoId = 0;
            UsuarioId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Sexo = string.Empty;
            FechaNacimiento = DateTime.Now;
            Sueldo = 0;
        }
    }
}
