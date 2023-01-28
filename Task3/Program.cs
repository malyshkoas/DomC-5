// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] arr = GetRandomArray(8);
PrintArray(arr);
System.Console.WriteLine(GetMax(arr) - GetMin(arr));

int GetMax(int[] array)
{
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int GetMin(int[] array)
{
    int min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int[] GetRandomArray(int length)
{
  int[] result = new int[length];

  for(int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(1, 50);
  }
  return result;
}

void PrintArray(int[] arr)
{
  foreach(int item in arr)
  {
    System.Console.Write(item + " ");
  }
  System.Console.WriteLine();
}