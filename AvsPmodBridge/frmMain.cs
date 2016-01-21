using System;
using System.Diagnostics;
using System.IO;
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
			Opacity = 0;

			var p = new Process();
			p.StartInfo = new ProcessStartInfo(Path.Combine("extension", "AvsPmod", "AvsPmod.exe"), $"\"{_file}\"")
            {
				WorkingDirectory = Path.Combine("extension", "AvsPmod"),
                UseShellExecute = false,
			};
			p.Start();
			p.WaitForExit();
		}

		private void frmMain_Shown(object sender, EventArgs e)
		{
			Close();
		}
	}
}
