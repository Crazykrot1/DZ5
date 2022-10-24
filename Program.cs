//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] array = Getarray(4,100,999);
Console.WriteLine(String.Join(" ",array));
int count=0; // Счётчик для подсчёта чётных
for (int i =0; i<array.Length; i++){
    if (array[i]%2==0){
        count++;
    }
    else{

    }
}

Console.WriteLine($"Количество чётных {count}");


int[] Getarray(int size, int minValue, int maxValue){
int [] res = new int [size];
for (int i=0; i<size;i++){
    res [i]= new Random().Next( minValue, maxValue+1);
}
return res;
}
*/
 //Задайте одномерный массив, заполненный случайными числами. 
 //Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Write($"Введи количество элементов массива: ");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 

// int Numbers(int numberElements, int min, int max)
//   {
//   int[] Numbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("Получившийся массив: ");

//     for (int i = 0; i <Numbers.Length; i++ ){
//       Numbers[i] = new Random().Next(min, max);

//       Console.Write(Numbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + Numbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  Numbers(numberElements, 1, 10);

// Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");

//Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем).
 //Найдите разницу между максимальным и минимальным элементов массива.
 int [] array = new int[8];

int maxNumber = 0;

int minNumber = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
}

for (int i = 0; i < array.Length; i++)
{
    if(array[i] > maxNumber) maxNumber = array[i];
    
    else minNumber = array[i];
}
int result = maxNumber - minNumber;


Console.WriteLine(String.Join("; ", array));
Console.WriteLine($" Разницу между максимальным и минимальным элементом {result}");