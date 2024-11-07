using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<InventoryItem> inventory = new List<InventoryItem>();

    // Start is called before the first frame update
    void Start()
    {
        inventory.Add(new InventoryItem("Sword", 3, 10));
        inventory.Add(new InventoryItem("Axe", 5, 20));
        inventory.Add(new InventoryItem("Mace", 22, 15));
        inventory.Add(new InventoryItem("Bow", 4, 12));
        inventory.Add(new InventoryItem("Stone", 1, 5));
        inventory.Add(new InventoryItem("Gold", 10, 30));
        inventory.Add(new InventoryItem("Diamond", 11, 50));
        inventory.Add(new InventoryItem("Iron", 7, 13));

        // Task 1: Linear Search
        Debug.Log("LINEAR SEARCH: ");
        Debug.Log(LinearSearchByName(inventory, "Mace"));

        //Debug.Log(BinarySearchByID(inventory, inventory[3].id)); //<- bubble search method

        /*for (int i = 0; i < inventory.Count; i++) {
            Debug.Log($"Name: {inventory[i].name}, ID: {inventory[i].id}, Value: {inventory[i].value}");
        }*/
        //test to see values being implemented

        // Task 2: Quick Sort
        QuickSortByValue(inventory, 0, inventory.Count - 1);

        Debug.Log("QUICK SORT: ");
        for (int i = 0; i < inventory.Count; i++) {
            Debug.Log(inventory[i]);
        }
    }

    //task 1
    static InventoryItem LinearSearchByName(List<InventoryItem> list, string itemName)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].name == itemName)
            {
                return list[i];
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

    // task 3
    #region Quick Sort

    int PartitionByValue(List<InventoryItem> inventory, int first, int last)
    {
        int pivot = inventory[last].value;
        int smaller = first - 1;

        for(int element = first; element < last; element++)
        {
            if(inventory[element].value < pivot)
            {
                smaller++;

                InventoryItem temporary = inventory[smaller];
                inventory[smaller] = inventory[element];
                inventory[element] = temporary;
            }
        }

        InventoryItem temporaryNext = inventory[smaller + 1];
        inventory[smaller + 1] = inventory[last];
        inventory[last] = temporaryNext;

        return smaller + 1;
    }

    public void QuickSortByValue(List<InventoryItem> inventory, int first, int last)
    {
        if(first < last)
        {
            int pivot = PartitionByValue(inventory, first, last);

            QuickSortByValue(inventory, first, pivot - 1);
            QuickSortByValue(inventory, pivot + 1, last);
        }
    }
    #endregion
}
