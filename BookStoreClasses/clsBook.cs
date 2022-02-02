using System;

namespace BookStoreClasses
{
    public class clsBook
    {
        public string Author { get; set; }
        public int Edition { get; set; }
        public int PublicationYear { get; set; }
        public decimal bookPrice { get; set; }
        public decimal bookShelfNo { get; set; }
        public string bookTitle { get; set; }
        public string genreName { get; set; }

        public bool Find(string Title)
        {
            return true;
        }

        public string Valid(string Author)
        {
            string Error = "";
            if (Author == "")
            {
                Error = "The Author may not be blank";
            }
            if (Author.Length > 50)
            {
                Error = "The Author must be 50 characters or less";
            }
            return Error;
        }

        public string ValidPubYear(Int32 PubYear)
        {
            string Error = "";
            if (PubYear <= 1700 || PubYear >= 3001)
            {
                Error = "Please enter valid publication year";
            }
            return Error;
        }

        public string ValidEdition(Int32 Edition)
        {
            string Error = "";

            if (Edition < 0 || Edition > 1)
            {
                Error = "The edition can be only 0 or 1";
            }

            return Error;
        }

        public string ValidBookPrice(decimal bookPrice)
        {
            string Error = "";

            if (bookPrice < 0.01m || bookPrice > 500.00m)
            {
                Error = "The book price is not valid";
            }

            return Error;
        }

        public string ValidBookShelfNo(decimal bookShelfNo)
        {
            string Error = "";

            if (bookShelfNo < 0.0000m || bookShelfNo > 999.9999m)
            {
                Error = "The book shlef number is not valid";
            }

            return Error;
        }

        public string ValidTitle(string bookTitle)
        {
            string Error = "";
            if (bookTitle == "")
            {
                Error = "The Book Title may not be blank";
            }
            if (bookTitle.Length > 50)
            {
                Error = "The Book Title must be 50 characters or less";
            }
            return Error;
        }
        public string ValidGenre(string genreName)
        {
            string Error = "";
            if (genreName == "")
            {
                Error = "The Book Genre may not be blank";
            }
            if (genreName.Length > 50)
            {
                Error = "The Book Genre must be 50 characters or less";
            }
            return Error;
        }

        public bool List()
        {
            return true;
        }
    }
}