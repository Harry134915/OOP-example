namespace EventPractice
{
    class InputArgs
    {
        public char input;
    }
    class InputManager
    {
        //public delegate void EventHandler(object sender,InputArgs args)
        public event EventHandler<InputArgs> ? OnInput = null;
        public void WaitForInput()
        {
            while (true)
            {
                //1.等待用户输入的字符
                char input = Convert.ToChar(Console.Read());
                //Console.WriteLine(input);

                // 2.调用OnInput事件，将字符传给监听方法 / 监听者
            if (OnInput != null)
                {
                    InputArgs ia = new InputArgs();
                    ia.input = input;
                    OnInput(this, ia);
                }
            } 
        }
    }

    internal class Program
    {
        public static void OnKeyInput(object sender,InputArgs args)
        {
            Console.WriteLine("受到了OnInput事件，已接受到字符："+args.input);
        }
        static void Main(string[] args)
        {
            InputManager im = new InputManager();
            im.OnInput += OnKeyInput;

            im.WaitForInput();
        }

        //private static void Im_OnInput(object? sender, InputArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
