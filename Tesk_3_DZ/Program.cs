// Напишите программу , которая задает массив 
// из 8 элементов и выходит их на экран.
int [] array = new int[8];

void PrintArray(int [] array)
{
    int lenght = array.Length;
    for(int i = 0; i< lenght; i++)
    {
        array[1] = new Random().Next(0, 199);
        Console.Write($"{array[1]} ");
    }
}

PrintArray(array);