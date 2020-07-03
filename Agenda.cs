using System.Collections.Generic;
using System.IO;

namespace Aula31
{
    public class Agenda : lAgenda
    {
        List<Contato> contatos = new List<Contato>();
        public const string PATH = "Database/Produto.csv";

        

        public Agenda(){
            string Pasta = PATH.Split('/')[0];
            if(!Directory.Exists(Pasta)){
                Directory.CreateDirectory(Pasta);
            }

            //Cria o arquivo, caso nao exista
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }

        }
        
        
        
        public void Cadastrar(Contato Contato){
            var linha = new string[] {PrepararLinhaCSV(Contato)};
                File.AppendAllLines(PATH, linha);

        }
        

        public void Excluir(string Contato)
        {
            //Criando uma lista de string para salvar as linhas do csv
            List<string> linhas = new List<string>();

            //Utilizando o using para abrir e fechar o arquivo com a base de dados
            using(StreamReader file = new StreamReader(PATH)){
                //Lendo o arquivo
                string line;
                while ((line = file.ReadLine())!= null){
                    linhas.Add(line);
                }
                //Removendo todas as linhas que tenha o termo
                linhas.RemoveAll(l => l.Contains(Contato));
            }
            //Reescrevendo o arquivo
            using (StreamWriter output = new StreamWriter(PATH)){
                foreach(string ln in linhas){
                output.Write(ln + "\n");
                }
            }
        }

        public void Listar()
        {
            List<string> linhas = new List<string>();

            //Utilizando o using para abrir e fechar o arquivo com a base de dados
            using(StreamReader file = new StreamReader(PATH)){
                //Lendo o arquivo
                string line;
                while ((line = file.ReadLine())!= null){
                    linhas.Add(line);
        }
            }
        }
        private string PrepararLinhaCSV(Contato conta)
        {
            return $"O Nome do seu contato é: {conta.Nome} e o número de seu contato é: {conta.Telefone}";
        }
        
    }
}