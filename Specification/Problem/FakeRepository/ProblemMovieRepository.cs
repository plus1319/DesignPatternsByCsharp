using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Specification.Problem.Entity;

namespace Specification.Problem.FakeRepository
{
    public class ProblemMovieRepository
    {
        private IEnumerable<ProblemMovie> problemMovies = new List<ProblemMovie>
        {
            new ProblemMovie{Id = 1,
                Name="black blue",
                Genre = "dram",
                MpaaRating = ProblemMpaaRating.R,
                Rating = 3,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new ProblemMovie{Id = 1,
                Name="black mirror",
                Genre = "dram",
                MpaaRating = ProblemMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,13)
            },
            new ProblemMovie{Id = 1,
                Name="rambo",
                Genre = "action",
                MpaaRating = ProblemMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new ProblemMovie{Id = 1,
                Name="shawshang redemtion",
                Genre = "dram",
                MpaaRating = ProblemMpaaRating.R,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,13)
            },
            new ProblemMovie{Id = 1,
                Name="shilder list",
                Genre = "dram",
                MpaaRating = ProblemMpaaRating.R,
                Rating = 9,
                ReleaseDate = new DateTime(2019,7,13)
            },
            new ProblemMovie{Id = 1,
                Name="fury",
                Genre = "action",
                MpaaRating = ProblemMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,2)
            },
            new ProblemMovie{Id = 1,
                Name="focus",
                Genre = "dram",
                MpaaRating = ProblemMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,3,3)
            },
            new ProblemMovie{Id = 1,
                Name="terminator",
                Genre = "action",
                MpaaRating = ProblemMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,1,1)
            },
            new ProblemMovie{Id = 1,
                Name="funny boy",
                Genre = "cartoon",
                MpaaRating = ProblemMpaaRating.G,
                Rating = 4,
                ReleaseDate = new DateTime(2019,3,13)
            },
            new ProblemMovie{Id = 1,
                Name="deracula",
                Genre = "cartoon",
                MpaaRating = ProblemMpaaRating.G,
                Rating = 9,
                ReleaseDate = new DateTime(2019,2,13)
            },
            new ProblemMovie{Id = 1,
                Name="Mig Mig",
                Genre = "cartoon",
                MpaaRating = ProblemMpaaRating.G,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,22)
            },
        };
        
        public ProblemMovie GetOne(int id)
        {
            return problemMovies.FirstOrDefault(p => p.Id == id);
        }
        public IQueryable<ProblemMovie> GetList()
        {
            return problemMovies.AsQueryable();
        }

        public IEnumerable<ProblemMovie> isSuitableForChildren()
        {
            return problemMovies
                .Where(p => p.MpaaRating <= ProblemMpaaRating.PG13)
                .ToList();
        }
        public IEnumerable<ProblemMovie> HasCDVersion()
        {
            return problemMovies
                .Where(p => p.ReleaseDate <= DateTime.Now.AddMonths(-6))
                .ToList();
        }

    }
}
