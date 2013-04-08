using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AtomPlayer
{
    class DarkMenu : MenuStrip
    {
        public DarkMenu()
        {
            this.Renderer = new Renderers.DarkMenuStripRenderer();
        }
    }
}
