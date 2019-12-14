using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiddler.Demo.Api
{
    /// <summary>
    /// 为插件提供 fiddler 布局相关的支持
    /// </summary>
    public interface IFiddlerLayout
    {
        /// <summary>
        /// fiddler tab view 尺寸变化时调用。
        /// </summary>
        /// <param name="size"></param>
        void OnTabViewSizeChanged(Size size);
    }
}
