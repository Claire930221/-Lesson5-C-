/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
 которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

//получить размерность массива с консоли
int GetNumber(string message)
{
int result;

while(true)
{
System.Console.WriteLine(message);

if(int.TryParse(System.Console.ReadLine(), out result) && result > 0)
{
break;
}
else
{
System.Console.WriteLine("Ввели не число. Введите корректное число");
}
}
return result;
}

//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
int[] array = new int[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
array[i] = rnd.Next(100, 1000);
}

return array;
}

//распечатать массив на консоль
void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write($"{array[i]} ");
}

System.Console.WriteLine();
}

int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArray(array);

int Numbers(int[] array)
{
    int num = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
           num++;
    }
    return num;
}

int result = Numbers(array);
System.Console.WriteLine($"количество чётных чисел в массиве = {result}.");

