﻿using System;
namespace Facturaciòn
{
    public partial class Factura : Gtk.Window
    {
        public Factura() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }
    }
}
