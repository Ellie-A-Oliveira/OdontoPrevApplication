using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdontoPrevApplication.Domain.Entities
{
    [Table("tb_servico")]
    public class ServicoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public double ValorPago { get; set; }

        [Required]
        [Key]
        [ForeignKey("tb_tipo_servico")]
        public required int TipoServicoId { get; set; }

        [Required]
        [Key]
        [ForeignKey("tb_sinistro")]
        public required int SinistroId { get; set; }

        public virtual TipoServicoEntity? TipoServicoEntity { get; set; }
        public virtual SinistroEntity? Sinistro { get; set; }
    }
}
