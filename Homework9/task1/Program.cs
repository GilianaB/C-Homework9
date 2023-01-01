Console.WriteLine("выберите задание");
Console.WriteLine("цифра 1 - задача 66");
Console.WriteLine("цифра 2 -задача 68");
int n = Convert.ToInt32(Console.ReadLine());

switch(n)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break;
    default:
        break;
}

void task1()
{
Console.WriteLine("Введите m и n");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
Sum(m,n);
Console.WriteLine(Sum(m-1,n));

int Sum(int m,int n)
{
	int x=m;
    if (m==n)
    return 0;
    m++;
    x=m+Sum(m,n);    
    return x;
}
}


void task2()
{
Console.WriteLine("Введите m и n");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
Function(m,n);
Console.WriteLine(Function(m,n));

int Function(int m, int n)
{
    if (m == 0)
    return n + 1;
    else if (n == 0 && m > 0)
        return Function (m - 1, 1);
        else
        return (Function (m - 1, Function (m, n - 1)));
}
}