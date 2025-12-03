namespace Event
{
    class Player
    {
        //public delegate void OnAttackDelegate(object o,EventArgs args);
        //public OnAttackDelegate OnAttack = null;

        public event EventHandler ? OnAttack = null;

        public void DoAoe()
        {
            if (OnAttack != null)
            {
                OnAttack(this, EventArgs.Empty);
            }
        }
    }

    class Enemy
    {
        public void AttackMe(object? sender, EventArgs e)
        {
            Console.WriteLine("Enemy is attacking!");
        }    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Enemy enemy = new Enemy();

            player.OnAttack += enemy.AttackMe;

            //player.DoAoe();


            //在类外直接调用event修饰的委托去执行是不允许的
            //player.OnAttack(new object(),EventArgs.Empty);
        }
    }
}
