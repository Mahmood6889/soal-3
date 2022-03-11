int a;
for (var i = 0; i < 3 ; i++)
{
    System.Console.WriteLine("hoghoh ro bede");
    a=Convert.ToInt32(Console.ReadLine());
    if (a>2000000 && a<3000000)
    {
        System.Console.WriteLine(a*0.05);
        
    }else if (a>=3000000)
    {
            System.Console.WriteLine(a*0.07);
    }
    else
    {
                System.Console.WriteLine("maliat=0");
    }
}