using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo: Nome!")]
        [MaxLength(250, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999999999")]
        [Required(ErrorMessage = "Preencha um valor!")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o campo: Cliente!")]
        public int ClienteId { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

    }
}