

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
//O int não consegue converter para double

double altura = 1.80;

//Valor monetario
decimal preco = 1.80M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("O valor da varaivel quantidade é: "+quantidade);
Console.WriteLine("O valor da variavel altura é: " + altura.ToString("0.00"));
Console.WriteLine("O valor da variavel preco é: " + preco);
Console.WriteLine("O valor da variavel condicao é: " + condicao);


DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine("A data atual é: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));