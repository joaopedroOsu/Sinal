int zero;
Console.WriteLine("Digite um número: ");
int numeropositivo = Convert.ToInt32(Console.ReadLine());

if (numeropositivo >0)
{
    Console.WriteLine("Positivo");
}
else if (numeropositivo <0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("zero");
}
