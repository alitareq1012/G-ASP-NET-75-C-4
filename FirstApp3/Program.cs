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

            #region Question08
            ///double[] prices = { 25.5, 40.0 };

            ///ReplaceArray(ref prices);

            ///Console.WriteLine(prices.Length);
            #endregion

            #region Question09
            //double price;

            //if (TryGetPrice("Clean Code", out price))
            //{
            //    Console.WriteLine(price);
            //}
            //else
            //{
            //    Console.WriteLine("Book not found");
            //}
            #endregion

            #region Question092
            // PrintBookInfo("Clean Code");

            // PrintBookInfo("The Pragmatic Programmer", 320);
            #endregion

          //  PrintBookInfo(pages: 350, title: "Clean Code");


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

        #region Question08
        ///static void ReplaceArray(ref double[] prices)
        ///{
        ///    prices = new double[] { 10.0, 12.5, 15.0 };
        ///}
        #endregion

        #region Question09
        //static bool TryGetPrice(string title, out double price)
        //{
        //    if (title == "Clean Code")
        //    {
        //        price = 25.5;
        //        return true;
        //    }
        //    else
        //    {
        //        price = 0;
        //        return false;
        //    }
        //}
        #endregion

        #region Question092
        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine("Title: " + title);
        //    Console.WriteLine("Pages: " + pages);
        //}
        #endregion

        #region Question10
        //static void PrintBookInfo(string title, int pages = 300)
        //{
        //    Console.WriteLine("Title: " + title);
        //    Console.WriteLine("Pages: " + pages);

        //}
        #endregion
    }
}
