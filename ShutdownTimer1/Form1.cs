using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutdownTimer1
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private async void btnStartTimer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMinutes.Text, out int minutes) && minutes > 0)
            {
                _cancellationTokenSource?.Cancel(); 
                _cancellationTokenSource = new CancellationTokenSource();

                int delay = minutes * 60 * 1000; 

               
                Task.Run(async () =>
                {
                    for (int i = minutes * 60; i >= 0; i--)
                    {
                        if (_cancellationTokenSource.Token.IsCancellationRequested)
                            break;

                        
                        int hours = i / 3600;
                        int remainingMinutes = (i % 3600) / 60;
                        int seconds = i % 60;

                        
                        Invoke((Action)(() =>
                        {
                            label1.Text = $"Time remaining: {hours:D2} hr {remainingMinutes:D2} min {seconds:D2} sec";
                        }));

                        await Task.Delay(1000); 
                    }
                }, _cancellationTokenSource.Token);

                try
                {
                    await Task.Delay(delay, _cancellationTokenSource.Token); 
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0"); 
                }
                catch (TaskCanceledException)
                {
                    lblStatus.Text = "Timer canceled.";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of minutes greater than zero.");
            }
        }

        private void btnCancelTimer_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel(); 
            label1.Text = "Timer canceled.";
        }
    }
}
