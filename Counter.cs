    namespace knightmoves;
    public class Counter
    {
        public static int Visitors = 100;
        public int PrefixIncrement = ++Visitors;
        public int PostfixIncrement = Visitors++;

        public int prefixDecrement = --Visitors;
        public int postfixDecrement = Visitors--;

    }