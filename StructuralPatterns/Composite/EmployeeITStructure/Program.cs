namespace EmployeeITStructure
{
    using System;

    using Composite.Common;

    public class Program
    {
        public static void Main()
        {
            Employee boss = new() { Id = 1, Position = Constants.DisplayCEO };

            Employee backEndTeamLeader = new() { Id = 2, Position = Constants.DisplayBackEndTeamLeader };
            Employee frontEndTeamLeader = new() { Id = 3, Position = Constants.DisplayFrontEndTeamLeader };

            boss.AddSubordinate(backEndTeamLeader);
            boss.AddSubordinate(frontEndTeamLeader);
            
            Employee cSharpSeniorDeveloper = new() { Id = 4, Position = Constants.DisplayCSharpSenior };
            Employee pythonSeniorDeveloper = new() { Id = 5, Position = Constants.DisplayPythonSenior };

            backEndTeamLeader.AddSubordinate(cSharpSeniorDeveloper);
            backEndTeamLeader.AddSubordinate(pythonSeniorDeveloper);

            Employee angularSeniorDeveloper = new() { Id = 6, Position = Constants.DisplayAngularSenior };
            Employee blazorSeniorDeveloper = new() { Id = 7, Position = Constants.DisplayBlazorSenior };

            Contractor juniorAngularDeveloper = new() { Id = 8, Position = Constants.DisplayJuniorAngular };
            Contractor juniorReactDevelope = new() { Id = 9, Position = Constants.DisplayJuniorReact };

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
