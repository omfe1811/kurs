namespace oppgave
{
    class Animal
    {
        public string Name { get; set; } = "";
        public int Legs { get; set; } = 0;
        public string Environment { get; set; } = "";

        //constructor
        public Animal()
        { }
        public void AnimalInfo()
        {
            string animalText = $@"
            Animal name is a {this.Name}
            the number of legs is {this.Legs}
            and it lives in the {this.Environment}";
            System.Console.WriteLine(animalText);
        }
        //string animalText=""
        //foreach 
    }
}
