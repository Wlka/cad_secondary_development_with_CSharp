### C#+AutoCAD二次开发实现不关闭CAD程序重新加载dll文件

##### 主要解决思路来源于https://blog.csdn.net/qq_26739115/article/details/119959843 以及 https://www.cnblogs.com/xwgli/p/11268650.html

- 启动项目时需要用netload命令加载NetloadX.dll文件，之后就可以利用NetloadX类里面的NLX加载编译后的其他dll文件了

- 解决方案里有另一个项目，这个项目上需要将AssemblyInfo.cs文件里面的代码按下面内容进行修改，此外还需要把该项目的csproj文件里面的Deterministic属性从true改成false，我用的是2017，如果不修改这个属性会报出CS8357错误。

  ```c#
  //[assembly: AssemblyVersion("1.0.0.0")]
  //[assembly: AssemblyFileVersion("1.0.0.0")]
  [assembly: AssemblyVersion("1.1.*")]
  ```

##### 以上就是我的解决思路，如果有更好的解决办法，欢迎大家一起讨论！
