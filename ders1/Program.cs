// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = { 13, 46, 0, 1, 18, -9 };

Console.WriteLine(numbers[0]);

Console.WriteLine(numbers.Length);

Array.Sort(numbers);      //artan düzene göre sırala
foreach (int i in numbers) // herbiri için 
{
    Console.WriteLine(i);
}

Console.WriteLine(numbers.Max()); 
Console.WriteLine(numbers.Min());  
Console.WriteLine(numbers.Sum());
Console.WriteLine(numbers.Average()); // ortalama 
