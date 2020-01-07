using System;
using System.Collections.Generic;
using System.Text;

namespace Specification.Naive_Impilimentation.Entity
{
    public class NeiveMovie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public NeiveMpaaRating MpaaRating { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }

    public enum NeiveMpaaRating
    {
        G,
        PG13,
        R
    }
}
