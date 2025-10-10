using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GCook.Models;
[Table("Comentario")]
    public class Comentario
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Receita")]
        [Required(ErrorMessage = "A Receita é obrigatória")]
        public int ReceitaId { get; set; }
        [ForeignKey("ReceitaId")]
        [Display(Name = "Receita")]
        public Receita Receita { get; set; }

        [Display(Name = "Usuario")]
        [Required(ErrorMessage = "O Usuario é obrigatório")]
        public int UsuarioId { get; set; }
        [ForeignKey("UsuarioId")]
        [Display(Name = "Usuario")]
        public Usuario Usuario { get; set; }

        [Display(Name = "Data do Comentário")]
        [Required(ErrorMessage = "A Data é obrigatória")]
        public DateTime DataComentario { get; set; }
        [StringLength(300)]
        [Required(ErrorMessage = "O Texto é obrigatório")]
        public string TextoComentario { get; set; }
    }