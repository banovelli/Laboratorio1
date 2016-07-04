using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        int raceTrackLength = 405;
        int startingPosition = 22;

        public Form1()
        {
            InitializeComponent();
            guyJoao = initializeGuy("João", 50, JoaoRdb, ApostaJoaoLbl); 
            guyBeto = initializeGuy("Beto", 75, BetoRdb, ApostaBetoLbl);
            guyAlfredo = initializeGuy("Alfredo", 45, AlfredoRbd, ApostaAlfredoLbl);
        
            greyHound1 = initializeGreyHound(dogPicUm, 27);
            greyHound2 = initializeGreyHound(dogPicDois,25);
            greyHound3 = initializeGreyHound(dogPicTres, 21);
            greyHound4 = initializeGreyHound(dogPicQuatro, 23);
        }

        private Guy initializeGuy(string Name, int Cash, RadioButton radioButton, Label label){
            Guy someGuy = new Guy { Name = Name, MyBet = null, Cash = Cash, MyRadioButton = radioButton, MyLabel = label };
            someGuy.UpdateLabels();
            return someGuy;
        }

        private GreyHound initializeGreyHound(PictureBox pictureBox, int seed)
        {
            GreyHound someGreyHound = new GreyHound() { StartingPosition = startingPosition, RaceTrackLength = raceTrackLength, MyPictureBox = pictureBox };
            someGreyHound.takeStartingPosition();
            someGreyHound.MyRandom = new Random(seed);
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

        private void executaCorrida()
        {
            button1.Enabled = false;
            runBtn.Enabled = false;
            //corrida maluca
            while ((greyHound1.Location < raceTrackLength) ||
                    (greyHound2.Location < raceTrackLength) ||
                    (greyHound3.Location < raceTrackLength) ||
                    (greyHound4.Location < raceTrackLength)
                )
            {
                greyHound1.Run();
                greyHound2.Run();
                greyHound3.Run();
                greyHound4.Run();
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }

        private int verificaVencedor()
        {
             int[] posicoes = new int[4] { greyHound1.Location, greyHound2.Location, greyHound3.Location, greyHound4.Location };

            //vencedor???
            int Winner = 0;
            int localizacao = posicoes[0];
            for (int i = 1; i < posicoes.Length; i++){
                if(localizacao < posicoes[i]){
                    localizacao = posicoes[i];
                    Winner = i;
                }
            }
            return Winner+1;
        }

           //to Do quebrar esse metodo em outros para cada um cuidar de uma parte!!!
        private void atualizaCorrida(int Winner)
        {
            //atualizo dindin dos apsotadores
            if (guyJoao.MyBet != null)
            {
                guyJoao.Collet(Winner);
            }
            if (guyBeto.MyBet != null)
            {
                guyBeto.Collet(Winner);
            }
            if (guyAlfredo.MyBet != null)
            {
                guyAlfredo.Collet(Winner);
            }
            

            //limpo apostas
            guyJoao.clearBet();
            guyBeto.clearBet();
            guyAlfredo.clearBet();

            //atualizo info dos apostadores
            guyJoao.UpdateLabels();
            guyBeto.UpdateLabels();
            guyAlfredo.UpdateLabels();

            greyHound1.takeStartingPosition();
            greyHound2.takeStartingPosition();
            greyHound3.takeStartingPosition();
            greyHound4.takeStartingPosition();

            button1.Enabled = true;
            runBtn.Enabled = true;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            executaCorrida();

            int Winner = verificaVencedor();

            MessageBox.Show("O vencedor foi o número " + (Winner), "Cachorro vencedor");

            atualizaCorrida(Winner);      
        }
    }
}
