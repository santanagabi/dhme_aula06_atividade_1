// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.Write("Qual seu nome? ");
string nomeDoUsuario = Console.ReadLine();
Console.Write("Qual sua idade? ");
int idadeDoUsuario = Convert.ToInt32(Console.ReadLine());
Console.Write("Qual o ano atual? ");
int anoAtual = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Olá " + nomeDoUsuario + ", você nasceu em " + (anoAtual - idadeDoUsuario));
