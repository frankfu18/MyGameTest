using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager
{
    private List<ISystem> systemList = new List<ISystem>()
    {
        
    };
    
    private bool isLoadDone;
    
    public void Init(MonoBehaviour _mono)
    {
        isLoadDone = false;

        foreach (ISystem sys in systemList)
        {
            sys.Init(_mono);
        }
    }
}
