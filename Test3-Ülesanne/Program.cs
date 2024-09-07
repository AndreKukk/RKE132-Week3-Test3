char letter;
Console.WriteLine("Mis hinde sa said?");
letter = Convert.ToChar(Console.ReadLine()!);


if (letter == 'A')
{
    Console.WriteLine("Suurepärane!");
}

 else if (letter == 'B') 
{   
    Console.WriteLine("Väga hea!");

}

   else if (letter == 'C')
{
    Console.WriteLine("Hea!");
}

   else if (letter == 'D')
{
    Console.WriteLine("Rahuldav!");
}

   else if (letter == 'E')
{
    Console.WriteLine("Kasin!");
}
   else if (letter == 'F')
{ 
    Console.WriteLine("Puudulik!");
}
   else
{
    Console.WriteLine("Vale väärtus");
}
