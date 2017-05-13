using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    int visitors = 0;
  
   

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }


    public void UpdateVisitorsText(){
		visitorsLabel.Text = visitors.ToString() + " visitors so far";

    }




  

    protected void OnBtnStartClicked(object sender, EventArgs e)
    {

        btnStart.Visible = false;   
        btnStop.Visible = true;
        lblMainText.Text = "Application Running...";
        UpdateVisitorsText();

        // Now Listen for push button and do work
        Console.WriteLine("Listening on Push Button...");   
    }


    protected void OnBtnIncrementClicked(object sender, EventArgs e)
    {
        
        visitors++;
        UpdateVisitorsText();

    }

	protected void OnBtnDecrementClicked(object sender, EventArgs e)
    {   if(visitors > 0){
			visitors--;
			UpdateVisitorsText();
        }
	}

    protected void OnBtnStopClicked(object sender, EventArgs e)
    {
        btnStart.Visible = true;
        btnStop.Visible = false;
        lblMainText.Text = "";
    }

    protected void OnBtnStopClocked(object sender, EventArgs e)
    {
    }
}
