namespace lab8
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }

        public override string ToString()
        {
            return $" Animal information Id IS {Id} ,name {Name} , brithday{Dob}";
        }

        public abstract void Speak();
    }
}