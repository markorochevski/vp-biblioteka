using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vp_proektna_biblioteka
{   
    public class Book
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public string AUTHOR { get; set; }
        public string CATEGORY { get; set; }
        public string CONTENT { get; set; }

        public Book(int id, string title, string author, string category, string content)
        {
            ID = id;
            TITLE = title;
            AUTHOR = author;
            CATEGORY = category;
            CONTENT = content;
        }
    }
}
