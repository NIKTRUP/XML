using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservedTables
{
    [Serializable]
    public class Client
    {
        public Client()
        { }
        public Client(int id, string fullName, int tableNumber, string reservationTime, int age, long phoneNumber)
        {
            Id = id;
            FullName= fullName;
            TableNumber = tableNumber;
            ReservationTime = reservationTime;
            Age = age;
            PhoneNumber = phoneNumber;
        }
        [System.Xml.Serialization.XmlElement("id", Namespace = "")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("fullName", Namespace = "")]
        public string FullName { get; set; }
        [System.Xml.Serialization.XmlElement("tableNumber", Namespace = "")]
        public int TableNumber { get; set; }
        [System.Xml.Serialization.XmlElement("reservationTime", Namespace = "")]
        public string ReservationTime { get; set; }
        [System.Xml.Serialization.XmlElement("age", Namespace = "")]
        public int Age { get; set; }
        [System.Xml.Serialization.XmlElement("phoneNumber", Namespace = "")]
        public long PhoneNumber { get; set; }
    }
}
