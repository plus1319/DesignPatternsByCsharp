using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Specification.Naive_Impilimentation.Entity;

namespace Specification.Naive_Impilimentation.FakeRepository
{
    public class NeiveMovieRepository
    {
        private IEnumerable<NeiveMovie> neiveMovies = new List<NeiveMovie>
        {
            new NeiveMovie{Id = 1,
                Name="black blue",
                Genre = "dram",
                MpaaRating = NeiveMpaaRating.R,
                Rating = 3,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new NeiveMovie{Id = 1,
                Name="black mirror",
                Genre = "dram",
                MpaaRating = NeiveMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,13)
            },
            new NeiveMovie{Id = 1,
                Name="rambo",
                Genre = "action",
                MpaaRating = NeiveMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new NeiveMovie{Id = 1,
                Name="shawshang redemtion",
                Genre = "dram",
                MpaaRating = NeiveMpaaRating.R,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,13)
            },
            new NeiveMovie{Id = 1,
                Name="shilder list",
                Genre = "dram",
                MpaaRating = NeiveMpaaRating.R,
                Rating = 9,
                ReleaseDate = new DateTime(2019,7,13)
            },
            new NeiveMovie{Id = 1,
                Name="fury",
                Genre = "action",
                MpaaRating = NeiveMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,2)
            },
            new NeiveMovie{Id = 1,
                Name="focus",
                Genre = "dram",
                MpaaRating = NeiveMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,3,3)
            },
            new NeiveMovie{Id = 1,
                Name="terminator",
                Genre = "action",
                MpaaRating = NeiveMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,1,1)
            },
            new NeiveMovie{Id = 1,
                Name="funny boy",
                Genre = "cartoon",
                MpaaRating = NeiveMpaaRating.G,
                Rating = 4,
                ReleaseDate = new DateTime(2019,3,13)
            },
            new NeiveMovie{Id = 1,
                Name="deracula",
                Genre = "cartoon",
                MpaaRating = NeiveMpaaRating.G,
                Rating = 9,
                ReleaseDate = new DateTime(2019,2,13)
            },
            new NeiveMovie{Id = 1,
                Name="Mig Mig",
                Genre = "cartoon",
                MpaaRating = NeiveMpaaRating.G,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,22)
            },
        };

        public static Expression<Func<NeiveMovie, bool>> isSuitableForChildren = 
            m => m.MpaaRating <= NeiveMpaaRating.PG13;

        public static Expression<Func<NeiveMovie, bool>> hasCD =
            m => m.ReleaseDate <= DateTime.Now.AddMonths(-6);

        public NeiveMovie GetOne(int id)
        {
            return neiveMovies.FirstOrDefault(p => p.Id == id);
        }
        public IQueryable<NeiveMovie> GetList()
        {
            return neiveMovies.AsQueryable();
        }
        public IList<NeiveMovie> Find(Expression<Func<NeiveMovie,bool>> expression)
        {
            return neiveMovies.AsQueryable().Where(expression).ToList();
        }
    }
}
