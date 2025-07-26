int numero = 5;

for (int contador = 0; contador <= 5; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}


int contador2 = 0;
while (contador2 <= 5)
{
    Console.WriteLine($"{numero} x {contador2} = {numero * contador2}");
    contador2++;
}

contador2 = 0;
while (contador2 <= 5)
{
    Console.WriteLine($"{numero} x {contador2} = {numero * contador2}");
    contador2++;
    if (contador2 == 6)
    {
        break;
    }
}



int soma=0, numero2 = 0;
do
{
    Console.WriteLine("Digite um numero (0 para parar)");
    numero2 = Convert.ToInt32(Console.ReadLine());

    soma += numero2;

} while (numero2 != 0);
