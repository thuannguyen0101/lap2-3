namespace lab4
{
    public class Person
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public void ToString()
        {
            // Console.OutputEncoding = Encoding.UTF8;
            // Console.WriteLine($"Name: {Name}, Phone: {Phone}, Email: {Email}");
        }
    }
}