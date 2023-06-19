﻿int Prompt(string message)
{
    System.Console.Write( message );
    int value= Convert.ToInt32(Console.ReadLine());
    return value ;
}
int num = Prompt("chislo > ");
if ( 5<num && num <8 )
{
    Console.WriteLine ("yes");

}
else Console.WriteLine("no");