namespace oppgave
{
    class Person
    {
        private string Name { get; set; } = "";
        public int Age { get; set; } = 0;
        public string City { get; set; } = "";

        //constructor
        public Person()
        { }
        public void SetMethod(string name)
        {
            this.Name = name;
        }
        public string GetMethod()
        {
            return this.Name;
        }
    }
}
