/*
 * Course: CSCI-473   Assignment :2    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 01/28/2021
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ErindSimeonAssignment2
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string slacker;
            string[] tokens;
            try
            {
                using (StreamReader inFile = new StreamReader("..//..//..//players.txt"))
                {
                    slacker = inFile.ReadLine();

                    while (slacker != null)
                    {
                        tokens = slacker.Split('\t');
                        globals.player.Add(Convert.ToUInt32(tokens[0]), new Player(Convert.ToUInt32(tokens[0]), tokens[1], (Race)Convert.ToUInt32(tokens[2]), Convert.ToUInt32(tokens[5]),
                            Convert.ToUInt32(tokens[4]), (ClassType)Convert.ToUInt32(tokens[3]), Convert.ToUInt32(tokens[6]), ""));
                        slacker = inFile.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            /*
           * try to read the files guilds.txt, if it cant catch the exceptions
           * split each line into tokens and then populate the dictionary map
           */
            string ReadGuild;
            string[] tokens1;
            string[] tokens2;
            try
            {
                using (StreamReader inFile1 = new StreamReader("..//..//..//guilds.txt"))
                {
                    ReadGuild = inFile1.ReadLine();
                    while (ReadGuild != null)
                    {
                        tokens1 = ReadGuild.Split('\t');
                        tokens2 = tokens1[1].Split('-');
                        globals.map.Add(Convert.ToUInt32(tokens1[0]), new Guilds(Convert.ToUInt32(tokens1[0]),tokens2[0],tokens2[1],""));
                        ReadGuild = inFile1.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Application.Run(new Form1());
        }
    }
}
