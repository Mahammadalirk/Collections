using System;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();

            nums.Add(5);
            nums.Add(6);
            nums.Add(7);
            nums.Add(8);
            nums.Add(9);





            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }

            if (nums.Count == 5)
            {
                Console.WriteLine("List Count is {0}", nums.Count);
            }

            List<Person> people = new List<Person>();

            Person person1 = new Person();
            person1.Name = "Adil";
            person1.Id = 6;
            person1.Email = "adil1222@mail.ru";

            Person person2 = new Person
            {
                Id = 8,
                Name = "Ismet",
                Email = "ismet3345@mail.ru"


            };

            people.Add(person1);
            people.Add(person2);

            people.Add(new Person { Id = 1, Name = "Eli", Email = "eli@mail.ru" });
            people.Add(new Person { Id = 2, Name = "Eliyar", Email = "eliyar@mail.ru" });
            people.Add(new Person { Id = 8, Name = "Veli", Email = "veli@mail.ru" });
            people.Add(new Person { Id = 3, Name = "Huseyn", Email = "huseyn@mail.ru" });
            people.Add(new Person { Id = 4, Name = "Ilkin", Email = "ilkin@mail.ru" });
            people.Add(new Person { Id = 5, Name = "Maga", Email = "maga@mail.ru" });

            GetStudents(people);
            GetNumbers(nums);

            var result = GetPersonByName(people, "Huseyn");
            Console.WriteLine(result.Name + "-" + result.Id + "-" + result.Email + "-");

            var result = GetPeopleByName(people, "Huseyn");

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "-" + item.Id + "-" + item.Email + "-");
            }

            Hashtable datas = new Hashtable();
            datas.Add(1, "Azer");
            datas.Add(2, "Ilkin");
            datas.Add(3, "Huseyn");
            datas.Add(4, "Eli");

            foreach (DictionaryEntry item in datas)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            SortedList datas = new SortedList();
            datas.Add(1, "Azer");
            datas.Add(5, "Ilkin");
            datas.Add(34, "Huseyn");
            datas.Add(4, "Eli");

            foreach (DictionaryEntry item in datas)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            SortedList<int, string> datas = new SortedList<int, string>(); //classda yazmaq olur
            datas.Add(6, "Azer");
            datas.Add(4, "Ilkin");

            foreach (KeyValuePair<int, string> item in datas)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            ArrayList datas = new ArrayList();

            datas.Add("Hello");
            datas.Add(5);
            datas.Add(true);

            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }

            HashSet<int> datas = new HashSet<int>();
            datas.Add(1);
            datas.Add(5);
            datas.Add(1);

            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }

            Stack<int> datas = new Stack<int>();
            datas.Push(8);
            datas.Push(22);
            datas.Push(18);
            datas.Push(11);

            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }

            Queue<int> datas = new Queue<int>();
            datas.Enqueue(5);
            datas.Enqueue(7);
            datas.Enqueue(8);
            datas.Enqueue(11);

            foreach (var item in datas)
            {
                Console.WriteLine(item);
            }

            Dictionary<string, string> datas = new Dictionary<string, string>();
            datas.Add("Admin", "Maga");
            datas.Add("SuperAdmin", "Azer");
            datas.Add("Members", "Huseyn");
            datas.Add("User", "Eli");

            foreach (var item in datas)
            {
                Console.WriteLine($"Name :{item.Value}, Speciality : {item.Key}");
            }

            foreach (var item in datas)
            {
                if (item.Key == "Admin")
                {
                    Console.WriteLine($"Name : {item.Value}, Speciality : {item.Key}");
                    break;
                }
            }
        }




        public static void GetStudents(List<Person> students)
        {
            foreach (var stu in students)
            {
                Console.WriteLine("Students : Id - {0},Name -{1}, Email -{2}", stu.Id, stu.Name, stu.Email);
            }

        }

        public static void GetNumbers(List<int> numbers)
        {
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        public static List<Person> GetPeopleByName(List<Person> people, string name)
        {
            var person = people.FindAll(m => m.Name == name);
            return person;
        }

    }
}
