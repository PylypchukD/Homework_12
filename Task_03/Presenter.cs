using System;

namespace Task_03
{
    class Presenter
    {
        Model model = null;
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            model = new Model();
            
            this.mainWindow.AddEvent += MainWindowAdd;
            this.mainWindow.SubEvent += MainWindowSub;
            this.mainWindow.MulEvent += MainWindowMul;
            this.mainWindow.DivEvent += MainWindowDiv;
        }

        void MainWindowAdd(object sender, EventArgs e)
        {
            string variable = model.Add(Convert.ToInt32(mainWindow.x_textBox.Text), Convert.ToInt32(mainWindow.y_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowSub(object sender, EventArgs e)
        {
            string variable = model.Sub(Convert.ToInt32(mainWindow.x_textBox.Text), Convert.ToInt32(mainWindow.y_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowMul(object sender, EventArgs e)
        {
            string variable = model.Mul(Convert.ToInt32(mainWindow.x_textBox.Text), Convert.ToInt32(mainWindow.y_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
        void MainWindowDiv(object sender, EventArgs e)
        {
            string variable = model.Div(Convert.ToInt32(mainWindow.x_textBox.Text), Convert.ToInt32(mainWindow.y_textBox.Text));
            mainWindow.Result_textBox.Text = variable;
        }
    }
}
