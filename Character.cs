using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleQuest;

public class Skills {
    public int Strange { get; set; }
    public int Charm { get; set; }
    public int Luck { get; set; }
};
public class Character
{
    private string _name;
    public Skills Skills { get; set; }
    public int Balance { get; set; }
    public Inventory Inventory { get; }

    public string Name { get  => _name; }
    public Character(Skills skills, string name)
    {
        Skills = new Skills
        {
            Strange = skills.Strange,
            Charm = skills.Charm,
            Luck = skills.Luck,
        };
        Inventory = new Inventory(5);
        _name = name;
        Balance = 0;
    }
    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"╔{new String('═', 23)}╗");

        Console.WriteLine($"║ {_name,21} ║");

        Console.WriteLine($"║{new String('═', 23)}║");

        Console.WriteLine($"║ {"Strange",-15}:{Skills.Strange,5} ║");

        Console.WriteLine($"║ {"Charm",-15}:{Skills.Charm,5} ║");

        Console.WriteLine($"║ {"Luck",-15}:{Skills.Luck,5} ║");

        Console.WriteLine($"║ {"Balance",-15}:{Balance,5} ║");

        Console.WriteLine($"╚{new String('═', 23)}╝");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
