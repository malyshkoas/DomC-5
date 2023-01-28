// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


int[] arr = GetRandomArray(8);
PrintArray(arr);
System.Console.WriteLine(GetSummOfOddElements(arr));

int GetSummOfOddElements(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            sum = sum + array[i];
            i++;
        }
    }
    return sum;
}

int[] GetRandomArray(int length)
{
  int[] result = new int[length];

  for(int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(-10, 20);
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
