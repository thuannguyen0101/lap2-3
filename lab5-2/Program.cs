namespace lab5_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var highSchoolTeacher = new HighSchoolTeacher
            {
                PersonName = "Meo Mi",
                IsSeniorLecturer = true,
                Experience = 3,
            };
            highSchoolTeacher.CalculateSalary();
        }
    }
}