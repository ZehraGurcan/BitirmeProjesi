/*using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FlowerInventoryTutan : MonoBehaviour
{
    public FlowerInventory flowerInventory;
    UIControllerFlowerInventory inventory;

    public GameObject water;



    bool hasChosen;
    int tempIndex;
    Slots tempSlot;

    public bool useActive = false;

    private void Start()
    {
        inventory = gameObject.GetComponent<UIControllerFlowerInventory>();
        

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            choice(1);
            delete();
            inventory.UiUpdate();
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            choice(2);
            delete();
            inventory.UiUpdate();
        }else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            choice(3);
            delete();
            inventory.UiUpdate();
        }else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            choice(4);
            delete();
            inventory.UiUpdate();
        }else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            choice(5);
            delete();
            inventory.UiUpdate();
        }else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            choice(6);
            delete();
            inventory.UiUpdate();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            useActive = true;
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                choice(1);
                kullan();
                delete();
                inventory.UiUpdate();
                
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                choice(2);
                kullan();
                delete();
                inventory.UiUpdate();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                choice(3);
                kullan();
                delete();
                inventory.UiUpdate();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                choice(4);
                kullan();
                delete();
                inventory.UiUpdate();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                choice(5);
                kullan();
                delete();
                inventory.UiUpdate();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                choice(6);
                kullan();
                delete();
                inventory.UiUpdate();
            }

            

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            useActive = false;
        }

    }

    public void choice(int index)
    {
        
        
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (hasChosen == false)
                {
                    tempIndex = 0;
                    tempSlot = flowerInventory.flowerSlots[tempIndex];
                    hasChosen = true;
                }

            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if (hasChosen == false)
                {
                    tempIndex = 1;
                    tempSlot = flowerInventory.flowerSlots[tempIndex];
                    hasChosen = true;
                }

            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                if (hasChosen == false)
                {
                    tempIndex = 2;
                    tempSlot = flowerInventory.flowerSlots[tempIndex];
                    hasChosen = true;
                }

            }
            else if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                if (hasChosen == false)
                {
                    tempIndex = 3;
                    tempSlot = flowerInventory.flowerSlots[tempIndex];
                    hasChosen = true;
                }

            }
            else if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                if (hasChosen == false)
                {
                    tempIndex = 4;
                    tempSlot = flowerInventory.flowerSlots[tempIndex];
                    hasChosen = true;
                }

            }
            else if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                if (hasChosen == false)
                {
                    tempIndex = 5;
                    tempSlot = flowerInventory.flowerSlots[tempIndex];
                    hasChosen = true;
                }

            
        }
        

        
        
    }

    public void delete()
    {
        if(hasChosen == true)
        {
                flowerInventory.deleteItem(tempIndex);
                hasChosen = false;
        }
    }

   
    public void kullan()
    {
        if(useActive == true)
        {
            
                flowerInventory.useItem(tempIndex);
            //water.GetComponent<WaterBar>().can += flowerInventory.flowerSlots[tempIndex].item.waterValue;
            //PlayerPrefs.SetFloat("Water", water.GetComponent<WaterBar>().can + flowerInventory.flowerSlots[tempIndex].item.waterValue);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item") || other.gameObject.CompareTag("Water") || other.gameObject.CompareTag("Earth") || other.gameObject.CompareTag("Sun"))
        {
            flowerInventory.addItem(other.gameObject.GetComponent<ItemTutan>().item);
            inventory.UiUpdate();
        }
    }
}*/
