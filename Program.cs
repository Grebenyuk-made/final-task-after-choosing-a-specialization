// ПРОГРАММА ДЛЯ ВЫПОЛНЕНИЯ ПОСТАВЛЕННОЙ ЗАДАЧИ.

void PrintArray(string[] array)
{   
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        Console.Write($"{array[i]},");
    }
}
 
void CreateFirstMass (int sizeMass, string[] mass)
{
    for (int i = 0; i < sizeMass; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        mass[i] = Console.ReadLine();
    }

}

void СreatinSecondMass (string[] mass)
{
    string[] newMass = new string[sizeMass];
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] <= 
    }
}



Console.WriteLine("Введите размер массива: ");
int sizeMass = int.Parse(Console.ReadLine() ?? "0");
string[] mass = new string[sizeMass];
CreateFirstMass(sizeMass, mass);
Console.Write("Изначальный массив: ");
PrintArray(mass);