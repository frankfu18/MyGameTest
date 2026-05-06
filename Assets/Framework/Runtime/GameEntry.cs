using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrankGame
{
    public abstract class GameEntry : SingleMonoBehaviour<GameEntry>
    {
        protected GameLauncher gameLauncher;//启动器
        
        protected override void Awake()
        {
            Application.targetFrameRate = GameConfig.Setting.FrameRate;
            Application.runInBackground = GameConfig.Setting.RunInBackground;
            
            this.gameObject.AddComponent<NetworkCheck>();
            
            this.gameLauncher = new GameLauncher(this, OnLaunchComplete);
        }
        
        //流程启动完成
        protected virtual void OnLaunchComplete()
        {

        }
    }
}
