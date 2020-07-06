namespace Aula31
{
    public class Mensagem
    {
        public string Texto;
        public Contato Destinatario;

        public string Enviar(Contato contato){
            return $"O texto: '{Texto}' foi enviado para o contato: {contato.Nome}";
        }
    }
}