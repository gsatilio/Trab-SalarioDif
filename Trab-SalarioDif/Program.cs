//5 - faça um programa que leia o valor atual do salário de uma pessoa e o valor com acréscimo e informe a % de acréscimo que foi dada [(maior / menor) x 100 ]

double salario = 0, salariomaior = 0, calculo = 0;

while (salario <= 0)
{
    Console.WriteLine("Informe o valor do seu salário atual:");
    salario = double.Parse(Console.ReadLine());
}

while ((salariomaior <= 0))
{
    Console.WriteLine("Informe o valor do seu salário com valor acrescentado:");
    salariomaior = double.Parse(Console.ReadLine());
}

while ((salariomaior <= salario))
{
    Console.WriteLine("Informe o valor do seu salário com valor acrescentado (Precisa ser maior que o salário atual):");
    salariomaior = double.Parse(Console.ReadLine());
}

calculo = ((salariomaior / salario) * 100);

Console.WriteLine($"O aumento do salário foi de {calculo}%.");

Console.ReadKey();

