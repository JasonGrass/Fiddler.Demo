对 Fiddler 插件开发的封装 SDK

[JasonGrass/Fiddler.Plugin.SDK: Fiddler 插件开发 SDK](https://github.com/JasonGrass/Fiddler.Plugin.SDK )

# Fiddler 插件 Demo

Fiddler 插件的 UI，本身使用的 WinForm，这个例子是使用 WinForm 中的 WPF 容器，将 WPF 控件作为 Fiddler 插件的 UI 使用。

为什么使用 WPF ？为了自适应布局呀。

## 如何使用此 Demo

插件的入口程序集为 `Fiddler.Demo.PluginEntry`，编译项目之后，在根目录中的 `Bin` 文件夹可以看到输出。
将输出中的全部 DLL 文件，拷贝到 Fiddler 的插件目录，重新启动 Fiddler 即可看到插件。

![Snipaste_2019-12-14_14-47-36.png](https://i.loli.net/2019/12/14/pk2igmjHr1vwo9T.png)

相关博客：
[Fiddler 插件开发，使用 WPF 作为 UI 控件 - J.晒太阳的猫 - 博客园](https://www.cnblogs.com/jasongrass/p/12039575.html )