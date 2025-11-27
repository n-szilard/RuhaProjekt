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
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public static List<Clothing> Read(string fileName, bool header)
        {
            try
            {
                StreamReader reader = new StreamReader(fileName);
                List<Clothing> list = new List<Clothing>();

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
                            /*list.Add(new Clothing(line[1]));*/
                            break;
                        case "TopWear":
                            break;
                        case "BottomWear":
                            break;
                    }


                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
