using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonTest : MonoBehaviour
{
    void Start()
    {
        // SingletonComponent.Instance.DebugSingletonComponent();
        ResourceBank.Instance.Debug();
    }
}
