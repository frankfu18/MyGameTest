using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FrankGame
{
    public static class GameConfig
    {
        public readonly static SettingConfig Setting = SettingConfig.Instance;
        public readonly static LogConfig Log = LogConfig.Instance;
        public readonly static PathConfig Path = PathConfig.Instance;
        public readonly static LocalizationConfig Localization = LocalizationConfig.Instance;
        public readonly static AudioConfig Audio = AudioConfig.Instance;
    }
}
