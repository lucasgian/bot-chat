
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.IO;

namespace Bot
{
    public class Feeder
    {
        private string fileName;
        private dynamic array;

        
        private void read()
        {
            JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            using (StreamReader r = new StreamReader(this.fileName))
            {
                string json = r.ReadToEnd();
                this.array = serializer.DeserializeObject(json);

                /*
                    Print do array dynamic com o valor do arquivo json
                    Console.WriteLine("");
                    Console.WriteLine(serializer.Serialize(array));
                    Console.WriteLine("");
                    Console.ReadKey(); 
                */
            }
        }
    }
}
