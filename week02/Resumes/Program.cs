using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Reciclarg";
        job1._jobTitle = "IT technician";
        job1._startYear = 2015;
        job1._endYear = 2018;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Programer";
        job2._company = "Power IT";
        job2._startYear = 2018;
        job2._endYear = 2025;
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Andrés Fernández";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}