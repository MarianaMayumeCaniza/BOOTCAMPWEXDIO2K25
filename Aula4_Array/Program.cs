int[] arrayInteiros = new int[3];
arrayInteiros[0] = 1;
arrayInteiros[1] = 2;
arrayInteiros[2] = 3;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");
}

//ForEach
contadorForeach = 0;
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº{contadorForach} - {valor}");
    contadorForeach++;
}

//Redimensionar o array 

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


//Copiando elementos

int[] arrayInteiros2 = new int[arrayInteiros];
Array.Copy(arrayInteiros, arrayInteiros2, arrayInteiros.Length);

//Listas
List<String> listaString = new List<String>();
listaString.Add("Item 1");
listaString.Add("Item 2");
listaString.Add("Item 3");

Console.WriteLine("Percorrendo a lista com For");
for (int cont = 0; cont < listaString.Count; cont++)
{
    Console.WriteLine($"Posição Nº {cont} - {listaString[cont]}");
}

Console.WriteLine("Percorrendo a lista com um Foreach");
int contForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº {contForeach} - {item}");
    contForeach++;
}

listaString.Remove("Item 1");
Console.WriteLine("Percorrendo a lista com For");
for (int cont = 0; cont < listaString.Count; cont++)
{
    Console.WriteLine($"Posição Nº {cont} - {listaString[cont]}");
}