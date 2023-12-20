using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_12_2023_Peregruzka
{
    public class Parole
    {
        public char[] Par { get; set; }
        public int Len { get; set; }

        public Parole() { }
        public Parole(int len)
        {

            Len = len;
            Par = GeneratorEyse(Len);

        }

        private char[] GeneratorEyse(int Len)
        {
            char[] x = new char[Len];
            Random rnd = new Random();
            
            for (int i = 0; i < Len; i++)
            { 

                
                x[i] = (char)rnd.Next(65, 122); 
            }
            return x;

        }

        public void GeneratePas()
        {
            Random rnd = new Random();
            char ch;
            bool f;
            for (int i = 0; i <= Len; i++)
            {
                do
                {
                    ch = (char)rnd.Next(33, 128);

                    f = true;
                    for (int j = 0; j < i; j++)
                    {
                        if (Par[j] == ch)
                        {
                            f = false;
                        }
                    }
                    f = !f;
                } while (f);
                this.Par[i] = ch;
            }
        }

        public char this[int indx]
        {
            get
            {
                return Par[indx];
            }
            set { Par[indx] = value; }
        }


        public override string ToString()
        {
            string xxx = "";
            for (int i = 0;i < Len ;i++) { xxx += Par[i]; }
            return xxx;
        }

    }
    
}
