﻿using MediaBrowser.Model.Plugins;
using System;

namespace Jellyfin.Plugins.TuneIn.Configuration
{
    /// <summary>
    /// Class PluginConfiguration
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        public String Username { get; set; }
        public String LatLon { get; set; }
    }
}
