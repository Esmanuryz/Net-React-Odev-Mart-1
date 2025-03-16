using System;
using Business;
using DataAccess;
using Entities;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var langRepo = new ProgrammingLanguageRepository();
        var langManager = new ProgrammingLanguageManager(langRepo);

        while (true)
        {
            Console.WriteLine("\n1- Yeni Programlama Dili Ekle");
            Console.WriteLine("2- Tüm Programlama Dillerini Listele");
            Console.WriteLine("3- Çıkış");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Programlama dili adı: ");
                string name = Console.ReadLine();
                langManager.AddLanguage(name);
                Console.WriteLine("Dil eklendi.");
            }
            else if (choice == "2")
            {
                List<ProgrammingLanguage> languages = langManager.GetAllLanguages();
                Console.WriteLine("\nProgramlama Dilleri:");
                foreach (var lang in languages)
                {
                    Console.WriteLine($"{lang.Id} - {lang.Name}");
                }
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim.");
            }
        }
    }
}
