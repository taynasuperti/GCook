using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;
[Table("ReceitaIngrediente")]
    public class ReceitaIngrediente
    {
        [Key, Column(Order = 1)]
        [Display(Name = "Receita")]
        public int ReceitaId { get; set; }
        [ForeignKey("ReceitaId")]
        [Display(Name = "Receita")]
        public Receita Receita { get; set; }

        [Key, Column(Order = 2)]
        [Display(Name = "Ingrediente")]
        public int ReceitaId { get; set; }
        [ForeignKey("IngredienteId")]
        [Display(Name = "Ingrediente")]
        public Ingrediente Ingrediente { get; set; }

        [Required]
        [StringLength(30)]
        public string Quantidade { get; set; }
    }