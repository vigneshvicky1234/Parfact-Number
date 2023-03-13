// See https://aka.ms/new-console-template for more information
int n = 6;
int sum = 0;
for (int i = 1; i <n; i++)
{
    if (n%i== 0)
    {
        sum = sum + i;


    }
}
    if (n == sum)
    {
        Console.WriteLine("This is perfact number " );

    }
    else
    {
        Console.WriteLine(" Your Number is Not Perfact Number");
    }




