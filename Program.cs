
// 1 - SOMA = 91
int indice = 13; 
int soma = 0; 
int k = 0;

while(k < indice)
{
    k = k + 1;
    soma = soma + k;
}

Console.WriteLine(soma);

// 2 - 
int numero = int.Parse(Console.ReadLine()!);
int a = 0;
int b = 1;

while(b < numero)
{
    int temporario = a;
    a = b;
    b = temporario + b;
}

if(b == numero)
{
    Console.WriteLine($"{numero} pertence a sequência de Fibonacci.");
}
else
{
    Console.WriteLine($"{numero} não pertence a sequência de Fibonacci.");
}

/* 3 - 
   a) 11
   b) 64
   c) 49
   d) 100
   e) 13
   f) 27
*/

/*  4 - 
    1º Ligaria o primeiro interruptor e esperaria 10min, depois o desligaria;
    2º Ligaria o segundo interruptor e logo depois o desligaria;
    3º Iria até uma das salas das lâmpadas e tocaria na lâmpada, 
       se estivesse quente seu interruptor equivalente seria o segundo, 
       se a lâmpada estivesse morna seria o interruptor 1, 
       e se estivesse fria seria o terceiro interruptor;
    4º Iria até outra sala e repetiria o mesmo processo do passo 3, descartando 
       o interruptor da qual exclui ser da primeira sala; 
    5º O interruptor que sobrasse seria o correspondente da terceira sala. */

// 5 - Escreva um programa que inverta os caracteres de um string.

string input = "Desafio Target";
char[] letrasString = input.ToCharArray();
int tamanhoString = letrasString.Length;

for(int i = 0; i < tamanhoString / 2; i++)
{
    char inverso = letrasString[i];
    letrasString[i] = letrasString[tamanhoString - 1 - i];
    letrasString[tamanhoString - 1 - i ] = inverso;
}

Console.WriteLine(letrasString);