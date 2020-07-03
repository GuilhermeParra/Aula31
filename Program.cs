using System;
using System.Collections.Generic;

namespace Aula31
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda contatinhos = new Agenda();

            Contato p1 = new Contato();

            
            p1.Nome = "Outro aleatório";
            p1.Telefone = "(54)5457-2135";

            

            contatinhos.Cadastrar(p1);

            

            

            contatinhos.Excluir("Linha");

            
            
            
            
    }
}
    }

