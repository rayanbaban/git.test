namespace qiii
{
    class program
    {
        static void Main(string[] args)
        {
            artistInfo  NY = new artistInfo("50 Cent", "Get rich or die tryin", 2003, 872.000f);
            artistInfo  CA = new artistInfo("The Game", "The Documentary", 2005, 586.000f);

            Console.WriteLine(NY.artistNavn + " Sitt første album heter " + NY.albumNavn + " ble utgitt i år: " 
                + NY.utgivelseÅr + " og solgte: " + NY.albumSolgt + " den første uken");
            
        }
    }
}