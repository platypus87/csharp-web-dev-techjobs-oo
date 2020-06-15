﻿using System;
using System.Collections.Generic;
using TechJobsOO;
namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<Job> jobs = new List<Job>();

            jobs.Add(job1);
            jobs.Add(job2);
            jobs.Add(job3);

            foreach (Job job in jobs)
            {
                Console.WriteLine(job.ToString());
            }
            
            /*
            Job job1 = new Job("Job 1", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer(""), new Location(""), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job3 = new Job();

            Console.WriteLine(job1.ToString());
            Console.WriteLine(job2.ToString());
            Console.WriteLine(job3.ToString());
            Console.WriteLine(job1.EmployerName.Id);
            */
            //Console.WriteLine(job1.ToString());
            //Console.WriteLine(job2.ToString());
            //Console.WriteLine(job3.ToString());

        }
    }
}
