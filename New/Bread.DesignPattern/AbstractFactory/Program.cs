using System;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreteFactory;

namespace AbstractFactory
{
    class Program
    {
        /*
         * 抽象工厂与工厂方法最大的区别就在于，工厂方法模式针对的是一个产品等级结构，而抽象工厂模式需要面对多个产品等级结构，一个工厂等级结构可以负责多个不同产品等级中的产品对象的创建。
         * 
         * 一个界面皮肤库的实例，多个产品等级结构，如果使用工厂方法模式的，代码就非常多了。
         * 增加新的产品等级结构很麻烦，增加新的产品等级结构很麻烦，增加新的产品等级结构很麻烦！！！（重要的事情说三遍）因为需要对原有系统进行较大的修改，甚至需要修改抽象层代码，这必然会带来较大的不便，在这个角度，它违背了开闭（对扩展开放，对修改封闭）原则。

　　想想，如果我们需要为单选按钮（RadioButton）提供不同皮肤的风格化显示，会发现无论选择哪种皮肤，单选按钮都显得“格格不入”。
         * 
         * 抽象工厂角色
         * 具体工厂角色
         * 抽象产品角色
         * 具体产品角色
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ISkinFactory skinFactory = new SpringSkinFactory();
            if (skinFactory == null)
            {
                Console.WriteLine("读取当前选中皮肤类型失败...");
            }

            IButton button = skinFactory.CreateButton();
            ITextField textField = skinFactory.CreateTextField();
            IComboBox comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();

            Console.ReadKey();
        }
    }
}
