//Some as entradas até que o resultado seja solicitado (digitando zero)


int soma = 0;
int numero = 0;
do 
{
    Console.Write("Digite um número para somar. Quando quiser conferir o resultado, digite 0: ");
    if (int.TryParse(Console.ReadLine(), out numero) == false)
    {
        Console.WriteLine("Digite um número válido");
        return;
    }
    else
    {
        soma += numero;
    }
} 
while (numero != 0);

Console.WriteLine($"O resultado da soma é: {soma}");