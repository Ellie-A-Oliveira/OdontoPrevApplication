using System.ComponentModel.DataAnnotations;

namespace OdontoPrevApplication.Application.Dtos
{
    public class EnderecoDto
    {
        public int? Id { get; set; }

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
    }
}
