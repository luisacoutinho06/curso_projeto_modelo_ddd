using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "Preencha o campo: Nome!")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Preencha o campo: Sobrenome!")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Sobrenome { get; set; }


        [Required(ErrorMessage = "Preencha o campo: E-mail!")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um e-mail válido!")]
        [DisplayName("E-mail")]
        public string Email { get; set; }


        [ScaffoldColumn(false)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}