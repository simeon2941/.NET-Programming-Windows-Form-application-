
/*
 * Course: CSCI-473   Assignment :2    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 01/28/2021
 * 
 * Description:
 * This file contains the globals class. It diclares 2 dictionaries
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ErindSimeonAssignment2
{
    public static class globals
    {
        public static Dictionary<uint, Guilds> map = new Dictionary<uint, Guilds>();   // Declaration for the guilds dictionary
        public static Dictionary<uint, Player> player = new Dictionary<uint, Player>();  //Declaration for the players dictionary
    }
}