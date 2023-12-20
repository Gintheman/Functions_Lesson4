EnterNumber();
int[] EnterNumber()
{
    Console.WriteLine("Enter the number");
    int num = Convert.ToInt32(Console.ReadLine());
    int numSum = 0;
    int[] array = new int[num];
    for(int i = 0; i < array.Length; i++)
    {
    // if(num > 100)
    // {
        
    //     array[i] = num / 100;
    //     numSum = numSum + array[i];
    // }

    // if(num > 10)
    // {
    //     array[i] = num / 10;
    //     numSum = numSum + array[i];
    // }

    if(num > 1)
    {
        array[i] = num % 10;
        numSum = numSum + array[i];
    }
    

    }

    if(numSum % 2 == 0)
    {
        Console.WriteLine($"Stop!");
    }
    return array;
}










// EnterNumber();
// void EnterNumber()
// {
//     Console.WriteLine("Enter the number");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if(num == "q" || num % 10 == 0)
//     {
//         Console.WriteLine($"Stop!");
//     }    
//     else 
//     {
//         Console.WriteLine("Enter the number");
//         int num = Convert.ToInt32(Console.ReadLine());  
//     }
    
// };










// void FillArray()
// {
//     int[] array = new int[num];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(num > 10)
//         {
//             array[i] = num % 10;
//         }
        
//         if(array[i] = "q")
//         {
//             Console.WriteLine($"Stop!");
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Enter the number");
//             num = Convert.ToInt32(Console.ReadLine());
//         }

//     };    
// };


// EnterNumber();
// void EnterNumber()
// {
//     // bool isFind;
//     // if (q = "q"){
//     //     isFind = true;
//     //     Console.WriteLine($"Stop!");
//     // };
//     int numSum = num / 10 + num % 10;
//     if(numSum % 2 != 0)
//     {
//         Console.WriteLine($"Stop!");
//     }
//       else
//     {
//         Console.WriteLine("Enter the number");
//         num = Convert.ToInt32(Console.ReadLine());
//     }
// }


