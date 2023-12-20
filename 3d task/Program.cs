Console.WriteLine($"Enter the array length");
int num = Convert.ToInt32(Console.ReadLine());
ReverseArray();
void ReverseArray() 
{
    int[] array = new int[num];
    int[] array2 = new int[num];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        System.Console.Write(array[i] + " ");
        
    };
    for(int i = 0; i < array.Length; i++)
    {
        array2[i] = array[num - 1 - i];
        System.Console.Write(array2[i] + " ");
    }
}




