namespace CompositePattern
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Employee boss = new Employee { Id = 1, Name = "boss" };

            Employee backEndTeamLeader = new Employee { Id = 2, Name = "back-end Team Leader" };
            Employee frontEndTeamLeader = new Employee { Id = 3, Name = "front-end Team Leader" };

            boss.AddSubordinate(backEndTeamLeader);
            boss.AddSubordinate(frontEndTeamLeader);

            Employee cSharpSeniorDeveloper = new Employee { Id = 4, Name = "C# Senior Developer" };
            Employee pythonSeniorDeveloper = new Employee { Id = 5, Name = "Python Senior Developer" };

            backEndTeamLeader.AddSubordinate(cSharpSeniorDeveloper);
            backEndTeamLeader.AddSubordinate(pythonSeniorDeveloper);

            Employee angularSeniorDeveloper = new Employee { Id = 6, Name = "Angular Senior Developer" };
            Employee blazorSeniorDeveloper = new Employee { Id = 7, Name = "Blazor Senior Developer" };

            Contractor juniorAngularDeveloper = new Contractor { Id = 8, Name = "Junior Angular Developer" };
            Contractor juniorReactDevelope = new Contractor { Id = 9, Name = "Junior React Developer" };

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
