using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ce103_hw3__library_lib
{
    public class Books
    {
        public int Id { get; set; }

        public String Bookname { get; set; }

        public string Bookauthor { get; set; }

        public int category { get; set; }

        public int Bookpages { get; set; }

        public int BookYear{ get; set; }

        public int BookEdition{ get; set; }

        public String Bookeditorts { get; set; }

        public String BookPublisher { get; set; }
        public String city { get; set; }

        public double price  { get; set; }

        public string Authorkeyword { get; set; }

        public String tags { get; set; }

        public String Abstract{ get; set; }

        public string Categorybook{ get; set; }

        //category
        public string Catadd { get; set; }
        public int Catid { get; set; }

        public string chose { get; set; }

        //barrow



        public string Barowername { get; set; }

        public int  tc { get; set; }

        public string Barrowbookname { get; set; }

        public int Barrowdate { get; set; }




    }
}
