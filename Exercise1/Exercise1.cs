using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Exercise1
{
  
    class Exercise1
    {
        List<User> lst = new List<User>();
        public void  inputList()
        {            
            User us = new User();
            Console.WriteLine("Nhap username: ");
            us.username = Console.ReadLine();
            Console.WriteLine("Nhap password: ");
            us.password = Console.ReadLine();
            lst.Add(us);
        }

        public void showList()
        {
            foreach (User i in lst)
            {
                Console.WriteLine("Username: "+i.username);
                Console.WriteLine("Password: "+i.password);
            }        
        }

        public static void menu()
        {
            Console.WriteLine("1. Nhap user.");
            Console.WriteLine("2. Hien thi user.");
            Console.WriteLine("3. Thoat");
        }
        static void Main(string[] args)
        {
            Exercise1 ex = new Exercise1();                   
            int choice;
            do
            {
                menu();
                string inputStr = Console.ReadLine();
                choice = Int32.Parse(inputStr);
                switch (choice)
                {
                    case 1:
                        ex.inputList();
                        break;
                    case 2:
                        ex.showList();
                        Console.ReadKey();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong");
                        break;
                }
                Console.ReadLine();
            } while (choice != 3);
        }
    }
}
