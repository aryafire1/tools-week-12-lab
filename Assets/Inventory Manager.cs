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
        Debug.Log("LINEAR SEARCH FOR MACE: ");
        Debug.Log(LinearSearchByName(inventory, "Mace"));

        // Task 2: Binary Search
        Debug.Log("BINARY SEARCH FOR ID 4: ");

        inventory.Sort((item1, item2) => item1.id.CompareTo(item2.id));

        Debug.Log(inventory[BinarySearchByID(inventory, 4)]);

        // Task 3: Quick Sort
        QuickSortByValue(inventory, 0, inventory.Count - 1);

        Debug.Log("QUICK SORT BY VALUE: ");
        for (int i = 0; i < inventory.Count; i++) {
            Debug.Log(inventory[i]);
        }
    }

    // task 1
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

    // task 2
    int BinarySearchByID(List<InventoryItem> inventory, int target)
    {
        int left = 0;
        int right = inventory.Count - 1;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;

            if(inventory[mid].id == target)
            {
                return mid;
            }
            else if(inventory[mid].id < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    // task 3
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
}
