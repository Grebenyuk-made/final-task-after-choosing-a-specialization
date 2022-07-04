// ПРОГРАММА ДЛЯ ВЫПОЛНЕНИЯ ПОСТАВЛЕННОЙ ЗАДАЧИ.
void PrintArray(string[] array) // Метод для печати Массива.
{   
    int len = array.Length;
    for (int i = 0; i < len; i++)
        Console.Write($"{array[i]},");
    return;
}
string[] CreateFirstMass(int sizeMass) // Метод для ручного ввода элементов массива.
{
    string[] mass = new string[sizeMass];
    for (int i = 0; i < sizeMass; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        mass[i] = Console.ReadLine() ?? "";
    }
    return mass;
}
string[] СreatinSecondMass(string[] mass) // Метод для создания второго массива с помощью сравнения Первого массива и Второго массива
{
    int n = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
            n++;
    }
    string[] newMass = new string[n];
    n = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            newMass[n] = mass[i];
            n++;
        }
    }
    return newMass;                 
}
Console.Clear(); // Убираем лишнее с консоли
Console.WriteLine("Введите размер массива: ");
int sizeMass = int.Parse(Console.ReadLine() ?? "0");
string[] firstMass = CreateFirstMass(sizeMass);
Console.WriteLine("Изначальный массив: ");
PrintArray(firstMass);
Console.WriteLine();
string[] newMass = СreatinSecondMass(firstMass);
Console.WriteLine("Итоговый массив: ");
PrintArray(newMass);