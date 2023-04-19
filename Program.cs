//if-switch/case-do/while-for/foreach
// static string Senha(string senha)
string senha;
bool autenticado = false;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine(@$"
                                                                         --------------------------------------
                                                                         | Olá, seja bem-vindo à GabAviations |
                                                                         |                                    |
                                                                         | Antes de começarmos informe        |
                                                                         | a sua senha:                       |
                                                                         --------------------------------------
");
Console.ResetColor();
do
{
    senha = Console.ReadLine();
    if (senha == "GustavoLanches")
    {
        autenticado = true;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Agora prossiga com as seguintes informações: ");
        Console.ResetColor();
    }

    else
    {
        autenticado = false;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Digite a senha novamente: ");
        Console.ResetColor();
    }
} while (!autenticado);

int opcao;

Console.WriteLine(@$"
-------------------------
| [1]- Cadastrar passagem |
| [2]- Listar Passagens   |
| [0]- Sair               |
-------------------------
");
opcao = int.Parse(Console.ReadLine());



switch (opcao)
{

    case '1':
        string[] nome = new string[5];
        string[] origem = new string[5];
        string[] destino = new string[5];
        string[] dataDoVoo = new string[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Informe o nome do {i + 1}º Passageiro: ");
            nome[i] = Console.ReadLine().ToLower();

            Console.WriteLine($"Informe a origem do {i + 1}º Passageiro: ");
            origem[i] = Console.ReadLine().ToLower();

            Console.WriteLine($"Informe o destino da {i + 1}º Passageiro: ");
            destino[i] = Console.ReadLine().ToLower();

            Console.WriteLine($"Informe a data do voo do {i + 1}º Passageiro: ");
            dataDoVoo[i] = Console.ReadLine();
        }
        break;

    case '2':
        Console.WriteLine($"As informações apresentadas foram: ");
        for (var i = 0; i < 5; i++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@$"
                                                                         --------------------------------------
                                                                          {i + 1}º passageiro:                     
                                                                            nome: {nome[i]}                       
                                                                            origem: {origem[i]}              
                                                                            destino: {destino[i]}            
                                                                            data do voo: {dataDoVoo[i]}          
                                                                         --------------------------------------
    ");
        }
        break;

    case '0':
    Console.WriteLine($"Saindo do programa...........");
    break;
    default:
    Console.WriteLine($"Opção inválida, tente novamente");
    break;
}
/// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////