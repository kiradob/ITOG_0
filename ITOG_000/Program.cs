// Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1=new string[10] {"My", "name", "is", "Kira", "Dobrynina", "I", "live", "in", "Siberia", "!"};
string[] array2=new string[array1.Length];
int count=0;
void SecondArray(string[] array1, string[] array2)
{
for (int i=0; i<array1.Length; i++)
{
    if(array1[i].Length <=3)
        {
        array2[count]=array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(array1, array2);
PrintArray(array2);