
// This file has been generated by the GUI designer. Do not modify.
namespace Facturaciòn
{
	public partial class Inventario
	{
		private global::Gtk.Fixed @fixed;

		private global::Gtk.Label label4;

		private global::Gtk.HSeparator hseparator2;

		private global::Gtk.Image image4;

		private global::Gtk.Entry entry3;

		private global::Gtk.Button button4;

		private global::Gtk.Image image7;

		private global::Gtk.Button btnAñadirp;

		private global::Gtk.ComboBoxEntry comboproveedores;

		private global::Gtk.Image image6;

		private global::Gtk.Button btnEliminarp;

		private global::Gtk.Image image8;

		private global::Gtk.Button btnEditarp;

		private global::Gtk.Frame frame2;

		private global::Gtk.Alignment GtkAlignment1;

		private global::Gtk.ScrolledWindow scrolled;

		private global::Gtk.Table tablaproductos;

		private global::Gtk.Label label10;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.Label label9;

		private global::Gtk.Label GtkLabel4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Facturaciòn.Inventario
			this.Name = "Facturaciòn.Inventario";
			this.Title = global::Mono.Unix.Catalog.GetString("Inventario");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Facturaciòn.Inventario.Gtk.Container+ContainerChild
			this.@fixed = new global::Gtk.Fixed();
			this.@fixed.Name = "fixed";
			this.@fixed.HasWindow = false;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Gestiòn de Inventarios");
			this.@fixed.Add(this.label4);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.label4]));
			w1.X = 9;
			w1.Y = 10;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.WidthRequest = 750;
			this.hseparator2.Name = "hseparator2";
			this.@fixed.Add(this.hseparator2);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.hseparator2]));
			w2.X = 5;
			w2.Y = 35;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.image4 = new global::Gtk.Image();
			this.image4.Name = "image4";
			this.image4.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-find", global::Gtk.IconSize.LargeToolbar);
			this.@fixed.Add(this.image4);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.image4]));
			w3.X = 7;
			w3.Y = 92;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.entry3 = new global::Gtk.Entry();
			this.entry3.CanFocus = true;
			this.entry3.Name = "entry3";
			this.entry3.IsEditable = true;
			this.entry3.InvisibleChar = '•';
			this.@fixed.Add(this.entry3);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.entry3]));
			w4.X = 36;
			w4.Y = 88;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.button4 = new global::Gtk.Button();
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString("Buscar Producto");
			this.@fixed.Add(this.button4);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.button4]));
			w5.X = 39;
			w5.Y = 44;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.image7 = new global::Gtk.Image();
			this.image7.Name = "image7";
			this.image7.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.LargeToolbar);
			this.@fixed.Add(this.image7);
			global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.image7]));
			w6.X = 219;
			w6.Y = 46;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.btnAñadirp = new global::Gtk.Button();
			this.btnAñadirp.CanFocus = true;
			this.btnAñadirp.Name = "btnAñadirp";
			this.btnAñadirp.UseUnderline = true;
			this.btnAñadirp.Label = global::Mono.Unix.Catalog.GetString("Añadir Producto");
			this.@fixed.Add(this.btnAñadirp);
			global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.btnAñadirp]));
			w7.X = 249;
			w7.Y = 43;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.comboproveedores = global::Gtk.ComboBoxEntry.NewText();
			this.comboproveedores.Name = "comboproveedores";
			this.@fixed.Add(this.comboproveedores);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.comboproveedores]));
			w8.X = 241;
			w8.Y = 87;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.image6 = new global::Gtk.Image();
			this.image6.Name = "image6";
			this.image6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-cut", global::Gtk.IconSize.LargeToolbar);
			this.@fixed.Add(this.image6);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.image6]));
			w9.X = 395;
			w9.Y = 47;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.btnEliminarp = new global::Gtk.Button();
			this.btnEliminarp.CanFocus = true;
			this.btnEliminarp.Name = "btnEliminarp";
			this.btnEliminarp.UseUnderline = true;
			this.btnEliminarp.Label = global::Mono.Unix.Catalog.GetString("Eliminar Producto");
			this.@fixed.Add(this.btnEliminarp);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.btnEliminarp]));
			w10.X = 427;
			w10.Y = 44;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.image8 = new global::Gtk.Image();
			this.image8.Name = "image8";
			this.image8.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.LargeToolbar);
			this.@fixed.Add(this.image8);
			global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.image8]));
			w11.X = 575;
			w11.Y = 47;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.btnEditarp = new global::Gtk.Button();
			this.btnEditarp.CanFocus = true;
			this.btnEditarp.Name = "btnEditarp";
			this.btnEditarp.UseUnderline = true;
			this.btnEditarp.Label = global::Mono.Unix.Catalog.GetString("Editar Productos");
			this.@fixed.Add(this.btnEditarp);
			global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.btnEditarp]));
			w12.X = 609;
			w12.Y = 43;
			// Container child fixed.Gtk.Fixed+FixedChild
			this.frame2 = new global::Gtk.Frame();
			this.frame2.WidthRequest = 640;
			this.frame2.HeightRequest = 300;
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.scrolled = new global::Gtk.ScrolledWindow();
			this.scrolled.WidthRequest = 615;
			this.scrolled.HeightRequest = 200;
			this.scrolled.CanFocus = true;
			this.scrolled.Name = "scrolled";
			this.scrolled.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolled.Gtk.Container+ContainerChild
			global::Gtk.Viewport w13 = new global::Gtk.Viewport();
			w13.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.tablaproductos = new global::Gtk.Table(((uint)(9)), ((uint)(6)), false);
			this.tablaproductos.WidthRequest = 650;
			this.tablaproductos.HeightRequest = 200;
			this.tablaproductos.Name = "tablaproductos";
			this.tablaproductos.RowSpacing = ((uint)(6));
			this.tablaproductos.ColumnSpacing = ((uint)(6));
			// Container child tablaproductos.Gtk.Table+TableChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Stock");
			this.tablaproductos.Add(this.label10);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.tablaproductos[this.label10]));
			w14.LeftAttach = ((uint)(5));
			w14.RightAttach = ((uint)(6));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tablaproductos.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("ID Producto");
			this.tablaproductos.Add(this.label5);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.tablaproductos[this.label5]));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tablaproductos.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre Producto");
			this.tablaproductos.Add(this.label6);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.tablaproductos[this.label6]));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tablaproductos.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Precio Regular");
			this.tablaproductos.Add(this.label7);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.tablaproductos[this.label7]));
			w17.LeftAttach = ((uint)(2));
			w17.RightAttach = ((uint)(3));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tablaproductos.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Precio de Descuento");
			this.tablaproductos.Add(this.label8);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.tablaproductos[this.label8]));
			w18.LeftAttach = ((uint)(3));
			w18.RightAttach = ((uint)(4));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tablaproductos.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("ID Proveedor");
			this.tablaproductos.Add(this.label9);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.tablaproductos[this.label9]));
			w19.LeftAttach = ((uint)(4));
			w19.RightAttach = ((uint)(5));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			w13.Add(this.tablaproductos);
			this.scrolled.Add(w13);
			this.GtkAlignment1.Add(this.scrolled);
			this.frame2.Add(this.GtkAlignment1);
			this.GtkLabel4 = new global::Gtk.Label();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString("Productos");
			this.GtkLabel4.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel4;
			this.@fixed.Add(this.frame2);
			global::Gtk.Fixed.FixedChild w24 = ((global::Gtk.Fixed.FixedChild)(this.@fixed[this.frame2]));
			w24.X = 57;
			w24.Y = 138;
			this.Add(this.@fixed);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 784;
			this.DefaultHeight = 498;
			this.Show();
		}
	}
}
