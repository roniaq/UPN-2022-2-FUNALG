//int dividendo = 2;
//int divisor = 1;
//int divisiones = 0;
//while (dividendo <= 100)
//{
//    while (dividendo <= 100)
//    {
//        while (divisor <= dividendo)
//        {
//            if (dividendo % divisor == 0)
//            {
//                divisiones++;
//            }
//            divisor++;
//        }
//        if (divisiones == 2)
//        {
//            Console.WriteLine(dividendo);
//        }
//        dividendo++;
//        divisor = 1;
//        divisiones = 0;
//    }
//}

/*1. Diseñar un programa para imprimir todos

     los números primos entre 2 y 100 inclusive.*/
//-------------------------------------
//int cont = 0;
//for (int num = 2; num <= 100; num++)
//{
//    for (int num2 = 1; num2 <= num; num2++)
//    {
//        if (num % num2 == 0)
//        {                        cont = cont + 1;

//        }
//            }
//    if (cont <= 2)
//    {
//        Console.WriteLine(num);
//    }
//    cont = 0;
//}
//Console.ReadKey();

//------------------------

bool esPrimo;
int n = 100;
string primos = "";
for (int x = 2; x <= n; x++)
{
    esPrimo = true;
    for (int y = 2; y < x; y++)
    {
        if (x % y == 0)
        {
            esPrimo = false;
            break;
        }
    }
    if (esPrimo) primos += x + "-";
}
Console.WriteLine("Los numeros primos son: " + primos);
Console.ReadKey();
