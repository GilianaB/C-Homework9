Console.WriteLine("выберите задание");
Console.WriteLine("цифра 1 - задача 54");
Console.WriteLine("цифра 2 -задача 56");
Console.WriteLine("цифра 3 -задача 58");
Console.WriteLine("цифра 4 -задача 60");
Console.WriteLine("цифра 5 -задача 62");
int n = Convert.ToInt32(Console.ReadLine());

switch(n)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break;
    case 3:
        task3();
        break;
    case 4:
        task4();
        break;
    case 5:
        task5();
        break;
    default:
        break;
}

void task1()
{
Console.WriteLine("Введите m и n");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int [m,n];
int [,] arraynew = new int[m,n];
int [] array = new int [n];
Random random = new Random();
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=random.Next (-10,10);
        Console.Write(array2d[i,j]+" ");
        array[j]=array2d[i,j];
    }
    Console.WriteLine();
    Array.Sort(array);Array.Reverse(array);
    for (int j = 0; j <array.Length; j++)
    {
        arraynew[i,j]=array[j];
    }
} 
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(arraynew[i,j]+" ");    
    }
    Console.WriteLine();
}
}

void task2()
{
Console.WriteLine("Введите m и n");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int [m,n];
Random random = new Random();
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=random.Next (-10,10);
        Console.Write(array2d[i,j]+" ");
    }
    Console.WriteLine();
}
int min = n*10;
int row=0;
for (int i = 0; i < array2d.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        sum = sum + array2d[i, j];        
    }
    if (sum < min)
    {
        min = sum;
        row++;
    }
}

Console.WriteLine("строка с наименьшей суммой " +row+ " ");
}

void task3()
{
Console.WriteLine("Введите m и n первой матрицы");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x и y второй матрицы");
int x= Convert.ToInt32(Console.ReadLine());
int y= Convert.ToInt32(Console.ReadLine());

int [,] arrayfirst = new int [m,n];
int [,] arraysecond = new int [x,y];
Random random = new Random();
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        arrayfirst[i,j]=random.Next (-10,10);
        Console.Write(arrayfirst[i,j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i=0; i<x;i++)
{
    for (int j=0; j<y; j++)
    {
        arraysecond[i,j]=random.Next (-10,10);
        Console.Write(arraysecond[i,j]+" ");
    }
    Console.WriteLine();
}
int [,] arraynew = new int[arrayfirst.GetLength(0),arraysecond.GetLength(1)];
for (int i = 0; i < arrayfirst.GetLength(0); i++)
{
    for (int j = 0; j < arraysecond.GetLength(1); j++)
    {
        for (int k = 0; k < arraysecond.GetLength(1); k++)
        {
            arraynew[i,j] += arrayfirst[i,k] * arraysecond[k,j];
        }
    }
}
Console.WriteLine();

for (int i = 0; i < arraynew.GetLength(0); i++)
{
    for (int j = 0; j < arraynew.GetLength(1); j++)
    {
        Console.Write(arraynew[i,j]+" ");
    }Console.WriteLine();
}
}

void task4()
{
Console.WriteLine("Введите размеры матрицы");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
int k= Convert.ToInt32(Console.ReadLine());


int [,,] array3d = new int [m,n,k];

Random random = new Random();
for (int i=0; i<m;i++)
{
    for (int j=0; j<n; j++)
    {
        for (int l=0; l<k; l++)
        {
        array3d[i,j,l]=random.Next (10,100);
        Console.Write(array3d[i,j,l]+"("+i+","+j+","+l+")"+" ");
        }
    }
    Console.WriteLine();
}

}

void task5()
{
int[,] array = new int[4, 4];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= 16)
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < array.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= array.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > array.GetLength(1) - 1)
    j--;
  else
    i--;
}


PrintArray(array);
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           Console.Write(array[i, j] + " ");
                      
        }
        Console.WriteLine();
    }
}
}