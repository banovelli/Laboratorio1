using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1
{
    public partial class Form1 : Form
    {
        Guy guyJoao;
        Guy guyBeto;
        Guy guyAlfredo;

        public Form1()
        {
            InitializeComponent();
            guyJoao = initializeGuy("João", 50, JoaoRdb, ApostaJoaoLbl); 
            guyBeto = initializeGuy("Beto", 75, BetoRdb, ApostaBetoLbl);
            guyAlfredo = initializeGuy("Alfredo", 45, AlfredoRbd, ApostaAlfredoLbl);
        }

        private Guy initializeGuy(string Name, int Cash, RadioButton radioButton, Label label){
            Guy someGuy = new Guy { Name = Name, MyBet = null, Cash = Cash, MyRadioButton = radioButton, MyLabel = label };
            someGuy.UpdateLabels();
            return someGuy;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
