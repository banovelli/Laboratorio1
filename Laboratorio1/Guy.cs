using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;
        public void UpdateLabels(){

            MyRadioButton.Text = Name + " tem " + Cash + " reais.";
            if (MyBet.Amount)
            {
                MyLabel.Text = MyBet.GetDescription();
            }
            else{
                MyLabel.Text = Name + "ainda não apostou";
            }
            
            //decrição  da aposta
            //o dinheiro atual
        }

        public void clearBet()
        {
            //reinicializa aposta
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            //crie uma nova aposta e armazene no campo belt
            //retorna verdadeiro se tme din suficiente
            if(Cash > 4){
                MyBet = new Bet(Amount = Amount, Dog = Dog, Guy = this);
            }
            return false;
        }

        public void Collet(int Winner)
        {
            //cobre aposta se ganhei
            Cash += Bet.PayOut(Winner);            
        }
    }
}
