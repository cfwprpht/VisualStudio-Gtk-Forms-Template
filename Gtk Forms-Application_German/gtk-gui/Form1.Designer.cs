
public partial class Form1
{
    protected virtual void Build()
    {
        global::Stetic.Gui.Initialize(this);
        this.Name = "Form1";
        this.Title = global::Mono.Unix.Catalog.GetString("Form1");
        this.WindowPosition = ((global::Gtk.WindowPosition)(4));


        // Add your components here.

        
        this.DefaultWidth = 400;
        this.DefaultHeight = 194;
        this.Show();
        this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
    }
}
