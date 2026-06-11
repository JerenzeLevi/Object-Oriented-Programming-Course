using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omandam_Midterm_SetA
{
    class BookApp
    {
        private String Title;
        private String Author;
        private String Publisher;
        private int YearPublished;

        public BookApp(String title, String author, String publisher, int yearPublisher){
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.YearPublished = yearPublisher;
        }

        public String title
        {
            get { return Title; }
            set { Title = value; }
        }

        public String author
        {
            get { return Author; }
            set { Author = value; }
        }

        public String publisher
        {
            get { return Publisher; }
            set { Publisher = value; }
        }

        public int yearpublished
        {
            get { return YearPublished; }
            set { YearPublished = value; }
        }
    }

    
}
