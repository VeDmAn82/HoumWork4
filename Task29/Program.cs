// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

Console.Write("Введите размер массива: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int num);

if (!isNumber || num <= 0)
{
    Console.WriteLine("Is not valid");
    return;
}

int[] GetArray(int count)
{
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

PrintArray(GetArray(num));

void PrintArray(int[]array)
{
    string str = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        str += array[i];
    }
    Console.WriteLine(str);
}









// Console.WriteLine("Введите числа: ");
// int N = 8;

// int[] myArray = new int[N];

// for (int i=0; i<N; i++)
// {
//     myArray[i] = Convert.ToInt32(Console.ReadLine());
// }
 
// for (int i = 0; i < N; i++)
// {
//     Console.Write("{0} ", myArray[i]);
// }