namespace ProspectState
{
    using System;

    using Memento.Common;

    public class Program
    {
        public static void Main()
        {
            SalesProspect prospect = new("Atanas", "088 8999 891", 200);
            Console.WriteLine(PrintMessages.InitialState);
            Console.WriteLine(prospect);

            Console.WriteLine(PrintMessages.SavingState);
            ProspectMemory prospectMemory = new()
            {
                Memento = prospect.SaveMemento()
            };

            Console.WriteLine(PrintMessages.ChangeState);
            prospect.Name = "Nasko";
            prospect.Phone = "123 456 789";
            prospect.Budget = 12000;
            Console.WriteLine(prospect);

            Console.WriteLine(PrintMessages.RestoreState);
            prospect.RestoreMemento(prospectMemory.Memento);
            Console.WriteLine(prospect);
        }
    }
}
