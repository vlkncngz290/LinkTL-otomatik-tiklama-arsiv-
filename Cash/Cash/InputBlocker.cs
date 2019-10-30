using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cash
{
    class InputBlocker
    {
        [DllImport("user32.dll")]
        static extern bool BlockInput(bool fBlockIt);
        private static Timer timer = new Timer();
        static InputBlocker()
        {
            timer.Tick += new EventHandler(tick);
        }
        public static void Block(int mill)
        {
            if (!BlockInput(true))
            {
                throw new System.ComponentModel.Win32Exception();
            }
            BlockInput(true);
            timer.Interval = mill;
            timer.Start();

        }
        private static void tick(object sender, EventArgs e)
        {
            BlockInput(false);
            timer.Stop();
        }
    }
}
