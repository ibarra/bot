// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Bot {
    
    
    public partial class DialogError {
        
        private Gtk.HBox hbox4;
        
        private Gtk.Label label9;
        
        private Gtk.Button buttonOk;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Bot.DialogError
            this.Name = "Bot.DialogError";
            this.Title = Mono.Unix.Catalog.GetString("Error");
            this.Icon = Stetic.IconLoader.LoadIcon(this, "gtk-dialog-error", Gtk.IconSize.Menu, 16);
            this.TypeHint = ((Gdk.WindowTypeHint)(1));
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.AllowShrink = true;
            this.HasSeparator = false;
            // Internal child Bot.DialogError.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.hbox4 = new Gtk.HBox();
            this.hbox4.Name = "hbox4";
            this.hbox4.Spacing = 6;
            // Container child hbox4.Gtk.Box+BoxChild
            this.label9 = new Gtk.Label();
            this.label9.Name = "label9";
            this.label9.LabelProp = Mono.Unix.Catalog.GetString("Error al Connectarse");
            this.hbox4.Add(this.label9);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox4[this.label9]));
            w2.Position = 1;
            w2.Expand = false;
            w2.Fill = false;
            w1.Add(this.hbox4);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(w1[this.hbox4]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Internal child Bot.DialogError.ActionArea
            Gtk.HButtonBox w4 = this.ActionArea;
            w4.Name = "dialog1_ActionArea";
            w4.Spacing = 6;
            w4.BorderWidth = ((uint)(5));
            w4.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.buttonOk = new Gtk.Button();
            this.buttonOk.CanDefault = true;
            this.buttonOk.CanFocus = true;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseStock = true;
            this.buttonOk.UseUnderline = true;
            this.buttonOk.Label = "gtk-ok";
            this.AddActionWidget(this.buttonOk, -5);
            Gtk.ButtonBox.ButtonBoxChild w5 = ((Gtk.ButtonBox.ButtonBoxChild)(w4[this.buttonOk]));
            w5.Expand = false;
            w5.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 264;
            this.DefaultHeight = 141;
            this.Show();
        }
    }
}
