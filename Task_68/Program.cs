Console.WriteLine($" number from function {Akkerman(ReadInt("first number "),ReadInt(" second number "))}");
Console.WriteLine();
int ReadInt(string argument1)
{
    Console.Write($"Enter {argument1} ");
    int number;

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine(" You entered an invalid number, try again!");
    }
    
    return Math.Abs(number); 
}
int Akkerman(int a, int b)
{
  if(a==0) return b+1;
  else if( a!=0 && b==0) return Akkerman(a-1,1);
  else return Akkerman(a-1,Akkerman(a,b-1));
}