namespace FirstApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ouestion01
            ///double[] prices = { 25.5, 40.0, 33.75 };
            /// Console.WriteLine(prices[1]);
            #endregion

            #region Ouestion02
            /// int[,] shelfCopies =
            ///{
            ///    { 3, 5 },
            ///    { 1, 4 }
            ///};

            ///  Console.WriteLine(shelfCopies[1, 0]);
            #endregion

            /// PrintWelcomeMessage();
            /// PrintBookTitle("Clean Code");
            /// 
            #region Question05
            ///int pages = 400;

            ///AddBonusPages(pages);

            ///Console.WriteLine(pages);
            #endregion

            #region Question06
            /// double[] prices = { 25.5, 40.0 };

            ///ApplyDiscount(prices);

            ///Console.WriteLine(prices[0]);
            #endregion

            #region Question07
            ///int pages = 400;

            ///AddBonusPagesByRef(ref pages);

            ///Console.WriteLine(pages);
            #endregion
        }
        #region Ouestion03
        ///  static void PrintWelcomeMessage()
        ////  {
        ///   Console.WriteLine("Welcome to the Library!");
        /// }
        #endregion

        #region Ouestion04
        /// static void PrintBookTitle(string title)
        /// {
        ///     Console.WriteLine("Book title: " + title);
        ///  }
        #endregion

        #region Question05
        /// static void AddBonusPages(int pages)
        /// {
        ///     pages += 50;
        ///}
        #endregion

        #region Question06
        ///static void ApplyDiscount(double[] prices)
        ///{
        ///    prices[0] -= 5;
        ///}
        #endregion


        #region Question07
        ///static void AddBonusPagesByRef(ref int pages)
        ///{
        ///    pages += 50;
        ///}
        #endregion
    }
}
