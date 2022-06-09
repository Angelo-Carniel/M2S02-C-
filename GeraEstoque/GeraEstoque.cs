namespace GeraEstoque;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
Seja bem vindo ao GeraEstoque 1.0
---------------------------------
1 Cadastrar produto
2 Consultar produto
3 Modificar produto
4 Excluir produto
0 Sair");
        
        Console.WriteLine("Digite a opção:");
        Console.ReadLine();
    }
}
