﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelDTOs
{
	public class BookDTO
	{
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the author's first name")]
        public string AuthorFirstName { get; set; }

        [Required(ErrorMessage = "Please enter the author's last name")]
        public string AuthorLastName { get; set; }

        public int PrintLength { get; set; }

        public string Publisher { get; set; }

        public DateTime PublicationDate { get; set; } = DateTime.Now;

        public int ISBN { get; set; }
        [Range(1, 10, ErrorMessage = "Rate between 1 (low) and 10 (high)")]
        public int ReviewRating { get; set; }

        public string Comments { get; set; }
        //public string AuthorMiddleName { get; set; }

        //public int CategoryId { get; set; }

        //public int SubCategoryId { get; set; }

        //public string CreatedUser { get; set; }

        //public string UpdatedUser { get; set; }

        //public DateTime CreatedDate { get; set; }

        //public DateTime UpdatedDate { get; set; }
	}
}
