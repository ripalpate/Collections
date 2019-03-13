using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrayOfObjects = new object[5];
            var studentsWithBlackHair = new List<string> { "Pathan Monzales", "Austin Smith", "Marty Mcfly" };//collection intializer beacause you are doing collection

            var studentsWithBlackHairAndP = studentsWithBlackHair
                .Where(name => name.StartsWith("P"))
                .Select(name =>
                    new { FirstName = name.Split(" ")[0],       //anonymous Type check in class repo for other way to do it with writing method.
                        LastName = name.Split(" ")[1]
                    });

            if (studentsWithBlackHairAndP.All(student => student.FirstName.StartsWith("M")))
            {
                Console.WriteLine("Not getting un here");
            }

            //  studentsWithBlackHairAndP.Average(student => student.FirstName.Length);
            var groupedStudentsNames = studentsWithBlackHair.GroupBy(name => name.First());

            //foreach (var groupOfStudentNames in groupedStudentNames)
            //{
            //    // groupOfStudents.Key
            //    var key = groupOfStudentNames.Key;
            //    var numberOfPeople = groupOfStudentNames.Count();
            //    foreach (var name in groupOfStudentNames)
            //    {
            //        Console.WriteLine($"{ name} starts with {key}");
            //    }
            //}

            foreach (var student in studentsWithBlackHairAndP)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} HashCode a 'P' in it");
            }
           
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
