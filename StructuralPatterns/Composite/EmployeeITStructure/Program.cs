namespace EmployeeITStructure
{
    using System;
    using StructuralPatterns.Common;

    public class Program
    {
        public static void Main()
        {
            Employee boss = new Employee { Id = 1, Position = Constants.DisplayCEO };

            Employee backEndTeamLeader = new Employee { Id = 2, Position = Constants.DisplayBackEndTeamLeader };
            Employee frontEndTeamLeader = new Employee { Id = 3, Position = Constants.DisplayFrontEndTeamLeader };

            boss.AddSubordinate(backEndTeamLeader);
            boss.AddSubordinate(frontEndTeamLeader);
            
            Employee cSharpSeniorDeveloper = new Employee { Id = 4, Position = Constants.DisplayCSharpSenior };
            Employee pythonSeniorDeveloper = new Employee { Id = 5, Position = Constants.DisplayPythonSenior };

            backEndTeamLeader.AddSubordinate(cSharpSeniorDeveloper);
            backEndTeamLeader.AddSubordinate(pythonSeniorDeveloper);

            Employee angularSeniorDeveloper = new Employee { Id = 6, Position = Constants.DisplayAngularSenior };
            Employee blazorSeniorDeveloper = new Employee { Id = 7, Position = Constants.DisplayBlazorSenior };

            Contractor juniorAngularDeveloper = new Contractor { Id = 8, Position = Constants.DisplayJuniorAngular };
            Contractor juniorReactDevelope = new Contractor { Id = 9, Position = Constants.DisplaJuniorReact };

            frontEndTeamLeader.AddSubordinate(angularSeniorDeveloper);
            frontEndTeamLeader.AddSubordinate(blazorSeniorDeveloper);
            frontEndTeamLeader.AddSubordinate(juniorAngularDeveloper);
            frontEndTeamLeader.AddSubordinate(juniorReactDevelope);

            Console.WriteLine(boss);

            foreach (Employee manager in boss)
            {
                Console.WriteLine($"\t" + manager);

                foreach (var employee in manager)
                {
                    Console.WriteLine("\t\t" + employee);
                }
            }
        }
    }
}
