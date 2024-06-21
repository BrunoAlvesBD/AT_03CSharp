using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT_03CS
{
    //interface que implementa metodos nas subclasses livro e revista
    internal interface IEmprestavel
    {
        public void verificarDisponibilidade();

        public void obterPrazoDeDevolução();
    }
}
