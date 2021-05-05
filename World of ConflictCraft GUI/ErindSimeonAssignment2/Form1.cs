/*
 * Course: CSCI-473   Assignment :2    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 02/11/2021
 * 
 * Description:
 * This file contains the code for the main window that implements the form.
 * It contains 2 list box. The player list box contains players name, classType and Level,
 * and the Guid Listbox contains guild name and server name. It contains a set of functions 
 * which called Management Functions which can print guild roster, disband guild,join guild,
 * leave guild and ssearch by player name and by server name.
 * Also it contain the option to create a new player and creating new guild.
 * At the end of the forms it contains a rich text box which will be helpful for giving feedback.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErindSimeonAssignment2
{
    public partial class Form1 : Form
    {
        /*
         * Constructor: Form1
         * It constructs a new Dirived form object
         * parameters none
         * returns none
         */
        public Form1()
        {
            InitializeComponent();
            populatePlayerListBox(); // calls the populatePlayerLisBox to populate the players lsit box
            populateGuildListBox(); // calls the populateGuildListBox to populate the guilds list box
            //adds the Race to the comboBox
            comboBoxRace.Items.Add("Orc");
            comboBoxRace.Items.Add("Troll");
            comboBoxRace.Items.Add("Tauren");
            comboBoxRace.Items.Add("Forseken");
            //for loop that iterates through ClassType items and adds them to comboBoxClassType
            foreach (ClassType val in Enum.GetValues(typeof(ClassType)))
            {
                comboBoxClassType.Items.Add(val);
            }
            //adds this server names into the servername combo box
            comboBoxServerNames.Items.Add("Beta4Azeroth");
            comboBoxServerNames.Items.Add("TKWasASetback");
            comboBoxServerNames.Items.Add("ZappyBoi");
            //adds these guild guild types into the guilds type combobox
            comboBoxGuildType.Items.Add("Causal");
            comboBoxGuildType.Items.Add("Questing");
            comboBoxGuildType.Items.Add("Mythic+");
            comboBoxGuildType.Items.Add("Raiding");
            comboBoxGuildType.Items.Add("PVP");
        }
        /*
         * populatePlayerListBox() 
         * this function iterates through the players dictionary and populates the player listbox
         * with players name, class type and level
         * params: none
         * return: none
         */
        private void populatePlayerListBox()
        {
            //foreach loop to iterate through the players dictionary and adds the players into the playerListBox
            foreach (KeyValuePair<uint, Player> p in globals.player.OrderBy(key => key.Value.Name))
            {
                playerListBox.Items.Add(p.Value.Name.PadRight(20) + "\t" + p.Value.ClassType + "\t\t" + p.Value.Level);
            }
        }
        /*
         * populateGuildListBox()
         * this functions iterates through the guilds dictionary and populates the guilds list box
         * with guild name and guilds  server name
         * params: none
         * return:non
         */
        private void populateGuildListBox()
        {
            //foreach loop that iterates through the guilds dictionary and populates the guildListBox by calling ToString()
            foreach (KeyValuePair<uint, Guilds> g in globals.map.OrderBy(key => key.Value.Name))
            {
                //checks if the key is not 0
                if (g.Key != 0)
                {
                    guildsListBox.Items.Add(g.Value.ToString());
                }
            }
        }
        /*
         * PrintGuildRoster_Click(object sender, EventArgs e)
         * prints all players that a guild has
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void PrintGuildRoster_Click(object sender, EventArgs e)
        {
            var sele = guildsListBox.SelectedItem; //variable that holds the selected item on the guildsListBox
            outputText.Clear(); // clear the outputext
            //check if they have selected a guild
            if (guildsListBox.SelectedIndex != -1)
            {
                //for each loop that iterates through the guilds dictionary
                foreach (KeyValuePair<uint, Guilds> g in globals.map)
                {
                    //checks to see if the selected item is on the dictionary
                    if (Convert.ToString(sele).Contains(g.Value.Name) && Convert.ToString(sele).Contains(g.Value.Server))
                    {
                        outputText.Text += "Guild Listening for " + g.Value.Name + "\t\t" + g.Value.Server + "\n";
                        outputText.Text += "-----------------------------------------------------------------------------------------------------------------------------------------\n";
                        //foreach loop that iterates through player dictionary 
                        foreach (KeyValuePair<uint, Player> p in globals.player.OrderBy(key => key.Value.Name))
                        {
                            // if the guild id at Players dictionary is equal to the key on guilds dictionary then print it out ont the outputtext
                            if (p.Value.GuildID == g.Key)
                            {
                                outputText.Text += "|" + p.Value.ToString() + "|" + "\n";
                            }
                        }
                        outputText.Text += "-----------------------------------------------------------------------------------------------------------------------------------------\n";
                    }
                }
            }
        }
        /* 
         * playerListBox_SelectedIndexChanged(object sender, EventArgs e)
         * Prints info about the select player or the select guild
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = playerListBox.SelectedItem; //variable to hold the selected player in the playerListBox
            outputText.Clear(); // clear the outputText box
            //foreach loop tha iterates through the player dictionary
            foreach (KeyValuePair<uint, Player> p in globals.player.OrderBy(key => key.Value.Name))
            {   //check to see if the guildId is not 0
                if(p.Value.GuildID != 0)
                {   //if the guildId is not - and the selected item contains the players Name then print it on the outputText
                    if (Convert.ToString(sel).Contains(p.Value.Name))
                    {
                        outputText.Text += p.Value.ToString() + "\n";
                    }
                //if the guild ID is 0 and the selected item contains the player name then print it in the outputText
                }else if(p.Value.GuildID == 0 && Convert.ToString(sel).Contains(p.Value.Name))
                {
                    outputText.Text += "Name: " + p.Value.Name + "\t\tRace: " + p.Value.Race + "\t\tLevel: " + p.Value.Level + "\n";
                }    
            }
        }
        /* disbandGuildButton(object sender, EventArgs e)
         * this function removes the guild from the list box containing  the list of guilds
         * that itereates throug hte playerbase and sets the guildID property of those playesr who 
         * previously were part of the guild
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void disbandGuildButton(object sender, EventArgs e)
        {
            var sele = guildsListBox.SelectedItem;  //variable that holds the selectedItem  on guildsListBox
            int count = 0; // variable that holds the number of players in a guild 
            outputText.Clear(); //
            //check if the user has selected a guild from the guildsListBox
            if (guildsListBox.SelectedIndex != -1)
            {   //foreach loop that iterates through that guilds dictionary
                foreach (KeyValuePair<uint, Guilds> g in globals.map)
                {
                    // check if the selected Guild is on the dictionary
                    if (Convert.ToString(sele).Contains(g.Value.Name) && Convert.ToString(sele).Contains(g.Value.Server))
                    {   //forloop that iterates through the player dictionary 
                        foreach (KeyValuePair<uint, Player> p in globals.player.OrderBy(key => key.Value.Name))
                        {
                            // if the guildID is equal to the guilds dictionary key then set the guildID to 0 and increment count
                            if (p.Value.GuildID == g.Key)
                            {
                                p.Value.GuildID = 0;
                                count++;
                            }
                        }
                        globals.map.Remove(g.Key); // remove the guild from the dictionary
                        guildsListBox.Items.Remove(sele); // remove it from the listbox
                        outputText.Text += count + " player have been disbanded from" + g.Value.Name + "\t" + g.Value.Server + "\n";
                    }
                }
            }
            //if nothing is selected and the button is clicked show this appropriate message
            else
            {
                outputText.Text += "Please select the Guild that you want to disband!\n";
            }

        }
        /* joinGuildButton(object sender, EventArgs e)
         * this funcction first check if the user has selected a player and a guild, if not it displays a message,
         * if the user has selected a player and a guild, it iterates through the players dictionary and then it iterates through 
         * guilds dictionary and changes the players guildId to match the one of the guild that they will join.
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void joinGuildButton(object sender, EventArgs e)
        {
            var selectedGuild = guildsListBox.SelectedItem; // variable that  holds the selected guilds from guildsListBox
            var selectedPlayer = playerListBox.SelectedItem; // variable that holds the player selected from playersListBox
            outputText.Clear(); // clear the outputText
            //check to see if the user has selected a player and a guild
            if (playerListBox.SelectedIndex != -1 && guildsListBox.SelectedIndex != -1)
            {   //loop that iterates through the players dictionary
                foreach (KeyValuePair<uint, Player> p in globals.player.OrderBy(key => key.Value.Name))
                {   //check to see if the selected player is on the dictionary
                    if (Convert.ToString(selectedPlayer).Contains(p.Value.Name))
                    {   //iterate through the guilds dictionary
                        foreach (KeyValuePair<uint, Guilds> g in globals.map)
                        {
                            //check to see if the selected guild is on the guild dictionary if so guildId will be set to the guilds key    
                            if (Convert.ToString(selectedGuild).Contains(g.Value.Name) && Convert.ToString(selectedGuild).Contains(g.Value.Server))
                            {
                                p.Value.GuildID = g.Key;
                                outputText.Text += p.Value.Name + " player have joined " + g.Value.Name + "-" + g.Value.Server + "\n";
                            }
                        }
                    }
                }
            }
            //if not show this message
            else
            {
                outputText.Text += "Please select a player and a guild in order for this function to work!\n";
            }
        }
        /*
         * leaveGuildButton1(object sender, EventArgs e)
         * this functions first checks if the user has selected both the guild and the player, than it check if that guild
         * contains that player.. if so it it iterates through the player database and through the guilds databases and if there
         * is a match it changes the guildID of the player to 0 so the player can leave the guild.
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void leaveGuildButton1(object sender, EventArgs e)
        {
            var selectedGuild = guildsListBox.SelectedItem; // variable that holds the selected guild from guildsListBox
            var selectedPlayer = playerListBox.SelectedItem; // variable that holds the selected player from playerListBox
            outputText.Clear();
            // check to see if user has selected the player and guilds are selected
            if (guildsListBox.SelectedIndex != -1 && playerListBox.SelectedIndex != -1)
            {   // loop through the players database
                foreach (KeyValuePair<uint, Player> p in globals.player.OrderBy(key => key.Value.Race))
                {
                    //checks to see if selected player is on the dictionary    
                    if (Convert.ToString(selectedPlayer).Contains(p.Value.Name))
                    {   //foreach that iterates through the guilds Dictionary
                        foreach (KeyValuePair<uint, Guilds> g in globals.map)
                        {   //checks to see if the selected guils is on the dictionary
                            if (Convert.ToString(selectedGuild).Contains(g.Value.Name) && Convert.ToString(selectedGuild).Contains(g.Value.Server))
                            {
                                //if the key of guilds dictionary is equal to the guildId then set the GuildId to 0
                                if (g.Key == p.Value.GuildID)
                                {
                                    p.Value.GuildID = 0;
                                    outputText.Text += p.Value.Name + " player has left " + g.Value.Name + "-" + g.Value.Server + "\n";
                                }
                                // else print out that the dictionar ydoesnt contain that player
                                else
                                {
                                    outputText.Text += g.Value.Name + " doesnt contain " + p.Value.Name + "\n";
                                }
                            }
                        }
                    }
                }
            }
            //if not and the leaveguildButton is clicked show this message
            else
            {
                outputText.Text += "Please select a player and a guild in order for this function to work!\n";
            }
        }
        /* applySearchButton_(object sender, EventArgs e)
         * this function first check if the entered name in the name box and server box is on the respective dictionaries
         * if not it displays a message that those names arent in the list.. if they are it iterates throug hthe respective dictionaries
         * and shows on the list box only the names that start with whatever the user inputed in the search box.
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void applySearchButton_(object sender, EventArgs e)
        {
            string player = searchPlayerName.Text; //variable that holds the input at SearchPlayerName
            string guild = searchGuildByServer.Text; // variable that holds the input at searchGuildByServer
            playerListBox.Items.Clear();
            guildsListBox.Items.Clear();
            //check ot see if the entered player name is on the players dictionary
            if (! globals.player.Any(x => x.Value.Name.ToLower().StartsWith(player.ToLower())))
            {
                outputText.Text += "Player list doesnt contain " + player + "\n";
            } 
            //else it contains the entered player
            else
            {   //iterate through the player dictionary
                foreach (KeyValuePair<uint, Player> p in globals.player.OrderBy(key => key.Value.Name))
                {   //if the name on players Dictionary starts with the entered word, show those words
                    if (p.Value.Name.ToUpper().StartsWith(searchPlayerName.Text.ToUpper()))
                    {
                        playerListBox.Items.Add(p.Value.Name.PadRight(20) + "\t" + p.Value.ClassType + "\t\t" + p.Value.Level);
                    }
                }
            }
            // check to see if the entered guild name is on the guilds dictionary
            if (!globals.map.Any(y => y.Value.Server.ToLower().StartsWith(guild.ToLower())))
            {
                outputText.Text += "Guild list doesnt contain " + guild + " server name!"+ "\n";
            }
            // else it means that the entered guilds is on the dictionary
            else
            {
                //iterate throug hte guilds dictionary
                foreach (KeyValuePair<uint, Guilds> g in globals.map.OrderBy(key => key.Value.Name))
                {   //if the servers name starts with the entered name in the searchGuildByServer then show only those values
                    if (g.Value.Server.ToUpper().StartsWith(searchGuildByServer.Text.ToUpper()))
                    {
                        guildsListBox.Items.Add(g.Value.ToString());
                    }
                }
            }
        }
        /* comboBoxClassTypeSelect(object sender, EventArgs e)
         * this function check the classType and base on the selected class type it shows 
         * different roles to pick.. for some classType that have only 1 role it automatically selects that role.
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void comboBoxClassTypeSelect(object sender, EventArgs e)
        {
            int x = comboBoxClassType.SelectedIndex; // variable that holds the index of the selected item
               if ( x == 0) // if the index is 0 show Tank and Dps on the comboBoxRole
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Tank");
                comboBoxRole.Items.Add("Dps");
            } else if (x == 1)// if the index is 1 show Dps on the combobox Role
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Text = "Dps";
            } else if (x == 2) // if the index is 2 show Tank Healer Dps on the combobox Role
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Tank");
                comboBoxRole.Items.Add("Healer");
                comboBoxRole.Items.Add("Dps");
            } else if (x == 3) // if the index is3  show Healder and Dps on the comboboxRole
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Healer");
                comboBoxRole.Items.Add("Dps");
            } else if (x == 4) // if the index is 4 show Dps on the comboBoxRole
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Text = "Dps";
            } else if (x == 5) // if the index is 5 show Dps on the comboBoxrOLE
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Text = "Dps";
            } else if (x == 6) // if the index is 6 show Tank Healer and Dps on the comboBoxRole
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Tank");
                comboBoxRole.Items.Add("Healer");
                comboBoxRole.Items.Add("Dps");
            } else if (x == 7) // if the index is 7 show Dps on the comboBoxRole
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Text = "Dps";
            } else if (x == 8) // if the index is 8 show Healer and Dps on the comboBox
            {
                comboBoxRole.Items.Clear();
                comboBoxRole.Items.Add("Healer");
                comboBoxRole.Items.Add("Dps");
            }
        }
        /*
         * addNewPlayer(object sender, EventArgs e)
         * this function first checks if the user has entered all the values before clicking the add player button
         * if so, it checks if the generated unique id is part of players ID, if not it adds the nw player in the dictionary
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return none
         */
        private void addNewPlayer(object sender, EventArgs e)
        {
            string playerName = playername.Text; // variable to hold Playername
            var raceType = comboBoxRace.SelectedIndex; // variable to hold comboBoxRace
            var classType = comboBoxClassType.SelectedIndex; // variable to hold the index of classType
            var roleSelected = comboBoxRole.SelectedItem; // variable to hold the selected item on comboboxrole
            int x = Convert.ToInt32(comboBoxClassType.SelectedIndex); //variable to hold the index of comboBoxClassType
            Random rnd = new Random();
            int myRandomNo = rnd.Next(10000000, 99999999); // create a unique  8 digits number
            //check to see if the playername is not emtpy , if comboBoxRace is  selected and comboBoxClassType is  selected
            if(playerName != "" && comboBoxRace.SelectedIndex != -1 && comboBoxClassType.SelectedIndex != -1  )
            {   //if the Players dictionary contains the new key, then create a new key and aadd the new player
                if (globals.player.ContainsKey(Convert.ToUInt32(myRandomNo)))
                {
                    myRandomNo = rnd.Next(10000000, 99999999);
                    globals.player.Add(Convert.ToUInt32(myRandomNo), new Player(Convert.ToUInt32(myRandomNo), playerName, (Race)raceType, 0, 0, (ClassType)x, 0, ""));
                } // else add the player on the dictionary
                else
                {
                    globals.player.Add(Convert.ToUInt32(myRandomNo), new Player(Convert.ToUInt32(myRandomNo), playerName, (Race)raceType, 0, 0, (ClassType)x, 0,""));
                }
            }
            //else show an appropriate message 
            else
            {
                outputText.Text += "In order to add a player you need to pick a player name, a Race, a Class and a Role in order for this function to work!" + "\n";
            }

            playerListBox.Items.Clear(); //clear PlayerListBox
            playername.Clear(); //clear entered playername
            comboBoxRace.ResetText(); // clear the comboBoxRace
            comboBoxClassType.ResetText(); // clear the comboBoxClassType
            comboBoxRole.ResetText(); // clear the comboBoxRole
            populatePlayerListBox(); // populate the playerListBox
        }
        /* addNewGuild2(object sender, EventArgs e)
        * the function of this function is very similar to the one of add player, first we check to see if players had selected all the input filed,
        * if not we show a message.. then we check if the guild dictionary contain the key .. if not we then add to the new guild in the dictionary.
        * params: Sender: Reference to the object that called this function,
        *         EventArgs: The arguments passed from the calling object
        * return none
        */
        private void addNewGuild2(object sender, EventArgs e)
        {
            string guilNme = guildName.Text; //variable to hold guildname
            var serverIndex = comboBoxServerNames.SelectedItem; // variable to hold the server selected item
            var guildTypeIndex = comboBoxGuildType.SelectedIndex; // variable to hold selected guildType
            Random rnd = new Random();
            int myRandomNo = rnd.Next(100000, 999999); // create a unique   digits number
            //checks to see if the guildname is not empty and selectedIndex on the comboBoxServer name is selected and comboBoxGuildType is selected
            if (guilNme != "" && comboBoxServerNames.SelectedIndex != -1 && comboBoxGuildType.SelectedIndex != -1)
            {
                //check to see if the guilds dictionary contains the new create key, if so create a new one
                if (globals.map.ContainsKey(Convert.ToUInt32(myRandomNo)))
                {
                    myRandomNo = rnd.Next(100000, 999999);
                    globals.map.Add(Convert.ToUInt32(myRandomNo), new Guilds(Convert.ToUInt32(myRandomNo), guilNme, serverIndex as string, comboBoxGuildType.SelectedItem as string));
                }
                else // if its not on the dictionary then add the new guild
                {
                    globals.map.Add(Convert.ToUInt32(myRandomNo), new Guilds(Convert.ToUInt32(myRandomNo), guilNme,serverIndex as string , comboBoxGuildType.SelectedItem as string));
                }
            }
            //if they are not selected before clicking the button then print this appropriate message
            else
            {
                outputText.Text += "In order to add a guild you need to pick a guild name, a serverand a Type in order for this function to work!" + "\n";
            }

            guildsListBox.Items.Clear(); // clear the guilds ListBox
            comboBoxServerNames.ResetText(); // clear the comboBoxServerNames
            comboBoxGuildType.ResetText(); // clear the comboBoxGuildType 
            populateGuildListBox(); //populate the guildLisTbOX
            guildName.Clear(); // clear the guildName
        }
        /*
        *  deselectPlayersAndGuild(object sender, EventArgs e)
        *  this function deselect the player and guild from player list and guild list and also clears out the output text box.
        * params: Sender: Reference to the object that called this function,
        * EventArgs: The arguments passed from the calling object
        * return none
        */
        private void deselectPlayersAndGuild(object sender, EventArgs e)
        {
            outputText.Clear();
            playerListBox.SelectedIndex = -1; //deselect the playerListBox
            guildsListBox.SelectedIndex = -1; // deselect the guildsListBox
        }
    }
}
