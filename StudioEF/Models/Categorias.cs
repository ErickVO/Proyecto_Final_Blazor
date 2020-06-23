using StudioEF.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudioEF.Models
{     
    public class Categorias
    {
        [Key]
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public int CategoriaId { get; set; }

        [Range(minimum:1,maximum:200000000, ErrorMessage ="El rango de este campo debe ser mayor a 0.")]
        [Required(ErrorMessage="Este campo no puede estar vacio.")]
        public int UsuarioId { get; set; }

        [MinLength(4,ErrorMessage ="Este campo no puede tener menos de 4 caracteres.")]
        [MaxLength(30,ErrorMessage ="Ha alcanzado el maximo de caracteres.")]
        public string Nombre { get; set; }

       
        public Categorias()
        {
            CategoriaId = 0;
            UsuarioId = 0;
            Nombre = string.Empty;
           
        }
    }
}
