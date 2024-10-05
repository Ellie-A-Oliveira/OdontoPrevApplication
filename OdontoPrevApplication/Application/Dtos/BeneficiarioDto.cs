﻿using OdontoPrevApplication.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace OdontoPrevApplication.Application.Dtos
{
    public class BeneficiarioDto
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = $"Campo {nameof(Nome)} é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Campo deve ter no mínimo 2 caractéres")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Password)} é obrigatório")]
        [StringLength(200)]
        public required string Password { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Cpf)} é obrigatório")]
        [RegularExpression(@"^(?!.*(\d)(?:.*\1){2})\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Campo deve possuir o formato XXX.XXX.XXX-XX")]
        public required string Cpf { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Tipo)} é obrigatório")]
        public required TipoBeneficiarioEnum Tipo { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Telefone)} é obrigatório")]
        [RegularExpression(@"^(\+55\s ?)?(0?(\(?\d{2}\)?)?\s?\d{4,5}-?\d{4}$)")]
        public required string Telefone { get; set; }

        public string? FotoUrl { get; set; }

        public string? NumeroContrato { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Rua)} é obrigatório")]
        public required string Rua { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Numero)} é obrigatório")]
        public required int Numero { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Cidade)} é obrigatório")]
        public required string Cidade { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Estado)} é obrigatório")]
        public required string Estado { get; set; }

        [Required(ErrorMessage = $"Campo {nameof(Cep)} é obrigatório")]
        public required string Cep { get; set; }

        public string? Complemento { get; set; }

        public int? EmpresaContratanteId { get; set; }
    }
}
