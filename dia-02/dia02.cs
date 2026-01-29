using Data;
public class dia02
{
    public static void Dia02()
    {
        // NEW OBJ PRODCUT 

        string[] data = new string[3];
        string KEY;
    try
    {
        
        Console.WriteLine("|---------------------------------------------------------");
        Console.WriteLine("|      ESTOQUE DE PRODUTOS DE VENDA ");
            Console.Write("*      COLOQUE O NOME DO PRODUTO: ");
        data[0] = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(data[0]))
        {
            Console.Write("#      ERRO: COLOQUE UM NOME VALIDO: ");
            data[0] = Console.ReadLine();
        }    
        

       
        data[1] = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(data[1]) || int.Parse(data[1]) <= 0)
        {
            Console.Write("#       ERRO: COLOQUE UM PRECO VALIDO: ");
            data[1] = Console.ReadLine();
        }    
        
    // ARRAYLIST[i].NOME 

      

        data[2] = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(data[2]) || int.Parse(data[2]) <= 0)
        {
            Console.Write("#   ERRO: COLOQUE UMA QUANTIDADE VALIDA: ");
            data[2] = Console.ReadLine();
        }    
        
            Console.WriteLine("|______________ INFORMAÇÂO DO PRODUTO___________");
            Console.WriteLine("NOME: "+ data[0] +" VALOR UNITARIO: R$ " + double.Parse(data[1])+ " QUANTIDADES DISPONIVEL NO STOCK: "+ int.Parse(data[2]));
            Console.Write("-    PRESSIONE A TECLA [S] PARA SALVAR O PRODUTO NO STOCK: ");
            KEY = Console.ReadLine();
            
            if(KEY == "S") ; 
    }
     catch (Exception err)
        {
            Console.WriteLine("# ERRO: ERRO AO CADASTRA O PRODUTO: "+ err);
            Console.WriteLine("DIGITE [S] PARA SAIR OU PRESSIONE QUALQUER TECLA PARA CONTINUAR");
            string? key = Console.ReadLine();
            if( key != "S" || key != "s") Dia02();
        }   
    }
}