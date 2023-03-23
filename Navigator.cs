using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortcuts
{
    interface IPage
    {
        string GetName();
        void Start();
    }

    class MainPage : IPage
    {
        Dictionary<string, IPage> options = new Dictionary<string, IPage>();
        public MainPage()
        {
            options.Add("1", new LoginPage());
            options.Add("2", new SignUpPage());
            options.Add("3", new AddUserPage());
        }

        public string GetName()
        {
            return "Main Page";
        }

        public void Start()
        {
            foreach (var key in options.Keys)
            {
                Console.WriteLine(key + ". "+ options[key].GetName());
            }

            string choice = Console.ReadLine();

            options[choice].Start();

        }
    }

    class LoginPage : IPage
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Login ");
            Console.WriteLine("Enter user name");
        }
        public string GetName()
        {
            return "Login Page";
        }
    }

    class SignUpPage : IPage
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("Sigup ");
            Console.WriteLine("Enter user name");
        }
        public string GetName()
        {
            return "Signup Page";
        }
    }

    class AddUserPage : IPage
    {
        public void Start()
        {
            Console.Clear();
            Console.WriteLine("ADd useer ");
            Console.WriteLine("Enter user name");
        }
        public string GetName()
        {
            return "Add User Page";
        }
    }


    public class Navigator
    {
        static Dictionary<string, IPage> pages = new Dictionary<string, IPage>();

        static Navigator()
        {
            pages.Add("Main", new MainPage());
            pages.Add("Login", new LoginPage());
            pages.Add("Signup", new SignUpPage());
        }


        public static void Navigate(string url)
        {
            Console.Clear();
            pages[url].Start();
        }
    }
}
