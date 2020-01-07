using System;
using System.Linq.Expressions;

namespace Specification.Generic_Naive_Implimantation
{
    public class GenericNeiveSpecification<T>
    {
        //validate expression in repository
        public Expression<Func<T, bool>> Expression { get; }

        public GenericNeiveSpecification(Expression<Func<T, bool>> expression)
        {
            Expression = expression;
        }
        //validate expression for viewmodel
        #region Sample
        //GenericNeiveMovieRepository genericNeiveRepo = new GenericNeiveMovieRepository();

        //var genericNeiveMovie = genericNeiveRepo.GetOne(1);
        //var genericDelegateNeiveMovie =
        //        new GenericNeiveSpecification<GenericNeiveMovie>
        //            (x => x.MpaaRating <= GenericNeiveMpaaRating.PG13);
        //    if (!genericDelegateNeiveMovie.IsSatisfiedBy(genericNeiveMovie))
        //{
        //    Console.WriteLine($"this movie is suitable for children : {genericNeiveMovie.Name}");
        //}
        #endregion
        public bool IsSatisfiedBy(T entity)
        {
            return Expression.Compile().Invoke(entity);
        }
    }
}