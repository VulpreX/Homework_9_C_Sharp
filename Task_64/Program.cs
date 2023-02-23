Console.WriteLine(NaturalFromN(ReadInt(" number ")));
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
int NaturalFromN(int a)
{
    if (a > 1 ) 
    {
        Console.Write($"{a} ");
        return  NaturalFromN(a-1) ; 
        
    }
    else return 1 ;
}