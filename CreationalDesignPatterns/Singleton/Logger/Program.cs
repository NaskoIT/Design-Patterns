namespace Logger
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int objectsCount = 10000;
            object[] logObjects = CreateObjects(() => Log.Instance, objectsCount);
            bool logObjectsAreEqual = ObjectsAreEqual(logObjects);
            Console.WriteLine($"All created Log objects have the same instances => are equal: {logObjectsAreEqual}");

            Console.WriteLine(new string('-', 50));

            object[] loggerObjects = CreateObjects(() => Logger.Instance, objectsCount);
            bool loggerObjectsAreEqual = ObjectsAreEqual(loggerObjects);
            Console.WriteLine($"All created Logger objects have the same instances => are equal: {loggerObjectsAreEqual}");
            //Second implementation usnig static constructor demo
            Logger.Instance.Log("Successfully implemented singleton pattern!");
        }

        private static object[] CreateObjects(Func<object> objectFactory, int objectsCount)
        {
            object[] objects = new object[objectsCount];

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i] = objectFactory();
            }

            return objects;
        }

        private static bool ObjectsAreEqual(object[] objects)
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
