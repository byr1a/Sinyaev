﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        // Получаем данные о резервуарах, установках и заводах
        var tanks = GetTanks();
        var units = GetUnits();
        var factories = GetFactories();
        int choice = -1; // Инициализируем переменную choice, чтобы она не была неопределенной

        // Цикл работы программы
        while (choice != 2) // Зацикливаем программу, пока пользователь не выберет выход (2)
        {
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Выберите вариант вывода: \n" +
                              "0 - Вывести все элементы \n" +
                              "1 - Найти элемент по названию \n" +
                              "2 - Выйти из программы");

            // Получаем выбор пользователя с проверкой на корректность ввода
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                continue; // Перезапускаем цикл, чтобы предложить пользователю выбрать еще раз
            }

            switch (choice)
            {
                case 0:
                    // Выводим общий объем резервуаров
                    var totalVolume = GetTotalVolume(tanks);
                    Console.WriteLine($"Общий объем резервуаров: {totalVolume}");

                    // Выводим информацию о каждом резервуаре, его установке и заводе
                    Console.WriteLine("Вывод всех резервуаров:");
                    foreach (var tank in tanks)
                    {
                        var unit = FindUnit(units, tanks, tank.Name);
                        var factoryOfUnit = FindFactory(factories, unit);
                        Console.WriteLine($"Резервуар {tank.Name} принадлежит установке {unit.Name}, который принадлежит заводу {factoryOfUnit.Name}");
                    }
                    break;

                case 1:
                    // Поиск элемента по названию
                    Console.WriteLine("Введите наименование резервуара для поиска:");
                    string searchTankName = Console.ReadLine();
                    var foundTank = FindTank(tanks, searchTankName);

                    if (foundTank != null)
                    {
                        var unit = FindUnit(units, tanks, foundTank.Name);
                        var factoryOfUnit = FindFactory(factories, unit);

                        Console.WriteLine($"Резервуар {foundTank.Name} принадлежит установке {unit.Name}, который принадлежит заводу {factoryOfUnit.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"Резервуар с наименованием '{searchTankName}' не найден.");
                    }
                    break;

                case 2:
                    // Выход из программы
                    Console.WriteLine("Программа завершена.");
                    break;

                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, выберите снова.");
                    break;
            }
        }
    }

    // Метод для получения данных о резервуарах
    public static Tank[] GetTanks()
    {
        return new Tank[]
        {
            new Tank(1, "Резервуар 1", "Надземный - вертикальный", 1500, 2000, 1),
            new Tank(2, "Резервуар 2", "Надземный - горизонтальный", 2500, 3000, 1),
            new Tank(3, "Дополнительный резервуар 24", "Надземный - горизонтальный", 3000, 3000, 2),
            new Tank(4, "Резервуар 35", "Надземный - вертикальный", 3000, 3000, 2),
            new Tank(5, "Резервуар 47", "Подземный - двустенный", 4000, 5000, 2),
            new Tank(6, "Резервуар 256", "Подводный", 500, 500, 3)
        };
    }

    // Метод для получения данных об установках
    public static Unit[] GetUnits()
    {
        return new Unit[]
        {
            new Unit(1, "ГФУ-2", "Газофракционирующая установка", 1),
            new Unit(2, "АВТ-6", "Атмосферно-вакуумная установка", 1),
            new Unit(3, "АВТ-10", "Атмосферно-вакуумная установка", 2)
        };
    }

    // Метод для получения данных о заводах
    public static Factory[] GetFactories()
    {
        return new Factory[]
        {
            new Factory(1, "НПЗ№1", "Первый нефтеперерабатывающий завод"),
            new Factory(2, "НПЗ№2", "Второй нефтеперерабатывающий завод")
        };
    }

    // Метод для поиска резервуара по наименованию
    public static Tank FindTank(Tank[] tanks, string tankName)
    {
        foreach (var tank in tanks)
        {
            if (tank.Name == tankName)
            {
                return tank;
            }
        }
        return null;
    }

    // Метод для поиска установки по имени резервуара
    public static Unit FindUnit(Unit[] units, Tank[] tanks, string unitName)
    {
        foreach (var tank in tanks)
        {
            if (tank.Name == unitName)
            {
                foreach (var unit in units)
                {
                    if (unit.Id == tank.UnitId)
                    {
                        return unit;
                    }
                }
            }
        }
        return null;
    }

    // Метод для поиска завода по установке
    public static Factory FindFactory(Factory[] factories, Unit unit)
    {
        foreach (var factory in factories)
        {
            if (factory.Id == unit.FactoryId)
            {
                return factory;
            }
        }
        return null;
    }

    // Метод для вычисления общего объема всех резервуаров
    public static int GetTotalVolume(Tank[] tanks)
    {
        int totalVolume = 0;

        foreach (var tank in tanks)
        {
            totalVolume += tank.Volume;
        }

        return totalVolume;
    }
}

// Класс, представляющий установку
public class Unit
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public int FactoryId { get; }

    public Unit(int id, string name, string description, int factoryId)
    {
        Id = id;
        Name = name;
        Description = description;
        FactoryId = factoryId;
    }
}

// Класс, представляющий завод
public class Factory
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }

    public Factory(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }
}

// Класс, представляющий резервуар
public class Tank
{
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public int Volume { get; }
    public int MaxVolume { get; }
    public int UnitId { get; }

    public Tank(int id, string name, string description, int volume, int maxVolume, int unitId)
    {
        Id = id;
        Name = name;
        Description = description;
        Volume = volume;
        MaxVolume = maxVolume;
        UnitId = unitId;
    }
}
