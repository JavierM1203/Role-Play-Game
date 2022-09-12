namespace Library;

public class Item
{
    public string itemName {get; set;}
    public string description {get; set;}
    public int damage {get; set;}
    public int defense {get; set;}


    public Item(string itemName, int damage, int defense)
    {
        this.itemName = itemName;
        this.damage = damage;
        this.defense = defense;
    }

}
