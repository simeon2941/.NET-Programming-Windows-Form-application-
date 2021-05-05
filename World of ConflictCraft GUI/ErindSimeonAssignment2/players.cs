/*
 * Course: CSCI-473   Assignment :2    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 02/11/2021
 * 
 * Description:
 * This file contains the player class. With all getters and setters for 
 * the private data types. It implements the iComperable interface to sort
 * by name. 
 * Overloads ToString() to print the output nicely
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ErindSimeonAssignment2
{
    /*
     * enum Race Type which hold the races for the players
     */
    public enum Race { Orc, Troll, Tauren, Forsaken };
    /*
 * enum ItemType which holds ClassType Items
 */

    public enum ClassType
    {
        Warrior,    Mage,   Druid,  Priest,
        Warlock,    Rogue,  Paladin,    Hunter, Shaman
    }
    public class Player : IComparable
    {
        //global variables 
        private static uint MAX_LEVEL = 60;
        //private attributes
        private readonly uint id;
        private readonly string name;
        private readonly Race race;
        private uint exp;
        private uint level;
        private readonly ClassType classType;
        private uint guildID;
        private readonly string playerRole;
        /*
         * Constructor Player
         * Default constructor for Player
         * parameters none
         */
        public Player()
        {
            id = 0;
            name = "";
            race = 0;
            level = 0;
            exp = 0;
            guildID = 0;
            classType = 0;
            playerRole = "";
        }
        /* constructor that takes a number of arguments
         * params: an array of arguments
         */

        public Player(string[] args)
        {
            id = Convert.ToUInt32(args[0]);
            name = args[1];
            race = (Race)Convert.ToUInt32(args[2]);
            classType = (ClassType)Convert.ToUInt32(args[3]);
            level = Convert.ToUInt32(args[4]);
            exp = Convert.ToUInt32(args[5]);
            guildID = Convert.ToUInt32(args[6]);
        }
        /*
         * Alternative constructor
         * params: uint id, string name, Race race, uint level, uint exp, classType,uint guildID,
         */

        public Player(uint id, string name, Race race, uint exp, uint level, ClassType classType, uint guildID,string playerrole)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.exp = exp;
            this.level = level;
            this.classType = classType;
            this.guildID = guildID;
            this.playerRole = playerrole;

        }
        // id has only read access
        public uint Id
        {
            get { return id; }
        }
        // name -- only R access
        public string Name
        {
            get { return name; }
        }
        // race -- only R access
        public Race Race
        {
            get { return race; }
        }
        // ClassType containing only read access
        public ClassType ClassType
        {
            get { return classType; }
        }

        //level -- free R/W access, range is [0, MAX_LEVEL].
        public uint Level
        {
            get { return level; }
            set
            {
                // if the value is less than 0 or bigger then max_level reutrn
                if (value < 0 || value > MAX_LEVEL)
                {
                    return;
                }
                Console.WriteLine("Ding!");
                level = value;

            }
        }
        //exp -- normal R access, but the W access should instead increment the value of exp by... value. 
        //If this should make the exp value exceed the required experience for this player to increase their level (but not exceed MAX_LEVEL), it should do as such.
        public uint Exp
        {
            get { return exp; }
            set
            {
                exp += value;
                //loop to increment the level based on the entered exp value
                while (exp > (1000 * Level))
                {
                    Level++;
                    if (exp < (1000 * Level))
                    {
                        break;
                    }
                    exp = exp - ((1000 * Level));
                }
            }
        }

        // guildID -- free R/W access
        public uint GuildID
        {
            get { return guildID; }
            set { guildID = value; }
        }
        // playerRole has only READ ACCESS
        public string PlayerRole
        {
            get { return playerRole; }
        }
        /*
        * Function : CompareTo sorts by name
        * Comares player object by name
        * it return -1 , 0 or 1 based on the result of condition (-1 if its< . 0 if == and 1 if
        * params: object alpha
        * return -1 || 0 || -1
        * 
        */

        public int CompareTo(object alpha)
        {
            if (alpha == null) 
                throw new ArgumentNullException();

            Player rightOp = alpha as Player;

            if (rightOp != null)
            {
                if (name.CompareTo(rightOp.name) == 0)
                {
                    return level.CompareTo(rightOp.level);
                }
                else
                    return name.CompareTo(rightOp.name);
            }
            else
                throw new ArgumentException();
        }

        /*
         * Function: TOString, overrride  It prints Name: Race: Level: Guild
         * ex: Name: Scobomb           Race: Tauren            Level: 60           Guild: Death and Taxes  ServerName
         * Formats the output
         * Parametrs: none
         * return: the formated string
         */

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(String.Format("Name: {0,-20}\tRace: {1,-20}\tLevel: {2,-20}\tGuild: {3,-20} - {4,-20}", Name, Race, Level, globals.map[GuildID].Name, globals.map[GuildID].Server));
            return result.ToString();
        }
    }
}