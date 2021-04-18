# Sample coding:
private void button1_Click(object sender, EventArgs e)
{
	// start
	ProgressBar.UI.Start(this);
	for (int i = 0; i < 2; i++)
	{
		// long process..
		System.Threading.Thread.Sleep(1000);
	}
	// stop/exit
	ProgressBar.UI.Stop();
}


# API:
ProgressBar.UI.Message = "Progress message";

// Set up speed in milliseconds
ProgressBar.UI.Interval = 100;

// Pause/play progress
ProgressBar.UI.Pause();
ProgressBar.UI.Play();

// Hide/show UI
ProgressBar.UI.Hide();
ProgressBar.UI.Show();