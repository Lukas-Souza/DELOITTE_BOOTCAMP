using System.Runtime.Serialization;
using System.Security.AccessControl;
using Services;
public class interfaceStock
{
    
    public static void Main()
    {
        bool keyInput= true;
        string key_, nameProduct_;
        double price_;
        double stockQuantity_;
        CreateProductInList dhhdhd= new CreateProductInList

        try
        {
        do
        {
        Console.WriteLine("|-----------------------------------------------------------------");
        Console.WriteLine("| BEM VINDO AO SISTEMA DE ESTOQUE DE ARMAZENHAMENTOS DE PRODUTO:   ");
        key_ = Console.ReadLine().ToUpper();
        switch (key_)
        {
            case "C":
            Console.Write("*      COLOQUE O NOME DO PRODUTO: ");
            nameProduct_ = Console.ReadLine();
            
            Console.Write("*      COLOQUE O PRECO DO PRODUTO: ");
            price_ = double.Parse(Console.ReadLine());
            
            Console.Write("*      COLOQUE A QUANTIDE DE PRODUTOS EXISTENTES: ");
            stockQuantity_ = int.Parse(Console.ReadLine());
            Console.WriteLine("|----------------------------------------------------------------");
            Console.WriteLine("/ NOME DO PRODUTO: "+ nameProduct_);
            Console.WriteLine("/ PRÇO DO PRODUTO: R$ " + price_);
            Console.WriteLine("/ QUANTIDADE EM STOCK PRODUTO: " +stockQuantity_);
            Console.WriteLine("*----------------------------------------------------------------------");
            Console.Write("| DIGITE [S] PARA CADASTRA:");
            if(Console.ReadLine().ToUpper() == "S" ) ;
            break;

            
            case "D":
            break;

            case "L":


            default:
            Console.WriteLine("| OPCAO INVALIDA");
            break;

        }    
        }while(keyInput);
            
        }
        catch (System.Exception)
        {
            
            throw;
        }
    }
}