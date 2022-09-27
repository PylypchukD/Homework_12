using System;
using System.Windows;

// View

namespace Task_04
{    
    public partial class MainWindow : Window
    {
        /*
         * Измените существующий проект данного урока 003_MVP, расширив его добавлением методов доступа add и remove к событию.
         */

        private EventHandler Event = null;
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Event.Invoke(sender, e);
        }

        public event EventHandler MyEvent
        {
            add { Event += value; }
            remove { Event -= value; }
        }
    }
}
