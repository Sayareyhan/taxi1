namespace TaxiOBjek
{
    class program
    {
        static void Main(string[] args)
        {
            taxio taxio = new taxio();

            taxio.DriverName = "Supri";
            taxio.onDuty = false; taxio.onDuty = true;
            taxio.numPassanger = 69696969;


            taxio.info();
            taxio.naik();
            taxio.turun();

            Console.ReadKey();
        }
    }
}
