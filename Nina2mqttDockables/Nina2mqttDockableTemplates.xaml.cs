﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace USARedDragon.NINA.Nina2mqtt.Nina2mqttDockables {
    [Export(typeof(ResourceDictionary))]
public partial class MyPluginDockableTemplates : ResourceDictionary {
    public MyPluginDockableTemplates() {
        InitializeComponent();
    }
}
}