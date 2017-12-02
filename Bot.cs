using System;

namespace Bot
{
    public class Bot
    {

        //private Dialog user;

        public static void Main(string[] args)
        {
            Dialog user = new Dialog();
            Console.WriteLine("");
            Console.WriteLine(user.identifier("OI"));
            Console.ReadKey();
        }
    }
}
