using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GCook.Models;
[Table("Usuario")]
    public class Usuario
    {
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [DataType(DataType.Date)]

        public DateTime? DataNascimento { get; set; }

        [StringLength(30)]
        public string Foto { get; set; }
    }