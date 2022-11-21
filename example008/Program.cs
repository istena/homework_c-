Console.Clear();
Console.WriteLine("Введите число");
int a=int.Parse(Console.ReadLine());
int i=2;
while (a>=i){
    Console.Write(i);
    Console.Write(",");
    i+=2;
}