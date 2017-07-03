namespace Api.Models
{
    public enum JobEnum { Actor, Director, Producer, Staff }
    public class Person
    {
        public int Id { get; set; }
        public JobEnum Function { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}