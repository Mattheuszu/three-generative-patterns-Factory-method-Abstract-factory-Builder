/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/

using System;

// Продукт: Компьютер
public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public void ShowSpecs()
    {
        Console.WriteLine($"CPU: {CPU}");
        Console.WriteLine($"GPU: {GPU}");
        Console.WriteLine($"RAM: {RAM}");
        Console.WriteLine($"Storage: {Storage}");
    }
}

// Строитель: Интерфейс строителя для компьютера
public interface IComputerBuilder
{
    void SetCPU();
    void SetGPU();
    void SetRAM();
    void SetStorage();
    Computer GetComputer();
}

// Конкретный строитель: Строитель игрового компьютера
public class GamingComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void SetCPU()
    {
        computer.CPU = "Intel Core i9";
    }

    public void SetGPU()
    {
        computer.GPU = "NVIDIA RTX 3090";
    }

    public void SetRAM()
    {
        computer.RAM = "32GB DDR4";
    }

    public void SetStorage()
    {
        computer.Storage = "1TB SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

// Конкретный строитель: Строитель офисного компьютера
public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer computer = new Computer();

    public void SetCPU()
    {
        computer.CPU = "Intel Core i5";
    }

    public void SetGPU()
    {
        computer.GPU = "Integrated Graphics";
    }

    public void SetRAM()
    {
        computer.RAM = "16GB DDR4";
    }

    public void SetStorage()
    {
        computer.Storage = "512GB SSD";
    }

    public Computer GetComputer()
    {
        return computer;
    }
}

// Директор: Управляет процессом сборки
public class Director
{
    private IComputerBuilder builder;

    public Director(IComputerBuilder builder)
    {
        this.builder = builder;
    }

    public void BuildComputer()
    {
        builder.SetCPU();
        builder.SetGPU();
        builder.SetRAM();
        builder.SetStorage();
    }

    public Computer GetComputer()
    {
        return builder.GetComputer();
    }
}