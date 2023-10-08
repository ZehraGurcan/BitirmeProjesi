/*using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SearchService;
using UnityEditor;

public class UIControllerFlowerInventory : MonoBehaviour
{
    public List<UISlotController> uiList = new List<UISlotController>();
    FlowerInventoryTutan flowerinventorytutan;
    
    private void Start()
    {
        flowerinventorytutan = GetComponent<FlowerInventoryTutan>();
        UiUpdate();
        
    }

    private void Update()
    {
        UiUpdate();
    }

    public void UiUpdate()
    {
        for (int i=0; i<uiList.Count; i++)
        {
            if (flowerinventorytutan.flowerInventory.flowerSlots[i].slotIsFull == true)
            {
                uiList[i].icon.sprite = flowerinventorytutan.flowerInventory.flowerSlots[i].item.itemIcon;
                uiList[i].text.gameObject.SetActive(true);

                if (flowerinventorytutan.flowerInventory.flowerSlots[i].item.itemPrefab.CompareTag("Water"))
                    uiList[i].text.text = flowerinventorytutan.flowerInventory.flowerSlots[i].item.waterValue.ToString();

                if (flowerinventorytutan.flowerInventory.flowerSlots[i].item.itemPrefab.CompareTag("Sun"))
                    uiList[i].text.text = flowerinventorytutan.flowerInventory.flowerSlots[i].item.sunValue.ToString();

                if (flowerinventorytutan.flowerInventory.flowerSlots[i].item.itemPrefab.CompareTag("Earth"))
                    uiList[i].text.text = flowerinventorytutan.flowerInventory.flowerSlots[i].item.earthValue.ToString();

                if (flowerinventorytutan.flowerInventory.flowerSlots[i].item.itemPrefab.CompareTag("Item"))
                    uiList[i].text.text = flowerinventorytutan.flowerInventory.flowerSlots[i].item.trivialValue.ToString();
                

            }
            else 
            {
                uiList[i].icon.sprite = null;
                //uiList[i].icon.sprite = gameObject.GetComponent<FlowerInventoryTutan>().flowerInventory.flowerSlots[i].item.itemNullIcon;
                uiList[i].text.gameObject.SetActive(false); 
            }
        }
    }
}*/
