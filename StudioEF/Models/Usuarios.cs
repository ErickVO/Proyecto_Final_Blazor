using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudioEF.Models

{
    public class Usuarios
    {
        [Key]
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public String Nombres { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [MinLength(3, ErrorMessage = "Este campo no puede tener menos de 3 caracteres.")]
        [MaxLength(30, ErrorMessage = "Ha alcanzado el maximo de caracteres.")]
        public String NombreUsuario { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public String Contrasena { get; set; }

        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        [EmailAddress]
        public String Email { get; set; }


        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            NombreUsuario = string.Empty;
            Contrasena = string.Empty;
            Email = string.Empty;
        }

        public Usuarios(int usuarioId, string nombres, string nombreUsuario, string contrasena, string email)
        {
            UsuarioId = usuarioId;
            Nombres = nombres;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Email = email;
        }
    }
}
