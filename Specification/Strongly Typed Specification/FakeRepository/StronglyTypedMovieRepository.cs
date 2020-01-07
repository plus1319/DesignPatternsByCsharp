using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Specification.Problem.Entity;
using Specification.Strongly_Typed_Specification.Entity;

namespace Specification.Strongly_Typed_Specification.FakeRepository
{
    public class StronglyTypedMovieRepository
    {
        private IEnumerable<StronglyTypedMovie> stronglyTypedMovies = new List<StronglyTypedMovie>
        {
            new StronglyTypedMovie{Id = 1,
                Name="black blue",
                Genre = "dram",
                MpaaRating = StronglyTypedMpaaRating.R,
                Rating = 3,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new StronglyTypedMovie{Id = 1,
                Name="black mirror",
                Genre = "dram",
                MpaaRating = StronglyTypedMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,13)
            },
            new StronglyTypedMovie{Id = 1,
                Name="rambo",
                Genre = "action",
                MpaaRating = StronglyTypedMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new StronglyTypedMovie{Id = 1,
                Name="shawshang redemtion",
                Genre = "dram",
                MpaaRating = StronglyTypedMpaaRating.R,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,13)
            },
            new StronglyTypedMovie{Id = 1,
                Name="shilder list",
                Genre = "dram",
                MpaaRating = StronglyTypedMpaaRating.R,
                Rating = 9,
                ReleaseDate = new DateTime(2019,7,13)
            },
            new StronglyTypedMovie{Id = 1,
                Name="fury",
                Genre = "action",
                MpaaRating = StronglyTypedMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,2)
            },
            new StronglyTypedMovie{Id = 1,
                Name="focus",
                Genre = "dram",
                MpaaRating = StronglyTypedMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,3,3)
            },
            new StronglyTypedMovie{Id = 1,
                Name="terminator",
                Genre = "action",
                MpaaRating = StronglyTypedMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,1,1)
            },
            new StronglyTypedMovie{Id = 1,
                Name="funny boy",
                Genre = "cartoon",
                MpaaRating = StronglyTypedMpaaRating.G,
                Rating = 4,
                ReleaseDate = new DateTime(2019,3,13)
            },
            new StronglyTypedMovie{Id = 1,
                Name="deracula",
                Genre = "cartoon",
                MpaaRating = StronglyTypedMpaaRating.G,
                Rating = 9,
                ReleaseDate = new DateTime(2019,2,13)
            },
            new StronglyTypedMovie{Id = 1,
                Name="Mig Mig",
                Genre = "cartoon",
                MpaaRating = StronglyTypedMpaaRating.G,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,22)
            },
        };
        
        public StronglyTypedMovie GetOne(int id)
        {
            return stronglyTypedMovies.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<StronglyTypedMovie> isSuitableForChildren()
        {
            return stronglyTypedMovies
                .Where(p => p.MpaaRating <= StronglyTypedMpaaRating.PG13)
                .ToList();
        }
        public IEnumerable<StronglyTypedMovie> HasCDVersion()
        {
            return stronglyTypedMovies
                .Where(p => p.ReleaseDate <= DateTime.Now.AddMonths(-6))
                .ToList();
        }
        public IReadOnlyList<StronglyTypedMovie> Find(Specification<StronglyTypedMovie> specification)
        {
            return stronglyTypedMovies
                .AsQueryable()
                .Where(specification.ToExpression())
                .ToList();
        }
    }
}
