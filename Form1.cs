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
    public partial class Form1 : Form
    {

        Button[] button = new Button[9];

        myButton mybutton = new myButton();

        string[] btConteudo = new string[9];

        public Form1()
        {
            InitializeComponent();

            button[0] = button1;
            button[1] = button2;
            button[2] = button3;
            button[3] = button4;
            button[4] = button5;
            button[5] = button6;
            button[6] = button7;
            button[7] = button8;
            button[8] = button9;

            for (int i = 0 ; i < button.Length ; i++)
            {

            }

            //... Verificar se o botão está vazio ou não        : Feito
            //... Verificar turno (Jogador1 = X | Jogador2 = O) : ...
            //... Verificar vitória / empate                    : ...
        }

    }
}
