using System.ComponentModel.DataAnnotations;

namespace Parcial2_BoteroAgudeloJessicaMaria.DAL.Entities
{
    public class Entity
    {
        [Required]
        public Guid Id { get; set; } //PK (Dato obligatorio)

        [Display(Name = "Fecha de creación")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Fecha de Modificación")]
        public DateTime? ModifiedDate { get; set; }

       

    }
}
