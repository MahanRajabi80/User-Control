using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_16_9
{
    public partial class SmartButton : UserControl
    {
        public SmartButton()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------
        private void SmartButton_Load(object sender, EventArgs e)
        {
            button1.Dock = DockStyle.Fill;
        }
        //--------------------------------------------------------------
        protected override void InitLayout()
        {
            base.InitLayout();
            if (this.DesignMode == false && Animation == true)//zaman ejra harekat 
            {
                timer1.Enabled = true;
                timer1.Interval = 1;
                this.Left = AnimationStartX;
            }
            else
                timer1.Enabled = false;
        }
        //--------------------------------------------------------------
        [BrowsableAttribute(true)]
        public string SmartText     //equal text
        {
            get
            {
                return button1.Text;
            }
            set
            {
                button1.Text = value;
            }
        }
        //--------------------------------------------------------------
        //after type override, press space key, to show all override members.
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                button1.BackColor = value;
                base.BackColor = value;
            }
        }
        //--------------------------------------------------------------
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                button1.ForeColor = value;
                base.ForeColor = value;
            }
        }
        //--------------------------------------------------------------
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                button1.BackgroundImage = value;
                base.BackgroundImage = value;
            }
        }
        //--------------------------------------------------------------
        public override ImageLayout BackgroundImageLayout
        {
            get
            {
                return base.BackgroundImageLayout;
            }
            set
            {
                button1.BackgroundImageLayout = value;
                base.BackgroundImageLayout = value;
            }
        }
        //--------------new property------------------------------------
        [BrowsableAttribute(true)]
        public ContentAlignment TextAlign
        {
            get
            {
                return button1.TextAlign;
            }
            set
            {
                button1.TextAlign = value;
            }
        }
        //--------------new property------------------------------------
        [BrowsableAttribute(true)]
        public int AnimationStartX
        {
            get;set;
        }
        //--------------new property------------------------------------
        [BrowsableAttribute(true)]
        public int AnimationEndX
        {
            get;set;
        }
        //--------------new property------------------------------------
        [BrowsableAttribute(true)]
        public bool Animation
        {
            get;set;
        }
        //--------,..........
        //------------hidden Property-----------------------------------
        [BrowsableAttribute(false)]
        public override bool AutoScroll
        {
            get{return base.AutoScroll;}set{base.AutoScroll = value;}
        }
        //---------------timer event------------------------------------
        int x = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (AnimationEndX == AnimationStartX)//not move
                return;
            if (this.Left == AnimationEndX)
                x = -1;
            else if (this.Left == AnimationStartX)
                x = 1;
            this.Left+=x;
        }
    }
}
