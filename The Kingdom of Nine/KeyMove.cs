using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace The_Kingdom_of_Nine
{
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
    public class KeyMove
    {
        public static MANNode man = new MANNode();
        public KeyMove(int x,int  y)
        {
            man.x = x;
            man.y = y;
        }
        public void LeftMove(object sender, EventArgs e)
        {
            man.x -= 1;
            if (man.x > 16 || man.y > 16 || man.x < 0 || man.y < 0)
            {
                //判断越界
                man.x += 1;

            }
            //判断撞墙
            //判断撞到道具         
        }
        public void RightMove(object sender, EventArgs e)
        {
            man.x += 1;
            if (man.x > 16 || man.y > 16 || man.x < 0 || man.y < 0)
            {
                //判断越界
                man.x += 1;

            }
            //判断撞墙
            //判断撞到道具         
        }
        public void UpMove(object sender, EventArgs e)
        {
            man.y -= 1;
            if (man.x > 16 || man.y > 16 || man.x < 0 || man.y < 0)
            {
                //判断越界
                man.x += 1;

            }
            //判断撞墙
            //判断撞到道具         
        }
        public void DownMove(object sender, EventArgs e)
        {
            man.y -= 1;
            if (man.x > 16 || man.y > 16 || man.x < 0 || man.y < 0)
            {
                //判断越界
                man.x += 1;

            }
            //判断撞墙
            //判断撞到道具         
        }
        public void keypress(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.W)
            {
                UpMove(sender, e);
            }
            if (e.Key == Key.A)
            {
                LeftMove(sender, e);
            }
            if (e.Key == Key.S)
            {
                DownMove(sender, e);
            }
            if (e.Key == Key.D)
            {
                RightMove(sender, e);
            }

        }
    }
}
