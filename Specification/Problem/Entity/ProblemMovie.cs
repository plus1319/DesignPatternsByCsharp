using System;
using System.Collections.Generic;
using System.Text;

namespace Specification.Problem.Entity
{
    public class ProblemMovie 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ProblemMpaaRating MpaaRating { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
    }

    public enum ProblemMpaaRating
    {
        G,
        PG13,
        R
    }
}
