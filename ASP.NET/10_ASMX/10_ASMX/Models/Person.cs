using System.Runtime.Serialization;

namespace _10_ASMX.Models
{
    public class Person
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Phone { get; set; }
    }
}