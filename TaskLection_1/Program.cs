//Вид 1 (ничего не возвращают)

// void Method1()
// {
//     Console.WriteLine("Author...");
// }
// Method1();

//Вид2 (ничего не возвращают)

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Text");

//Вид2_1 (ничего не возвращают)

// void Method22(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method22("Text", 4);

//Вид 3 (что-то возвращают, но ничего не принимают)

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

//Вид 4 (что-то возвращают, что-то принимают)

// string Method4(int count, string text);
// {
//     int i = 0;
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//      result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// Цикл в цикле (таблица умножения)

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// Задача с заменой (пробелов)
// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//              + "ежели бы вас послали вместо нашего милого Винценгероде,"
//              + "вы бы взяли приступом согласие прусского короля."
//              + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
    
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     } 

//     return result;
// }
// string newText = Replace(text, " ", "/");
// Console.WriteLine(newText);

//Задача с массивом

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
      Console.Write($"{array[i]} ");  
    }
    Console.WriteLine(); 
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinPosition = i;

       for (int j = i + 1; j < array.Length; j++)
       {
        if(array[j] < array[MinPosition]) MinPosition = j;
       }
        int temporary = array[i];
        array[i] = array[MinPosition];
        array[MinPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);