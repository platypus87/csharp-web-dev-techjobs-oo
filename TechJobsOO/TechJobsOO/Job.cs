using System;
using System.Runtime.CompilerServices;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }


        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        //Test 4 Code: Custom ToString() Method
        //*****Using Code help from Josh
        public override string ToString()
        {
            string retVal;
            if (string.IsNullOrEmpty(Name))
            {
                Name = "Data Not Available";
            }
            retVal = $"\nID: {Id}\nName: {Name}\nEmployer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\nCore Competency: {JobCoreCompetency}\n";
            return retVal;
        }
        //*****Attempt at going through instructions line by line for ToString() method
        /*
        public override string ToString()
        {
            string retVal = "\n";
            retVal += "\n";

            return retVal;
        }
        */
        
        
        //*****Shawn's code for ToString() override, but uses null reference types; not the default
        /*
        public override string ToString()
        {
            string result = "\n";
            result += $"Name: {Name}\n";
            if (string.IsNullOrEmpty(Name))
            {
                result += $"Name: Data not available\n";
            }
            else
            {
                result += $"Name: {Name}\n";
                result += $"Employer: {Employer.ToString()}\n";
                result += $"Location: {Location.ToString()}\n";
                result += $"Position Type: {PositionType.ToString()}\n";
                result += $"Core Competency: {CoreCompetency.ToString()}\n";
                result += "\n";
                return result;
            }
        }
        */
        //*****My adaptation of Shawn's fix; does not account for data being absent in any field other than the Name field
        /*
        public override string ToString()
        {
            string result = "\n";
            
            if (string.IsNullOrEmpty(Name))
            {
                result += $"Name: Data not available\n";
            }
            else
            {
                result += $"Name: {this.Name}\n";
                result += $"Employer: {this.EmployerName}\n";
                result += $"Location: {this.EmployerLocation}\n";
                result += $"Position Type: {this.JobType}\n";
                result += $"Core Competency: {this.JobCoreCompetency}\n";
                result += "\n";
            }
            return result;
        }
        */
        //*****My ToString() method; works as it is supposed to, but is too long. Needs re-work
       
        /*
        public override string ToString()
        {
            string noData = "Data Not Available";
            if (this.Id != 0 && this.Name == null && this.EmployerName == null && this.EmployerLocation == null && this.JobType == null && this.JobCoreCompetency == null)
            {
                Console.WriteLine("\nOOPS! This job does not seem to exist.\n");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("ID: " + this.Id);
                if (this.Name != "")
                {
                    Console.WriteLine("Name: " + this.Name);
                }
                else
                {
                    Console.WriteLine("Name: " + noData);
                }
                if (string.IsNullOrEmpty(EmployerName.Value))
                {
                    Console.WriteLine($"Employer: {noData}");
                }
                else
                {
                    Console.WriteLine($"Employer: {EmployerName.Value}");
                }
                if (string.IsNullOrEmpty(EmployerLocation.Value))
                {
                    Console.WriteLine($"Location: {noData}");
                }
                else
                {
                    Console.WriteLine($"Location: {EmployerLocation.Value}");
                }
                if (string.IsNullOrEmpty(JobType.Value))
                {
                    Console.WriteLine($"Position Type: {noData}");
                }
                else
                {
                    Console.WriteLine($"Position Type: {JobType.Value}");
                }
                if (string.IsNullOrEmpty(JobCoreCompetency.Value))
                {
                    Console.WriteLine($"{noData}");
                }
                else
                {
                    Console.WriteLine($"Core Competency: {JobCoreCompetency}");
                }
            }
            return "";
        }
        */
        //Attempt at a re-word of working code
        /*
        public override string ToString()
        {
            string retVal = $"\n";
            string noData = "Data Not Available";
            retVal += $"ID: {Id}\n";
            if (string.IsNullOrEmpty(Name))
            {
                retVal += $"Name: {noData}\n";
            }
            else
            {
                retVal += $"Name: {Name}\n";
            }
            if (string.IsNullOrEmpty(EmployerName.Value))
            {
                retVal += $"Employer: {noData}";
            }
            else
            {
                retVal += $"Employer: {EmployerName.Value}\n";
            }
            if (string.IsNullOrEmpty(EmployerLocation.Value))
            {
                retVal += $"Location: {noData}";
            }
            else
            {
                retVal += $"Location: {EmployerLocation.Value}\n";
            }
            if (string.IsNullOrEmpty(JobType.Value))
            {
                retVal += $"Position Type: {noData}";
            }
            else
            {
                retVal += $"Position Type: {JobType.Value}\n";
            }
            if (string.IsNullOrEmpty(JobCoreCompetency.Value))
            {
                retVal += $"Core Competency: {noData}";
            }
            else
            {
                retVal += $"Core Competency: {JobCoreCompetency.Value}\n";
            }
            return retVal;
        }
        */
        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

    }
}
