using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleQuest;




public class Shop()
{

    public bool Trade(string itemname, Character ch1, Character ch2)
    {
        var item = ch1.Inventory.GetItem(itemname);

        if (item == null) return false;
        if (ch2.Balance < item.Value.Cost) return false;
        ch2.Balance -= item.Value.Cost;

        ch1.Inventory.RemoveItem(itemname);
        ch2.Inventory.AddItem((Item) item);
        return true;
    }

    public void Display(Character ch1, Character ch2)
    {

    }



}



