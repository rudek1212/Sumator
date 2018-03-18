namespace Sumator
{
    public class HalfAdder
    {
        public bool A { get; set; }
        public bool B { get; set; }
        public bool C { get; set; }
        public bool S { get; set; }

        public void SetValues(bool a, bool b)
        {
            A = a;
            B = b;
            CalculateOutputs();
        }

        private void CalculateOutputs()
        {
            C = LogicGates.And(A, B);
            S = LogicGates.XOr(A, B);
        }
    }
}