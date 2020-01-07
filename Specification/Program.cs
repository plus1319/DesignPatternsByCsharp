using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Specification.Generic_Naive_Implimantation;
using Specification.Generic_Naive_Implimantation.Entity;
using Specification.Generic_Naive_Implimantation.FakeRepository;
using Specification.Naive_Impilimentation.Entity;
using Specification.Naive_Impilimentation.FakeRepository;
using Specification.Problem.Entity;
using Specification.Problem.FakeRepository;
using Specification.Strongly_Typed_Specification;
using Specification.Strongly_Typed_Specification.Entity;
using Specification.Strongly_Typed_Specification.FakeRepository;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            //strongly typed specification with and ,or,not
            StronglyTypedMovieRepository stronglyTypedMovieRepository = new StronglyTypedMovieRepository();

            var kidsSpecification = new MovieForKidsSpecification();
            var hasCdMovies = new HasCDSpecification();
            Specification<StronglyTypedMovie> spec = Specification<StronglyTypedMovie>.All;

            spec = spec.And(new MovieForKidsSpecification());
            spec = spec.Or(new HasCDSpecification());
            var test = stronglyTypedMovieRepository.Find(spec);
            foreach (var movie in test)
            {
                Console.WriteLine($"this movie has cd :{movie.Name}");
            }
            //==================================================================================

            //Strongly Typed Specification
            //StronglyTypedMovieRepository stronglyTypedMovieRepository = new StronglyTypedMovieRepository();


            //StronglyTypedMovie storynglyTypedMovie = stronglyTypedMovieRepository.GetOne(1);
            //var stronglyTypedMovieSpecification = new MovieForKidsSpecification();

            //if (!stronglyTypedMovieSpecification.IsSatisfiedBy(storynglyTypedMovie))
            //{
            //    Console.WriteLine($"this movie is suitable for children : {storynglyTypedMovie.Name}");
            //}
            //Console.WriteLine("----------------------------------------------");

            //var kidsSpecification = new MovieForKidsSpecification();
            //foreach (var stronglyTypedMovie in stronglyTypedMovieRepository.Find(kidsSpecification))
            //{
            //    Console.WriteLine($"these movie are for children : {stronglyTypedMovie.Name}");
            //}
            //Console.WriteLine("----------------------------------------------");

            //var hasCdMovies =new HasCDSpecification();
            //foreach (var movie in stronglyTypedMovieRepository.Find(hasCdMovies))
            //{
            //    Console.WriteLine($"this movie has cd :{movie.Name}");
            //}
            //==================================================================================

            //Generic Neive
            //GenericNeiveMovieRepository genericNeiveRepo = new GenericNeiveMovieRepository();

            //var genericNeiveMovie = genericNeiveRepo.GetOne(1); 
            //var genericDelegateNeiveMovie = 
            //    new GenericNeiveSpecification<GenericNeiveMovie>
            //        (x=>x.MpaaRating <= GenericNeiveMpaaRating.PG13);
            //if (!genericDelegateNeiveMovie.IsSatisfiedBy(genericNeiveMovie))
            //{
            //    Console.WriteLine($"this movie is suitable for children : {genericNeiveMovie.Name}");
            //}
            //Console.WriteLine("----------------------------------------------");


            //var genericNeiveForChildrenMovies =
            //    genericNeiveRepo.Find(GenericNeiveMovieRepository.isSuitableForChildren);

            //foreach (var movie in genericNeiveForChildrenMovies)
            //{
            //    Console.WriteLine($"Movie name is :{movie.Name}");
            //}
            //Console.WriteLine("----------------------------------------------");

            //var genericNeiveForHasCdMovies = genericNeiveRepo.Find(GenericNeiveMovieRepository.hasCD);
            //foreach (var movie in genericNeiveForHasCdMovies)
            //{
            //    Console.WriteLine($"this movie has cd :{movie.Name}");
            //}

            //==================================================================================

            //Naive
            //NeiveMovieRepository neiveRepo = new NeiveMovieRepository();

            ////check expression here
            //NeiveMovie neiveMovie = neiveRepo.GetOne(1);
            //    //expression to delegate
            //Func<NeiveMovie, bool> delegateNeiveMovie = 
            //    NeiveMovieRepository.isSuitableForChildren.Compile();
            //if (!delegateNeiveMovie(neiveMovie))
            //{
            //    Console.WriteLine($"this movie is suitable for children : {neiveMovie.Name}");
            //}
            //Console.WriteLine("----------------------------------------------");

            //var neiveForChildrenMovies = 
            //    neiveRepo.Find(NeiveMovieRepository.isSuitableForChildren);

            //foreach (var movie in neiveForChildrenMovies)
            //{
            //    Console.WriteLine($"Movie name is :{movie.Name}");
            //}
            //Console.WriteLine("----------------------------------------------");

            //var neiveForHasCdMovies = neiveRepo.Find(NeiveMovieRepository.hasCD);
            //foreach (var movie in neiveForHasCdMovies)
            //{
            //    Console.WriteLine($"this movie has cd :{movie.Name}");
            //}

            //==================================================================================
            //Problem
            //ProblemMovieRepository problemRepo = new ProblemMovieRepository();
            //var problemForChildrendMovies = problemRepo.isSuitableForChildren();

            //foreach (var movie in problemForChildrendMovies)
            //{
            //    Console.WriteLine($"for children Movie name is :{movie.Name}");
            //}

            //Console.WriteLine("----------------------------------------------");
            //var problemForHasCdMovies = problemRepo.HasCDVersion();
            //foreach (var movie in problemForHasCdMovies)
            //{
            //    Console.WriteLine($"has cd Movie name is :{movie.Name}");
            //}



            Console.ReadKey();
        }
    }
}
