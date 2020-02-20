using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var instance1 = new Class1();
            var instance4 = new Class1().showTest();
            var instance2 = new Class1(100);
            var instance3 = new Class1();
            Object obj1 = new Class1();//アップキャスト　Object型がツリー構造の上位 <実務ではあまりみないが、interfaceへの考え方の布石>
            //obj1.//showTestというインスタンスメソッドはないなぜならObjectにはその定義がないから
            Console.WriteLine(instance1.showTest());
        }

    }
}
