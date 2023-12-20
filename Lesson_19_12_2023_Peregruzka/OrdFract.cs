using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_12_2023_Peregruzka
{
    public class OrdFract
    {
        public int Numerator {  get; set; }
        public int Denominator { get; set; }

        public OrdFract() { }

        public OrdFract(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public virtual void PrintFract ()
        {
            Console.WriteLine($"{Numerator} / {Denominator}");
        }

        public static OrdFract operator +(OrdFract left, OrdFract right)
        {
            OrdFract newFr = new OrdFract();
            if (left.Denominator == right.Denominator)
            {
                newFr.Numerator = left.Numerator + right.Numerator;
                newFr.Denominator = left.Denominator;
                int mostAll = newFr.Numerator;
                while (mostAll > 1)
                {
                    if ((newFr.Numerator % mostAll == 0) && (newFr.Denominator % mostAll == 0))
                    {
                        newFr.Numerator /= mostAll;
                        newFr.Denominator /= mostAll;
                        break;
                    }
                    mostAll--;
                }

            }
            else
            {
                newFr.Denominator = left.Denominator * right.Denominator;
                newFr.Numerator = left.Numerator * right.Denominator + right.Numerator * left.Denominator;

                int mostAll = newFr.Numerator;
                while (mostAll > 1) {
                    if ((newFr.Numerator % mostAll == 0) && (newFr.Denominator % mostAll == 0))
                    {
                        newFr.Numerator /= mostAll;
                        newFr.Denominator /= mostAll;
                        break;
                    }
                    mostAll--;
                }

            }
            return newFr;
        }

        public static OrdFract operator-(OrdFract left, OrdFract right)
        {
            OrdFract newFr = new OrdFract();
            if (left.Denominator == right.Denominator)
            {
                newFr.Numerator = left.Numerator - right.Numerator;
                newFr.Denominator = left.Denominator;
                int mostAll = newFr.Numerator;
                while (mostAll > 1)
                {
                    if ((newFr.Numerator % mostAll == 0) && (newFr.Denominator % mostAll == 0))
                    {
                        newFr.Numerator /= mostAll;
                        newFr.Denominator /= mostAll;
                        break;
                    }
                    mostAll--;
                }

            }
            else
            {
                newFr.Denominator = left.Denominator * right.Denominator;
                newFr.Numerator = left.Numerator * right.Denominator - right.Numerator * left.Denominator;

                int mostAll = newFr.Numerator;
                while (mostAll > 1)
                {
                    if ((newFr.Numerator % mostAll == 0) && (newFr.Denominator % mostAll == 0))
                    {
                        newFr.Numerator /= mostAll;
                        newFr.Denominator /= mostAll;
                        break;
                    }
                    mostAll--;
                }

            }
            return newFr;
        }

        public static OrdFract operator *(OrdFract left, OrdFract right)
        {
            OrdFract newFr = new OrdFract();
           
            newFr.Numerator = left.Numerator * right.Numerator;
            newFr.Denominator = left.Denominator * right.Denominator;
            int mostAll = newFr.Numerator;
            while (mostAll > 1)
            {
                if ((newFr.Numerator % mostAll == 0) && (newFr.Denominator % mostAll == 0))
                {
                    newFr.Numerator /= mostAll;
                    newFr.Denominator /= mostAll;
                    break;
                }
                mostAll--;
            }
            return newFr;
        }

        public static OrdFract operator /(OrdFract left, OrdFract right)
        {
            OrdFract newFr = new OrdFract();

            newFr.Numerator = left.Numerator * right.Denominator;
            newFr.Denominator = left.Denominator * right.Numerator;
            int mostAll = newFr.Numerator;
            while (mostAll > 1)
            {
                if ((newFr.Numerator % mostAll == 0) && (newFr.Denominator % mostAll == 0))
                {
                    newFr.Numerator /= mostAll;
                    newFr.Denominator /= mostAll;
                    break;
                }
                mostAll--;
            }
            return newFr;
        }

        public static bool operator > (OrdFract left, OrdFract right)
        {
            bool rez = true;
            if (left.Denominator == right.Denominator)
            {
                if (left.Numerator > right.Numerator)
                    rez = true;
                else { rez = false; }
            }
            else
            {
                int d = left.Denominator;
                left.Numerator *= right.Denominator;
                left.Denominator *= right.Denominator;
                right.Numerator *= d;
                right.Denominator *= d;
                if (left.Numerator > right.Numerator)
                    rez = true;
                else { rez = false; }

            }
            return rez;
        }
        public static bool operator < (OrdFract left, OrdFract right)
        {
            bool rez = true;
            if (left.Denominator == right.Denominator)
            {
                if (left.Numerator < right.Numerator)
                    rez = true;
                else { rez = false; }
            }
            else
            {
                int d = left.Denominator;
                left.Numerator *= right.Denominator;
                left.Denominator *= right.Denominator;
                right.Numerator *= d;
                right.Denominator *= d;
                if (left.Numerator < right.Numerator)
                    rez = true;
                else { rez = false; }

            }
            return rez;
        }
        public static bool operator == (OrdFract left, OrdFract right)
        {
            bool rez = true;
            if (left.Denominator == right.Denominator)
            {
                if (left.Numerator == right.Numerator)
                    rez = true;
                else { rez = false; }
            }
            else
            {
                int d = left.Denominator;
                left.Numerator *= right.Denominator;
                left.Denominator *= right.Denominator;
                right.Numerator *= d;
                right.Denominator *= d;
                if (left.Numerator == right.Numerator)
                    rez = true;
                else { rez = false; }
            }
            return rez;
        }

        public static bool operator !=(OrdFract left, OrdFract right)
        {
            bool rez = true;
            if (left.Denominator == right.Denominator)
            {
                if (left.Numerator != right.Numerator)
                    rez = true;
                else { rez = false; }
            }
            else
            {
                int d = left.Denominator;
                left.Numerator *= right.Denominator;
                left.Denominator *= right.Denominator;
                right.Numerator *= d;
                right.Denominator *= d;
                if (left.Numerator != right.Numerator)
                    rez = true;
                else { rez = false; }
            }
            return rez;
        }

    }
}
