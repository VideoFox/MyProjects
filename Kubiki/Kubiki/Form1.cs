using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Kubiki
{
    public delegate void DelegateShow(int a , int b);

    public partial class Form1 : Form
    {
        private Dice _dice1;
        private Dice _dice2;
        private Dice _dice3;

        public Form1()
        {
            InitializeComponent();
        }

        public void Init()
        {
            _dice1=new Dice(ShowSum);
            _dice2 = new Dice(ShowDice);
            _dice3 = new Dice(ShowBox);

            //Thread t1=new Thread(_dice1.Run);
            //timer.Start();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            _dice1.Go();
            _dice2.Go();
            _dice3.Go();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
            
        }

        private void ShowDice(int a, int b)
        {
            if (InvokeRequired)
            {
                DelegateShow show = ShowDice;
                Invoke(show, a, b);
                return;
            }

            textDices.Text = a + @" : " + b;
        }

      //  readonly object _block = new object();

        private void ShowSum(int a, int b)
        {
            if (InvokeRequired)
            {
                DelegateShow show = ShowSum;
                Invoke(show, a, b);
                return;
            }
             labelSum.Text = (a + b).ToString();

        }
        private void ShowBox(int a, int b)
        {
            if (InvokeRequired)
            {
                DelegateShow show = ShowBox;
                Invoke(show, a, b);
                return;
            }

            box1.Image = box(a);
            box2.Image = box(b);
        }

        private Image box(int n)
        {
            switch (n)
            {
                case 1:
                    return Properties.Resources._1;
                case 2:
                    return Properties.Resources._2;
                case 3:
                    return Properties.Resources._3;
                case 4:
                    return Properties.Resources._4;
                case 5:
                    return Properties.Resources._5;
                case 6:
                    return Properties.Resources._6;

            }
            return null;
        }


    }
}
