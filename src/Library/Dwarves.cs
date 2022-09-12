namespace Library ;
using System.Collections;
using System.Collections.Generic;
public class Dwarves
{
    public  Dwarves(string name){
     this.name = name ;
     this.strength = 50 ;
     this.resistance = 100 ;
     this.friends = new List<string>();
     this.equipment = new List<Item>();
    }
    public string name {get; set;}
    public int strength {get; set;}
    public int resistance  {get; set;}
    public List<string> friends  {get; set;}
    public List<Item> equipment {get; set;}
    
    public void EquipItem(Item item) {
       this.equipment.Add(item);
       
    }
    public void UnequipItem(Item item){
        this.equipment.RemoveAt(this.equipment.IndexOf(item));
    }

}