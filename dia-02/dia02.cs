using System.ComponentModel;
using System.Data.Common;

public class Stock
{
    public List<Produto> Sotck = new List<Produto>();
}
public class Produto
{
    public string Name { get;  private set;}
    public double  Price { get; private set; }
    public int StockQuantity {get; private set;}
    public Produto( int stockQuantity_, double price_, string name_)
    {
        Name = name_;
        Price = price_;
        StockQuantity = stockQuantity_;
    }
}
public class dia02
{
    public static void Main()
    {
        // NEW OBJ PRODCUT 
        Stock stock = new Stock();
        string[] data = new string[3];

    try
    {
        
        Console.WriteLine("|---------------------------------------------------------");
        Console.WriteLine("|      ESTOQUE DE PRODUTOS DE VENDA ");
            Console.Write("*      COLOQUE O NOME DO PRODUTO: ");
        data[0] = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(data[0]))
        {
            Console.Write("#      ERRO: COLOQUE UM NUMERO VALIDO: ");
            data[0] = Console.ReadLine();
        }    
        

            Console.Write("*      COLOQUE O PRECO DO PRODUTO: ");
        data[1] = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(data[1]) || int.Parse(data[1]) <= 0)
        {
            Console.Write("#       ERRO: COLOQUE UM PRECO VALIDO: ");
            data[1] = Console.ReadLine();
        }    
        
    
        Console.Write("*      COLOQUE A QUANTIDE DE PRODUTOS EXISTENTES: ");

        data[2] = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(data[2]) || int.Parse(data[1]) <= 0)
        {
            Console.Write("#   ERRO: COLOQUE UMA QUANTIDADE VALIDA: ");
            data[2] = Console.ReadLine();
        }    
        
            Console.WriteLine("|______________ INFORMAÇÂO DO PRODUTO___________");
            Console.WriteLine("NOME: "+ data[0] +" VALOR UNITARIO: R$" + double.Parse(data[1])+ " QUANTIDADES DISPONIVEL NO STOCK: "+ double.Parse(data[2]));
            Console.Write("-    PRESSIONE A TECLA [S] PARA SALVAR O PRODUTO NO STOCK: ");
            stock.Sotck.Add(new Produto(1, 2.3, ""));
    }
     catch (Exception err)
        {
            Console.WriteLine("# ERRO: ERRO AO CADASTRA O PRODUTO: "+ err);
            Console.WriteLine("DIGITE S PARA SAIR OU PRESSIONE QUALQUER TECLA PARA CONTINUAR");
            string key = Console.ReadLine();
            if( key != "S" || key != "s") Main();
        }   
    }
}