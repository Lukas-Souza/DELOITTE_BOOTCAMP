
// Metodos 
// Sacar 
// Depositar 
// Consultar 
//  Verificar 

using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
string? Key = "";
bool decition = true;
decimal _saldo;
string INTERFACE_STRING= "SELECIONE A SUA OPÇÂO: \n [0] SAIR: \n [1] DEPOSITAR VALOR: \n [2] SACAR VALOR: \n [3] VERIFICAR SALDO: \n [4] VERIFICAR NUMERO: \n [5] VERIFICAR LIMITE: ";


while (decition)
{
    Console.WriteLine(INTERFACE_STRING);
    Key =Console.ReadLine(); 
    CCInformation cCInformation = new CCInformation(false, "X-10055", 1000,100 );
switch (Key)
{
    case "0":
    decition = false;
    
    break;
    case "1":
    Console.Write("VALOR:");
    _saldo =decimal.Parse(Console.ReadLine());
    
    if (cCInformation.DepositarSaldo(_saldo))
    {
        Console.WriteLine("VALOR DEPOSITADO COM SUCESSO..");
    }
    else
    {
        Console.WriteLine("OCORREU UM ERRO NO DEPOSTIO...");
    }

    break;

   case "2":
     Console.Write("VALOR:");
    _saldo =decimal.Parse(Console.ReadLine());
    if (cCInformation.SacarValor(_saldo))
    {
        Console.WriteLine("VALOR SACADO COM SUCESSO...");
    }else{

        Console.WriteLine("OCORREU UM ERRO AO SACAR O VALOR...");                
    }
    break;

    case "3":
    Console.WriteLine("SALDO: "+ cCInformation.GetSaldo());
    break;

    
    case "4":
    Console.WriteLine("LIMITE: : "+ cCInformation.GetLimite());
    break;
    
    case "5":
    Console.WriteLine("NUMERO: "+ cCInformation.GetNUmber());
    break;

}   
}