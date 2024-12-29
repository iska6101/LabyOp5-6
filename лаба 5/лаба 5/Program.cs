using System;
using лаба_5;

class Program
{
    static void Main(string[] args)
    {
        string studentName = "Загртдинов Искандэр Алмазович";
        string group = "Группа 6101-090301D";

        Menu menu = new Menu(studentName, group);
        menu.Start();
    }
}
