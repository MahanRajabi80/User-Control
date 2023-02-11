using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_16_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            SmartButton smartButton1 = new SmartButton();
            smartButton1.SmartText = "Animate";
            smartButton1.Top = this.ClientSize.Height / 2;
            smartButton1.Left = 0;
            smartButton1.Animation = true;
            smartButton1.AnimationStartX = 0;
            smartButton1.AnimationEndX = this.ClientSize.Width-smartButton1.Width;
            this.Controls.Add(smartButton1);
        }
    }
}
