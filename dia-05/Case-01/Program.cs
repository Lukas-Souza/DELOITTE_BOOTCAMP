using System.Collections;
using DataVisitant;
using Service;

string Key= "";
bool condition = true;
ListService LService = new ListService();
string INTERFACE_MENU_STRING = "[0] ADICIONAR VISITANTE: \n [2] LISTA VISITANTE: \n [3] SAIDA USUARIO: \n [4] SAIR:";

do
{
    Console.WriteLine(INTERFACE_MENU_STRING);
    Key = Console.ReadLine();
    switch (Key)
    {
        case "0":
        Console.WriteLine("DIGITE O NOME DO CLIENTE: ");
        string name = Console.ReadLine();

        Console.WriteLine("INFORME OS DOCUMENTOS: ");
        string docs = Console.ReadLine();

        LService.AddUser(name, docs, DateTime.Now);
        Console.WriteLine(" CLIENTE ADICIONADO..");
        break;

        case "1":
        Console.WriteLine("QUAL O NOME DO CLIENTE: ");
        string nameCLient = Console.ReadLine();
        LService.ExitVisit(nameCLient);
        break;
        
        case "2":
        Console.WriteLine("_________________________LIST OR BY ID____________________________");
        foreach (var item in LService.Visitantes)
        {
            string montCondition = 
            "\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "| ID: " + item.ID +
                "\n| NAME: " + item.Name +
                "\n| DOCUMENTS: " + item.Documents +
                "\n| DATA VISIT: " + item.DataVisit.ToString("dd/MM/yyyy") +
                "\n| IS VISIT PRIMARY: " + item.isVisitPrimary +
                "\n| IS HOSPED: " + item.isHosped;
            Console.WriteLine(montCondition);
        }
        Console.WriteLine("__________________________________________________________________\n");

        break;
        
        case "3":
        Console.Write("NOME DO CLIENT:");
        string nameClient = Console.ReadLine();
        Console.WriteLine("SAIDA REALIZADA COM SUCESSO..");
        LService.ExitVisit(nameClient);
        break;


        case "5":
        condition = false;
        break;
        
        default:

        break;
    }
}while (true);
