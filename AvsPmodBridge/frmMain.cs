using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace AvsPmodBridge
{
	public partial class frmMain : Form
	{
		string _file;

		public frmMain(string file, string lang)
		{
			InitializeComponent();
			_file = file;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.Opacity = 0;

			// Process.Start(Path.Combine("extension", "AvsPmod", "AvsPmod.exe"), _file).WaitForExit(); // file did not open, why?

			var p = new Process();
			p.StartInfo = new ProcessStartInfo("cmd", String.Format("/c START \"F\" \"{0}\" \"{1}\"", Path.Combine("extension", "AvsPmod", "AvsPmod.exe"), _file))
			{
				UseShellExecute = false,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			p.Start();
			p.WaitForExit();
		}

		private void frmMain_Shown(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
