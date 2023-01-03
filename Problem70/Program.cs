namespace Problem70;

public abstract class Program {
    
    public static void Main(string[] args)
    {
    }
    
    public int ClimbStairs(int n)
    {
        switch (n)
        {
            case 1:
                return 1;
            case 2:
                return 2;
            default:
            {
                var a = 1;
                var b = 2;
                for (var i = 2; i < n; i++)
                {
                    var c = a + b;
                    a = b;
                    b = c;
                }
                return b;
            }
        }
    }
}