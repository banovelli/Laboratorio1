using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1
{
    public class GreyHound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run(){
            //move de 1 a 4 espaços
            int distancia = MyRandom.Next(4);

            Point p = MyPictureBox.Location;
            p.X += distancia;
            MyPictureBox.Location = p;

            //update posicção caixa de netrada
            if(p.X > RaceTrackLength){
                return true;
            }
            
            //returna true se ganhou corrida
            return false;
        }

        public void takeStartingPosition(){
            //volta para a posição inicial
            Point p = MyPictureBox.Location;
            p.X = StartingPosition;
            MyPictureBox.Location = p;
        }
    }
}
