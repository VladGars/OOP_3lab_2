using System;

public class Device
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Пристрій увімкнено.");
    }
}

// Похідні класи, що перевизначають метод
public class Laptop : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Ноутбук завантажує операційну систему...");
    }
}

public class Smartphone : Device
{
    public override void TurnOn()
    {
        Console.WriteLine("Смартфон показує екран блокування.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Device myDevice = new Device();
        Laptop myLaptop = new Laptop();
        Smartphone myPhone = new Smartphone();

        myDevice.TurnOn();
        myLaptop.TurnOn();
        myPhone.TurnOn();
    }
}
