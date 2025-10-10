using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GCook.Models;

[Table("Receita")]
    public class Receita
    {
        [Key]
        public int Id { get; set; }

        //adicionar a fk da categoria
        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "A Categoria é obrigatória")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        [Display(Name = "Categoria")]

        public Categoria Categoria { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "O Nome da Receita é obrigatório")]
        public string Nome { get; set; }

        [StringLength(1000)]
        [Required(ErrorMessage = "A Descrição da Receita é obrigatória")]
        public string Descricao { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "O Tempo de Preparo da Receita é obrigatório")]
        public string TempoPreparo { get; set; }

        //não tenho certeza se assim tá certo
        public int Rendimento { get; set; }

        public Dificuldade Dificuldade { get; set; }

        //adicionar a fk da dificuldade

        [StringLength(300)]
        public string Foto { get; set; }

        [StringLength(8000)]
        [Required(ErrorMessage = "O Modo de Preparo da receita é obrigatório")]
        public string Preparo { get; set; }
    }