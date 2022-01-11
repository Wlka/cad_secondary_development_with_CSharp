### C#+AutoCAD二次开发实现不关闭CAD程序重新加载dll文件

##### 主要解决思路来源于https://blog.csdn.net/qq_26739115/article/details/119959843 以及 https://www.cnblogs.com/xwgli/p/11268650.html

- 启动项目时需要用netload命令加载NetloadX.dll文件，之后就可以利用NetloadX类里面的NLX加载编译后的其他dll文件了

- 解决方案里有另一个项目，这个项目上需要将AssemblyInfo.cs文件里面的代码按下面内容进行修改，此外还需要把该项目的csproj文件里面的Deterministic属性从true改成false，我用的是2017，如果不修改这个属性会报出CS8357错误。

  ```c#
  //[assembly: AssemblyVersion("1.0.0.0")]
  //[assembly: AssemblyFileVersion("1.0.0.0")]
  [assembly: AssemblyVersion("1.1.*")]
  ```

##### 以上就是我的解决思路，这里也再分享一位大佬的解决思路https://www.bilibili.com/video/BV1eq4y1J7wV?p=3 ，他用的也是调用外部dll文件的方式实现不重启CAD重编译项目，不过在实际使用过程中我发现有时候他的这个办法会报错，且无法对项目进行调试，这里我分享的这个思路可以按平常的步骤对开发的项目进行调试。

##### 写在最后，如果有更好的解决办法，欢迎大家一起讨论！！！
