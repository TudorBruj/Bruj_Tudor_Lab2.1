﻿namespace Bruj_Tudor_Lab2._1.Models
{
    public class BookCategory
    {

        public int ID { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
