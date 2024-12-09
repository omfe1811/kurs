namespace oppgave
{
    class Car
    {
        public string Brand { get; set; } = "";
        public string Color { get; set; } = "";
        public int Year { get; set; } = 0;

        //constructor
        public Car()
        { }
        public void CarInfo()
        {
            string CarText = $@"
            Car's brand is a {this.Brand}
            the color is {this.Color}
            and it was made in {this.Year}";
            System.Console.WriteLine(CarText);
        }
        public void IsCarOld()
        {
            if (Year <= 1970)
            {
                System.Console.WriteLine("The car is vintage");
            }
            else if (Year <= 1990)
            {
                System.Console.WriteLine("The car is pretty old");
            }
            else if (Year <= 2005)
            {
                System.Console.WriteLine("The car is a bit old");
            }
            else if (Year <= 2014)
            {
                System.Console.WriteLine("The car is ok");
            }
            else if (Year <= 2020)
            {
                System.Console.WriteLine("The car is pretty new");
            }
            else
            {
                System.Console.WriteLine("The car is new AF");
            }



        }
        //string animalText=""
        //foreach 
    }
}
