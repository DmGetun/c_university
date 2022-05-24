using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labTrainerAccount
{
    class Games
    {
        public int CountCorrect { get; protected set; }
        public int CountWrong { get; protected set; }
        public bool AnswerCorrect { get; protected set; }
        public string CodeText { get; protected set; }

        public event EventHandler Change;

        public int comp { get; protected set; }

        public void DoReset(int comp)
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue(comp);
        }

        public void DoContinue(int comp)
        {
            Random rnd = new Random();
            int xValue1 = 0;
            int xValue2 = 0;
            int xResult = 0;
            string action;
            if (comp == 1)
            {
                 xValue1 = rnd.Next(20);
                 xValue2 = rnd.Next(20);
            }
            else if (comp == 2)
            {
                xValue1 = rnd.Next(200);
                xValue2 = rnd.Next(200);
            }
            else if (comp == 3)
            {
                xValue1 = rnd.Next(15);
                xValue2 = rnd.Next(15);
            }

            if (comp == 1 || comp == 2 )
            {
                xResult = xValue1 + xValue2;
            }
            else if (comp == 3)
            {
                xResult = xValue1 * xValue2;
            }
            
            int xResultNew;
            int xSign;

            if (rnd.Next(2) == 1)
            {
                xResultNew = xResult;
            }
            else
            {
                if (rnd.Next(2) == 1)
                    xSign = 1;
                else
                    xSign = -1;

                if (comp == 1)
                    xResultNew = xResult + (rnd.Next(7) * xSign);
                else if (comp == 2)
                    xResultNew = xResult + (rnd.Next(20) * xSign);
                else
                    xResultNew = xResult * (rnd.Next(7) * xSign);
                if (xResultNew < 0)
                    xResultNew = -xResultNew;
            }
            AnswerCorrect = (xResult == xResultNew);

            if (comp == 1 || comp == 2)
                action = "+";
            else
                action = "*";
                
            CodeText = String.Format("{0} {1} {2} = {3}", xValue1,action, xValue2, xResultNew);
            //
            Change(this, EventArgs.Empty);
        }

        public void DoAnswer(bool v,int comp)
        {
            if (v == AnswerCorrect)
                CountCorrect++;
            else CountWrong++;
            DoContinue(comp);
        }
    }
}
