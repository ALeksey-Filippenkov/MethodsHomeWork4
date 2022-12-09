// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

void numberPower(int firstNumber1, int secondNumber1)
{
    int result = 1;
    for (int i = 0; i < secondNumber1; i++)
    {
        result *= firstNumber1;
    }
    System.Console.WriteLine(result);
}
System.Console.WriteLine("Введите два любых числа");
System.Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
numberPower(firstNumber, secondNumber);




// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

int Nums(int number)
{
    int sum = 0;
    while (number > 0 || number < 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
System.Console.Write("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Nums(number));





//  Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
int[] Array(int lengthMass)
{
    int[] arr = new int[lengthMass];
    for (int i = 0; i < lengthMass; i++)
    {
        System.Console.Write($"Введите значение эллемента с индексом {i} - ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
void ShowArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
System.Console.Write("Введите длинну массива: ");
int lengthMass = Convert.ToInt32(Console.ReadLine());
ShowArray(Array(lengthMass));