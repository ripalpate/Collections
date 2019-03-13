using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfObjects = new object[5];
            var studentsWithBlackHair = new List<string> {"Nathan", "Austin", "Marty Mcfly"};//collection intializer beacause you are doing collection

            studentsWithBlackHair.Add("Robert");
            var studentsByHairColor = new Dictionary<string, List<string>>
            {
                { "Black", studentsWithBlackHair }
            };
            studentsByHairColor.Add("Bald", new List<string> {"Martin"});
            //studentsByHairColor.Add("Bald", new List<string> { "Adam" }); // it will trhow exception as you can't add multiple values to same key.

            var theBlackHairedStudents= studentsByHairColor["Black"]; //gives value out of List. 

            if (theBlackHairedStudents == studentsWithBlackHair)
            {
                Console.WriteLine("They are the same");
            }

            //studentsByHairColor["Black"] = new List<string>();

            //studentsByHairColor["Black"].Add("Welly");
            //kvp is key value pair. when you want to destructure use it(key, value) so its not wrapped around. and can access key and value. hairColor is key and students are value
            foreach (var (hairColor, students) in studentsByHairColor)
            {
                Console.WriteLine($"The following students have {hairColor} hair");

                //students.Add("new person");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
            }
            Console.ReadLine();
        }
    }
}
