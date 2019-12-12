﻿using IPA.Config;
using IPA.Config.Stores;
using IPA.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPA.Loader
{
    internal class DisabledConfig
    {
        public static Config.Config Disabled { get; set; }

        public static DisabledConfig Instance;

        public static void Load()
        {
            Disabled = Config.Config.GetConfigFor("Disabled Mods", "json");
            Instance = Disabled.Generated<DisabledConfig>();
        }

        public virtual bool Reset { get; set; } = true;

        public virtual HashSet<string> DisabledModIds { get; set; } = new HashSet<string>();

        protected virtual void OnReload()
        {
            if (DisabledModIds == null)
                DisabledModIds = new HashSet<string>();
        }
    }
}
