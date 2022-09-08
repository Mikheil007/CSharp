int[,] CreateRandom2dArray()
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(ConsoleReadLine());
    Console.Write("Input numbers of columns: ");
    int rows = Convert.ToInt32(ConsoleReadLine());
    Console.Write("Input numbers of value: ");
    int rows = Convert.ToInt32(ConsoleReadLine());
    Console.Write("Input numbers of value: ");
    int rows = Convert.ToInt32(ConsoleReadLine());

    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    
        for(int j = 0; j < columns; j++)
        newArray[i,j] = new Random().Next(minValue, maxValue + 1);
return newArray;


void Show2dArray(int[,] array);
}
    for(int i = 0; i < array.GetLenght(0); j++)
{
    for(int i = 0; i < array.GetLenght(1); j++)
    Console.Write(array[i,j] + " ");

    Console.WriteLine();
}

Console.WriteLine();
{

int[,] myArray = CreateRandom2dArray();
}
Show2dArray(myArray);