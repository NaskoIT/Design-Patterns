namespace Logger
{
    using System;

    using Singleton.Common;

    public class Program
    {
        public static void Main()
        {
            int objectsCount = Constants.ObjectsCount;
            object[] logObjects = CreateObjects(() => Log.Instance, objectsCount);
            bool logObjectsAreEqual = ObjectsAreEqual(logObjects);
            Console.WriteLine(PrintMessages.AllCreatedObjects, nameof(Log), logObjectsAreEqual);

            Console.WriteLine(new string('-', 50));

            object[] loggerObjects = CreateObjects(() => Logger.Instance, objectsCount);
            bool loggerObjectsAreEqual = ObjectsAreEqual(loggerObjects);
            Console.WriteLine(PrintMessages.AllCreatedObjects, nameof(Logger), loggerObjectsAreEqual);

            Console.WriteLine(new string('-', 50));

            //Second implementation usnig static constructor demo
            Logger.Instance.Log(PrintMessages.SuccesfullyImpemented);
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
