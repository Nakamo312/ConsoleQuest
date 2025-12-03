using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuest;

public struct Item
{
    public string Name { get; set; }
    public float Weight { get; set; }
    public int Cost { get; set; }
    public Item(string name, float weight, int cost)
    {
        this.Name = name;
        this.Weight = weight;
        this.Cost = cost;
    }


    public override string ToString()
    {
        return $"{Name} (Вес: {Weight}, Цена: {Cost} монет)";
    }
}