using PhoneBookApplication.Controllers;
using PhoneBookApplication.Models;
using System;

namespace PhoneBookApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Erhan", "Yükselen", "123"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Ayberk", "Kalyoncu", "456"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Faruk", "Erol", "789"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Murat", "Aktaş", "321"));
            PhoneBookListModel.phoneBookNumberList.Add(new PhoneBookNumberModel("Doğukan", "Sevinç", "654"));


            OperationController.StartMethots();
            Console.WriteLine("Çıkmak İçin Herhangi Bir Tuşa Basınız...");
            Console.ReadKey();

        }
    }
}