using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDTOs
{
	public class BookDTO
	{
        public int BookId { get; set; }

        public string Title { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string AuthorMiddleName { get; set; }

        public int CategoryId { get; set; }

        public int SubCategoryId { get; set; }

        public int PrintLength { get; set; }

        public string Publisher { get; set; }

        public DateTime PublicationDate { get; set; }

        public int ISBN { get; set; }

        public Decimal ReviewRating { get; set; }

        public string Comments { get; set; }

        public string CreatedUser { get; set; }

        public string UpdatedUser { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

	}
}
