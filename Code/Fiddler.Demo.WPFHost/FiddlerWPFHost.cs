using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiddler.Demo.Api;

namespace Fiddler.Demo.WPFHost
{
    public class FiddlerWPFHost : UserControl, IFiddlerLayout
    {
        private System.Windows.Forms.Integration.ElementHost wpfElementHost;

        public FiddlerWPFHost()
        {
            InitializeComponent();
            this.SizeChanged += OnSizeChanged;
        }

        /// <summary>
        /// 添加 WPF 控件
        /// </summary>
        /// <param name="wpfUiElement"></param>
        public void AddWpfUIElement(System.Windows.UIElement wpfUiElement)
        {
            wpfElementHost.Child = wpfUiElement;
        }

        /// <summary>
        /// 在 Host 尺寸变化时，调整 WPF 控件的大小。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnSizeChanged(object sender, EventArgs e)
        {
            wpfElementHost.Width = this.Width;
            wpfElementHost.Height = this.Height;
        }

        /// <summary>
        /// fiddler tab view 大小变化时，由 <see cref="IFiddlerLayout"/> 调用。
        /// </summary>
        /// <param name="size"></param>
        void IFiddlerLayout.OnTabViewSizeChanged(Size size)
        {
            // 更新此 Host 的尺寸。
            this.Width = this.Parent.Width;
            this.Height = this.Parent.Height;
        }

        private void InitializeComponent()
        {
            this.wpfElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // wpfElementHost
            // 
            this.wpfElementHost.Location = new System.Drawing.Point(0, 0);
            this.wpfElementHost.Name = "wpfElementHost";
            this.wpfElementHost.Size = new System.Drawing.Size(500, 300);
            this.wpfElementHost.TabIndex = 0;
            this.wpfElementHost.Text = "wpfElementHost";
            this.wpfElementHost.Child = null;
            // 
            // FiddlerWPFHost
            // 
            this.Controls.Add(this.wpfElementHost);
            this.Name = "FiddlerWPFHost";
            this.Size = new System.Drawing.Size(500, 300);
            this.ResumeLayout(false);
        }

    }
}
