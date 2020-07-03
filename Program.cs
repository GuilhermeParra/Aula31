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

            
            p1.Nome = "Chris";
            p1.Telefone = "(54)6878-2135";
            
            Mensagem SMS = new Mensagem();
            SMS.Texto = "Salve quebrada";
            SMS.Destinatario = p1;



            contatinhos.Cadastrar(p1);

            contatinhos.Excluir("Linha");

            Console.WriteLine(SMS.Enviar(SMS.Destinatario));
            
            
            
            
    }
}
    }

