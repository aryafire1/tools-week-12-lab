using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem
{
    private int _id;
    private string _name;
    private int _value;

    public int id {
        get {return _id;}
        set {_id = value;}
    }
    public string name {
        get {return _name;}
        set {_name = value;}
    }
    public int value {
        get {return _value;}
        set {_value = value;}
    }

    public InventoryItem(string Name, int ID, int Value) {
        _name = Name;
        _id = ID;
        _value = Value;
    }

    public override string ToString()
    {
        return "Name: " + name + ", ID: " + id.ToString() + ", Value: $" + value.ToString() + ".00";
    }
    
}
