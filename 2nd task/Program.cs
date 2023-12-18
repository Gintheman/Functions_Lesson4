Console.WriteLine($"Enter the array length");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

CreateArray();
int[] CreateArray () 
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write(array[i] + " ");
    };

    return array; // возвращает результат функции
};


FindNumber();
void FindNumber ()
{
    int countNumber = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
        countNumber++;
        }
    };

    Console.WriteLine($"\n{countNumber}");
};