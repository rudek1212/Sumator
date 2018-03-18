namespace Sumator
{
    public static class LogicGates
    {
        public static bool And(bool a, bool b)
        {
            if (a && b) return true;
            return false;
        }

        public static bool Or(bool a, bool b)
        {
            if (a || b) return true;
            return false;
        }

        public static bool XOr(bool a, bool b)
        {
            if (a && !b || !a && b) return true;
            return false;
        }
    }
}