using System.ComponentModel;
int size = 150;
int[] numeros = new int[size], ordenado = new int[size], inverso = new int[size] ;
int aux = 0, menor = 0, comparacao = 0;
bool imprime = true;

Console.WriteLine("");
for (int i = 0; i < size; i++)
{
    numeros[i] = new Random().Next(0,100);
    ordenado[i] = numeros[i];
    Console.Write(numeros[i] + " ");
}
Console.ReadLine();

for(int referencia = 0; referencia < size; referencia++)
{
    for (comparacao = referencia + 1; comparacao < (size); comparacao++)
    {
  
        if (ordenado[referencia] > ordenado[comparacao])
        {
            aux = ordenado[referencia];
            ordenado[referencia] = ordenado[comparacao];
            ordenado[comparacao] = aux;

        }
    }
}


Console.WriteLine("Numeros ordenados:");


for  (int referencia = 0;referencia < size ; referencia++)
{
    imprime = true;
    for (comparacao = referencia + 1; comparacao < size; comparacao++)
    {
        if (ordenado[referencia] == ordenado[comparacao])
        {
            comparacao = size;
            imprime = false;
        }
    }
    if (imprime == true)
    {
        Console.Write(ordenado[referencia] + " ");
    }
}

Console.WriteLine("Vetor invertido");
for (int i = 0; i < size; i++)
{
    inverso[i] = ordenado[i];
}

for (int referencia = 0; referencia < size; referencia++)
{
    for (comparacao = referencia + 1; comparacao < (size); comparacao++)
    {

        if (inverso[referencia] < inverso[comparacao])
        {
            aux = inverso[referencia];
            inverso[referencia] = inverso[comparacao];
            inverso[comparacao] = aux;

        }
    }
}

for (int i = 0; i < size; i++)
{
    Console.Write(inverso[i] + " ");
}