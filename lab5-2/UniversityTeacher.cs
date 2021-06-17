namespace lab5_2
{
    public class UniversityTeacher: Person
    {
        public int EnglishSkill { get; set; }
        
        public override double CalculateSalary()
        {
            var salary = 50000 + Experience * 5000 + EnglishSkill * 1000;
            if (IsSeniorLecturer && salary < 60000)
            {
                throw new AmountException("Senior lecturer cannot get less than 60000 salary", PersonName);
            }
            return salary;
        }
        
        public override double CalculateBonus()
        {
            var bonus = 5000 + Experience * 2000;
            if (bonus > 10000)
            {
                throw new AmountException("Bonus cannot be more than 10000", PersonName);
            }
            return bonus;
        }
    }
}