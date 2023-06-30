/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/


int[] arrayNumbers;
arrayNumbers = GetArray();

Console.WriteLine($"Числа введенные пользователем = [{String.Join(", ", arrayNumbers)}]");
Console.WriteLine($"Чисел больше нуля = {GetNumbersGreaterThanZero(arrayNumbers)}");

int[] GetArray()//Функция получения массива, вводимый пользователем
{
    Console.Write("Введите числа через пробел: ");
    string stringNumbers = Console.ReadLine()!;//"87 25 32 155 1"
    string[] stringsArray = stringNumbers.Split(' '); //"87 25 32 155 1" => ["87", "25", "32", "155", "1"]

    int[] arrayNumbers = new int[stringsArray.Length];
    for (var i = 0; i < arrayNumbers.Length; i++)
    {
        arrayNumbers[i] = int.Parse(stringsArray[i]);
    }
    return arrayNumbers;
}

int GetNumbersGreaterThanZero(int[] array)//Получение кол-ва чисел больше нуля
{
    int NumbersGreaterThanZero = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            NumbersGreaterThanZero += 1;
        }
    }
    return NumbersGreaterThanZero;
}
