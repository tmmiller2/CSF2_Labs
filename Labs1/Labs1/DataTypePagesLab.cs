using DataTypeClasses; //Added for easier access to DataTypeClasses 
using Signatures; //Added for easier access to Signature

namespace Labs1
{
    class LabSets
    {
        static void Main(string[] args)
        {
            Signature.Header("Lab Sets");

            Student s1 = new Student();
            s1.FirstName = "John";
            s1.LastName = "Doe";
            s1.Id = "1629402";
            s1.Gpa = 2;

            Console.WriteLine("\n{0} {1} is a part of our test group. Their student id is: {2}, " +
                "and they have a GPA of {3}\n", s1.FirstName, s1.LastName, s1.Id, s1.Gpa);

            Student s2 = new Student();
            s2.FirstName = "Bob";
            s2.LastName = "Smith";
            s2.Id = "1847392";
            s2.Gpa = 4;

            Console.WriteLine("{0} {1} is someone I would study with. Their student id is: {2}, " +
                "and they have a GPA of {3}\n\n", s2.FirstName, s2.LastName, s2.Id, s2.Gpa);



            Vehicle v1 = new Vehicle();

            v1.Make = "Dodge";
            v1.Model = "Charger";
            v1.Year = 2022;
            v1.Weight = 4486;

            Console.WriteLine($"The {v1.Year} {v1.Make} {v1.Model} is a nice vehicle that weighs {v1.Weight} lbs.\n");

            Vehicle v2 = new Vehicle();

            v2.Make = "Dodge";
            v2.Model = "Challenger";
            v2.Year = 2021;
            v2.Weight = 4247;

            Console.WriteLine($"The {v2.Year} {v2.Make} {v2.Model} is a mean looking vehicle, coming in at {v2.Weight} lbs.\n\n");


            Login l1 = new Login();

            l1.Username = "john.doe@outlook.com";
            l1.Password = "Jd1234567!";

            Console.WriteLine($"The username is: {l1.Username}\nThe password is: {l1.Password}\n");

            Login l2 = new Login();

            l2.Username = "bob.smith@outlook.com";
            l2.Password = "Bs7654321!";

            Console.WriteLine($"The username is: {l2.Username}\nThe password is: {l2.Password}\n\n");


            ContactInfo c1 = new ContactInfo();

            c1.StreetAddress = "1234 S. Miller Dr.";
            c1.City = "Kansas City";
            c1.State = "Missouri";
            c1.Zip = "64030";
            c1.Phone = "816-777-7777";
            c1.Email = "john.doe@outlook.com";

            Console.WriteLine($"The user has logged in with the email, {c1.Email}, and the phone number, {c1.Phone}" +
                $". Their address is {c1.StreetAddress}, {c1.City}, {c1.State} {c1.Zip}.\n");


            ContactInfo c2 = new ContactInfo();

            c2.StreetAddress = "4321 W. Pepper Lane.";
            c2.City = "Lees Summit";
            c2.State = "Missouri";
            c2.Zip = "64081";
            c2.Phone = "816-888-8888";
            c2.Email = "bob.smith@outlook.com";

            Console.WriteLine($"The user has logged in by email, {c2.Email}, and linked the phone number, {c2.Phone}" +
                $". Their address is {c2.StreetAddress}, {c2.City}, {c2.State} {c2.Zip}.\n\n");

        }
    }
}