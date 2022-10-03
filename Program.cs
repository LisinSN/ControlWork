// Контрольная работа по теме: Итоги блока. Выбор специализации. IT-специалист
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine();
Console.WriteLine("*** Давайте заполним массив и определим все элементы, где менее 4-х символов***");
Console.WriteLine();

string[] CreateShowArray(int size)
{
    string[] array = new string[size];
    int max = 3;
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"* Введите {i + 1}-й элемент: ");
        string symbol = Convert.ToString(Console.ReadLine());
        if (symbol.Length <= max)
        {
            array[j] = symbol;
            j++;
        }
    }
    return array;
}

// Метод вывода

void PrintArray(string[] array)
{
    Console.Write("** Выбранные элементы: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Ввод данных

Console.Write("** Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
string[] array = CreateShowArray(size);
Console.WriteLine();
PrintArray(array);


