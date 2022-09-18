void showNums(int n)
{
    if(n > 1) showNums(n - 1);

    Console.Write(n + " ");
}

showNums(5);