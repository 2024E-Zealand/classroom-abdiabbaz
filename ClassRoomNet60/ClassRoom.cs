using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassRoomNet60
{
    public class ClassRoom
    {
        public string? Name { get; set; }

        public List<Student> Students { get; set; } 

        public DateTime SemesterStart { get; set; }

        public ClassRoom()
        {
            Name = "";
            Students = new List<Student>();
            SemesterStart = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Students)}={Students}, {nameof(SemesterStart)}={SemesterStart.ToString()}}}";
        }

        public void CountBirthdays()
        {
            var list = new List<string> { "Summer", "Winter", "Autumn", "Spring" };
            foreach (var seasons in list)
            {
                var count = Students.Where(s => s.Season() == seasons).Count();
                Console.WriteLine($"Season: {seasons}, How many: {count}");
            }
        }
    }
}
