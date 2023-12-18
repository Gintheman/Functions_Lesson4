string q = "q";
Console.WriteLine("Enter the number");
int num = Convert.ToInt32(Console.ReadLine());



EnterNumber();
void EnterNumber()
{
    bool isFind = false;
    if ((string)num = q){
        isFind == true;
    };
    int numSum = num / 10 + num % 10;
    if(numSum % 2 != 0)
    {
        Console.WriteLine($"Stop!");
    }
    else if(isFind = true)
    {
        Console.WriteLine($"Stop!");
    }
    else
    {
        Console.WriteLine("Enter the number");
        num = Convert.ToInt32(Console.ReadLine());
    }
}


