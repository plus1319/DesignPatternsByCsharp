using System;
using System.Linq;
using System.Linq.Expressions;
using Specification.Strongly_Typed_Specification.Entity;

namespace Specification.Strongly_Typed_Specification
{
    public abstract class Specification<T>
    {
        public static readonly Specification<T> All = new IdentitySpecification<T>();

        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }
        public abstract Expression<Func<T, bool>> ToExpression();
        //and , or , not
        public Specification<T> And(Specification<T> specification)
        {
            if (this == All)
                return specification;
            if (specification == All)
                return this;
            return new AndSpecification<T>(this,specification);
        }
        public Specification<T> Or(Specification<T> specification)
        {
            if (this == All || specification == All)
                return All;
            return new OrSpecification<T>(this,specification);
        }
        public Specification<T> Not()
        {
            return new NotSpecification<T>(this);
        }
    }
    public sealed class MovieForKidsSpecification : Specification<StronglyTypedMovie>
    {
        public override Expression<Func<StronglyTypedMovie, bool>> ToExpression()
        {
            return m => m.MpaaRating <= StronglyTypedMpaaRating.PG13;
        }
    }
    public sealed class HasCDSpecification : Specification<StronglyTypedMovie>
    {
        public override Expression<Func<StronglyTypedMovie, bool>> ToExpression()
        {
            return m => m.ReleaseDate <= DateTime.Now.AddMonths(-6);
        }
    }

    

   
}