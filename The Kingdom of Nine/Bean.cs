using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace The_Kingdom_of_Nine
{
    public class Bean:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;                   //属性改变时触发的事件
        private string hP;
        private string dPS;
        private string lEVEL;
        private string mhP;
        private string mdPS;
        private string mlEVEL;
        private string x;
        private string y;

        public string HP                                                      //实际中用到的变量名
        {
            get
            {
                return this.hP;
            }
            set
            {
                if (this.hP != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.hP = value;                                          //更新文件名
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("HP"));
                    }
                }
            }
        }
        public string DPS                                                      //实际中用到的变量名
        {
            get
            {
                return this.dPS;
            }
            set
            {
                if (this.dPS != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.dPS = value;                                          //更新文件名
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("DPS"));
                    }
                }
            }
        }
        public string LEVEL                                                      //实际中用到的变量名
        {
            get
            {
                return this.lEVEL;
            }
            set
            {
                if (this.lEVEL != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.lEVEL = value;                                      
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("LEVEL"));
                    }
                }
            }
        }
        public string MHP                                                      //实际中用到的变量名
        {
            get
            {
                return this.mhP;
            }
            set
            {
                if (this.mhP != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.mhP = value;                                          //更新文件名
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("MHP"));
                    }
                }
            }
        }
        public string MDPS                                                      //实际中用到的变量名
        {
            get
            {
                return this.mdPS;
            }
            set
            {
                if (this.mdPS != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.mdPS = value;                                          //更新文件名
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("MDPS"));
                    }
                }
            }
        }
        public string MLEVEL                                                      //实际中用到的变量名
        {
            get
            {
                return this.mlEVEL;
            }
            set
            {
                if (this.mlEVEL != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.mlEVEL = value;
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("MLEVEL"));
                    }
                }
            }
        }
        public string X                                                      //实际中用到的变量名
        {
            get
            {
                return this.x;
            }
            set
            {
                if (this.x != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.x = value;                                          //更新文件名
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("X"));
                    }
                }
            }
        }
        public string Y                                                      //实际中用到的变量名
        {
            get
            {
                return this.y;
            }
            set
            {
                if (this.y != value)           //如果当前的变量值不等于先前的文件名，说明需要更新文件名
                {
                    this.y = value;                                          //更新文件名
                    if (PropertyChanged != null)                                    //如果已经触发了改变事件
                    {
                        //通知绑定此变量的textbox在前台更新
                        PropertyChanged(this, new PropertyChangedEventArgs("Y"));
                    }
                }
            }
        }
    }
}
