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
    
    
    public partial class MainWindow {
        
        private Gtk.UIManager UIManager;
        
        private Gtk.Action FileAction;
        
        private Gtk.Action ConnectAction;
        
        private Gtk.Action ResetAction;
        
        private Gtk.Action CloseAction;
        
        private Gtk.Action QuitAction;
        
        private Gtk.Action EditAction;
        
        private Gtk.Action ViewAction;
        
        private Gtk.Action ToolsAction;
        
        private Gtk.Action HelpAction;
        
        private Gtk.Action HelpAction1;
        
        private Gtk.Action AboutAction;
        
        private Gtk.VBox vbox1;
        
        private Gtk.MenuBar menubar1;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.Label label2;
        
        private Gtk.Label label3;
        
        private Gtk.HBox hbox3;
        
        private Gtk.Entry entryServer;
        
        private Gtk.Entry entryChannel;
        
        private Gtk.Entry entryPort;
        
        private Gtk.Button button1;
        
        private Gtk.HSeparator hseparator2;
        
        private Gtk.Label lblTitle;
        
        private Gtk.ScrolledWindow GtkScrolledWindow1;
        
        private Gtk.TextView textviewLog;
        
        private Gtk.Label label5;
        
        private Gtk.Statusbar statusbarBot;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Bot.MainWindow
            this.UIManager = new Gtk.UIManager();
            Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
            this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("File"), null, null);
            this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("File");
            w1.Add(this.FileAction, null);
            this.ConnectAction = new Gtk.Action("ConnectAction", Mono.Unix.Catalog.GetString("Connect"), null, "gtk-connect");
            this.ConnectAction.ShortLabel = Mono.Unix.Catalog.GetString("Connect");
            w1.Add(this.ConnectAction, null);
            this.ResetAction = new Gtk.Action("ResetAction", Mono.Unix.Catalog.GetString("Reset"), null, "gtk-refresh");
            this.ResetAction.ShortLabel = Mono.Unix.Catalog.GetString("Reset");
            w1.Add(this.ResetAction, null);
            this.CloseAction = new Gtk.Action("CloseAction", Mono.Unix.Catalog.GetString("Close"), null, "gtk-stop");
            this.CloseAction.ShortLabel = Mono.Unix.Catalog.GetString("Disconnect");
            w1.Add(this.CloseAction, null);
            this.QuitAction = new Gtk.Action("QuitAction", Mono.Unix.Catalog.GetString("Quit"), null, "gtk-quit");
            this.QuitAction.ShortLabel = Mono.Unix.Catalog.GetString("Quit");
            w1.Add(this.QuitAction, null);
            this.EditAction = new Gtk.Action("EditAction", Mono.Unix.Catalog.GetString("Edit"), null, null);
            this.EditAction.ShortLabel = Mono.Unix.Catalog.GetString("Edit");
            w1.Add(this.EditAction, null);
            this.ViewAction = new Gtk.Action("ViewAction", Mono.Unix.Catalog.GetString("View"), null, null);
            this.ViewAction.ShortLabel = Mono.Unix.Catalog.GetString("View");
            w1.Add(this.ViewAction, null);
            this.ToolsAction = new Gtk.Action("ToolsAction", Mono.Unix.Catalog.GetString("Tools"), null, null);
            this.ToolsAction.ShortLabel = Mono.Unix.Catalog.GetString("Tools");
            w1.Add(this.ToolsAction, null);
            this.HelpAction = new Gtk.Action("HelpAction", Mono.Unix.Catalog.GetString("Help"), null, null);
            this.HelpAction.ShortLabel = Mono.Unix.Catalog.GetString("Help");
            w1.Add(this.HelpAction, null);
            this.HelpAction1 = new Gtk.Action("HelpAction1", Mono.Unix.Catalog.GetString("Help"), null, "gtk-help");
            this.HelpAction1.ShortLabel = Mono.Unix.Catalog.GetString("Help");
            w1.Add(this.HelpAction1, null);
            this.AboutAction = new Gtk.Action("AboutAction", Mono.Unix.Catalog.GetString("About"), null, "gtk-about");
            this.AboutAction.ShortLabel = Mono.Unix.Catalog.GetString("About");
            w1.Add(this.AboutAction, null);
            this.UIManager.InsertActionGroup(w1, 0);
            this.AddAccelGroup(this.UIManager.AccelGroup);
            this.Name = "Bot.MainWindow";
            this.Title = Mono.Unix.Catalog.GetString("Kakaroto's Bot");
            this.Icon = Stetic.IconLoader.LoadIcon(this, "stock_smiley-10", Gtk.IconSize.Menu, 16);
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Gravity = ((Gdk.Gravity)(5));
            // Container child Bot.MainWindow.Gtk.Container+ContainerChild
            this.vbox1 = new Gtk.VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='ConnectAction' action='ConnectAction'/><menuitem name='ResetAction' action='ResetAction'/><menuitem name='CloseAction' action='CloseAction'/><separator/><menuitem name='QuitAction' action='QuitAction'/></menu><menu name='EditAction' action='EditAction'/><menu name='ViewAction' action='ViewAction'/><menu name='ToolsAction' action='ToolsAction'/><menu name='HelpAction' action='HelpAction'><menuitem name='HelpAction1' action='HelpAction1'/><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
            this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
            this.menubar1.Name = "menubar1";
            this.vbox1.Add(this.menubar1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.vbox1[this.menubar1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Homogeneous = true;
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("Irc. Server");
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w3.Position = 0;
            w3.Expand = false;
            w3.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label2 = new Gtk.Label();
            this.label2.Name = "label2";
            this.label2.LabelProp = Mono.Unix.Catalog.GetString("Channel");
            this.hbox1.Add(this.label2);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.hbox1[this.label2]));
            w4.Position = 1;
            w4.Expand = false;
            w4.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label3 = new Gtk.Label();
            this.label3.Name = "label3";
            this.label3.LabelProp = Mono.Unix.Catalog.GetString("Port");
            this.hbox1.Add(this.label3);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.label3]));
            w5.Position = 2;
            w5.Expand = false;
            w5.Fill = false;
            this.vbox1.Add(this.hbox1);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
            w6.Position = 1;
            w6.Expand = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox3 = new Gtk.HBox();
            this.hbox3.Name = "hbox3";
            this.hbox3.Spacing = 6;
            // Container child hbox3.Gtk.Box+BoxChild
            this.entryServer = new Gtk.Entry();
            this.entryServer.CanFocus = true;
            this.entryServer.Name = "entryServer";
            this.entryServer.Text = Mono.Unix.Catalog.GetString("irc.freenode.net");
            this.entryServer.IsEditable = true;
            this.entryServer.InvisibleChar = '●';
            this.hbox3.Add(this.entryServer);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.hbox3[this.entryServer]));
            w7.Position = 0;
            w7.Expand = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.entryChannel = new Gtk.Entry();
            this.entryChannel.CanFocus = true;
            this.entryChannel.Name = "entryChannel";
            this.entryChannel.Text = Mono.Unix.Catalog.GetString("#gultij");
            this.entryChannel.IsEditable = true;
            this.entryChannel.InvisibleChar = '●';
            this.hbox3.Add(this.entryChannel);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.hbox3[this.entryChannel]));
            w8.Position = 1;
            w8.Expand = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.entryPort = new Gtk.Entry();
            this.entryPort.CanFocus = true;
            this.entryPort.Name = "entryPort";
            this.entryPort.Text = Mono.Unix.Catalog.GetString("6667");
            this.entryPort.IsEditable = true;
            this.entryPort.InvisibleChar = '●';
            this.hbox3.Add(this.entryPort);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.hbox3[this.entryPort]));
            w9.Position = 2;
            w9.Expand = false;
            // Container child hbox3.Gtk.Box+BoxChild
            this.button1 = new Gtk.Button();
            this.button1.CanFocus = true;
            this.button1.Name = "button1";
            this.button1.UseUnderline = true;
            // Container child button1.Gtk.Container+ContainerChild
            Gtk.Alignment w10 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w11 = new Gtk.HBox();
            w11.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w12 = new Gtk.Image();
            w12.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-connect", Gtk.IconSize.Menu, 16);
            w11.Add(w12);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w14 = new Gtk.Label();
            w14.LabelProp = Mono.Unix.Catalog.GetString("Connect");
            w14.UseUnderline = true;
            w11.Add(w14);
            w10.Add(w11);
            this.button1.Add(w10);
            this.hbox3.Add(this.button1);
            Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.hbox3[this.button1]));
            w18.Position = 3;
            w18.Expand = false;
            w18.Fill = false;
            this.vbox1.Add(this.hbox3);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
            w19.Position = 2;
            w19.Expand = false;
            w19.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hseparator2 = new Gtk.HSeparator();
            this.hseparator2.Name = "hseparator2";
            this.vbox1.Add(this.hseparator2);
            Gtk.Box.BoxChild w20 = ((Gtk.Box.BoxChild)(this.vbox1[this.hseparator2]));
            w20.Position = 3;
            w20.Expand = false;
            w20.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.lblTitle = new Gtk.Label();
            this.lblTitle.Name = "lblTitle";
            this.vbox1.Add(this.lblTitle);
            Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.vbox1[this.lblTitle]));
            w21.Position = 4;
            w21.Expand = false;
            w21.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.GtkScrolledWindow1 = new Gtk.ScrolledWindow();
            this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
            this.GtkScrolledWindow1.ShadowType = ((Gtk.ShadowType)(1));
            // Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
            this.textviewLog = new Gtk.TextView();
            this.textviewLog.CanFocus = true;
            this.textviewLog.Name = "textviewLog";
            this.GtkScrolledWindow1.Add(this.textviewLog);
            this.vbox1.Add(this.GtkScrolledWindow1);
            Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow1]));
            w23.Position = 5;
            // Container child vbox1.Gtk.Box+BoxChild
            this.label5 = new Gtk.Label();
            this.label5.Name = "label5";
            this.vbox1.Add(this.label5);
            Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.vbox1[this.label5]));
            w24.Position = 6;
            w24.Expand = false;
            w24.Fill = false;
            // Container child vbox1.Gtk.Box+BoxChild
            this.statusbarBot = new Gtk.Statusbar();
            this.statusbarBot.Name = "statusbarBot";
            this.statusbarBot.Spacing = 6;
            this.vbox1.Add(this.statusbarBot);
            Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox1[this.statusbarBot]));
            w25.Position = 7;
            w25.Expand = false;
            w25.Fill = false;
            this.Add(this.vbox1);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 601;
            this.DefaultHeight = 494;
            this.Show();
            this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
            this.CloseAction.Activated += new System.EventHandler(this.OnCloseActionActivated);
            this.QuitAction.Activated += new System.EventHandler(this.OnQuitActionActivated);
            this.button1.Clicked += new System.EventHandler(this.OnButton1Clicked);
        }
    }
}
