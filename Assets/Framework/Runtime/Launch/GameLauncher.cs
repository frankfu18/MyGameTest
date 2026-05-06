using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace FrankGame
{
    public class GameLauncher 
    {
        private GameEntry gameEntry;
        private Action onLaunchComplete;
        
        public GameLauncher(GameEntry _gameEntry, Action _onComplete)
        {
            this.gameEntry = _gameEntry;
            this.onLaunchComplete = _onComplete;

            Init();
        }

        private void Init()
        {

        }
    }
}
