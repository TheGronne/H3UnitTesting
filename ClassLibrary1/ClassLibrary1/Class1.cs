using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
namespace ClassLibraryUnit
{
    public class Person
    {
        string firstName;
        string lastName;
        int age;
        JobTypes? job; //Nullable 

        public Person(string firstName, string lastName, int age, JobTypes? job)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            if (this.age < 0)
                this.age = 0;
            this.job = job;
        }

        public void AssignNewJob(string job)
        {
            try
            {
                this.job = (JobTypes)Enum.Parse(typeof(JobTypes), job);
            }
            catch (ArgumentException)
            {
                this.job = null;
            }
        }

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public int GetAge()
        {
            return age;
        }

        public JobTypes? GetJob()
        {
            return job;
        }

        public void HappyBirthday()
        {
            age += 1;
        }
    }

    public enum JobTypes
    {
        Teacher,
        Fireman,
        Policeman,
        Politician,
        Comedian,
        Mechanic,
        Programmer
    }

    public class Email
    {
        public string Sender;
        public string Receiver;
        public string Message;
        public int Priority;
        public bool Sent = false;

        public Email(string sender, string receiver, string message, int priority)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.Message = message;
            this.Priority = priority;
        }

        public bool Send()
        {
            if (Sent)
            {
                return false;
            }
            Sent = true;
            MailAccount.accounts["receiver"].inbox.Add(this);
            return true;
        }
    }

    public class MailAccount
    {
        public static Dictionary<string, MailAccount> accounts = new Dictionary<string, MailAccount>();
        public List<Email> inbox = new List<Email>();
        public Email[] GetInbox()
        {
            Email[] inbox2 = new Email[inbox.Count];
            for (int i = 0; i < inbox2.Length; i++)
            {
                inbox2[i] = inbox[i];
            }
            return inbox2;
        }
    }

    public class Bicycle
    {
        public string name;
        public int size;
        public int gears;
        public double price;

        
        public Bicycle(string name, int size, int gears, double price)
        {
            this.name = name;
            this.size = size;
            this.gears = gears;
            this.price = price;
        }
    }

    public class BicycleShop
    {
        static int size;
        public List<Bicycle> bicycles = new List<Bicycle>();

        public void AddBicycle(Bicycle bicycle)
        {
            bicycles.Add(bicycle);
        }
        public Bicycle GetBicycle(int id)
        {
            Bicycle bicycle = bicycles[id];
            return bicycle;
        }
        public List<Bicycle> GetAllBicycles()
        {
            return bicycles;
        }
        public void UpdateBicycle(string name, int size, int gears, double price, int id)
        {
            Bicycle bicycle = new Bicycle(name, size, gears, price);
            bicycles[id] = bicycle;
        }
        public void DeleteBicycle(int id)
        {
            bicycles.RemoveAt(id);
        }
    }
}
