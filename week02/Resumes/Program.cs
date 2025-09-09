using System;

class Program
{
    static void Main(string[] args)
    {
        //Shorthand to assign initial value to the attributes directly when creating an objet of the class 
        // Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);


        //setting a new job instance or object
        Job job1 = new Job();

        //to assign value to attributes
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        //Shorthand to assign initial value to the attributes directly when creating an objet of the class 
        // Job job2 = new Job("Apple", "MAnager", 2022, 2023);


        //setting a second job instance or object
        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2014;
        job2._endYear = 2030;

        job1.Display();
        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}