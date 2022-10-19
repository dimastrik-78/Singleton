using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemsTypes", menuName = "New item", order = 51)]
public class Resource
{
    public enum ResourceType { Wood, Stone, Gold, Money }
    public ResourceType ItemType;
    public int ItemCount;

    public Resource(ResourceType type, int count)
    {
        ItemType = type;
        ItemCount = count;
    }
}
