using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if(Amount > 0){
                return Bettor.Name + " apostou " + Amount + " no cão " + Dog;
            }
            else{
                return Bettor.Name + "não apostou.";
            }
        }

        public int PayOut(int Winner)
        {
            if (Winner == Dog)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
