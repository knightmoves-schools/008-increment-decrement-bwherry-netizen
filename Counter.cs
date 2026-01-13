
namespace knightmoves;
public class Counter
{
    public static int Visitors = 100;
    public int PrefixIncrement()
    {

        Visitors = ++Visitors;
        Visitors = Visitors++;
        Visitors = --Visitors;
        Visitors = Visitors--;



       return Visitors;
    }
}
