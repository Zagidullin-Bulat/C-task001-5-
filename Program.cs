// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

void RandomNumbers (int [] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers [i] = new Random().Next(99,1000);
    }
}
void PrintArray (int [] numbers)
{
    Console.Write ("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write (numbers[i] + " ");
    }
    Console.Write ("]");
    Console.WriteLine ();
}

int size = Convert.ToInt32(3);
int[] numbers = new int[size];
RandomNumbers (numbers);
Console.WriteLine ("Массив: ");
PrintArray (numbers);
int count1 = 0;
int count2 = 0;
for (int A = 0; A < numbers.Length; A++)
    if (numbers[A] % 2 == 0)
    count1++;
    else
    count2++;
    
Console.WriteLine ($"всего {numbers.Length} числа, {count1} из них чётные, {count2} из них нечетные.");
