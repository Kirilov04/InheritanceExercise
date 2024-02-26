using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Mammal> list = new List<Mammal>();
            list.Add(new Gorilla("Masha"));

            foreach (var mammal in list) 
            {
                //mammal.ProduceMilk();
            }
        }
    }
}
