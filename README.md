# Custom Attribute Unity
Untiy官方中提供了许多方便的特性，使得我们能够更方便去实现自己的项目，而这里将会存放许多本人自己写的一些Unity特性，如果有什么好点子，可以发邮箱：1325882743@qq.com，告诉我，我们一起讨论做什么样能够方便开发的特性。



注意：特性不能放在Editor文件夹下，否则打包时该脚本不会被打入包内，添加此特性的代码处会报错。



## 特性目录

### DevelopAuthorAttribute

开发人员标注特性

用法比较简单，导入项目后，在函数或者类的上方如下使用即可

```C#
[DevelopAuthor("花城萤火","测试开发人员标注特性而写的类")]
public class TestAttribute
{
    [DevelopAuthor("花城萤火","测试开发人员标注特性而写的函数")]
    public void test()
    {

    }
}
```

