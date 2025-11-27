using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuhaProjekt
{
    public class FileHelper
    {
        public static bool Write(string fileName, List<Clothing> clothes, string header)
        {
            try
            {
                StreamWriter writer = new StreamWriter(fileName);

                if (header != "")
                {
                    writer.WriteLine(header);
                }

                foreach (Clothing clothing in clothes)
                {
                    string line = $"{clothing.GetType().Name};{clothing.Brand};{clothing.Size};{clothing.Color}";

                    if (clothing is Accessory accessory)
                    {
                        line += $";{accessory.Type};{accessory.Functionality};{accessory.Weight}";
                    } else if (clothing is TopWear topWear)
                    {
                        line += $";{topWear.Type};{topWear.Fit};{topWear.Neckline}";

                    } else if (clothing is BottomWear bottomWear)
                    {
                        line += $";{bottomWear.Type};{bottomWear.Material};{bottomWear.Length}";
                    }

                    writer.WriteLine(line);
                }

                writer.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Sikertelen kiírás! Error message: {e.Message}");
                return false;
            }

        }

        public static List<Clothing> Read(string fileName, bool header)
        {
            List<Clothing> list = new List<Clothing>();
            try
            {
                StreamReader reader = new StreamReader(fileName);

                if (header)
                {
                    reader.ReadLine();
                }

                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(';');

                    switch (line[0])
                    {
                        case "Accessory":
                            list.Add(new Accessory(line[1], line[2], line[3], Convert.ToInt32(line[4]), line[5], line[6], Convert.ToInt32(line[7])));
                            break;
                        case "TopWear":
                            /*list.Add(new TopWear(line[1], line[2], line[3], Convert.ToInt32(line[4]), line[5], line[6], line[7]));
                            */break;
                        case "BottomWear":
                            list.Add(new BottomWear(line[1], line[2], line[3], Convert.ToInt32(line[4]), line[5], Convert.ToInt32(line[6]), line[7]));
                            break;
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Sikertelen beolvasás! Error message: {e.Message}");
            }
            
            return list;
        }
    }
}
