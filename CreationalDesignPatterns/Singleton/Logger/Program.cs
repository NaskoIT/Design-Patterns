namespace SingletonPattern
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            int objectsCount = 10000;
            object[] logObjects = CreateObjects(() => Log.Instance, objectsCount);
            bool logObjectsAreEqual = ObjectsAreaEqual(logObjects);
            Console.WriteLine($"All created Log objects have the same instances => are equal: {logObjectsAreEqual}");

            Console.WriteLine(new string('-', 50));

            object[] loggerObjects = CreateObjects(() => Logger.Instance, objectsCount);
            bool loggerObjectsAreEqual = ObjectsAreaEqual(loggerObjects);
            Console.WriteLine($"All created Logger objects have the same instances => are equal: {loggerObjectsAreEqual}");
            //Second implementation usnig static constructor demo
            Logger.Instance.Log("Successfully implemented singleton pattern!");
        }

        public static object[] CreateObjects(Func<object> objectFactory, int objectsCount)
        {
            object[] objects = new object[objectsCount];

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = objectFactory();
            }

            return objects;
        }

        public static bool ObjectsAreaEqual(object[] objects)
        {
            bool objectsAreEqual = true;
            //Check if all objects have the same instances
            for (int i = 0; i < objects.Length; i++)
            {
                if (!objectsAreEqual)
                {
                    break;
                }

                for (int j = 0; j < objects.Length; j++)
                {
                    if (i != j)
                    {
                        if (!objects[i].Equals(objects[j]))
                        {
                            objectsAreEqual = false;
                            break;
                        }
                    }
                }
            }

            return objectsAreEqual;
        }
    }
}
