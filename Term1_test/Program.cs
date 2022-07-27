// Задача: 
// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив задать на старте выполнения алгоритма:
// {"hello", "2", "world", ":-)"}.

string[] text = { "hello", "2", "world", ":-)" };
int count = 0;

for (int i = 0; i < text.Length; i++)   //Подзадача: определение длины нового массива
{
    if (text[i].Length <= 3)
    {
        count = count + 1;
    }
}

string[] newText = new string[count];
int iCurrent = 0;

for (int j = 0; j < count; j++)         //Основная задача: новый массив строк
{
    for (int i = iCurrent; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            newText[j] = text[i];
            iCurrent = i + 1;
            break;
        }
    }
}

PrintArr(text);        
PrintArr(newText);

void PrintArr(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
    Console.WriteLine();
}