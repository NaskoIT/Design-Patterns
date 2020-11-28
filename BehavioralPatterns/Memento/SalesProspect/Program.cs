namespace SalesProspect
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect prospect = new SalesProspect("Atanas", "088 8999 891", 200);
            Console.WriteLine("Initial state");
            Console.WriteLine(prospect);

            Console.WriteLine("Saving state\n");
            ProspectMemory prospectMemory = new ProspectMemory();
            prospectMemory.Memento = prospect.SaveMemento();

            Console.WriteLine("Change initial prospect");
            prospect.Name = "Nasko";
            prospect.Phone = "123 456 789";
            prospect.Budget = 132456;
            Console.WriteLine(prospect);

            Console.WriteLine("Restore intitial state");
            prospect.RestoreMemento(prospectMemory.Memento);
            Console.WriteLine(prospect);
        }
    }
}
