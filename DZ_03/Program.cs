//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.


void Zadacha19()
{

    Console.WriteLine("САЛАМ АЛЕЙКУМ, БРАТ!!!");
    Console.WriteLine("Введи, по-братски, пятизначное число через проблел!");
    string A = Console.ReadLine();
    string[] ASplit = A.Split();
    if(Convert.ToInt32(ASplit[0])==Convert.ToInt32(ASplit[4]) & Convert.ToInt32(ASplit[1]) == Convert.ToInt32(ASplit[3]))
    {
        Console.WriteLine("Где ты такое число нашел? Оно же палиндромом!"); 
    }
    else
    {
       Console.WriteLine("Это обычное число,не повезло"); 
    }

}

//Не знаю только как сделать так чтобы не через пробел писать


void Zadacha21()
{
    //Напишите программу, которая принимает на вход координаты 
    //двух точек и находит расстояние между ними в 3D пространстве.
    Console.WriteLine("Салам Алейкум,брат");
    Console.WriteLine("Введите координату первой точки по оси X");
    int X1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату первой точки по оси Y");
    int Y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату первой точки по оси Z");
    int Z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки по оси X");
    int X2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки по оси Y");
    int Y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату второй точки по оси Z");
    int Z2 = Convert.ToInt32(Console.ReadLine());

    int Z = Convert.ToInt32(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
    int result = Convert.ToInt32(Math.Pow(Z,1/3));
    Console.WriteLine($"Это разница брат '{result}'");
}


void Zadacha23()
{
    //Напишите программу, которая принимает на вход 
    //число (N) и выдаёт таблицу кубов чисел от 1 до N.
    Console.WriteLine("САЛАМ АЛЕЙКУМ, БРАТ!!!");
    Console.WriteLine("Введи число, по-братски");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("");

    for(int i=1; i <= A; i++)
    {
        int B= Convert.ToInt32(Math.Pow(i,3));
        Console.WriteLine($"{i}*{i}*{i}={B}");
    }
}

//Zadacha19();
//Zadacha21();
//Zadacha23();