namespace Sumator
{
    public class HalfAdder
    {
        public bool A { get; private set; }
        public bool B { get; private set; }
        public bool C { get; private set; }
        public bool S { get; private set; }

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