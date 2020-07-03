namespace Aula31
{
    public class Contato
    {

        public Contato(){
            
        }
        public Contato(string _nome, string _telefone){
            Nome = _nome;
            Telefone = _telefone;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }




    }
}