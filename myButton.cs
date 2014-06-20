using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDoGalo
{
    class myButton
    {
        private bool buttonEmpty;

        public void verifyButton(Button b , string[] s)
        {
            if (b.Text == "")
            {
                buttonEmpty = true;
                s[]
                MessageBox.Show(buttonEmpty.ToString());
            }

            else
            {
                buttonEmpty = false;
                MessageBox.Show(buttonEmpty.ToString());
            }
        }
    }
}
