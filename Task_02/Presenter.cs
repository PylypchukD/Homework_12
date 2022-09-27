using System;

namespace Task_02
{
    class Presenter
    {
        private readonly Model model; 
        private readonly Form1 view;
        
        public Presenter(Form1 form)
        {
            
            model = new Model();
            view = form;
            
            view.Start += ViewStart;
            view.Stop += ViewStop;
            view.Reset += ViewReset;
            view.timer.Tick += TimerTick;
            view.timer.Start();
            view.timer.Enabled = false;

        }

        void ViewReset(object sender, EventArgs e) 
        {
            view.timer.Stop();
            view.SecondsTextBox.Clear();
            model.Reset();
        }

        private void ViewStop(object sender, EventArgs e) 
        {
            view.timer.Enabled = false;
        }

        private void ViewStart(object sender, EventArgs e)
        {
            view.timer.Enabled = true;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            view.SecondsTextBox.Text = model.Tick();
        }

    }
}
