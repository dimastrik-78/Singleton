using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private InputField inputField;
    [SerializeField] private Dropdown dropdown;

    private Singleton _singleton;
    private Resource _type;
    void Start()
    {
        _singleton = new Singleton();
        _type = new Resource(Resource.ResourceType.Wood, 0);
    }
    public void AddButton()
    {
        if (dropdown.value == 0)
        {
            _type.ItemType = Resource.ResourceType.Wood;
            _type.ItemCount = _singleton.CountResource(_type);
        }
        else if (dropdown.value == 1)
        {
            _type.ItemType = Resource.ResourceType.Money;
            _type.ItemCount = _singleton.CountResource(_type);
        }
        else if (dropdown.value == 2)
        {
            _type.ItemType = Resource.ResourceType.Stone;
            _type.ItemCount = _singleton.CountResource(_type);
        }
        else if (dropdown.value == 3)
        {
            _type.ItemType = Resource.ResourceType.Gold;
            _type.ItemCount = _singleton.CountResource(_type);
        }
        
        _singleton.AddingResource(_type.ItemType, int.Parse(inputField.text));
    }
}
