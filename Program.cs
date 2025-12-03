// See https://aka.ms/new-console-template for more information
using ConsoleQuest;

Console.WriteLine("Hello, World!");



Item item = new Item("Меч", 10, 500);



var charcater1 = new Character(new Skills(), "Person1");
var character2 = new Character(new Skills(), "Person1");

charcater1.Inventory.AddItem(item);
charcater1.Inventory.AddItem(item);
charcater1.Inventory.AddItem(item);

Shop shop1 = new Shop();

// Новая строчка
charcater1.Print();
charcater1.Inventory.Display();



