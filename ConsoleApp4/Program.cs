using System;
using ConsoleApp4.Entities;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "hiago", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "alex", 0.0, 500.0);
        }
    }
}
