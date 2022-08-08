// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateNewArray(int a)
{
   int[] array = new int[a];

    for (int i = 0; i < array.Length; i++) 
    {
        Console.WriteLine("Input array element ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int MoreThanZero(int[] array)
{
    int quantity = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            quantity++;
    }
    return quantity;
}

Console.Write("Input amount of elements: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = CreateNewArray(a);
Console.WriteLine("Amount of elements is: " + MoreThanZero(array));