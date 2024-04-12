namespace Making_a_Die_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();

            Console.WriteLine(die1);
            for(int i = 0; i < 10; i++)
            {
                die1.DrawRoll();
                die1.RollDie();
            }

            Console.WriteLine(die1.Roll);
            die1.DrawRoll();

        }
    }
}