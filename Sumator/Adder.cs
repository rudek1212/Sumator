namespace Sumator
{
    public class Adder
    {
        private readonly HalfAdder _hAdder1 = new HalfAdder();
        private readonly HalfAdder _hAdder2 = new HalfAdder();
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C1 { get; set; }
        public bool C { get; set; }
        public bool S { get; set; }

        public void SetValues(bool a, bool b, bool c1)
        {
            A = a;
            B = b;
            C1 = c1;
            _hAdder1.SetValues(a, b);
            _hAdder2.SetValues(_hAdder1.S, c1);
            CalculateOutputs();
        }

        public void CalculateOutputs()
        {
            S = _hAdder2.S;
            C = LogicGates.Or(_hAdder1.C, _hAdder2.C);
        }
    }
}