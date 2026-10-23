using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FrankGame
{
    public abstract class GameLaunchProcedure
    {
        protected GameLauncher launcher;
        protected Type nextProcedure;//下一个流程    
        
        public void Init(GameLauncher _launcher)
        {
            this.launcher = _launcher;

            OnInit();
        }
        
        protected virtual void OnInit()
        {

        }
        
        public void Enter(params object[] _params)
        {
            Log.Debug("Procedure enter: " + this.GetType().Name);

            OnEnter(_params);
        }

        protected virtual void OnEnter(params object[] _params)
        {

        }
    }
}
