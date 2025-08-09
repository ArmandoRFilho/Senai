using Controle_cliente;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informar Nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informar endereco: ");
string endereco = Console.ReadLine();

Console.WriteLine("Pessoa Fisica(f) ou juridica (j)?: ");
string tipo = Console.ReadLine();

if (tipo == "f") {

    PessoaFisica pf = new PessoaFisica() {

        nome = nome,
        endereco = endereco,
    };

    Console.WriteLine("Informe o CPF: ");
    pf.cpf = Console.ReadLine();

    Console.WriteLine("Informe o RG: ");
    pf.rg = Console.ReadLine();

    Console.WriteLine("Informe o valor de compra: ");
    float valor = float.Parse(Console.ReadLine());

    pf.PagarImposto(valor);

    Console.WriteLine("---------------------Pessoa Fisica-------------------");
    Console.WriteLine("Nome: " + pf.nome);
    Console.WriteLine("endereco: " + pf.endereco);
    Console.WriteLine("CPF: " + pf.cpf);
    Console.WriteLine("RG: " + pf.rg);
    Console.WriteLine("Valor da Compra: " + pf.valor.ToString("C"));
    Console.WriteLine("Imposto: " + pf.valorImposto);
    Console.WriteLine("Total a pagar: " + pf.total.ToString("C"));
}
else if (tipo == "j")
{

    PessoaJuridica pj = new PessoaJuridica()
    {
        nome = nome,
        endereco = endereco,
    };

    Console.WriteLine("Informe o CNPJ: ");
    pj.cnpj = Console.ReadLine();

    Console.WriteLine("Informe o IE: ");
    pj.ie = Console.ReadLine();

    Console.WriteLine("Informe o valor de compra: ");
    float valor = float.Parse(Console.ReadLine());

    pj.PagarImposto(valor);

    Console.WriteLine("---------------------Pessoa Juridica-------------------");
    Console.WriteLine("Nome: " + pj.nome);
    Console.WriteLine("endereco: " + pj.endereco);
    Console.WriteLine("CNPJ: " + pj.cnpj);
    Console.WriteLine("Ie: " + pj.ie);
    Console.WriteLine("Valor da Compra: " + pj.valor.ToString("C"));
    Console.WriteLine("Imposto: " + pj.valorImposto);
    Console.WriteLine("Total a pagar: " + pj.total.ToString("C"));
}
