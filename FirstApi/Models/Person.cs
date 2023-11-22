using System.ComponentModel.DataAnnotations;

namespace FirstApi.Models
{
    
    
        public class Person
        {
            [Required]
            public string Aadhar { get; set; }
            [MaxLength(100)]
            public string Name { get; set; }

            [Range(18, 100)]
            public int Age { get; set; }
            [EmailAddress]
            public string Email { get; set; }
        }
        public class PersonOpertaions
        {
            private static List<Person> _people = new List<Person>();
            public static List<Person> GetPeople()
            {
                if (_people.Count == 0)
                {
                    _people.Add(new Person() { Aadhar = "AA6736273", Age = 25, Email = "m@gmail,com", Name = "eena" });
                    _people.Add(new Person() { Aadhar = "BB6736273", Age = 26, Email = "m@gmail.com", Name = "meena" });
                    _people.Add(new Person() { Aadhar = "CC6736273", Age = 27, Email = "m@gmail.com", Name = "deena" });

                }
                return _people;
            }
            public static  bool Update(string pAadhar,Person updatedPerson)
        {
            var found=GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();

            if (found != null)
            {
                found.Email=updatedPerson.Email; 
                found.Name=updatedPerson.Name;
                found.Age=updatedPerson.Age;
                return true;
            }
            else
                throw new Exception("no such record");

        }
        
            public static Person Search(string pAadhar)
            {
                return GetPeople().Where(p => p.Aadhar == pAadhar).FirstOrDefault();
            }

            public static List<Person> getPeopleAge(int startage, int endage)
            {
                return GetPeople().Where(p => startage < p.Age && p.Age < endage).ToList();
            }

            internal static void CreateNew(Person p)
            {
                GetPeople();//get initaial records and then add
                _people.Add(p);// _people is static list)
            }

        public  static bool Delete(string pAadhar)
        {
            var found=GetPeople().Where(p=>p.Aadhar==pAadhar).FirstOrDefault();
            if (found != null)
            {
                GetPeople().Remove(found);
                return true;
            }
            else
                throw new Exception("no such record");
        }
    }
        
        
    
}
