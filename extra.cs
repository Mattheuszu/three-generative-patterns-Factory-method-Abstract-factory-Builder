using System;

// Шаг 1: Интерфейс Прототипа
public interface IPrototype
{
    IPrototype Clone();
}

// Шаг 2: Конкретный прототип
public class PrototypeCar : IPrototype // Изменили имя класса на PrototypeCar
{
    public string Model { get; set; }

    public PrototypeCar(string model)
    {
        Model = model;
    }

    public IPrototype Clone()
    {
        return new PrototypeCar(this.Model);
    }

    public void ShowModel()
    {
        Console.WriteLine($"Модель автомобиля: {Model}");
    }
}
