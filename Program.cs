using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace P4
{
    class Program
    {
        public int ID { get; set; }
        public string Name { get; set; }
        String name, branch;
        int enrol;
        public void printID()
        {
            Console.WriteLine("ID is: {0}", this.ID);
        }
        public void printName()
        {
            Console.WriteLine("Name is: {0}", this.Name);
        }
        public Program(String name)
        {
            this.name = name;
            Console.WriteLine("constructor 1:" + name);
        }
        public Program(String name, int enrol)
        {
            this.name = name;
            this.enrol = enrol;
            Console.WriteLine("constructor 2:" + name + " " + enrol);

        }
        public Program(String name, int enrol, String branch)
        {
            this.name = name;
            this.enrol = enrol;
            this.branch = branch;
            Console.WriteLine("constructor 3:" + name + " " + enrol + " " + branch);

        }
        static void Main(string[] args)
        {
            try
            {
                Type T = Type.GetType("p3a1.Program");
                MethodInfo[] methods = T.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine(method.ReturnType + " " + method.Name);
                }

                PropertyInfo[] properties = T.GetProperties();

                Console.WriteLine("\nProperties");
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine(property.PropertyType + " " + property.Name);
                }

                Console.WriteLine("\nConstructors");
                ConstructorInfo[] constructors = T.GetConstructors();
                foreach (ConstructorInfo constructor in constructors)
                {
                    Console.WriteLine(constructor.ToString());
                }

                Program p1 = new Program("bob");
                Program p2 = new Program("bob", 1);
                Program p3 = new Program("bob", 1, "computer");


                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();

            }
        }
    }
}

