using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба4
{
    public class Task
    {
        public void Task6()
        {
            int counter = 0;
            string line;
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '-', '/' };
            StringBuilder otvet = new StringBuilder();

            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(separator);

                    foreach (string slovo in words)
                    {
                        if (slovo.Length >= 3)
                        {
                            for (int i = 0; i < slovo.Length; i++)
                            {
                                if (slovo[i] == 'o' && slovo[i + 1] == 'n' && slovo[i + 2] == 'e')
                                {
                                    counter++;
                                    otvet.Append(slovo);
                                    otvet.Append(" ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("There were {0} sequences.", counter);
            Console.WriteLine(otvet.ToString());
            Console.ReadLine();
        }
    }
}
