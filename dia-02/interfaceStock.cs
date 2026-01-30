using System.Net.Http.Headers;
using System.Runtime.Serialization;
using ServicesCRUD;
using System.Security.AccessControl;
using Data;
public class interfaceStock
{
    

    
    
    public static void Main()
    {
        bool keyInput= true;
        string key_, nameProduct_;
        double price_;
        int stockQuantity_;
        Services services = new Services();

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
            Console.Write("* COLOQUE O NOME DO PRODUTO: ");
            nameProduct_ = Console.ReadLine();
            
            Console.Write("* COLOQUE O PRECO DO PRODUTO: ");
            price_ = double.Parse(Console.ReadLine());
            
            Console.Write("* COLOQUE A QUANTIDE DE PRODUTOS EXISTENTES: ");
            stockQuantity_ = int.Parse(Console.ReadLine());
            Console.WriteLine("|----------------------------------------------------------------");
            Console.WriteLine("/ NOME DO PRODUTO: "+ nameProduct_);
            Console.WriteLine("/ PRÇO DO PRODUTO: R$ " + price_);
            Console.WriteLine("/ QUANTIDADE EM STOCK PRODUTO: " +stockQuantity_);
            Console.WriteLine("*----------------------------------------------------------------------");
            Console.Write("/ DIGITE [S] PARA CADASTRA:");
            if(Console.ReadLine().ToUpper() == "S")
            {
            
                if(!services.CreateProductInList(stockQuantity_, price_, nameProduct_))
                {

                    Console.WriteLine("# ERRRO AO CADASTRAR O PRODUTO!");
                }
            else
            {
                Console.WriteLine("- PRODUTO ADICIONADO COM SUCESSO...");                    
            }} 

            break;
            case "D":
            Console.WriteLine("|---------------------------------------------------------------");
            Console.Write("/ QUAL È O NOME DO PRODUTO QUE VOCÊ DESEJA EXCLUIR: ");
            nameProduct_ = Console.ReadLine();
            if (!services.RemoveProductInList(nameProduct_))
            {
                Console.WriteLine("# OCORREU UM ERRO AO REMOVER O PRODUTO: ");
            }
            else
            {
                Console.WriteLine("|---------------------------------------------------------------\n");
                Console.WriteLine("- PRODUTO REMOVIDO COM SUCESSO...");
            }

            break;

            case "L":
                foreach (var item in services.stock.Sotck)
                {
                  Console.WriteLine("+ NAME: "+ item.Name+ " PRICE: "+item.Price +" QUANTIDADE DO STOCK: "+ item.StockQuantity);  
                }
            break;

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