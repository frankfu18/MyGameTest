using System;
using System.Collections;
using System.Collections.Generic;
using FrankGame;
using UnityEngine;

public class GameRoot : GameEntry
{
    public Action onUpdate;

    private SystemManager sysManager;
    
    protected override void OnInit()
    {
        sysManager = new SystemManager();
        sysManager.Init(this);
    }
}
