int sum =0;
int a =ReadInt("first number ");
int b = ReadInt(" second number ");
if(b<a)
{
  a=b+a;
  b=a-b;
  a=a-b;
}
Console.WriteLine(Sum(a,b,sum));
int ReadInt(string argument1)
{
    Console.Write($"Enter {argument1} ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine(" You entered an invalid number, try again!");
    }
    
    return number; 
}
int Sum(int a,int b,int sum)//сумма чисел от 1-го введеного до 2 введенного(вкл)
{
  if (a < b || b!=a-1) 
  {
    return sum+= b + Sum(a,b-1,sum) ; 
  }

  else return sum ;
}