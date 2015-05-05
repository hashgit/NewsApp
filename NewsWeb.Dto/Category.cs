using System;
using System.Collections.Generic;

namespace NewsWeb.Dto
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public IList<CategoryArticleSummary> Articles { get; set; } 
    }

    public class CategoryArticleSummary
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
    }
}
