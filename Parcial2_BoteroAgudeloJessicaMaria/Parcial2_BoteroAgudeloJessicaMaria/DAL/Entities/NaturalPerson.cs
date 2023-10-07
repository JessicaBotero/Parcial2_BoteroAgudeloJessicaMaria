﻿using System.ComponentModel.DataAnnotations;

namespace Parcial2_BoteroAgudeloJessicaMaria.DAL.Entities
{
    public class NaturalPerson : Entity
    {
        [Required] // Indicamos que es un campo requerido
        [Display(Name ="Nombre completo")]
        [MaxLength(50, ErrorMessage="El campo {0} debe tener máximo {1} caracteres")] // Límitamos el # de caracteres ingresados por el usuario
        public string FullName { get; set; }



        [Display(Name = "Correo Electrónico")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
        public string Email { get; set; }



        [Display(Name = "Fecha de cumpleaños")]
        public int BirthYear { get; set; }



        [Display(Name = "Edad")]
        public int Age { get; set;}
    }
}
