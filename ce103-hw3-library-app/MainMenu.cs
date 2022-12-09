using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ce103_hw3__library_lib
{
    public class MainMenu
    {
        

            public static void Mainmenu()
            {
            Console.Clear();
                string logo = @" 
                 __  __                      _       _     ___ ____  ____      _    ______   __
                |  \/  | ___ _ __   ___  ___( )___  | |   |_ _| __ )|  _ \    / \  |  _ \ \ / /
                | |\/| |/ _ \ '_ \ / _ \/ __|// __| | |    | ||  _ \| |_) |  / _ \ | |_) \ V / 
                | |  | |  __/ | | |  __/\__ \ \__ \ | |___ | || |_) |  _ <  / ___ \|  _ < | |  
                |_|  |_|\___|_| |_|\___||___/ |___/ |_____|___|____/|_| \_\/_/   \_\_| \_\|_|  
                                                                               
";

                Console.WriteLine(logo);

                string menu = @"
                            1-Catagories
                            2-Add Book
                            3-Review Books
                            4-Delete Book
                            6-Borrowing
                            7-Search Book
                            8-Exit



";
                Console.WriteLine(menu);

                Console.WriteLine("Please enter the action you want to do : ");
                int EnTry = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                
                    switch (EnTry)
                    {
                        case 1:

                            Class1 class1 = new Class1();
                            Class1.Choose1();


                            break;
                        case 2:
                            Class1 class2 = new Class1();
                                Class1.Choose2();

                            break;

                        case 3:
                            Class1 class3 = new Class1();
                            Class1.Choose3();
                            break;

                        case 4:
                            Class1 class4 = new Class1();
                            Class1.Choose4();
                            break;

                        case 5:
                            Class1 class5 = new Class1();
                            Class1.Choose5();
                            break;

                        case 6:
                            Class1 class6 = new Class1();
                            Class1.Choose6();
                            break;
                        case 7:
                        Class1 class7 = new Class1();
                            Class1.choose7();
                        break;



                        case 8:

                            MainMenu class14 = new MainMenu();
                            MainMenu.Dene();

                            break;

                    default:
                        MainMenu class17 = new MainMenu();
                        MainMenu.Dene();
                        break;

                }


            }
                
            }
        public static void Dene()
        {
            
            Console.WriteLine("Closing");
            Console.ReadLine(); 
            

        }



    }
}
