using System;
using System.Linq;
using System.Linq.Expressions;

namespace Specification.Strongly_Typed_Specification
{
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
            var paramExpr = Expression.Parameter(typeof(T));
            andExpression = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(andExpression);
            var finalExpr = Expression.Lambda<Func<T, bool>>(andExpression, paramExpr);

            return finalExpr;
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

            //convert unary expression to lambda
            var paramExpr = Expression.Parameter(typeof(T));
            orExpression = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(orExpression);
            var finalExpr = Expression.Lambda<Func<T, bool>>(orExpression, paramExpr);

            return finalExpr;
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