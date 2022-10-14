using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonComponent : MonoBehaviour
{
   public static SingletonComponent Instance
   {
      get;
      private set;
   }

   private void Awake()
   {
      if (Instance == null)
      {
         Instance = this;
         DontDestroyOnLoad(gameObject);
         return;
      }
      Destroy(gameObject);
   }

   public void DebugSingletonComponent()
   {
      Debug.Log("Singleton Component");
   }
}
