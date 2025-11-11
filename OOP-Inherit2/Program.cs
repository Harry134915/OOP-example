//using System;

//class Father
//{
//    public void Show()
//    {
//        Console.WriteLine("Father.Show()");
//    }
//}

//class Son : Father
//{
//    public void Show()
//    {
//        Console.WriteLine("Son.Show() —— 隐藏");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Father f = new Son();
//        Son s = new Son();

//        f.Show(); // 输出：Father.Show()
//        s.Show(); // 输出：Son.Show() —— 隐藏
//    }
//}


using System;
class Father
{
    public virtual void Show() { Console.WriteLine("Father.Show()"); }
}

class Son : Father
{
    public override void Show() { Console.WriteLine("Son.Show() —— 隐藏"); }
}

class GrandSon : Son
{
    public new void Show() { Console.WriteLine("GrandSon.Show() —— 重写"); }
}

class Program
{
    static void Main()
    {
        Father f1 = new Son();
        f1.Show(); // Father.Show() —— 隐藏，只看类型

        Father f2 = new GrandSon();
        f2.Show(); // GrandSon.Show() —— 重写，多态

        //重写(override)：运行时决定，调用结果看"对象类型"
        //隐藏(new)：编译时决定，调用结果看"变量类型"
    }
}



