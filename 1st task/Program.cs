using System;
class Program
{
    static void Main()
    {
        while (true) // Бесконечный цикл
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine(); // Чтение строки ввода пользователя
            if (input == "q") // Проверка на ввод 'q' для выхода
            {
                Console.WriteLine($"Sayonara!");
                break;
            }

            int number;
            if (int.TryParse(input, out number)) // Проверка, является ли ввод числом
            {
                int sum = 0;
                while (number > 0) // Вычисление суммы цифр числа
                {
                    sum += number % 10; // Добавление последней цифры к сумме
                    number /= 10; // Удаление последней цифры из числа
                }
                if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
            else // Если ввод не является числом и не 'q', повторить запрос
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
            }
        }
    }
}













// Мои варианты кода:

// EnterNumber();
// int[] EnterNumber()
// {
//     Console.WriteLine("Enter the number");
//     int num = Convert.ToInt32(Console.ReadLine());
//     int numSum = 0;
//     int[] array = new int[num];
//     for(int i = 0; i < array.Length; i++)
//     {
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

    //     if(num > 1)
    //     {
    //         array[i] = num % 10;
    //         numSum = numSum + array[i];
    //     }
    

    //     }

    //     if(numSum % 2 == 0)
    //     {
    //         Console.WriteLine($"Stop!");
    //         }
    //     return array;
    // }










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


