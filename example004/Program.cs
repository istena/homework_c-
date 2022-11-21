Console.Clear();
Console.WriteLine("Введите первое число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int d=int.Parse(Console.ReadLine());
int max=a;
if (b>max) 
max=b;
if(d>max)
max=d;
Console.Write("Максимально число ");
Console.Write(max);
