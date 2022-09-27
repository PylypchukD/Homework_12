using System;

// Presenter

namespace Task_04
{
    class Presenter
    {
        Model model = null; 
        MainWindow mainWindow = null;

        public Presenter(MainWindow mainWindow)
        {
            model = new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.MyEvent += new EventHandler(mainWindow_myEvent);
        }

        void mainWindow_myEvent(object sender, System.EventArgs e) 
        {
            string variable = model.Logic(this.mainWindow.textBox1.Text); 
            mainWindow.textBox1.Text = variable; 
        }
    }
}
