Console.Clear();
Console.WriteLine("Введите первое число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int d=int.Parse(Console.ReadLine());
int max=a;
//количество максимальных значений
int count_max=1;
if (b>max) 
max=b;
else if(b==max) 
count_max+=1;
if(d>max)
max=d;
else if(d==max) 
count_max+=1;
Console.Write($"Максимально число {max} , повторяется {count_max} раз ");

