using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClipFix
{
    public class Config
    {
        public bool RunOnStartUp { get; set; } = false;
        public bool RunOnMinimized { get; set; } = false;
        public bool EnableDebugNotification { get; set; } = false;
        public bool DisableOnStartNotification { get; set; } = false;

        internal void Load()
        {
            if(RunOnStartUp)
                Form1.Instance.cbRunOnStartUp.Checked = true;
            if(RunOnMinimized)
               Form1.Instance.cbRunMinimized.Checked = true;
            if(EnableDebugNotification)
               Form1.Instance.cbEnableDebugNotification.Checked = true;
            if(DisableOnStartNotification)
               Form1.Instance.cbDisableStartupNotification.Checked = true;
        }

        internal void Save()
        {
            File.WriteAllText("config.json", Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented));
        }
    }
}
