本项目基于Maui + Blazor + .Net9 技术实现。

### 参考
* [.NET 9 - Blazor组件构造函数注入服务](https://blog.csdn.net/limingdinghao/article/details/142666059)
* [疯狂吐槽 MAUI 以及 MAUI 入坑知识点](https://www.cnblogs.com/whuanle/p/17060473.html)
* [50条MAUI踩坑记](https://www.cnblogs.com/pylblog/p/18054137)
* [.NET8 Blazor的Auto渲染模式的初体验](https://cloud.tencent.com/developer/article/2360929)

#### AOT
参考
* [ASP.NET Core 对本机 AOT 的支持](https://learn.microsoft.com/zh-cn/aspnet/core/fundamentals/native-aot?view=aspnetcore-9.0)
* [.NET 9 AOT的突破 - 支持老旧Win7与XP环境](https://www.cnblogs.com/lsq6/p/18519287)
* [How to compile a .NET winform to native code?](https://stackoverflow.com/questions/77014217/how-to-compile-a-net-winform-to-native-code) 这里提到一个例子[WinFormsComInterop](https://github.com/kant2002/WinFormsComInterop),可以打包发布。

 在项目中加上这条就可以做到编译不错
```cs
 <_SuppressWinFormsTrimError>true</_SuppressWinFormsTrimError>
```
  