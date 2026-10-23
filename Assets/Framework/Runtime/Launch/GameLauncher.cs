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
        private Dictionary<Type, GameLaunchProcedure> staticProcedureDic = new Dictionary<Type, GameLaunchProcedure>();//静态流程
        
        private LancherPanel lancherPanel;
        
        public GameLauncher(GameEntry _gameEntry, Action _onComplete)
        {
            this.gameEntry = _gameEntry;
            this.onLaunchComplete = _onComplete;

            Init();
        }

        private void Init()
        {

        }
        
        public void RegisterProcedure(Type _procedureType)
        {
            staticProcedureDic[_procedureType] = CreateGameProcedure(_procedureType);
        }
        
        private GameLaunchProcedure CreateGameProcedure(Type _procedureType)
        {
            GameLaunchProcedure procedure = (GameLaunchProcedure)Activator.CreateInstance(_procedureType);
            procedure.Init(this);

            return procedure;
        }
        
        public void LoadPanel(System.Action _onLoadStartFunc = null, System.Action<float> _onLoadFinishFunc = null)
        {
            lancherPanel = LancherPanel.Load(gameEntry.UICanvas.gameObject, _onLoadStartFunc, _onLoadFinishFunc);
        }
    }
}
