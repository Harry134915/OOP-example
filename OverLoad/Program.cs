namespace OverLoad
{
    class Vector2
    {
        public int x = 0;
        public int y = 0;

        //实现双目运算符减法
        public static Vector2 operator -(Vector2 a,Vector2 b)
        {
            Vector2 v1 = new Vector2();
            v1.x = a.x - b.x;
            v1.y = a.y - b.y;

            return v1;
        }

        //实现单目运算符取反
        public static Vector2 operator -(Vector2 c)
        {
            Vector2 v2 = new Vector2();
            v2.x = -c.x;
            v2.y = -c.y;

            return v2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector2 va = new Vector2();
            va.x = 5;
            va.y = 6;
            Vector2 v2 = -va;

            Console.WriteLine(v2.x);
            Console.WriteLine(v2.y);


            Vector2 vb = new Vector2();
            vb.x = 15;
            vb.y = 19;
            Vector2 v1 = va - vb;

            Console.WriteLine(v1.x);
            Console.WriteLine(v1.y);
        }
    }
}
