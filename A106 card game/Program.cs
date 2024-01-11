using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace A106_card_game
{
    internal class Program
    {
        static string[] Hearts = { " ____ \r\n|A   |\r\n|(\\/)|\r\n| \\/ |\r\n|   A|\r\n`----` ", " ____ \r\n|2   |\r\n|(\\/)|\r\n| \\/ |\r\n|   2|\r\n`----` ", " ____ \r\n|3   |\r\n|(\\/)|\r\n| \\/ |\r\n|   3|\r\n`----` ", " ____ \r\n|4   |\r\n|(\\/)|\r\n| \\/ |\r\n|   4|\r\n`----` ", " ____ \r\n|5   |\r\n|(\\/)|\r\n| \\/ |\r\n|   5|\r\n`----` ", " ____ \r\n|6   |\r\n|(\\/)|\r\n| \\/ |\r\n|   6|\r\n`----` ", " ____ \r\n|7   |\r\n|(\\/)|\r\n| \\/ |\r\n|   7|\r\n`----` ", " ____ \r\n|8   |\r\n|(\\/)|\r\n| \\/ |\r\n|   8|\r\n`----` ", " ____ \r\n|9   |\r\n|(\\/)|\r\n| \\/ |\r\n|   9|\r\n`----` ", " ____ \r\n|J   |\r\n|(\\/)|\r\n| \\/ |\r\n|   J|\r\n`----` ", " ____ \r\n|Q   |\r\n|(\\/)|\r\n| \\/ |\r\n|   Q|\r\n`----` ", " ____ \r\n|K   |\r\n|(\\/)|\r\n| \\/ |\r\n|   K|\r\n`----` " };
        static string[] Diamonds = { " ____ \r\n|A   |\r\n| /\\ |\r\n| \\/ |\r\n|   A|\r\n`----`", " ____ \r\n|2   |\r\n| /\\ |\r\n| \\/ |\r\n|   2|\r\n`----`", " ____ \r\n|3   |\r\n| /\\ |\r\n| \\/ |\r\n|   3|\r\n`----`", " ____ \r\n|4   |\r\n| /\\ |\r\n| \\/ |\r\n|   4|\r\n`----`", " ____ \r\n|5   |\r\n| /\\ |\r\n| \\/ |\r\n|   5|\r\n`----`", " ____ \r\n|6   |\r\n| /\\ |\r\n| \\/ |\r\n|   6|\r\n`----`", " ____ \r\n|7   |\r\n| /\\ |\r\n| \\/ |\r\n|   7|\r\n`----`", " ____ \r\n|8   |\r\n| /\\ |\r\n| \\/ |\r\n|   8|\r\n`----`", " ____ \r\n|9   |\r\n| /\\ |\r\n| \\/ |\r\n|   9|\r\n`----`", " ____ \r\n|J   |\r\n| /\\ |\r\n| \\/ |\r\n|   J|\r\n`----`", " ____ \r\n|Q   |\r\n| /\\ |\r\n| \\/ |\r\n|   Q|\r\n`----`", " ____ \r\n|K   |\r\n| /\\ |\r\n| \\/ |\r\n|   K|\r\n`----`"};
        static string[] Spades = { " ____ \r\n|A   |\r\n| /\\ |\r\n|(__)|\r\n| /\\A|\r\n`----'", " ____ \r\n|2   |\r\n| /\\ |\r\n|(__)|\r\n| /\\2|\r\n`----'", " ____ \r\n|3   |\r\n| /\\ |\r\n|(__)|\r\n| /\\3|\r\n`----'", " ____ \r\n|4   |\r\n| /\\ |\r\n|(__)|\r\n| /\\4|\r\n`----'", " ____ \r\n|5   |\r\n| /\\ |\r\n|(__)|\r\n| /\\5|\r\n`----'", " ____ \r\n|6   |\r\n| /\\ |\r\n|(__)|\r\n| /\\6|\r\n`----'", " ____ \r\n|7   |\r\n| /\\ |\r\n|(__)|\r\n| /\\7|\r\n`----'", " ____ \r\n|8   |\r\n| /\\ |\r\n|(__)|\r\n| /\\8|\r\n`----'", " ____ \r\n|9   |\r\n| /\\ |\r\n|(__)|\r\n| /\\9|\r\n`----'", " ____ \r\n|J   |\r\n| /\\ |\r\n|(__)|\r\n| /\\J|\r\n`----'", " ____ \r\n|Q   |\r\n| /\\ |\r\n|(__)|\r\n| /\\Q|\r\n`----'", " ____ \r\n|K   |\r\n| /\\ |\r\n|(__)|\r\n| /\\K|\r\n`----'"};
        static string[] Clubs = { " ____\r\n|A   |\r\n| &  |\r\n|&|& |\r\n| | A|\r\n`----'", " ____\r\n|2   |\r\n| &  |\r\n|&|& |\r\n| | 2|\r\n`----'", " ____\r\n|3   |\r\n| &  |\r\n|&|& |\r\n| | 3|\r\n`----'", " ____\r\n|4   |\r\n| &  |\r\n|&|& |\r\n| | 4|\r\n`----'", " ____\r\n|5   |\r\n| &  |\r\n|&|& |\r\n| | 5|\r\n`----'", " ____\r\n|6   |\r\n| &  |\r\n|&|& |\r\n| | 6|\r\n`----'", " ____\r\n|7   |\r\n| &  |\r\n|&|& |\r\n| | 7|\r\n`----'", " ____\r\n|8   |\r\n| &  |\r\n|&|& |\r\n| | 8|\r\n`----'", " ____\r\n|9   |\r\n| &  |\r\n|&|& |\r\n| | 9|\r\n`----'", " ____\r\n|J   |\r\n| &  |\r\n|&|& |\r\n| | J|\r\n`----'", " ____\r\n|Q   |\r\n| &  |\r\n|&|& |\r\n| | Q|\r\n`----'", " ____\r\n|K   |\r\n| &  |\r\n|&|& |\r\n| | K|\r\n`----'"};
        static string[] PlayerCards_disp = new string[2];
        static int[] PlayerCards = new int[2];
        static Random rnd = new Random();

        static void Display_Cards(string card)
        {
            Console.WriteLine(card);
        }

        static void rand_card(int num)
        {
            Console.WriteLine("your cards are:");
            for (int i = 0; i < num; i++)
            {
                int choice = rnd.Next(1, 5);
                switch (choice)
                {
                    case 1: Display_Cards(Hearts[rnd.Next(12)]); break;
                    case 2: Display_Cards(Diamonds[rnd.Next(12)]); break;
                    case 3: Display_Cards(Spades[rnd.Next(12)]); break;
                    case 4: Display_Cards(Clubs[rnd.Next(12)]); break;
                }
            }
        }

        static void Choose_card(int card)
        {
            Console.WriteLine("Would you like to keep it?");
            string answer = Console.ReadLine().ToUpper();
            if(answer == "YES")
            {
                Console.WriteLine("Which card will you replace?");
                int replace = int.Parse(Console.ReadLine());
                switch (card)
                {
                    case 0:
                        PlayerCards_disp[replace] = Hearts[card];
                        PlayerCards[replace] = card;
                        break;
                    case 1:

                        PlayerCards_disp[replace] = Diamonds[card];
                        PlayerCards[replace] = card + 13;
                        break;
                    case 2:

                        PlayerCards_disp[replace] = Spades[card];
                        PlayerCards[replace] = card + 26;
                        break;
                    case 3:

                        PlayerCards_disp[replace] = Clubs[card];
                        PlayerCards[replace] = card + 39;
                        break;
                }
            }
        }
        static void Player_Go()
        {
            //Display_Cards();
            Console.WriteLine("would you like to stick or twist?");
            string answer;
            do
            {
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "stick":
                        break;

                    case "twist":
                        int card = rnd.Next(1, 52);
                        if(card <= 13)
                        {
                            Console.WriteLine("From the Deck you draw: ");
                            Console.WriteLine(Hearts[card]);
                            Choose_card(card);
                        }
                        else if(card >= 14 && card <= 26)
                        {
                            Console.WriteLine("From the Deck you draw: ");
                            Console.WriteLine(Diamonds[card]);
                            Choose_card(card);
                        }
                        else if (card >= 27 && card <= 39)
                        {
                            Console.WriteLine("From the Deck you draw: ");
                            Console.WriteLine(Spades[card]);
                            Choose_card(card);
                        }
                        else
                        {
                            Console.WriteLine("From the Deck you draw: ");
                            Console.WriteLine(Clubs[card]);
                            Choose_card(card);
                        }
                        break;

                    default:
                        Console.WriteLine("that is not an option, try again:");
                        break;
                }
            } while (answer != "stick" && answer != "twist");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("how many cards would you like?");
            string ans;
            int num = 0;
            do
            {
                ans = Console.ReadLine();
                Console.Clear();
                try
                {
                    num = int.Parse(ans);
                    rand_card(num);
                }
                catch (FormatException)
                {
                    Console.WriteLine("that is not a valid input try again");
                }
            } while (num == 0);

            //for (int i = 0; i < 2; i++)
            //{
            //    switch(rnd.Next(3))
            //    {
            //        case 0:
            //            int heart = rnd.Next(12);
            //            PlayerCards_disp[i] = Hearts[heart];
            //            PlayerCards[i] = heart;
            //            break;
            //        case 1:
            //            int diamond = rnd.Next(12);
            //            PlayerCards_disp[i] = Diamonds[diamond];
            //            PlayerCards[i] = diamond + 13;
            //            break;
            //        case 2:
            //            int spade = rnd.Next(12);
            //            PlayerCards_disp[i] = Spades[spade];
            //            PlayerCards[i] = spade + 26;
            //            break;
            //        case 3:
            //            int club = rnd.Next(12);
            //            PlayerCards_disp[i] = Clubs[club];
            //            PlayerCards[i] = club + 39;
            //            break;
            //    }
            //}
            //Player_Go();
            Console.ReadKey();
        }
    }
}
