using System;
using System.Collections.Generic;
using System.Text;

namespace Specification.Generic_Naive_Implimantation.Entity
{
    public class GenericNeiveMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public GenericNeiveMpaaRating MpaaRating { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }

    public enum GenericNeiveMpaaRating
    {
        G,
        PG13,
        R
    }
}
