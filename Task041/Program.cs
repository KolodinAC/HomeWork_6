// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int userLength = UserInputArrayLength("Введите желаемый размер массива:\t");
int[] array = new int[userLength];
GetArrayFromUser(array);
PrintArray(array);
int countOfPosNum = GetCountOfPositiveNumbers(array);
Console.WriteLine("Количество элементов массива со значением больше нуля составляет:  " + countOfPosNum);



// Methods:

int UserInputArrayLength(string msg)
{
    Console.Write(msg);
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum && num > 0)
    {
        return num;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

void GetArrayFromUser(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write($"\nВведите элемент массива с индексом {i}:\t ");
        collection[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine();
    Console.Write("Вывожу ваш массив: ");
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
    Console.WriteLine();
}

int GetCountOfPositiveNumbers(int[] collection)
{
    int count = 0;
    int i = 0;
    for (i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0)
        {
            count++;
        }
    }
    return count;
}
