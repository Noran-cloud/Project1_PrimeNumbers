

using System;
public class Prime_numbers
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please,enter first number ");
      int Firstnumber=int.Parse(Console.ReadLine());
      Console.WriteLine("Please,enter last number");
     int Lastnumber=int.Parse(Console.ReadLine());
     Console.WriteLine("Prime numbers between them are :");
     int i;
     for (; Firstnumber<Lastnumber;Firstnumber++)
     {
         for (i = 2; i<=Firstnumber; i++)
         {
         if (Firstnumber % i == 0)
         break;
     }
        if (i==Firstnumber)
        Console.Write(",{0}",i);
     }
    }
}
