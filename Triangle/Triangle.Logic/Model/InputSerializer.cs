using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace Triangle.Core.Model
{
    public class InputSerializer
    {
        private static DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Input));
        private const string defaultFileName = "input.json";

        [DataContract]
        public class Input
        {
            [DataMember]
            public string[] Strings { get; set; }

            public Input(string[] strings)
            {
                Strings = strings;
            }
        }

        public void Serialize(Input input, string file = defaultFileName)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, input);
            }
        }

        public Input Deserialize(string file = defaultFileName)
        {
            Input input = null;

            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                input = (Input)jsonFormatter.ReadObject(fs);
            }

            return input;
        }           
    }
}



