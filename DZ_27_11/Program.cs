//Используя определение степени числа, напишите цикл, который принимает на вход два 
//натуральных числа (A и B) и возводит число A в степень B.

void Zadacha25()
{
    Console.WriteLine("Добрый день, сегодня возводим числа в степень!");
    Console.WriteLine("Введите первое число");
    int X1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int Y1 = Convert.ToInt32(Console.ReadLine());

    int Z= Convert.ToInt32(Math.Pow(X1,(Y1)));
    
    Console.WriteLine("Ответ "+ Z);
}


void Zadacha27()
{
    //Задача 27: Напишите программу, которая 
    //принимает на вход число и выдаёт сумму цифр в числе.
    Console.WriteLine("Доброго времени суток!");
    Console.WriteLine("Сегодня находим сумму чисел в числе");
    Console.WriteLine("Введите число, где цифры вводятся через пробел");
    string A = Console.ReadLine();
    string[] ASplit = A.Split();
    int i= 0;
    int sum=0;
    int y= A.Split().Length;
    Console.WriteLine(y);
    while(i< y )
    {
        sum= sum + Convert.ToInt32(ASplit[i]);
        i++;
        
    }
    Console.WriteLine("Ответ "+ sum);

    
}


 void PrintArray(int[] array)
    {
        int count = array.Length;
        for (int i=0; i<count; i++)
        {
            Console.Write($"{array[i]}");
        }
        Console.WriteLine();
    }
void SelectionSort(int[] array)
    {
        for(int i=0; i<array.Length-1; i++)
        {
            int minPosition=i;
        
            for(int j=i+1; j<array.Length; j++ )
            {
                if (array[j]<array[minPosition]) minPosition = j;
            
            }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]= temporary;
        }
}






void Zadacha29()
{
//Задача 29: Напишите программу, которая задаёт массив из 8 c
//cлучайных целых чисел и выводит отсортированный по модулю массив.
   
    Console.WriteLine("Создадим массив и отсортируем его");
    Console.WriteLine("Прямо сейчас будет происходить волшебство");
    

    int size = 8;
    int[] arr = new int[size];
    Random rand = new Random();
    size = arr.Length;
    for(int i=0;i < size;i++ )
    {
        arr [i] = rand.Next(1,10);
    }
    
PrintArray(arr);
Console.WriteLine("Сверху находится наш не сортированный массив");
SelectionSort(arr);
PrintArray(arr);
Console.WriteLine("А сейчас сверху находится отсортированный массив");
}
//Zadacha25();
//Zadacha27();
Zadacha29();