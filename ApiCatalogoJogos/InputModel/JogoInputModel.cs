using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome do Jogo deve conter entre 3 a 100 caracteres.")]
        
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O Nome do Jogo deve conter entre 3 a 100 caracteres3")]

        public string Produtora{ get; set; }
        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser no mínimo R$: 1,00 e no máximo R$1.000,00.")]

        public double Preco { get; set; }

    }
}