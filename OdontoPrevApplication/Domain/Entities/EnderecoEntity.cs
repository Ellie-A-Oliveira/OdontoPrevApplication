﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdontoPrevApplication.Domain.Entities
{
    [Table("tb_endereco")]
    public class EnderecoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public required string Rua { get; set; }

        [Required]
        public required int Numero { get; set; }

        [Required]
        [StringLength(200)]
        public required string Cidade { get; set; }

        [Required]
        [RegularExpression(@"^\d{5}-\d{3}$")]
        public required string Estado { get; set; }

        [Required]
        [StringLength(200)]
        public required string Cep { get; set; }

        public string? Complemento { get; set; }
    }
}
