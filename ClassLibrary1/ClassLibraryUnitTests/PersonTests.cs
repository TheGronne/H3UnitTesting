using NUnit.Framework;
using ClassLibraryUnit;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryUnit.Tests
{
    [TestFixture()]
    public class PersonTests
    {
        [Test()]
        public void PersonTest()
        {
            //
        }

        [Test()]
        public void AssignNewJobTest()
        {
            Person person = new Person("Joe", "Foe", 19, JobTypes.Comedian);
            person.AssignNewJob("IT Supporter");
            Assert.That(person.GetJob() == null); //Passes

            Person person2 = new Person("Joe", "Foe", 19, JobTypes.Programmer);
            person2.AssignNewJob("Comedian");
            Assert.That(person2.GetJob() != null); //Passes
        }

        [Test()]
        public void GetFullNameTest()
        {
            Person person = new Person("Joe", "Foe", 19, JobTypes.Comedian);
            Assert.That(person.GetFullName() == "Joe Foe"); //Passes
        }

        [Test()]
        public void GetAgeTest()
        {
            Person person = new Person("Joe", "Foe", -2, JobTypes.Comedian);
            Assert.That(person.GetAge() == 0); //Passes
        }

        [Test()]
        public void GetJobTest()
        {
            Person person = new Person("Joe", "Foe", -2, JobTypes.Comedian);
            Assert.That(person.GetJob() == JobTypes.Comedian); //Passes
        }

        [Test()]
        public void HappyBirthdayTest()
        {
            Person person = new Person("Joe", "Foe", 19, JobTypes.Comedian);
            person.HappyBirthday();
            Assert.That(person.GetAge() == 20); //Passes
        }
    }
}