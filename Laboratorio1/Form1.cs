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

        GreyHound greyHound1;
        GreyHound greyHound2;
        GreyHound greyHound3;
        GreyHound greyHound4;

        int raceTrackLength = 433;
        int startingPosition = 22;

        public Form1()
        {
            InitializeComponent();
            guyJoao = initializeGuy("João", 50, JoaoRdb, ApostaJoaoLbl); 
            guyBeto = initializeGuy("Beto", 75, BetoRdb, ApostaBetoLbl);
            guyAlfredo = initializeGuy("Alfredo", 45, AlfredoRbd, ApostaAlfredoLbl);

            greyHound1 = initializeGreyHound(dogPicUm);
            greyHound2 = initializeGreyHound(dogPicDois);
            greyHound3 = initializeGreyHound(dogPicTres);
            greyHound4 = initializeGreyHound(dogPicQuatro);
        }

        private Guy initializeGuy(string Name, int Cash, RadioButton radioButton, Label label){
            Guy someGuy = new Guy { Name = Name, MyBet = null, Cash = Cash, MyRadioButton = radioButton, MyLabel = label };
            someGuy.UpdateLabels();
            return someGuy;
        }

        private GreyHound initializeGreyHound(PictureBox pictureBox)
        {
            GreyHound someGreyHound = new GreyHound() { StartingPosition = startingPosition, RaceTrackLength = raceTrackLength, MyPictureBox = pictureBox };
            someGreyHound.takeStartingPosition();
            return someGreyHound;
        }

        private void fazerAposta(Guy someGuy)
        {
            if (someGuy.MyBet != null)
            {
                MessageBox.Show("Você já apostou!!", "Atenção");
            }
            if (!someGuy.PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
            {
                MessageBox.Show("Você está sem dinehiro para apostar!!");
            }
            someGuy.UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (JoaoRdb.Checked)
            {
                fazerAposta(guyJoao);
            }
            if (BetoRdb.Checked)
            {
                fazerAposta(guyBeto);
            }
            if (AlfredoRbd.Checked)
            {
                fazerAposta(guyAlfredo);
            }

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            
            //corrida maluca
        while (greyHound1.Location < raceTrackLength || 
                greyHound2.Location < raceTrackLength || 
                greyHound3.Location < raceTrackLength || 
                greyHound4.Location < raceTrackLength
            )
            {
              greyHound1.Run();
              greyHound2.Run();
              greyHound3.Run();
              greyHound4.Run();
            }

            //vencedor???
            int Winner = Math.Max(greyHound1.Location, Math.Max(greyHound2.Location, Math.Max(greyHound3.Location, greyHound4.Location)));

            MessageBox.Show("O vencedor foi o número" + Winner, "Cachorro vencedor");

            //atualizo dindin dos apsotadores
            guyJoao.Collet(Winner);
            guyBeto.Collet(Winner);
            guyAlfredo.Collet(Winner);

            //limpo apostas
            guyJoao.clearBet();
            guyBeto.clearBet();
            guyAlfredo.clearBet();

            //atualizo info dos apostadores
            guyJoao.UpdateLabels();
            guyBeto.UpdateLabels();
            guyAlfredo.UpdateLabels();           
        }
    }
}
