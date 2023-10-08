/*using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "FlowerInventory", menuName = "Inventory/Flower Inventory")]
public class FlowerInventory : ScriptableObject
{
    public List<Slots> flowerSlots = new List<Slots>();

    WaterBar water;
    GameObject W;

    private void Awake()
    {
        W = GameObject.Find("SuBar");
    }

    public void deleteItem(int index)
    {
        flowerSlots[index].slotIsFull = false;
        flowerSlots[index].count = 0;
        flowerSlots[index].item = null;
        
    }

    public void useItem(int index)
    {
        W.GetComponent<WaterBar>().can += flowerSlots[index].item.waterValue;
    }

    public void addItem(Item item)
    {
        foreach(Slots slot in flowerSlots)
        {

            if (item.alreadyUsed == false)
            {
                if (slot.slotIsFull == false)
                {
                    slot.addItemToInventory(item);
                    item.alreadyUsed = true;
                    break;
                }
            }
           
        }
    }

}



[System.Serializable]
public class Slots
{
    public bool slotIsFull = false;
    public Item item;
    public int count;

    

    public void addItemToInventory(Item item)
    {
        this.item = item;
        slotIsFull = true;
        count++;
    }

}*/
