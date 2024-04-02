using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private int index;
    private string name;
    private ItemType type;
    private Sprite image;

    public int Index
    { 
        get { return index;}
        set { index = value; }
    
    
    }

    public string Name
    {
        get { return name; }
        set { name = value; }


    }

    public ItemType Type
    {
        get { return type; }
        set { type = value; }


    }

    public Sprite Image
    {
        get { return Image; }
        set { Image = value; }


    }

    public Item(int index, string name, ItemType type)
    {
        this.index = index;
        this.name = name;
        this.type = type;
    }

}

public enum ItemType
{
    weapon,
    Armor,
    Potion,
    QuestItem

}

public class Inventory
{
    private Item[] items = new Item[16];

    //아이템 인덱서
    public Item this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }
    //현재 인벤토리에 있는 아이템 수
    public int ItemCount
    {
        get
        {
            int count = 0; //아이템 수 검사를 위한 변수
            foreach (Item item in items)
            {
                if (item != null) count++;
            }
            return ItemCount;
        }
    }
    public bool Additem(Item item)
    {
        for(int i = 0; i < items.Length; i++)
        {
            if(items[i] == null)
            {
                items[i] = item;
                return true;
            }
        }
        return false;
    }

    public void RemoveItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                items[i] = null;
                break;
            }
        }
      
    }



}



public class ExSystem : MonoBehaviour
{
    private Inventory inventory = new Inventory();

    void Start()
    {
        Item sword = new Item(100, "Sword", ItemType.weapon);
        Item shield = new Item(100, "Shield", ItemType.Armor);

        

        inventory.Additem(sword);
        inventory.Additem(shield);

        Debug.Log("Player Inventory"  + GetInventoryAsString());

    }

    private string GetInventoryAsString()

    {
        string result = "";
        for (int i = 0; i < inventory.ItemCount; i++)
        {
            if(inventory[i] != null)
            {
                result += inventory[i].Name + ",";
            }
        }
        return result.TrimEnd(',');
    }
}
