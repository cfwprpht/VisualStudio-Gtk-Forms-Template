using System;
using Gtk;

public partial class Form1 : Gtk.Window {
    /// <summary>
	/// Initializes a new instance of the <see cref="MainWindow"/> class.
	/// </summary>
	public Form1() : base (Gtk.WindowType.Toplevel)
    {
        Build();
    }

    /// <summary>
    /// Raises the delete event event.
    /// </summary>
    /// <param name="sender">Sender.</param>
    /// <param name="a">The alpha component.</param>
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
