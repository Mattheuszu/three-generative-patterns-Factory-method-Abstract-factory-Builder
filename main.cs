/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;

// Шаг 1: Интерфейс транспортного средства
public interface ITransport
{
    void Drive();
}

// Шаг 2: Конкретные транспортные средства (машина и велосипед)
public class Car : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Машина едет!");
    }
}

public class Bike : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Велосипед едет!");
    }
}

// Шаг 3: Абстрактная фабрика
public abstract class TransportFactory
{
    // Метод создания транспортного средства
    public abstract ITransport CreateTransport();
}

// Шаг 4: Конкретные фабрики
public class CarFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Car(); // Создаем машину
    }
}

public class BikeFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Bike(); // Создаем велосипед
    }
}

// Шаг 5: Клиентский код
class Program
{
    static void Main(string[] args)
    {
        // Создаем фабрику для машины
        TransportFactory carFactory = new CarFactory();
        ITransport car = carFactory.CreateTransport();
        car.Drive();

        // Создаем фабрику для велосипеда
        TransportFactory bikeFactory = new BikeFactory();
        ITransport bike = bikeFactory.CreateTransport();
        bike.Drive();
        
         FurnitureFactory classicFactory = new ClassicFurnitureFactory();
        IChair classicChair = classicFactory.CreateChair();
        ITable classicTable = classicFactory.CreateTable();
        classicChair.SitOn();
        classicTable.PutSomethingOn();

        // Современная фабрика мебели
        FurnitureFactory modernFactory = new ModernFurnitureFactory();
        IChair modernChair = modernFactory.CreateChair();
        ITable modernTable = modernFactory.CreateTable();
        modernChair.SitOn();
        modernTable.PutSomethingOn();
        
         // Строим игровой компьютер
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        Director director = new Director(gamingBuilder);
        director.BuildComputer();
        Computer gamingComputer = director.GetComputer();
        Console.WriteLine("Gaming Computer Specs:");
        gamingComputer.ShowSpecs();

        Console.WriteLine();

        // Строим офисный компьютер
        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director = new Director(officeBuilder);
        director.BuildComputer();
        Computer officeComputer = director.GetComputer();
        Console.WriteLine("Office Computer Specs:");
        officeComputer.ShowSpecs();
        
         // Создаем оригинальный объект
        PrototypeCar originalCar = new PrototypeCar("Toyota");
        originalCar.ShowModel();

        // Клонируем объект
        PrototypeCar clonedCar = (PrototypeCar)originalCar.Clone();
        clonedCar.ShowModel();

        // Изменяем модель клона
        clonedCar.Model = "Honda";
        clonedCar.ShowModel(); // Показываем модель клона
        originalCar.ShowModel(); // Показываем модель оригинала
    }
}
