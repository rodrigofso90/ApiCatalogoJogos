using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ApiCatalogoJogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base("Este Jogo Já foi Cadastrado.")
            { }
    }
}