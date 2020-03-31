﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVLauncher.Addon;
using XIVLauncher.Game;

namespace XIVLauncher.Settings
{
    public interface ILauncherSettingsV3
    {
        #region Launcher Setting

        DirectoryInfo GamePath { get; set; }
        bool IsDx11 { get; set; }
        bool AutologinEnabled { get; set; }
        List<AddonEntry> AddonList { get; set; }
        bool UniqueIdCacheEnabled { get; set; }
        bool CharacterSyncEnabled { get; set; }
        string AdditionalLaunchArgs { get; set; }
        bool InGameAddonEnabled { get; set; }
        bool SteamIntegrationEnabled { get; set; }
        ClientLanguage Language { get; set; }
        string CurrentAccountId { get; set; }
        bool? EncryptArguments { get; set; }

        #endregion
    }
}