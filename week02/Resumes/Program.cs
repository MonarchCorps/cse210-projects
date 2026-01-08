using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Tech Solutions Inc.";
        job1._startDate = "2019";
        job1._endDate = "2021";

        Job job2 = new Job();
        job2._jobTitle = "Senior Developer";
        job2._company = "Innovatech LLC";
        job2._startDate = "2021";
        job2._endDate = "Present";

        Resume myResume = new Resume();

        myResume._name = "David Okocha";
        myResume._jobs.AddRange(job1, job2);

        myResume.DisplayResume();

    }
}