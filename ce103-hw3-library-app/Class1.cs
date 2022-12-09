using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using static System.Console;

namespace ce103_hw3__library_lib
{
    public class Class1
    {


        #region Categories
        public static void Choose1()
        {

            Console.Clear();

            string logo = @"


                 __  __                      _       _     ___ ____  ____      _    ______   __
                |  \/  | ___ _ __   ___  ___( )___  | |   |_ _| __ )|  _ \    / \  |  _ \ \ / /
                | |\/| |/ _ \ '_ \ / _ \/ __|// __| | |    | ||  _ \| |_) |  / _ \ | |_) \ V / 
                | |  | |  __/ | | |  __/\__ \ \__ \ | |___ | || |_) |  _ <  / ___ \|  _ < | |  
                |_|  |_|\___|_| |_|\___||___/ |___/ |_____|___|____/|_| \_\/_/   \_\_| \_\|_|  
                                                                               
"
            ;





            String Catergories = @"

                    1-Add category
                    2-See Category
                    3-Delete Category
                    4-Category Books
                    5-Exit





";


            Console.WriteLine(logo);
            Console.WriteLine(Catergories);
            Console.Write("Please enter the action you want to do :  ");






            int categor = Convert.ToInt32(Console.ReadLine());

            ConsoleKeyInfo key;

           
            switch (categor)
                {


                    case 1:
                    Console.Clear() ;
                    Console.WriteLine("Do you want to continue?");
                    Console.WriteLine("Press esc to go back");

                    if (Console.ReadKey().Key != ConsoleKey.Escape)
                    {
                        Console.WriteLine("ADD CATEGORY ");
                        
                        Console.WriteLine("Category id");
                        int catid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Catagory name");
                            String categor1 = Console.ReadLine();
                        Books book = (new Books { Catid = catid, Catadd = categor1});
                        StreamWriter sw = new StreamWriter("C:\\Users\\menes\\Desktop\\ce103-hw3\\ce103-hw3-library-app\\bin\\Debug\\assents\\Category.dat", true, Encoding.GetEncoding("Windows-1254"));
                         StreamWriter asw = new StreamWriter("C:\\Users\\menes\\Desktop\\ce103-hw3\\ce103-hw3-library-app\\bin\\Debug\\assents\\Categories\\" + categor1+".dat", true, Encoding.GetEncoding("Windows-1254"));

                    sw.WriteLine(  catid + "- " + categor1 );
                        sw.Close();
                        sw.Dispose();

                    Console.ReadLine();
                    Console.Clear() ;
                    MainMenu.Mainmenu();
                        String add = Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Class1.Choose1();
                    }
                    break;





                case 2:
                    Console.Clear();
                        Console.WriteLine("see Category");
                    

                    
                        string fileway = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Category.dat";
                        string books1 = System.IO.File.ReadAllText(fileway);
                        Console.WriteLine(books1);
                        key = Console.ReadKey();

                        if (Console.ReadKey().Key == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            Class1.Choose1();
                        }

                    
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Delete Category");
                    
                        Clear();
                        string fileway3 = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Category.dat";
                        string books3 = System.IO.File.ReadAllText(fileway3);
                        Console.WriteLine(books3);

                        Console.WriteLine("Which category  would you like to delete?");
                        string name = Console.ReadLine() ;

                        File.Delete(@"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Categories" + name + ".dat");
                        
                        Console.WriteLine("Accepted");
                        Console.ReadLine();

                        Console.WriteLine("Back to home for enter");
                        MainMenu.Mainmenu();



                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Do you want to continue?");
                    Console.WriteLine("Press esc to go back");
                    if (Console.ReadKey().Key != ConsoleKey.Escape)
                    {
                        string fileway1 = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Category.dat";
                    string books2 = System.IO.File.ReadAllText(fileway1);
                    Console.WriteLine(books2);

                    
                    Console.Write("Which Category : ");
                    string chose1 = Console.ReadLine();
                        Console.ReadLine();


                    



                        string fileway9 = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Categories\"+chose1+".dat";
                        string books9 = System.IO.File.ReadAllText(fileway9);
                        Console.WriteLine(books9);

                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Class1.Choose1();

                    }


                    break;
                
                

                    case 5:
                    Console.Clear();
                    MainMenu class1 = new MainMenu();
                    MainMenu.Mainmenu();

                    break;
                    

                }
            


        }
        #endregion

        #region Add Book
        public static void Choose2()
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

            ConsoleKeyInfo key;

            Console.WriteLine("Press ESC to go to main menu...");
            key = Console.ReadKey();

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu.Mainmenu();
            }

            Console.Clear();
            Console.WriteLine("Book's ID: ");
            int dene = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
                Console.Clear();
            Console.WriteLine("Book's Name: ");
            string Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Book's Author: ");
            string Author1 = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Book's Year: ");
            string Year = Console.ReadLine();
            int year = Convert.ToInt32(Year);

            Console.Clear();
            Console.WriteLine("Book's Pages: ");
            string Pages = Console.ReadLine();
            int page = Convert.ToInt32(Pages);

            Console.Clear();
            Console.WriteLine("Book's Edition: ");
            int Edition = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Book's Editors: ");
            string Editor = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Book's Publisher: ");
            string Publisher = Console.ReadLine();

            Console.Clear();
            string fileway = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Category.dat";
            var books1 = File.ReadAllText(fileway);
            Console.WriteLine(books1);
            
            Console.WriteLine("Book's Categories: ");
            Console.WriteLine("Please enter category");
            string  categor2 = Console.ReadLine();


            Console.Clear();
            Console.WriteLine("         --BOOK ADDED--     ");
            Console.WriteLine("Book's ID: " + dene);
            Console.WriteLine("Book's Name: " + Name);
            Console.WriteLine("Book's Author: " + Author1);
            Console.WriteLine("Book's Year: " + year);
            Console.WriteLine("Book's Pages: " + page);
            Console.WriteLine("Book's Edition: " + Edition);
            Console.WriteLine("Book's Editors: " + Editor);
            Console.WriteLine("Book's Publisher: " + Publisher);
            Console.WriteLine("Book's Publisher: " + categor2);


            Books book = (new Books { Id = dene, Bookname = Name, Bookauthor = Author1, BookYear = year, Bookpages = page, BookEdition = Edition , BookPublisher = Publisher, Categorybook = categor2   });
                StreamWriter sw = new StreamWriter("C:\\Users\\menes\\Desktop\\ce103-hw3\\ce103-hw3-library-app\\bin\\Debug\\assents\\Books.dat", true, Encoding.GetEncoding("Windows-1254"));
                StreamWriter bok = new StreamWriter("C:\\Users\\menes\\Desktop\\ce103-hw3\\ce103-hw3-library-app\\bin\\Debug\\assents\\"+Name+".dat", true, Encoding.GetEncoding("Windows-1254"));
            StreamWriter new1 = new StreamWriter("C:\\Users\\menes\\Desktop\\ce103-hw3\\ce103-hw3-library-app\\bin\\Debug\\assents\\" + categor2 + ".dat", true, Encoding.GetEncoding("Windows-1254"));
            StreamWriter new3 = new StreamWriter("C:\\Users\\menes\\Desktop\\ce103-hw3\\ce103-hw3-library-app\\bin\\Debug\\assents\\" + dene + ".dat", true, Encoding.GetEncoding("Windows-1254"));



            sw.WriteLine(" Book ID : " +dene + "\n"+ " Book Name : " + Name + "\n Book Author" + Author1 + "\n Book Year" + year + "\n Book Page" + page + "\n Book Edition" + Edition + "\n Book Editor" + Editor + "\n Book Pubsliher" + Publisher + "\n"  +  "\n" + "Category : " + categor2 +"\n"+dene +"*************************************************");
                sw.Close();
                sw.Dispose();
            bok.WriteLine(" Book ID : " + dene + "\n" + " Book Name : " + Name + "\n Book Author" + Author1 + "\n Book Year" + year + "\n Book Page" + page + "\n Book Edition" + Edition + "\n Book Editor" + Editor + "\n Book Pubsliher" + Publisher + "\n" + "\n" + "Category : " + categor2 + "\n" + dene + "*************************************************");
            bok.Close();
            bok.Dispose();
            new1.WriteLine(" Book ID : " + dene + "\n" + " Book Name : " + Name + "\n Book Author" + Author1 + "\n Book Year" + year + "\n Book Page" + page + "\n Book Edition" + Edition + "\n Book Editor" + Editor + "\n Book Pubsliher" + Publisher + "\n" + "\n" + "Category : " + categor2 + "\n" + dene + "*************************************************");
            new1.Close();
            new1.Dispose();
            new3.WriteLine(" Book ID : " + dene + "\n" + " Book Name : " + Name + "\n Book Author" + Author1 + "\n Book Year" + year + "\n Book Page" + page + "\n Book Edition" + Edition + "\n Book Editor" + Editor + "\n Book Pubsliher" + Publisher + "\n" + "\n" + "Category : " + categor2 + "\n" + dene + "*************************************************");
            new3.Close();
            new3.Dispose();

            Console.WriteLine("Press ESC to go to main menu...");
            key = Console.ReadKey();

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu.Mainmenu();
            }


        }
        #endregion

        #region Look Book
        public static void Choose3()
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

            Console.WriteLine("                                                     BOOKS");
            Console.WriteLine();

            ConsoleKeyInfo key;

            
            string fileway = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Books.dat";
            string books1 = System.IO.File.ReadAllText(fileway);
            Console.WriteLine(books1);
            Console.WriteLine("Press ESC to go to main menu...");
            key = Console.ReadKey();

            if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Console.Clear();
                MainMenu.Mainmenu();
            }
        }
        #endregion

        #region Delete Book
        public static void Choose4()
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
            string fileway1 = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Books.dat";
            string books2 = System.IO.File.ReadAllText(fileway1);
            Console.WriteLine(books2);
            Console.WriteLine("Which book would you like to delete?");
            
            
            string delete1 = Console.ReadLine();
            


            File.Delete(@"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\"+delete1+".dat");
                Console.WriteLine("Accepted") ;
                
                Console.WriteLine("Back to home for enter");
                MainMenu.Mainmenu();
              

           

        }
        #endregion

        #region EditBook
        public static void Choose5()
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

            Console.WriteLine("EDİT BOOK ");

        }
        #endregion

        #region Status book
        public static void Choose6()
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




            String status = @"

                    1-Barrow
                    2-Returned
                    3-saves
                    4-Exit
                    

Please enter the action you want to do :
";

            Console.WriteLine(status);


            int choosestatus = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
                switch (choosestatus)
            {
              

                case 1:
                    Console.WriteLine("Do you want to continue?");
                    Console.WriteLine("Press esc to go back");

                    if (Console.ReadKey().Key != ConsoleKey.Escape)
                    {

                    }
                    else
                    {
                        Console.Clear();
                        Class1   class45 = new Class1();
                        Class1.Choose6();
                    }

                    Console.Clear();   
                    Console.WriteLine("What is your Library ID : ");
                    int libID = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What is your name? ");
                    string libname = Console.ReadLine();

                    Console.WriteLine("Enter the ID of the book you want to barrow");
                    int libid = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the name of the you want to barrow");
                    string libbook = Console.ReadLine();

                    Console.WriteLine("Enter the day of the you want to barrow");
                    int day = Convert.ToInt32(Console.ReadLine());



                    Console.WriteLine("Congratulations! you borrowed the book");
                    Console.WriteLine("your return period is "+day+" days");


                    Books book = (new Books { tc = libid, Barowername = libname, Barrowbookname = libbook, Barrowdate = day});
                    StreamWriter sw = new StreamWriter("C:\\Users\\menes\\Desktop\\ce103-hw3\\ce103-hw3-library-app\\bin\\Debug\\assents\\Barrow.dat", true, Encoding.GetEncoding("Windows-1254"));
                    sw.WriteLine(" Person name : " + libname + "\t" + " Number: " + libid + "\n Book Name :" + libbook + "\n Back date : " + day +"\n*************************************************");
                    sw.Close();
                    sw.Dispose();
                    Console.Clear();
                    string fileway3 = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Barrow.dat";
                    string books3 = System.IO.File.ReadAllText(fileway3);
                    Console.WriteLine(books3);
                    Console.ReadLine();
                    Class1.Choose6();
                    break;

                case 3:

                    Console.Clear();

                    string fileway1 = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\Barrow.dat";
                    string books2 = System.IO.File.ReadAllText(fileway1);
                    Console.WriteLine(books2);

                    Console.ReadLine();
                    Console.WriteLine("Press Enter to go back");


                    break;

                case 4:
                    

                    Console.Clear();


                    MainMenu class9 = new MainMenu();
                    MainMenu.Mainmenu();

                    break;



                default:
                    Console.WriteLine("Back to Main menu ");
                    Console.ReadLine();
                    Console.Clear();
                    //MainMenu class6 = new MainMenu();
                    //MainMenu.Mainmenu();
                    break;
                }
            



        }

        #endregion

        #region Search Book

        public static void choose7()
        {
            String chose = @"
                
                How Search??

                1-ID
                2-Name
                3-Exit
";

            Console.WriteLine(chose);
            int chose2 = Convert.ToInt32(Console.ReadLine());

            switch (chose2)
            {
                case 1:
                    Clear();

                    Console.WriteLine("Plesae enter the ID");
                    int a = Convert.ToInt32(Console.ReadLine());

                    string fileway = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\"+a+".dat";
                    string books1 = System.IO.File.ReadAllText(fileway);
                    Console.WriteLine(books1);

                    Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("If you want to back manu pls press enter");
                    Class1.choose7();
                    break;
                case 2:
                    Clear();
                    Console.WriteLine("Plesae enter the Name");
                    string name = Console.ReadLine();

                    string fileway1 = @"C:\Users\menes\Desktop\ce103-hw3\ce103-hw3-library-app\bin\Debug\assents\" + name + ".dat";
                    string books2 = System.IO.File.ReadAllText(fileway1);
                    Console.WriteLine(books2);


                    Console.WriteLine("If you want to back manu pls press enter");
                    Console.ReadLine();
                    Class1.choose7();
                    break;

                case 3:
                    Clear();
                    Console.WriteLine("If you want to back manu pls press enter");
                    Console.ReadLine() ;
                    MainMenu.Mainmenu();
                    break;

                    default:
                    Clear();
                    Console.WriteLine("Wronge number !!!");
                    Console.WriteLine("You back to Home");

                    MainMenu.Mainmenu();
                    break;

            }

        }
        
        #endregion



    }
}




