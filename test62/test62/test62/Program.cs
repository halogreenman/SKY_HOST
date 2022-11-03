using System.Diagnostics;
using System.Net.NetworkInformation;

public class LinuxTest
{

    static void Main(string[] args)
    {
        Random bootup = new Random();

        string dir = "Home";
        string dir1 = "Desktop";
        string dir2 = "FileManager";
        string dir3 = "Config";
        string dir4 = "Bin";
        bool PwdTF = false;
        bool logout = false;
        string Entry = "1234";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Initiating SKY OS...");
        Thread.Sleep(bootup.Next(1000, 2000));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Initiation complete!");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Enter pin.\nHint: its 4 digits long");
        while (PwdTF == false)
        {
            try
            {
                string Pwd = Console.ReadLine();
                if (Pwd == Entry)
                {
                    PwdTF = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Access Granted");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Logged in as Root");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("type Help or ? for command list");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Access Denied\nIts not that hard.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            catch
            {

            }

        }
        while (logout == false)
        {
            Random RNG = new Random();
            Random random = new Random();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string input = Console.ReadLine().ToLower();
            if (input == "logout" || input == "exit")
            {
                logout = true;
                Console.WriteLine("logging out");
            }
            else if (input == "cd desktop")
            {
                dir = dir1;
                Console.WriteLine("Changing to Directory " + dir);
            }
            else if (input == "cd filemanager")
            {
                dir = dir2;
                Console.WriteLine("Changing to Directory " + dir);
            }
            else if (input == "cd config")
            {
                dir = dir3;
                Console.WriteLine("Changing to Directory " + dir);
            }
            else if (input == "cd bin")
            {
                dir = dir4;
                Console.WriteLine("Changing to Directory " + dir);
            }
            else if (input == "cd ..")
            {
                Console.WriteLine("Changing to Directory Home");
                dir = "Home";
            }
            else if (input == "cd list" || input == "cd ls")
            {
                Console.WriteLine("Home" + "\n" + dir1 + "\n" + dir2 + "\n" + dir3 + "\n" + dir4);
            }
            else if (input == "clear")
            {
                Console.Clear();
            }
            else if (input == "help" || input == "?")
            {
                Console.WriteLine("Commands\nCd         changes Directory\nDir          displays current Directory\nHelp            shows this menu\nLs             displays contents of current Directory\nClear           clears screen\nCat [filename]              displays contents of .txt files\nlogout             logs out\nCd list           lists all directories\nDisplay         displays contents of a .png file\nBrowse          Opens local browser file\nBrowse -r         opens local browser in root mode\nRng       generates random number from 1-100\nNetStat     Shows all available hosts\nPing[HostName]       pings specified host");

            }
            else if (input == "dir")
            {
                Console.WriteLine(dir);
            }
            else if (input == "cat note")
            {
                if (dir == dir1 || dir == dir2)
                {
                    Console.WriteLine("remember to make a better password");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("file not found");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
            }
            else if (input == "display secret")
            {
                if (dir == dir1 || dir == dir2)
                {
                    Console.WriteLine("     ......          .,,,,***/////////************,,,,,,,.../****,,,,.....      \r\n         ...........,,,,**//(((((((((((////////////****,,,,,*((////**,,,...     \r\n         ..........,***/////(((((((((((((///////////***,,,,,,#((////**,,,...    \r\n        ..... .....***//////(((((((((((((((//(//(////**,,,,,*%((((///**,,,..    \r\n        ..      ...****///**,,,,,,**//(((((//(//(////**,,,,,*%#(((////**,,,.    \r\n        .        .,***/***///((//(*,,,,,***/((*,(**,,,.,,,,,,##((((///***,,.    \r\n                 ,*******/(((/*,....,,**//((((/,....,,,,***,**##((((////**,,    \r\n      ..        .,****/////////*******/(//((((/*...,***,,,,,,,###((((///***,    \r\n               ..,***/////((((((((((///(((((((/**...,****,,,,,####((((///***    \r\n              ...,,**////((((((((((/(((((((((((/*....,,,***,,*####((((///**,    \r\n              ...,,**////(((((((((((((((((((((((/,....,,,**,,,####(((///**,,    \r\n             ....,,,**/////(((((((((((((((((((((/*,...,,,,,,,##((((///**,,..    \r\n          ... ,,,,,,**//////((((((((((((((/((((((//....,,,,,,(((///**,,...      \r\n               ,,,,,**///////(((((((((((/////////*....,,,,,,******,,...         \r\n                .,,,***//////(((((((((((///((*,//,..,..,,,.*,,,.....            \r\n                .,,,,**///////(//////////////**//*,,,....,,*...                 \r\n                *..,,,**///////////////((((((///**,,.....,,                     \r\n                ,,..,,,***////(/////////((((///***,.....,,.                     ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("file not found");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
            }
            else if (input == "ls")
            {
                if (dir == dir1)
                {
                    Console.WriteLine("Note         .txt file           5 GB\nConsole         .exe file            127 MB\nSecret         .png file           32 GB\nBrowser        .exe file           537000 GB");
                }
                else if (dir == dir2)
                {
                    Console.WriteLine("Note         .txt file           5 GB\nConsole         .exe file            127 MB\r\nSecret         .png file           32 GB");
                }
                else if (dir == dir3)
                {
                    Console.WriteLine("Xorg             .sys file           1 GB\nSystem32          .sys file           1 GB\nLog           .Bin file           1 MB\nRouter_Config         .Conf file          1 GB\n Linux        .OS file            1 GB\nMetaXploit            .so file        1 GB");
                }
                else if (dir == dir4)
                {
                    Console.WriteLine("Help         .EXE file       1 MB\nLogout        .EXE file       1MB\nCat            .EXE file           1MB\nCd         .EXE file       1 MB\ndir           .EXE            1 MB\nLs            .EXE file           1 MB\nClear         .EXE file           1 MB\nDisplay           .EXE file           1 MB\nBrowse        .EXE file           1 MB\nBrowse -r         .EXE file       1 MB\nRng           .EXE file           1 MB\nNetStat           .EXE file           1 MB\nPing          .EXE file           1 MB");
                }

                else if (dir == dir1)
                {

                }

            }
            else if (input == "browse -r")
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&cad=rja&uact=8&ved=2ahUKEwidkYLE4_H6AhWxBDQIHeb9ALsQwqsBegQICxAB&url=https%3A%2F%2Fwww.youtube.com%2Fwatch%3Fv%3DxvFZjo5PgG0&usg=AOvVaw1bR_FN-SnfIGtKD3fjAA5P",
                    UseShellExecute = true
                });
            }
            else if (input == "browse")
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.google.com",
                    UseShellExecute = true
                });
            }
            else if (input == "rng")
            {
                Console.WriteLine(RNG.Next(1, 101));
            }
            else if (input == "netstat")
            {
                Console.WriteLine("Sky Host ]> You\nStar Host\nn0v4 Host\nSun Host\nEris Host\nJuno Host\nSony Host\nSolar Host\nEONS Host\nLuna Host\nCyph3r Host\n");
            }
            else if (input == "ping sky")
            {
                Console.WriteLine("The ping responds successfully.\n You receive a ping from Sky host");
            }
            else if (input == "ping nova" || input == "ping n0v4")
            {
                Console.WriteLine("The ping returns with the message:\nWelcome to the n0v4 Bulletin Boards! Feel free to log in and browse the archives!");
            }
            else if (input == "ping star")
            {
                Console.WriteLine("the ping returns with the message:\nKernal: Fatal exception");
            }
            else if (input == "ping sun")
            {
                Console.WriteLine("the ping returns with the message:\nThis OS is currently HSFLOP(03)00:C18354AE months deprecated as of March 2010. Please reach out to your local Oracle Sales Representative.");
            }
            else if (input == "ping eris")
            {
                Console.WriteLine("The ping responds successfully.");
            }
            else if (input == "ping juno")
            {
                Console.WriteLine("the ping returns with the message:\n SSH Guest password: mamba");
            }
            else if (input == "ping sony")
            {
                Console.WriteLine("The ping returns with a successful message.");
            }
            else if (input == "ping solar")
            {
                Console.WriteLine("Away Message: In the bbs, seeking help.");
            }
            else if (input == "ping eons")
            {
                Console.WriteLine("You receive a response 10 milliseconds before your ping is sent, the logic here is distorted.");
            }
            else if (input == "ping luna")
            {
                Console.WriteLine("The ping returns with a successful message.");
            }
            else if (input == "ping sky")
            {
                Console.WriteLine("the ping responds successfully.");
            }
            else if (input == "ping cypher" || input == "ping cyph3r")
            {
                Console.WriteLine("the ping returns with the message:\nDo not disturb");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Unrecognized command, command may be misspelled or does not exist");
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        }
    }
}