ExibirTitulo();

Console.Write("Informe um número:");
int numero = Convert.ToInt32(Console.ReadLine());

bool ehPar = DefinirPar(numero);

ExibirResultado();

void ExibirTitulo()
{   
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("------------------");
    Console.WriteLine("--- Par ou ímpar");
    Console.WriteLine("-----------------------\n");
    Console.ResetColor();
}

void ExibirResultado()
{
    Console.WriteLine($"O número {numero} é {(ehPar ? "Par" : "Ímpar")}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("--------------------");
    Console.WriteLine("---Você Venceu---");
    Console.WriteLine("-------------------");
}

bool DefinirPar (int numero)
{
    bool ehPar = numero % 2 == 0;
    return ehPar;

}
