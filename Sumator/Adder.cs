namespace Sumator
{
    public class Adder
    {
        public HalfAdder HAdder1 = new HalfAdder();
        public HalfAdder HAdder2 = new HalfAdder();
        public bool Ai { get; set; }
        public bool Bi { get; set; }
        public bool Ci1 { get; set; }
        public bool Ci { get; set; }
        public bool Si { get; set; }

        public void SetValues(bool a, bool b, bool c1)
        {
            Ai = a;
            Bi = b;
            Ci1 = c1;
            HAdder1.SetValues(a, b);
            HAdder2.SetValues(HAdder1.S, c1);
            CalculateOutputs();
        }

        public void CalculateOutputs()
        {
            Si = HAdder2.S;
            Ci = LogicGates.Or(HAdder1.C, HAdder2.C);
        }
    }
}