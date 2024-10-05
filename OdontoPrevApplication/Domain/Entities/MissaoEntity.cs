using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OdontoPrevApplication.Domain.Entities
{
    [Table("tb_missao")]
    public class MissaoEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DefaultValue(false)]
        public required bool Concluido { get; set; }

        public int RecompensaRecebida { get; set; }

        [Required]
        public required DateTime ExpiraEm { get; set; }

        [Required]
        [Key]
        [ForeignKey("tb_tipo_missao")]
        public required int TipoMissaoId { get; set; }

        public virtual TipoMissaoEntity? TipoMissao { get; set; }
    }
}
