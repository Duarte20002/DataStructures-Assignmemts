using System;
using System.Collections;

public class Item
{
    public enum Type
    {
        Weapon,
        Armor,
        Potion,
        Scroll
    }

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public string name { get; }
    public Rarity rarity { get; }
    public Type type { get; }
    public int numberSlots { get; }
    public bool singleUse { get; }


    public Item(string name, Rarity rarity, Type type, int numberSlots, bool singleUse)
    {
      this.name = name;
      this.rarity = rarity;
      this.type = type;
      this.numberSlots = numberSlots;
      this.singleUse = singleUse;
    }
}

public class Inventory
{
    Hashtable inventory = new Hashtable();

    private int inventorySize;

    private int inventoryOccupied;

    public bool insert (Item item)
    {
        if (item.numberSlots + inventoryOccupied <= inventorySize)
        {
            inventory.Add(item.name, item);
            inventoryOccupied += item.numberSlots;
            return true;
        }
        return false;
    }

    public Item Remove(string name)
    {
        if (inventory.ContainsKey(name))
        {
            Item item = (Item)inventory[name];
            inventory.Remove(name);
            inventoryOccupied -= item.numberSlots;
            return item;
        }
        return null;
    }

    public int itemCount
    {
        get { return inventory.Count; }
    }

    public int occupiedSlots
    {
        get { return inventoryOccupied; }
    }

    public void printInventory()
    {
        if(inventory.Count == 0)
        {
            Console.WriteLine("Inventory is empty, go get some items loser >:)");
            return;
        }

        Console.WriteLine("Items available in your inventory:");
        foreach (DictionaryEntry entry in inventory)
        {
            Item item = ((Item)entry.Value);
            Console.WriteLine($"- {item.name}");
        }
    }

    public void cleanInventory()
    {
        inventory.Clear();
        inventoryOccupied = 0;
    }

    public void save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(inventorySize);                        //maximum number of slots
            foreach (DictionaryEntry entry in inventory)
            {
                Item item = (Item)entry.Value;
                writer.WriteLine($"{item.name},{item.rarity},{item.type},{item.numberSlots},{item.singleUse}");
            }
        }
        Console.WriteLine($"Inventory saved to this filename: {filename}");
    }

    public void load(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File name '{filename}' not found.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            inventorySize = int.Parse(reader.ReadLine());            //Read max slots

            cleanInventory();                                        // clear before loading

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');

                if (parts.Length == 5)
                {
                    string name = parts[0];
                    Item.Rarity rarity = (Item.Rarity)Enum.Parse(typeof(Item.Rarity), parts[1]);
                    Item.Type type = (Item.Type)Enum.Parse(typeof(Item.Type), parts[2]);
                    int numberSlots = int.Parse(parts[3]);
                    bool singleUse = bool.Parse(parts[4]);

                    Item newItem = new Item(name, rarity, type, numberSlots, singleUse);
                    insert(newItem);
                }
            }
        }
        Console.WriteLine($"Inventory loaded from {filename} file");
    }
}