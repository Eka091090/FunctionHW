// EX1 

// void Main()
// {
//     string value = userInput();
// }

// string userInput()
// {
//     while(true)
//     {
//         System.Console.Write($"Введите целое число или 'q' для выхода: ");
//         string? number = Console.ReadLine();
//         if(number == "q")
//         {
//             Console.WriteLine("[STOP]");
//             break;
//         }
//         int num;
//         int sum = 0;
//         if (int.TryParse(number, out num)) 
//             sum = 0;
//         while (num > 0) 
//         {
//             sum += num % 10; 
//             num /= 10; 
//             System.Console.WriteLine(sum);;
//         }
//         if (sum % 2 == 0) 
//         {
//             Console.WriteLine("[STOP]");
//             break;
//         }
//     }
//     return "";
// }

// Main();



// EX2

// using System.Data;

// void Main()
// {
//     int[] array = GenerateArray();
//     PrintArray(array);
//     CountNymbers(array);
//     Console.WriteLine("Количество четныхчисел: " + CountNymbers(array));
// }

// int CountNymbers(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] % 2 == 0)
//             count++;
//     return count;
// }


// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         System.Console.Write(array[i] + " ");
//     System.Console.WriteLine();
// }


// int[] GenerateArray()
// {
//     Random arraySize = new Random();
//     int size = arraySize.Next(1, 20);

//     int[] tempArray = new int[size];

//     Random rand = new Random();

//     for(int i = 0; i < tempArray.Length; i++)
//         tempArray[i] = rand.Next(100, 1000);
    
//     return tempArray;
// }

// Main();


// EX3

// void Main()
// {
//     int[] array = GenerateArray();
//     PrintArray(array);
//     PrintArray(reversArray(array));

// }

// int[] reversArray(int[] array)
// {
//     int[] temp = new int[array.Length];
//     for(int i = 0; i < array.Length; i++)

//         {
//         temp[i] += array[array.Length - 1 - i];
//         }
//     return temp;
// }


// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         System.Console.Write(array[i] + " ");
//     System.Console.WriteLine();
// }


// int[] GenerateArray()
// {
//     Random arraySize = new Random();
//     int size = arraySize.Next(1, 20);

//     int[] tempArray = new int[size];

//     Random rand = new Random();

//     for(int i = 0; i < tempArray.Length; i++)
//         tempArray[i] = rand.Next(100, 1000);
    
//     return tempArray;
// }

// Main();
