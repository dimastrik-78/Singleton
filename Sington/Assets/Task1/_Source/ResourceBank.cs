using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBank
{
    #region MyRegion
    // private static ResourceBank instance;
    // public static ResourceBank Instance
    // {
    //     get
    //     {
    //         if (instance == null)
    //         {
    //             UnityEngine.Debug.Log("create RB");
    //             instance = new ResourceBank();
    //         }
    //
    //         return instance;
    //     }
    // }
    #endregion

    #region MyRegion
    static  ResourceBank(){}
    private ResourceBank(){}
    private static readonly ResourceBank instance = new ResourceBank();
    
    public static ResourceBank Instance
    {
        get => instance;
    }
    #endregion

    #region MyRegion
    


    #endregion
    public void Debug()
    {
        UnityEngine.Debug.Log("ResourceBank instance");
    }
}
