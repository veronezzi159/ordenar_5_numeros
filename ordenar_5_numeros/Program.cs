int[] numeros = new int[5];
int aux = 0;

Console.WriteLine("Escreva 5 números inteiros");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Escreva o {i+1}º número");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0;i < 5; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (numeros[j] > numeros[j + 1])
        {
            aux = numeros[j + 1];
            numeros[j + 1] = numeros[j];
            numeros[j] = aux;
        }
    }
}
Console.WriteLine("Números Ordenados:");
for (int i = 0; i < 5 ; i++)
{
    Console.WriteLine(numeros[i]);
}