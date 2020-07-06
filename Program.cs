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
            Contato p2 = new Contato();
            Contato p3 = new Contato();
            Contato p4 = new Contato();

            

            
            
            p1.Nome = "Chris";
            p1.Telefone = "(54)6878-2135";

            p2.Nome = "Sara";
            p2.Telefone = "(54)5953-2135";

            p3.Nome = "Alexa";
            p3.Telefone = "(54)6226-2135";

            p4.Nome = "Rodolfo";
            p4.Telefone = "(54)2315-2135";


            
            Mensagem SMS = new Mensagem();
            SMS.texto = "Salve quebrada";
            SMS.destinatario = p1;
            
            



            contatinhos.Cadastrar(p1);
            contatinhos.Cadastrar(p2);
            contatinhos.Cadastrar(p3);
            contatinhos.Cadastrar(p4);

            contatinhos.Excluir("Chris");

            Console.WriteLine(SMS.Enviar(SMS.destinatario));

            
            
            
            
            
    }
}
    }

