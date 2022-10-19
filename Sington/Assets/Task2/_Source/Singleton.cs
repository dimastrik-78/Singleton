using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Singleton
{
    public Dictionary<Resource.ResourceType, Resource> _resourceDictionary =
        new Dictionary<Resource.ResourceType, Resource>()
        {
            [Resource.ResourceType.Wood] = new Resource(Resource.ResourceType.Wood, 5),
            [Resource.ResourceType.Gold] = new Resource(Resource.ResourceType.Gold, 72),
            [Resource.ResourceType.Stone] = new Resource(Resource.ResourceType.Stone, 30),
            [Resource.ResourceType.Money] = new Resource(Resource.ResourceType.Money, 0)
        };
    private Resource _resource;
    public int CountResource(Resource resourceType) => resourceType.ItemCount;

    public void AddingResource(Resource.ResourceType resourceType, int addCount)
    {
        _resourceDictionary[resourceType].ItemCount += addCount;
        // Debug.Log(resourceType);
        // Debug.Log(_resourceDictionary[resourceType].ItemCount);
    }
}
