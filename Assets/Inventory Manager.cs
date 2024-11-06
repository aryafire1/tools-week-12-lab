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
        //Debug.Log(BinarySearchByID(inventory, inventory[3].id)); //<- bubble search method

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

    //task 2
    /* Bubble sort method, throwing "not all code paths return a value" error in binary search method
    static int BinarySearchByID(List<InventoryItem> list, int target)
    {
        sortList(list);
        int left = 0;
        int right = list[list.Count - 1].id;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (mid == target)
            {
                return mid; // Return the index if the target is found
            }
            else if (mid < target)
            {
                left = mid + 1; // Narrow the search to the upper half
            }
            else
            {
                right = mid - 1; // Narrow the search to the lower half
            }
        }
    }
    static void sortList(List<InventoryItem> list)
    {
        int length = list.Count;

        for (int element = 0; element < length - 1; element++)
        {
            for (int neighbor = 0; neighbor < length - element - 1; neighbor++)
            {

                if (list[neighbor].id > list[neighbor + 1].id)
                {
                int temporary = list[neighbor].id;
                list[neighbor] = list[neighbor + 1];
                list[neighbor + 1].id = temporary;
                }
            }
        }
    }
    */




}
