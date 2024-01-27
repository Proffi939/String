//lesson 6 
using System.Diagnostics;
using System.Threading.Channels;

char [,] CreateRndCharMtx(int row, int col) //97-122a-z
{
    char [,] table = new char [row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            table[i, j] = Convert.ToChar(rnd.Next(97, 123));
        }
    }
    return table;
}

void WriteCharTable(char [,] tab)
{
    for(int i = 0; i < tab.GetLength(0); i++)
    {
        for(int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write($"{tab[i, j]}, ");
        }
        Console.WriteLine();
    }
}

string GetStringFromCharMtx(char [,] tab)
{
    string str = "";
    for(int i = 0; i < tab.GetLength(0); i++)
    {
        for(int j = 0; j < tab.GetLength(1); j++)
        {
            str += tab[i, j];
        }
    }
    return str;
}

int choise = 0;
while(choise != 5)
{
    Console.WriteLine("Введите номер задания для проверки (1-4, 5-выход)");
    choise = Convert.ToInt32(Console.ReadLine());
    //task 1
    if(choise == 1)
    {
        Console.WriteLine("Введите количество строк");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов ");
        int col = Convert.ToInt32(Console.ReadLine());
        char [,] table = CreateRndCharMtx(row, col);
        Console.WriteLine("Сгенерирован массив ");
        WriteCharTable(table);
        Console.WriteLine("Строка ");
        Console.Write(GetStringFromCharMtx(table));
        Console.WriteLine();
        Console.WriteLine("end"+'\n');
    }
    //task 2
    if(choise == 2)//65-90A-Z
    {
        Console.WriteLine("Введите строку латинских букв с разным регистром");
        string str = Convert.ToString(Console.ReadLine());
        string newstr = "";
        foreach(char e in str)
        {
            if((int)e < 97)
            {
                newstr += Convert.ToChar(((int)e + 32));
            }
            else
            {
                newstr += e;
            }
        }
        Console.WriteLine(newstr);
    }
    //task 3
    if(choise == 3)
    {
        Console.WriteLine("Введите строку (полиндром или нет)");
        string pol = Convert.ToString(Console.Read());
        int len = pol.Length;
        int flag = 0;
        for(int i = 0; i < (len /2); i++)
        {
            if (pol[i] != pol[(len-i-1)])
            {
                flag += 1;
            }
        }
        if(flag == 0)
        {
            Console.WriteLine("полиндром");
        }
        else
        {
            Console.WriteLine("не полиндром");
        }
    }
    //task 4
    if(choise == 4)
    {   
        Console.WriteLine("Введите предложение");
        string Str = Convert.ToString(Console.Read());
        int spacepos = Str.Length - 1;
        while(spacepos > 1)
        {    
            int charcount = 0;
            for(int i = spacepos; i == 0; i--)
            {
                charcount++;
                if((int)Str[i] == 32)
                {
                    spacepos = i;
                    break;
                }
            }
            for(int j = spacepos+1; j < spacepos+charcount; j++)
            {
                Console.Write(Str[j]);
            }


        }
    }
}
Console.WriteLine("end"+'\n');

