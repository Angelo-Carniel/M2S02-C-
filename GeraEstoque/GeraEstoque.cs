namespace GeraEstoque;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ShowOptions();
        var option = short.Parse(Console.ReadLine());

        switch(option)
        {
            case 1: CadastrarProduto(); break;
            case 2: break;
            case 3: break;
            case 4: break;
            case 0:
            {
                Console.Clear();
            } break;
        }
    }

    static void ShowOptions()
    {
        Console.SetCursorPosition(1,2);
        Console.WriteLine("Seja bem vindo ao GeraEstoque v0.1");
        Console.SetCursorPosition(1,3);
        Console.WriteLine("===================================");

        Console.SetCursorPosition(1,4);
        Console.WriteLine("1 - Cadastrar produto");
        Console.SetCursorPosition(1,5);
        Console.WriteLine("2 - Consultar produto");
        Console.SetCursorPosition(1,6);
        Console.WriteLine("3 - Modificar produto");
        Console.SetCursorPosition(1,7);
        Console.WriteLine("4 - Excluir produto");
        Console.SetCursorPosition(1,8);
        Console.WriteLine("0 - Sair");

        Console.SetCursorPosition(1,9);
        Console.WriteLine("Opção selecionada");
        Console.SetCursorPosition(1,9);
        Console.WriteLine("Opção selecionada: ");
    }

    static void CadastrarProduto()
    {
        string descricao;
        int quantidade;
        double valorCompra;
        double valorVenda;
        char continua = 's';

        do{

            Console.WriteLine("___Comanda___");

            Console.WriteLine("Insira a descrição do produto:");
            descricao = Console.ReadLine();
            
            Console.WriteLine("Insira a quantidade:");
            quantidade = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("insira o valor de compra:");
            valorCompra = double.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor de venda:");
            valorVenda = double.Parse(Console.ReadLine());

            Console.WriteLine("Deseja continuar? (s/n)");
            continua = Convert.ToChar(Console.ReadLine());

            //p0.addItem(descricao, quantidade, valor);

            }while (continua == 's');

            //Console.WriteLine("Total: " + p0.TotalPedido())

    }
}
