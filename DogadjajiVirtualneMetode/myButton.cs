using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class myButton : System.Windows.Forms.Button
    {
        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("Kliknuo si me!", "Moj botun");
          //  base.OnClick(e);
        }
    }
}
