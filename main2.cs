/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/

using System;

// Шаг 1: Интерфейсы для продуктов
public interface IChair
{
    void SitOn();
}

public interface ITable
{
    void PutSomethingOn();
}

// Шаг 2: Конкретные продукты для классической мебели
public class ClassicChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Сидите на классическом стуле.");
    }
}

public class ClassicTable : ITable
{
    public void PutSomethingOn()
    {
        Console.WriteLine("Положили на классический стол.");
    }
}

// Шаг 3: Конкретные продукты для современной мебели
public class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Сидите на современном стуле.");
    }
}

public class ModernTable : ITable
{
    public void PutSomethingOn()
    {
        Console.WriteLine("Положили на современный стол.");
    }
}

// Шаг 4: Абстрактная фабрика
public abstract class FurnitureFactory
{
    public abstract IChair CreateChair();
    public abstract ITable CreateTable();
}

// Шаг 5: Конкретные фабрики для классической и современной мебели
public class ClassicFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair()
    {
        return new ClassicChair();
    }

    public override ITable CreateTable()
    {
        return new ClassicTable();
    }
}

public class ModernFurnitureFactory : FurnitureFactory
{
    public override IChair CreateChair()
    {
        return new ModernChair();
    }

    public override ITable CreateTable()
    {
        return new ModernTable();
    }
}

