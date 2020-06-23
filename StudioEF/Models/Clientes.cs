using StudioEF.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudioEF.Models
{
    public class Clientes
    {
        [Key]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public int ClienteId { get; set; }

        [Range(1,20000000,ErrorMessage ="Este campo debe tener un rango mayor a 0.")]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        [MinLength(3,ErrorMessage ="Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30,ErrorMessage ="Ha alcanzo el maximo de caracteres.")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Ingrese los nombres.")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzo el maximo de caracteres.")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Ingrese los apellidos.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        [Phone(ErrorMessage ="Este campo solo debe contener numeros.")]
        [StringLength(11,ErrorMessage ="Este campo debe contener 11 caracteres.")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Ingrese una cedula.")]
        public string Cedula { get; set; }

        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Ingrese una dirección.")]
        public string Direccion { get; set; }

        [Phone(ErrorMessage = "Este campo solo debe contener numeros.")]
        [StringLength(10, ErrorMessage = "Este campo debe contener 10 caracteres.")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Ingrese un telefono.")]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Telefono { get; set; }

        [Phone(ErrorMessage = "Este campo solo debe contener numeros.")]
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "Ingrese un telefono.")]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [ForeignKey("ClienteId")]
        public List<Ventas> Ventas { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            UsuarioId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Celular = string.Empty;
            Sexo = string.Empty;
            FechaNacimiento = DateTime.Now;
            Ventas = new List<Ventas>();
        }
    }
}
