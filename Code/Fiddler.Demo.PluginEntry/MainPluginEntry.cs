using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler;

// Fiddler 最低版本要求
[assembly: RequiredVersion("2.1.8.1")]

namespace Fiddler.Demo.PluginEntry
{
    public class MainPluginEntry : IAutoTamper
    {
        private PluginViewController PluginViewController { get; }

        public MainPluginEntry()
        {
            PluginViewController = new PluginViewController();
        }

        public void OnLoad()
        {
            // 将 UI 添加到 fiddler 界面上
            PluginViewController.InjectView();
        }

        public void OnBeforeUnload()
        {
            
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
            
        }

        public void AutoTamperRequestAfter(Session oSession)
        {
            
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
            
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
            
        }

        public void OnBeforeReturningError(Session oSession)
        {
            
        }

    }
}
