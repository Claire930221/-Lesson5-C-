/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

//получить размерность массива с консоли
int GetNumber(string message)
{
int result;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 0)
{
break;
}
else
{
Console.WriteLine("Ввели не число. Введите корректное число");
}
}
return result;
}

//получить заполненный массив рандомными числами
double[] InitArray(int dimension)
{
double[] array = new double[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
array[i] = rnd.Next(0, 1000);
}

return array;
}

//распечатать массив на консоль
void PrintArray(double[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}

Console.WriteLine();
}

double MinMaxDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        if(array[i] > max)
            max = array[i];
    }
    double difference = max - min;
    return difference;
}

double[] array = InitArray(GetNumber("Введите размерность массива:"));
PrintArray(array);
double minMaxDiff = MinMaxDiff(array);
System.Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + minMaxDiff);