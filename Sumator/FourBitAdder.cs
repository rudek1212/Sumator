using System;
using System.Windows;

namespace Sumator
{
    internal class FourBitAdder
    {
        public Adder Add0 = new Adder();
        public Adder Add1 = new Adder();
        public Adder Add2 = new Adder();
        public Adder Add3 = new Adder();
        private int Number0 { get; set; }
        private int Number1 { get; set; }

        public void SetValues(int number0, int number1)
        {
            Number0 = number0;
            Number1 = number1;
            CalculateOutputs();
        }

        public void CalculateOutputs()
        {
            try
            {
                var binNumber0 = BinaryLogic.IntToBin(Number0);
                var binNumber1 = BinaryLogic.IntToBin(Number1);
                Add0.SetValues(BinaryLogic.TrueOrFalse(binNumber0[3]), BinaryLogic.TrueOrFalse(binNumber1[3]), false);
                Add1.SetValues(BinaryLogic.TrueOrFalse(binNumber0[2]), BinaryLogic.TrueOrFalse(binNumber1[2]),
                    Add0.Ci);
                Add2.SetValues(BinaryLogic.TrueOrFalse(binNumber0[1]), BinaryLogic.TrueOrFalse(binNumber1[1]),
                    Add1.Ci);
                Add3.SetValues(BinaryLogic.TrueOrFalse(binNumber0[0]), BinaryLogic.TrueOrFalse(binNumber1[0]),
                    Add2.Ci);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public char[] ReturnSum()
        {
            char[] sum =
            {
                BinaryLogic.TrueOrFalse(Add3.Ci), BinaryLogic.TrueOrFalse(Add3.Si), BinaryLogic.TrueOrFalse(Add2.Si),
                BinaryLogic.TrueOrFalse(Add1.Si), BinaryLogic.TrueOrFalse(Add0.Si)
            };
            return sum;
        }
    }
}