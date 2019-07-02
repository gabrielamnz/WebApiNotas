using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiNotas.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100,ErrorMessage ="O Título deve ter no máximo 100 caracteres.")]
        public string Titulo { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage ="O Body deve ter no máximo 200 caracteres.")]
        public string Body { get; set; }


    }
}