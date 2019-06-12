using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading;


namespace The_Kingdom_of_Nine
{
    /// <summary>
    /// StartWindow.xaml 的交互逻辑
    /// </summary>
    public partial class StartWindow : Window
    {
        public static MANNode MYman = new MANNode();
        public StartWindow()
        {
            InitializeComponent();
            Myattack.Text = "10";
            MyHP.Text = "100";
            Mylevel.Text = "1";
            Grid.SetColumn(man,MYman.x);
            Grid.SetRow(man, MYman.y);
            this.KeyDown += keypress;
        }

        private void test(object sender, MouseEventArgs e)
        {
            Myattack.Text = "200";
            Grid.SetColumn(man, MYman.x);
            Grid.SetRow(man, MYman.y);
        }
        public void setmyman(MANNode node)
        {
            Grid.SetColumn(man, node.x);
            Grid.SetRow(man, node.y);
        }
        public void keypress(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                UpMove(sender, e);
                setmyman(MYman);
            }
            if (e.Key == Key.A)
            {
                LeftMove(sender, e);
                setmyman(MYman);
            }
            if (e.Key == Key.S)
            {
                DownMove(sender, e);
                setmyman(MYman);
            }
            if (e.Key == Key.D)
            {
                RightMove(sender, e);
                setmyman(MYman);
            }

        }



        public void LeftMove(object sender, EventArgs e)
        {
            MYman.x -= 1;
            if (MYman.x > 16 || MYman.y > 16 || MYman.x < 0 || MYman.y < 0)
            {


            }
            //判断撞墙
            //判断撞到道具         
        }
        public void RightMove(object sender, EventArgs e)
        {
            MYman.x += 1;
            if (MYman.x > 16 || MYman.y > 16 || MYman.x < 0 || MYman.y < 0)
            {
                //判断越界
               

            }
            //判断撞墙
            //判断撞到道具         
        }
        public void UpMove(object sender, EventArgs e)
        {
            MYman.y -= 1;
            if (MYman.x > 16 || MYman.y > 16 || MYman.x < 0 || MYman.y < 0)
            {
                //判断越界
  

            }
            //判断撞墙
            //判断撞到道具         
        }
        public void DownMove(object sender, EventArgs e)
        {
            MYman.y += 1;
            if (MYman.x > 16 || MYman.y > 16 || MYman.x < 0 || MYman.y < 0)
            {
                //判断越界
     
            }
            //判断撞墙
            //判断撞到道具         
        }

    }
    public class MANNode
    {
        public int x { set; get; }
        public int y { set; get; }
        public MANNode()
        {
            this.x = 0;
            this.y = 0;
        }
    }
}



