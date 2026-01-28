using System.Data;

Console.WriteLine("|-----------------------------------------");
Console.WriteLine("|  ADICIONAR SEUS DADOS NO BANCO DE DADOS  ");
Console.Write("* INSIRA O SEU NOME PARA ADICIONAR: ");



string name,yearWold;

name = Console.ReadLine();      
while ( string.IsNullOrWhiteSpace(name) )
{
    Console.WriteLine("# ERRO: NOME INVALIDA");
    Console.Write("* INSIRA UM NOME CORRETO: ");
    name = Console.ReadLine() ;
}

Console.Write("* INSIRA A SUA IDADE: ");
yearWold = Console.ReadLine();
while (string.IsNullOrWhiteSpace(yearWold) || int.Parse(yearWold) <= 0)
{
    Console.WriteLine("# ERRO: IDADE INVALIDA");
    Console.Write("* INSIRA UM IDADE CORRETA: ");
    yearWold = Console.ReadLine();
}
Console.WriteLine("- SEU NOME È: "+ name);
Console.WriteLine("- SUA IDADE È: "+ yearWold);
Console.WriteLine("* DIGITE [S] PARA SALVAR OU APERTE QUALQUE TECLA PARA SALVAR OS DADOS");
char condition = char.Parse(Console.ReadLine());
if(condition == 'S' || condition == 's')
{
    Data data = new Data(name, int.Parse(yearWold));
    Console.WriteLine("* SUCESSO: DADOS ADICIONADOS COM SUCESSO...");
}
else
{
    Console.WriteLine("* PROCESSO FNALIZADO COM SUCESSO...");
}

 

