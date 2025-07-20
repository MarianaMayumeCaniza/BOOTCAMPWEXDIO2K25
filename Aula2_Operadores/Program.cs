int a = 10;
int b = 20;

int c = a + b;

Console.WriteLine(c);

c += 5;
Console.WriteLine(c);


//Conversão de tipos - Cast/Casting

int d = Convert.ToInt32 ("5");
Console.WriteLine(d);


//int e = int.Parse("5c");
//Console.WriteLine(e);


Console.WriteLine(Convert.ToInt32(null));
//Console.WriteLine(int.Parse(null));

int inteiro = 5;
string f = inteiro.ToString();
Console.WriteLine(f);


//casting implicito
int g = 5;
double h = a;
Console.WriteLine(h);

//Erro
long i = 5;
int j = i;
int l = Convert.ToInt32(i);
Console.WriteLine(l);

//Convertendo de forma segura
int.tryParse("5c", out int m);
Console.WriteLine(m);
Console.WriteLine("Conversão com sucesso");