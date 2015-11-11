using Microsoft.Win32;
using System;

namespace ForumPrograms {

    public class Program23 {

        static void Main(string[] args) {

            RegistryKey rk = Registry.CurrentUser;

            string subkey = "SOFTWARE\\MyExampleApp";
            string key = "VERSION";
            
            RegistryKey sk = rk.CreateSubKey(subkey);
            sk.SetValue(key, "1.0");
            
            string keyValue = (string)sk.GetValue(key);

            Console.WriteLine("Key Name : " + sk.Name);
            Console.WriteLine("Key Value: " + keyValue);

            //--            
            Console.ReadKey();
        }
    }
}