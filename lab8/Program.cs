namespace lab8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AnimalCollection<Animal> animalCollection = new AnimalCollection<Animal>();
            animalCollection.Add(new Cat()
            {
                Id = 1,
                Name = "hoang",
                Dob = "2001"
            });
            animalCollection.ShowInformation();
        }
    }
}