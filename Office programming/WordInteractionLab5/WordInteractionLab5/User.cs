using System.Runtime.Serialization;

namespace WordInteractionLab5
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string MiddleName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Rate { get; set; }
    }
}