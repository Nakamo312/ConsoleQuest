using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleQuest;

public class Inventory
{
    public int Size { get; }
    private List<Item> _items;
    public float MaxWeight { get; } = 50;
    public float Weight { get; private set; }
    public Inventory(int size)
    {
        this.Size = size;
        _items = new List<Item>(size);
    }

    public Item? GetItem(string name)
    {
        foreach (var item in _items)
        {
            if (item.Name == name) return item;
        }

        return null;
    }

    public bool AddItem(Item item)
    {
        if (item.Weight + Weight > MaxWeight) return false;
        if (_items.Count() + 1 > Size) return false;
        _items.Add(item);
        Weight += item.Weight;
        return true;
    }

    public Item? RemoveItem(string name) 
    { 
        foreach (Item item in _items)
        {
            if (item.Name == name)
            {
                Weight -= item.Weight;
                _items.Remove(item);
                return item;
            }
        }
        return null;

    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;

        const int NAME_WIDTH = 20;
        const int WEIGHT_WIDTH = 12;
        const int COST_WIDTH = 10;
        const int TOTAL_CONTENT_WIDTH = NAME_WIDTH + WEIGHT_WIDTH + COST_WIDTH + 6 + 2;

        string separator = new String('═', TOTAL_CONTENT_WIDTH);

        Console.WriteLine($"╔{separator}╗");
        Console.WriteLine($"║ {"Name",-NAME_WIDTH} ║ {"Weight",WEIGHT_WIDTH} ║ {"Cost",COST_WIDTH} ║");
        Console.WriteLine($"╠{separator}╣");

        if (_items.Count == 0)
        {
            Console.WriteLine($"║ {"Инвентарь пуст.",TOTAL_CONTENT_WIDTH} ║");
        }
        else
        {
            foreach (Item item in _items)
            {
                Console.WriteLine($"║ {item.Name,-NAME_WIDTH} ║ {item.Weight,WEIGHT_WIDTH:F1} ║ {item.Cost,COST_WIDTH} ║");
            }
        }

        Console.WriteLine($"╚{separator}╝");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
