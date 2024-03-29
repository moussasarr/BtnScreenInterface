
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button btnStart;

	private global::Gtk.Label lblMainText;

	private global::Gtk.Label visitorsLabel;

	private global::Gtk.Button btnStop;

	private global::Gtk.Button btnIncrement;

	private global::Gtk.Button btnDecrement;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnStart = new global::Gtk.Button();
		this.btnStart.CanFocus = true;
		this.btnStart.Name = "btnStart";
		this.btnStart.UseUnderline = true;
		this.btnStart.Label = global::Mono.Unix.Catalog.GetString("Start Application");
		this.fixed1.Add(this.btnStart);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnStart]));
		w1.X = 16;
		w1.Y = 12;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblMainText = new global::Gtk.Label();
		this.lblMainText.Name = "lblMainText";
		this.fixed1.Add(this.lblMainText);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblMainText]));
		w2.X = 28;
		w2.Y = 79;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.visitorsLabel = new global::Gtk.Label();
		this.visitorsLabel.Name = "visitorsLabel";
		this.fixed1.Add(this.visitorsLabel);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.visitorsLabel]));
		w3.X = 48;
		w3.Y = 192;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnStop = new global::Gtk.Button();
		this.btnStop.CanFocus = true;
		this.btnStop.Name = "btnStop";
		this.btnStop.UseUnderline = true;
		this.btnStop.Label = global::Mono.Unix.Catalog.GetString("STOP");
		this.fixed1.Add(this.btnStop);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnStop]));
		w4.X = 126;
		w4.Y = 12;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnIncrement = new global::Gtk.Button();
		this.btnIncrement.CanFocus = true;
		this.btnIncrement.Name = "btnIncrement";
		this.btnIncrement.UseUnderline = true;
		this.btnIncrement.Label = global::Mono.Unix.Catalog.GetString("Increment Count");
		this.fixed1.Add(this.btnIncrement);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnIncrement]));
		w5.X = 337;
		w5.Y = 14;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnDecrement = new global::Gtk.Button();
		this.btnDecrement.CanFocus = true;
		this.btnDecrement.Name = "btnDecrement";
		this.btnDecrement.UseUnderline = true;
		this.btnDecrement.Label = global::Mono.Unix.Catalog.GetString("Decrement Count");
		this.fixed1.Add(this.btnDecrement);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnDecrement]));
		w6.X = 339;
		w6.Y = 70;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 461;
		this.DefaultHeight = 300;
		this.btnStop.Hide();
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnStart.Clicked += new global::System.EventHandler(this.OnBtnStartClicked);
		this.btnStop.Clicked += new global::System.EventHandler(this.OnBtnStopClicked);
		this.btnIncrement.Clicked += new global::System.EventHandler(this.OnBtnIncrementClicked);
		this.btnDecrement.Clicked += new global::System.EventHandler(this.OnBtnDecrementClicked);
	}
}
