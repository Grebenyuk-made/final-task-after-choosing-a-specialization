// ПРОГРАММА ДЛЯ ВЫПОЛНЕНИЯ ПОСТАВЛЕННОЙ ЗАДАЧИ.

string PrintArray(int[] mass)
{
    string line = String.Empty;
    int arrayLine = mass.Length;
    for (int i = 0; i < arrayLine; i++ )
    {
        line += $"{mass[i]} ";
    }
    return $"[{line}] ";
}

