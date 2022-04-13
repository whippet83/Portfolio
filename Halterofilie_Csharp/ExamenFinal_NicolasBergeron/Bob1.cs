using System.Xml.Serialization;

namespace ExamenFinal_NicolasBergeron
{
    public class Bob
    {
        public int count1 { get; set; }
        public int count2 { get; set; }
        public int count3 { get; set; }
        public int count4 { get; set; }
        public int count5 { get; set; }

        public void Save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(Bob));
                XML.Serialize(stream, this);
            }
        }

        public static Bob LoadFromFile(string fileName) 
        {
            using (var stream = new FileStream(fileName, FileMode.Open)) 
            {
                var XML = new XmlSerializer(typeof(Bob));
                return (Bob)XML.Deserialize(stream);
            }
        }
    
    }
}