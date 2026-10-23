using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrankGame
{
    public abstract class GameEntry : SingleMonoBehaviour<GameEntry>
    {
        public Canvas UICanvas;
        public UnityEngine.EventSystems.EventSystem EventSystem;
        
        protected GameLauncher gameLauncher;//启动器
        
        protected System.Action onLoadStartFunc = null;
        protected System.Action<float> onLoadFinishFunc = null;
        
        protected override void Awake()
        {
            Application.targetFrameRate = GameConfig.Setting.FrameRate;
            Application.runInBackground = GameConfig.Setting.RunInBackground;
            
            this.gameObject.AddComponent<NetworkCheck>();
            
            this.gameLauncher = new GameLauncher(this, OnLaunchComplete);
            this.gameLauncher.RegisterProcedure(typeof(StartUpProcedure));//启动流程
            this.gameLauncher.RegisterProcedure(typeof(CheckVersionProcedure));//检测版本
            this.gameLauncher.RegisterProcedure(typeof(CheckPackageAssetsProcedure));//检测包内资源
            this.gameLauncher.RegisterProcedure(typeof(CheckHotfixProcedure));//检测热更新
            this.gameLauncher.RegisterProcedure(typeof(ResolveAssetsProcedure));//解析资源
            
            OnInit();
        }
        
        protected virtual void OnInit()
        {
        }
        
        private void Start()
        {
            this.gameLauncher.LoadPanel(onLoadStartFunc, onLoadFinishFunc);
        }
        
        //流程启动完成
        protected virtual void OnLaunchComplete()
        {

        }
    }
}
