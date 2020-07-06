namespace Aula31
{
    public class Mensagem
    {
        public string texto;
        public Contato destinatario;

        public string Enviar(Contato contato){
            return $"O texto: '{texto}' foi enviado para o contato: {contato.Nome}";
        }
    }
}