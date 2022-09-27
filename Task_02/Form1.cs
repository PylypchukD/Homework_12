using System;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Form1 : Form
    {
        private EventHandler start;
        private EventHandler stop;
        private EventHandler reset;
        public Form1()
        {
            InitializeComponent();
            new Presenter(this);
        }

        public event EventHandler Start
        {
            add { start += value; }
            remove { start -= value; }
        }

        public event EventHandler Stop
        {
            add { stop += value; }
            remove { stop -= value; }
        }

        public event EventHandler Reset
        {
            add { reset += value; }
            remove { reset -= value; }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            start.Invoke(sender, e);
        }

        private void StopButon_Click(object sender, EventArgs e)
        {
            stop.Invoke(sender, e);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            reset.Invoke(sender, e);
        }
    }
}

