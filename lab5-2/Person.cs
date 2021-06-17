namespace lab5_2
{
    public abstract class Person
    {
        public string PersonName { get; set; }
        public bool IsSeniorLecturer { get; set; }
        public int Experience { get; set; }

        public abstract double CalculateSalary();
        public abstract double CalculateBonus();
    }
}