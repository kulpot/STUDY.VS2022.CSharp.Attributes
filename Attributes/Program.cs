using System;

//ref link:https://www.youtube.com/watch?v=gBMJL8gE63U&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=6
//

class MeAttribute : Attribute
{
    public MeAttribute(int value, string secondValue)
    {
        Console.WriteLine("MeAttribute()");
        Console.WriteLine(value);
        Console.WriteLine(secondValue);
    }
    public int SomeIntProperty { get; set; }
    public char SomeCharProperty { get; set; }
}

[Me(25, "Kulpot King", SomeCharProperty = 'W', SomeIntProperty = 72)]
class MainClass
{
    static void Main()
    {
        typeof(MainClass).GetCustomAttributes(false);
    }
}