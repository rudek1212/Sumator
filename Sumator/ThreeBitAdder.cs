using System;

namespace Sumator
{
    class ThreeBitAdder
    {
        private readonly Adder _adder0 = new Adder();
        private readonly Adder _adder1 = new Adder();
        private readonly Adder _adder2 = new Adder();
        private char[] _binary0;
        private char[] _binary1;

        private void SetBinary0()
        {
            _binary0 = ToBinary.ToBin(Number0);
        }

        private void SetBinary1()
        {
            _binary1 = ToBinary.ToBin(Number1);
        }

        public int Number0 { get; set; }

        public int Number1 { get; set; }

        public ThreeBitAdder(int a, int b)
        {
            Number0 = a;
            Number1 = b;
            SetBinary0();
            SetBinary1();
        }

        public bool CheckIfTrue(char variable)
        {
            if (variable == '0') return false;
            return true;
        }

        public void SetValues(bool c1)
        {
            _adder0.SetValues(CheckIfTrue(_binary0[0]), CheckIfTrue(_binary1[0]), c1);
            _adder0.CalculateOutputs();
            _adder1.SetValues(CheckIfTrue(_binary0[1]), CheckIfTrue(_binary1[1]), _adder0.C);
            _adder1.CalculateOutputs();
            _adder2.SetValues(CheckIfTrue(_binary0[2]), CheckIfTrue(_binary1[2]), _adder2.C);
            _adder2.CalculateOutputs();
        }

        public string Output()
        {
            return _adder0.S.ToString() + _adder1.S + _adder2.S + _adder2.C;
        }
    }
}