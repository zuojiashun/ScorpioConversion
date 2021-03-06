
// This file has been generated by the GUI designer. Do not modify.
namespace ScorpioConversion
{
	public partial class FormTiny
	{
		private global::Gtk.HBox hbox8;
		
		private global::Gtk.VBox vbox7;
		
		private global::Gtk.HBox hbox9;
		
		private global::Gtk.Label labelApiKey;
		
		private global::Gtk.Entry TextBoxApiKey;
		
		private global::Gtk.HBox hbox10;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.Entry TextBoxSource;
		
		private global::Gtk.HBox hbox11;
		
		private global::Gtk.Label label12;
		
		private global::Gtk.Entry TextBoxTarget;
		
		private global::Gtk.Button buttonStart;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget ScorpioConversion.FormTiny
			this.Name = "ScorpioConversion.FormTiny";
			this.Title = global::Mono.Unix.Catalog.GetString ("TinyWindow");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(7));
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ScorpioConversion.FormTiny.Gtk.Container+ContainerChild
			this.hbox8 = new global::Gtk.HBox ();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox ();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.labelApiKey = new global::Gtk.Label ();
			this.labelApiKey.WidthRequest = 100;
			this.labelApiKey.Name = "labelApiKey";
			this.labelApiKey.LabelProp = global::Mono.Unix.Catalog.GetString ("API Key");
			this.hbox9.Add (this.labelApiKey);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.labelApiKey]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.TextBoxApiKey = new global::Gtk.Entry ();
			this.TextBoxApiKey.CanFocus = true;
			this.TextBoxApiKey.Name = "TextBoxApiKey";
			this.TextBoxApiKey.IsEditable = true;
			this.TextBoxApiKey.InvisibleChar = '●';
			this.hbox9.Add (this.TextBoxApiKey);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox9 [this.TextBoxApiKey]));
			w2.Position = 1;
			this.vbox7.Add (this.hbox9);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox9]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox ();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.WidthRequest = 100;
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("源文件目录");
			this.hbox10.Add (this.label11);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.label11]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.TextBoxSource = new global::Gtk.Entry ();
			this.TextBoxSource.CanFocus = true;
			this.TextBoxSource.Name = "TextBoxSource";
			this.TextBoxSource.IsEditable = true;
			this.TextBoxSource.InvisibleChar = '●';
			this.hbox10.Add (this.TextBoxSource);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.TextBoxSource]));
			w5.Position = 1;
			this.vbox7.Add (this.hbox10);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox10]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.label12 = new global::Gtk.Label ();
			this.label12.WidthRequest = 100;
			this.label12.Name = "label12";
			this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("目标文件目录");
			this.hbox11.Add (this.label12);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label12]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.TextBoxTarget = new global::Gtk.Entry ();
			this.TextBoxTarget.CanFocus = true;
			this.TextBoxTarget.Name = "TextBoxTarget";
			this.TextBoxTarget.IsEditable = true;
			this.TextBoxTarget.InvisibleChar = '●';
			this.hbox11.Add (this.TextBoxTarget);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.TextBoxTarget]));
			w8.Position = 1;
			this.vbox7.Add (this.hbox11);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hbox11]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			this.hbox8.Add (this.vbox7);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.vbox7]));
			w10.Position = 0;
			// Container child hbox8.Gtk.Box+BoxChild
			this.buttonStart = new global::Gtk.Button ();
			this.buttonStart.WidthRequest = 100;
			this.buttonStart.CanFocus = true;
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.UseUnderline = true;
			this.buttonStart.Label = global::Mono.Unix.Catalog.GetString (" 开始转换 ");
			this.hbox8.Add (this.buttonStart);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox8 [this.buttonStart]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.Add (this.hbox8);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 481;
			this.DefaultHeight = 135;
			this.Show ();
		}
	}
}
