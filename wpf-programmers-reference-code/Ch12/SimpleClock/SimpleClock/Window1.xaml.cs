using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SimpleClock
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			this.InitializeComponent();

			// Insert code required on object creation below this point.
            tmrClock = new System.Timers.Timer(1000.0);
            tmrClock.Elapsed += new System.Timers.ElapsedEventHandler(tmrClock_Elapsed);
            tmrClock.Enabled = true;
            SetTimeResource();
		}

        private System.Timers.Timer tmrClock;

        // Update the TimeNow resource every second.
        private void tmrClock_Elapsed(Object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(new Action(SetTimeResource));
        }

        // Update the TimeNow resource.
        private void SetTimeResource()
        {
            this.Resources.Remove("TimeNow");
            this.Resources.Add("TimeNow", DateTime.Now.ToString("T"));
        }
	}
}