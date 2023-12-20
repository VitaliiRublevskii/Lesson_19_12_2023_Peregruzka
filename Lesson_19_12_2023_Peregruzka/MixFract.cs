using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_19_12_2023_Peregruzka
{
    public class MixFract : OrdFract
    {
        public int Intrger { get; set; }
        public MixFract() { }
        public MixFract(int intrger, int numerator, int denominator): base() { 
            Intrger = intrger;
            Numerator = numerator;
            Denominator = denominator;
        }

        public override void PrintFract()
        {
            Console.WriteLine($"{Intrger} целых {Numerator} / {Denominator}");
        }

        public static MixFract operator +(MixFract left, MixFract right)
        {
            MixFract newFr = new MixFract();
            if (left.Denominator == right.Denominator)
            {
                newFr.Intrger = left.Intrger + right.Intrger;
                newFr.Numerator = left.Numerator + right.Numerator;
                newFr.Denominator = left.Denominator;
                if (newFr.Numerator > newFr.Denominator)
                {
                    int x = newFr.Numerator / newFr.Denominator;
                    newFr.Intrger += x;
                    newFr.Numerator -= newFr.Denominator;
                }
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
                newFr.Intrger = left.Intrger + right.Intrger;
                newFr.Denominator = left.Denominator * right.Denominator;
                newFr.Numerator = left.Numerator * right.Denominator + right.Numerator * left.Denominator;

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
        public static MixFract operator -(MixFract left, MixFract right)
        {
            MixFract newFr = new MixFract();
            if (left.Denominator == right.Denominator)
            {
                
               
                if (left.Numerator < right.Numerator)
                {
                    left.Numerator += left.Denominator;
                    left.Intrger--;
                }
                newFr.Intrger = left.Intrger - right.Intrger;
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
                if (left.Numerator < right.Numerator)
                {
                    left.Numerator += left.Denominator;
                    left.Intrger--;
                }
                newFr.Intrger = left.Intrger - right.Intrger;
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

        public static MixFract operator *(MixFract left, MixFract right)
        {
            MixFract newFr = new MixFract();
            newFr.Intrger = left.Intrger * right.Intrger;
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

        public static MixFract operator /(MixFract left, MixFract right)
        {
            MixFract newFr = new MixFract();
            left.Numerator += left.Intrger * left.Denominator;
            right.Numerator += right.Intrger * right.Denominator;


            newFr.Numerator = left.Numerator * right.Denominator;
            newFr.Denominator = left.Denominator * right.Numerator;
            
            if (newFr.Numerator > newFr.Denominator)
            {
                newFr.Intrger = newFr.Numerator / newFr.Denominator;
                newFr.Numerator -= newFr.Denominator;

            }

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

        public static bool operator > (MixFract left, MixFract right)
        {
            bool rez = true;
            if (left.Intrger > right.Intrger) { rez = true; }
            else if (left.Intrger < right.Intrger) { rez = false; }
            else 
            {
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
            }
            return rez;
        }

        public static bool operator < (MixFract left, MixFract right)
        {
            bool rez = true;
            if (left.Intrger < right.Intrger) { rez = true; }
            else if (left.Intrger > right.Intrger) { rez = false; }
            else
            {
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
            }
            return rez;
        }

        public static bool operator ==(MixFract left, MixFract right)
        {
            bool rez = true;
            if ( left.Intrger != right.Intrger) { rez = false; }
            else
            {
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
            }
            return rez;
        }

        public static bool operator !=(MixFract left, MixFract right)
        {
            bool rez = true;
            if (left.Intrger == right.Intrger) { rez = false; }
            else
            {
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
            }
            return rez;
        }

    }
}
