int[] numeros = new int[5], ordenado = new int[5];
int aux = 0, menor = 0, j = 0, maior = 0;

Console.WriteLine("Escreva 5 números inteiros positivos");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Escreva o {i+1}º número");
    numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    ordenado[i] = numeros[i];
}

for(int i = 0; i < 5; i++)
{
    for (j = i + 1; j < 5; j++)
    {
        if (ordenado[i] > ordenado[j])
        {
            aux = ordenado[j];
            ordenado[j] = ordenado[i];
            ordenado[i] = aux;
        }
    }
}

Console.WriteLine("Numeros ordenados:");
for (int i = 0; i < 5 ; i++)
{
    Console.WriteLine(ordenado[i]);
}