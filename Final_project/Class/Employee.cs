using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Class
{
    public class Employee
    {
        private int id;
        private string name;
        private DateTime dataOfBirth;
        private string adress;
        private string phoneNumber;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DataOfBirth { get => dataOfBirth; set => dataOfBirth = value; }
        public string Adress { get => adress; set => adress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

        public Employee(int id, string name,DateTime dataOfBirth, string adress, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.DataOfBirth = dataOfBirth;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
        }

        public Employee(string name, DateTime dataOfBirth, string adress, string phoneNumber)
        {
            this.Name = name;
            this.DataOfBirth = dataOfBirth;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
        }
    }
}
