using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Specification.Generic_Naive_Implimantation.Entity;
using Specification.Naive_Impilimentation.Entity;

namespace Specification.Generic_Naive_Implimantation.FakeRepository
{
    public class GenericNeiveMovieRepository
    {
        private IEnumerable<GenericNeiveMovie> genericNeiveMovies = new List<GenericNeiveMovie>
        {
            new GenericNeiveMovie{Id = 1,
                Name="black blue",
                Genre = "dram",
                MpaaRating = GenericNeiveMpaaRating.R,
                Rating = 3,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new GenericNeiveMovie{Id = 1,
                Name="black mirror",
                Genre = "dram",
                MpaaRating = GenericNeiveMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,13)
            },
            new GenericNeiveMovie{Id = 1,
                Name="rambo",
                Genre = "action",
                MpaaRating = GenericNeiveMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,8,13)
            },
            new GenericNeiveMovie{Id = 1,
                Name="shawshang redemtion",
                Genre = "dram",
                MpaaRating = GenericNeiveMpaaRating.R,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,13)
            },
            new GenericNeiveMovie{Id = 1,
                Name="shilder list",
                Genre = "dram",
                MpaaRating = GenericNeiveMpaaRating.R,
                Rating = 9,
                ReleaseDate = new DateTime(2019,7,13)
            },
            new GenericNeiveMovie{Id = 1,
                Name="fury",
                Genre = "action",
                MpaaRating = GenericNeiveMpaaRating.R,
                Rating = 8,
                ReleaseDate = new DateTime(2019,4,2)
            },
            new GenericNeiveMovie{Id = 1,
                Name="focus",
                Genre = "dram",
                MpaaRating = GenericNeiveMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,3,3)
            },
            new GenericNeiveMovie{Id = 1,
                Name="terminator",
                Genre = "action",
                MpaaRating = GenericNeiveMpaaRating.PG13,
                Rating = 5,
                ReleaseDate = new DateTime(2019,1,1)
            },
            new GenericNeiveMovie{Id = 1,
                Name="funny boy",
                Genre = "cartoon",
                MpaaRating = GenericNeiveMpaaRating.G,
                Rating = 4,
                ReleaseDate = new DateTime(2019,3,13)
            },
            new GenericNeiveMovie{Id = 1,
                Name="deracula",
                Genre = "cartoon",
                MpaaRating = GenericNeiveMpaaRating.G,
                Rating = 9,
                ReleaseDate = new DateTime(2019,2,13)
            },
            new GenericNeiveMovie{Id = 1,
                Name="Mig Mig",
                Genre = "cartoon",
                MpaaRating = GenericNeiveMpaaRating.G,
                Rating = 10,
                ReleaseDate = new DateTime(2019,6,22)
            },
        };

        public static GenericNeiveSpecification<GenericNeiveMovie> isSuitableForChildren = 
           new GenericNeiveSpecification<GenericNeiveMovie>
               (m=>m.MpaaRating <= GenericNeiveMpaaRating.PG13);

        public static GenericNeiveSpecification<GenericNeiveMovie> hasCD =
           new GenericNeiveSpecification<GenericNeiveMovie>
               (m => m.ReleaseDate <= DateTime.Now.AddMonths(-6));

        public GenericNeiveMovie GetOne(int id)
        {
            return genericNeiveMovies.FirstOrDefault(p => p.Id == id);
        }
        public IQueryable<GenericNeiveMovie> GetList()
        {
            return genericNeiveMovies.AsQueryable();
        }
        public IList<GenericNeiveMovie> Find(GenericNeiveSpecification<GenericNeiveMovie> specification)
        {
            return genericNeiveMovies.AsQueryable().Where(specification.Expression).ToList();
        }
    }
}
