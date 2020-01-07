using System;
using System.Collections.Generic;
using System.Text;

namespace Specification.Strongly_Typed_Specification.Entity
{
    public class StronglyTypedMovie 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public StronglyTypedMpaaRating MpaaRating { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }

    public enum StronglyTypedMpaaRating
    {
        G,
        PG13,
        R
    }
}
