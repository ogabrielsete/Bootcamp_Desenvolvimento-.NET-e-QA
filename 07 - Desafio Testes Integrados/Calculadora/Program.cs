using Calculadora.Services;

CalculadoraImp c1 = new CalculadoraImp();

int n1 = 20;
int n2 = 30;

Console.WriteLine($"{n1} + {n2} = {c1.Somar(n1, n2)}");