using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> inventory = new List<InventoryItem>();

    // Start is called before the first frame update
    void Start()
    {
        inventory.Add(new InventoryItem("Sword"));
        inventory.Add(new InventoryItem("Axe"));
        inventory.Add(new InventoryItem("Mace"));
        inventory.Add(new InventoryItem("Bow"));
        inventory.Add(new InventoryItem("Stone"));
        inventory.Add(new InventoryItem("Iron"));
        inventory.Add(new InventoryItem("Gold"));
        inventory.Add(new InventoryItem("Diamond"));

        Debug.Log(LinearSearchByName(inventory, "Mace"));

        /*for (int i = 0; i < inventory.Count; i++) {
            Debug.Log($"Name: {inventory[i].name}, ID: {inventory[i].id}, Value: {inventory[i].value}");
        }*/
        //test to see values being implemented
    }

    //task 1
    static string LinearSearchByName(List<InventoryItem> list, string itemName)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].name == itemName)
            {
                return list[i].name;
            }
        }
        return null;
    }



}
