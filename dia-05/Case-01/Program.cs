using System.Collections;
using DataVisitant;
using Service;

// VARIABLE
string Key= "";
bool condition = true;
ListService LService = new ListService();
string? docs, name, nameClient;

// VARIABLE INTERFACE
string[] INTEFACE_MENU = 
{
    "| [0] ADICIONAR VISITANTE: \n| [1] SAIDA USUARIO: \n| [2] LISTA VISITANTE: \n| [3] SAIR:",
    "| OPÇÂO INVALIDA",
    "| OPERAÇÂO REALIZADA COM SUCESSO...",
    "| NÂO FOI POSSIVEL REALIZAR ESSA OPERAÇÂO !!!",
    "------------------------------------------------------------------\n",
    "_________________________LIST OR BY ID____________________________\n",
    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n"
};


do
{
    Console.WriteLine(INTEFACE_MENU[0]);
    Key = Console.ReadLine();
    switch (Key)
    {
        case "0":
        Console.WriteLine(INTEFACE_MENU[4]);
        Console.WriteLine("DIGITE O NOME DO CLIENTE: ");
        name = Console.ReadLine();

        Console.WriteLine("INFORME OS DOCUMENTOS: ");
        docs = Console.ReadLine();

        LService.AddUser(name, docs);
        Console.WriteLine(INTEFACE_MENU[2]);
        Console.WriteLine(INTEFACE_MENU[4]);
        break;

        case "1":
        Console.WriteLine(INTEFACE_MENU[5]);
        Console.Write("NOME DO CLIENT:");
        try
        {
         
        nameClient = Console.ReadLine();
        Console.WriteLine(INTEFACE_MENU[2]);
        Console.WriteLine(INTEFACE_MENU[4]);
        LService.ExitVisit(nameClient);   
        }
        catch (System.Exception err)
        {
            
            throw new ArgumentException(INTEFACE_MENU[3]+": "+ err);
        }
        break;


        break;
        
        case "2":
   
        Console.WriteLine(INTEFACE_MENU[5]);

        foreach (var item in LService.GetListOrdById())
        {
            string montCondition = 
                INTEFACE_MENU[6]+
                "| ID: " + item.ID +
                "\n| NAME: " + item.Name +
                "\n| DOCUMENTS: " + item.Documents +
                "\n| DATA VISIT: " + item.DataVisit.ToString("dd/MM/yyyy") +
                "\n| IS VISIT PRIMARY: " + item.isVisitPrimary +
                "\n| IS HOSPED: " + item.isHosped;

            Console.WriteLine(montCondition);
            Console.WriteLine(INTEFACE_MENU[6]);

        }
     Console.WriteLine(INTEFACE_MENU[4]);
        break;
        
        case "3":
          condition = false;
        break;
       
        default:
        Console.WriteLine("OPÇÂO INALIDA ...");
        break;
    }
}while (condition);
