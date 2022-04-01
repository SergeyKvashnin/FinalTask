//программа формирующая из данного массива, массив из строк, длинна которых меньше либо равна 3 символам.
Console.Clear();
string[] mass1 = new string[5] {"743", "23", "hello", "world", "tod"};
string[] mass2 = new string[mass1.Length];
void First (string[] mass1, string[] mass2)
{
    int count = 0;
    for (int i = 0; i < mass1.Length; i++)
    {
    if(mass1[i].Length <= 3)
        {
        mass2[count] = mass1[i];
        count++;
        }
    }
}


