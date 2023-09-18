
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login l1 = new Login();
            l1.setNameLoginDetails("sidharth", 23);
            l1.getProfile();
            Console.ReadLine();
        }
    }
    class User
    {
        public String name = "RKP";
        private int age;
        protected void setProfile(String name, int age)
        {
            this.name = name;
            this.setAge(age);
        }
        private void setAge(int age)
        {
            this.age = age;
        }
        public void getProfile()
        {
            Console.WriteLine("NAME :" + name + " " + "Age :" + age);
        }
    }
    class Login : User
    {
        public void setNameLoginDetails(String name, int age)
        {
            this.setProfile(name, age);
        }
    }
}
