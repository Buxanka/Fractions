using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._08._22_Fractions_
{
    class Fractions
    {
        private int Numerator;
        private int Denominator;
        private int tmp = 0;
        public void Swap(ref int _first, ref int _second)
        {
            tmp = _first;
            _first = _second;
            _second = tmp;
            //(_first, _second) = (_second, _first);
        }
        public void Swap(ref Fractions _first, ref Fractions _second)
        {

        }
        public Fractions()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public void setNumerator(int _numerator)
        {
            this.Numerator = _numerator;
        }
        public int getNumerator
        {
            get { return Numerator; }
        }
        public bool setDenominator(int _denominator)
        {
            bool _result = false;
            if (this.Denominator > 0)
            {
                this.Denominator = _denominator;
                _result = true;
            }
            else
            {
                this.Denominator = 1;
            }
            return _result;
        }
        public int getDenominator
        {
            get { return Denominator; }
        }
        static public int LCM(int _first, int _second) //НОК
        {
            int _result = 0;
            if (_first < _second)
            {
                (_first, _second) = (_second, _first);
            }
            for (int i = _first; i < _first * _second; i++)
            {
                if ((i % _second == 0) & (i % _first == 0))
                {
                    return i;
                }
            }
            _result = _first * _second;

            return _result;
        }
        static public Fractions operator +(Fractions _first, Fractions _second)
        {
            Fractions _result = new Fractions();
            _result.Denominator = LCM(_first.Denominator, _second.Denominator);
            _result.Numerator = (_first.Numerator * _second.Denominator) +
                (_second.Numerator * _first.Denominator);
            return _result;
        }
        static public Fractions operator -(Fractions _first, Fractions _second)
        {
            Fractions _result = new Fractions();
            _result.Denominator = LCM(_first.Denominator, _second.Denominator);
            _result.Numerator = (_first.Numerator * _second.Denominator) -
                (_second.Numerator * _first.Denominator);
            return _result;
        }
        static public bool operator >(Fractions _first, Fractions _second)
        {
            Fractions _differents = _first - _second;
            bool _result = (_differents.Numerator > 0);
            if (_result)
            {
                return true;
            }
            return false;
        }
        static public bool operator <(Fractions _first, Fractions _second)
        {
            Fractions _differents = _second - _first;
            bool _result = (_differents.Numerator > 0);
            if (_result)
            {
                return true;
            }
            return false;
        }
        static public Fractions operator *(Fractions _first, Fractions _second)
        {
            Fractions _result = new Fractions();
            _result.Numerator = _first.Numerator * _second.Numerator;
            _result.Denominator = _first.Denominator * _second.Denominator;
            return _result;
        }
        static public Fractions operator /(Fractions _first, Fractions _second)
        {
            Fractions _result = new Fractions();
            _result.Numerator = _first.Numerator * _second.Denominator;
            _result.Denominator = _first.Denominator * _second.Numerator;
            return _result;
        }
        class Program
        {
            static void Main(string[] args)
            {
                //int a = 15, b = 12;
                //Console.WriteLine("НОК от {0} и {1} равен {2}", a, b, Fractions.LCM(a, b));
                Fractions fract01 = new Fractions();
                Fractions fract02 = new Fractions();
                fract02.setNumerator(2);
                fract02.setDenominator(3);
                fract01.setNumerator(1);
                fract01.setDenominator(2);
                var fract03 = fract01 + fract02;
                Console.WriteLine(fract03.getNumerator);
                Console.WriteLine("-");
                Console.WriteLine(fract03.getDenominator + "\n");
                fract03 = fract01 - fract02;
                Console.WriteLine(fract03.getNumerator);
                Console.WriteLine("-");
                Console.WriteLine(fract03.getDenominator + "\n");
                fract03 = fract01 * fract02;
                Console.WriteLine(fract03.getNumerator);
                Console.WriteLine("-");
                Console.WriteLine(fract03.getDenominator + "\n");
                fract03 = fract01 / fract02;
                Console.WriteLine(fract03.getNumerator);
                Console.WriteLine("-");
                Console.WriteLine(fract03.getDenominator + "\n");
            }
        }
    }
}
