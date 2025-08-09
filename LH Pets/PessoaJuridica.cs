namespace Controle_cliente
{
    public class PessoaJuridica : Clientes
    {
        
        public string cnpj { get; set;}
        public string ie { get; set;}
        public override void PagarImposto(float v)
        {

        }
    }
}