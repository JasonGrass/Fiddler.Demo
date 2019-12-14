using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler.Demo.Api;
using Fiddler.Demo.UI;
using Fiddler.Demo.WPFHost;

namespace Fiddler.Demo.PluginEntry
{
    /// <summary>
    /// 处理插件的 UI 加载与尺寸变化
    /// </summary>
    class PluginViewController
    {
        private readonly IList<IFiddlerLayout> FiddlerLayoutViews = new List<IFiddlerLayout>();

        /// <summary>
        /// 将 UI 添加到 fiddler 界面上
        /// </summary>
        public void InjectView()
        {
            // new tab
            var eventReportPage = new TabPage("Fiddler Plugin Demo") { ImageIndex = (int)SessionIcons.Silverlight };
            // new WinForm Host
            var host = new FiddlerWPFHost();
            // new WPF View (true plugin view)
            var view = new FiddlerView();

            // add view to host
            host.AddWpfUIElement(view);
            // add host to tab 
            eventReportPage.Controls.Add(host);
            // add tab to fiddler 
            FiddlerApplication.UI.tabsViews.TabPages.Add(eventReportPage);

            if (host is IFiddlerLayout layout)
            {
                FiddlerLayoutViews.Add(layout);
            }

            // 提供 fiddler 窗口变化的支持
            FiddlerApplication.UI.tabsViews.SizeChanged += TabsViewsOnSizeChanged;
            FiddlerApplication.UI.tabsViews.Selected += (sender, args) =>
            {
                UpdateViewSize();
            };
        }

        private void TabsViewsOnSizeChanged(object sender, EventArgs e)
        {
            UpdateViewSize();
        }

        private void UpdateViewSize()
        {
            var size = FiddlerApplication.UI.tabsViews.Size;
            foreach (var view in FiddlerLayoutViews)
            {
                view.OnTabViewSizeChanged(size);
            }
        }

    }
}
