using ce103_hw3__library_lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw3_library_app
{
    public class Password
    {
        public static void den()
        {
            int deneme = 2;

            string welcome = @"

██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗
██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝
██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  
██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  
╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗
 ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝
                                                              

";
            Console.WriteLine(welcome);

            

            while (true)
            {


                Console.WriteLine("Please write your password");
                int given = Convert.ToInt32(Console.ReadLine());
                

                if (given == 1907 )
                {
                    Console.Clear();
                    Console.WriteLine("                                             WELCOME SIR CELIK");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();

                    MainMenu class2 = new MainMenu();
                    MainMenu.Mainmenu();





                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That password is wrong! ");
                    Console.WriteLine("YOUR REMAINING RIGHTS " + deneme);
                    System.Threading.Thread.Sleep(2000);
                    if (deneme > 0)
                    {
                        deneme -= 1;
                    }
                    if (deneme == 0)
                    {
                        Console.WriteLine("You have no right to try");
                        Console.WriteLine("The application is closing");
                        break;
                    }
                }
                
            }
            Console.Read();

        }
    }
}
