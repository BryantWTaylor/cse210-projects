using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Sales Representative";
        job1._company = "Wireless Advocates";
        job1._startYear = 2017;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "Optician";
        job2._company = "Costco";
        job2._startYear = 2018;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Bryant Taylor";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}