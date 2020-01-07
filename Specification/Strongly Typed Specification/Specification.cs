using System;
using System.Linq;
using System.Linq.Expressions;
using Specification.Strongly_Typed_Specification.Entity;

namespace Specification.Strongly_Typed_Specification
{
    public sealed class IdentitySpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> ToExpression()
        {
            return x => true;
        }
    }
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
    public sealed class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            _left = left;
            _right = right;
        }
        
        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T,bool >> leftExpression = _left.ToExpression();
            Expression<Func<T, bool>> rightExpression = _right.ToExpression();

            BinaryExpression andExpression = Expression.AndAlso(leftExpression.Body, rightExpression.Body);

            //convert binary expression to lambda
            return Expression.Lambda<Func<T, Boolean>>(andExpression, leftExpression.Parameters.Single());
        }
    }
    public sealed class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            _left = left;
            _right = right;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression = _left.ToExpression();
            Expression<Func<T, bool>> rightExpression = _right.ToExpression();

            BinaryExpression orExpression = Expression.OrElse(leftExpression.Body, rightExpression.Body);

            //convert binary expression to lambda
            return Expression.Lambda<Func<T, bool>>(orExpression, leftExpression.Parameters.Single());
        }
    }
    public sealed class NotSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _specification;
        public NotSpecification(Specification<T> specification)
        {
            _specification = specification;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> expression = _specification.ToExpression();

            UnaryExpression notExpression = Expression.Not(expression.Body);

            //convert unary expression to lambda
            return Expression.Lambda<Func<T, bool>>(notExpression, expression.Parameters.Single());
        }
    }
}