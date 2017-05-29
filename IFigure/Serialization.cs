using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Model;
using System.Windows.Forms;
using System.IO;

namespace Figure
{
    class Serialization
    {
        private JsonSerializer _serializer = new JsonSerializer()
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include
        };

        public JsonSerializer SerialAccess
        {
            get { return _serializer; }
            set { _serializer = value; }
        }

        public void Serializing(SaveFileDialog sv, FigureList list)
        {
            using (StreamWriter sw = new StreamWriter(sv.FileName))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    SerialAccess.Serialize(writer, list.listFigures);
                }
            }
        }

        public void Deserializing(OpenFileDialog dg, FigureList list)
        {
            using (StreamReader sr = new StreamReader(dg.FileName))
            {
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    list.listFigures = (List<Model.IFigure>)SerialAccess.Deserialize(reader, typeof(List<Model.IFigure>));
                }
            }
        }
    }
}
