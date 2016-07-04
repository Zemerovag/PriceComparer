using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PriceComparer.Extensions
{
    public static class ExpressionExtensions
    {
        private const string ArgumentIsNotAPropertyException = "Argument is not a property";
        private const string InvalidArgumentException = "Invalid argument";

        public static string GetPropertyName<T>(this Expression<Func<T>> propertyExpression)
        {
            ArgumentChecks.NotNull(propertyExpression, "propertyExpression");

            var propertyInfo = propertyExpression.GetPropertyInfo();
            if (propertyInfo == null)
            {
                throw new ArgumentException(ArgumentIsNotAPropertyException, nameof(propertyExpression));
            }

            return propertyInfo.Name;
        }

        public static string GetPropertyName<T, TP>(this Expression<Func<T, TP>> propertyExpression)
        {
            ArgumentChecks.NotNull(propertyExpression, "propertyExpression");

            var pi = propertyExpression.GetPropertyInfo();
            if (pi == null)
            {
                throw new ArgumentException(ArgumentIsNotAPropertyException, nameof(propertyExpression));
            }

            return pi.Name;
        }

        public static PropertyInfo GetPropertyInfo<T, TP>(this Expression<Func<T, TP>> propertyExpression)
        {
            ArgumentChecks.NotNull(propertyExpression, "propertyExpression");

            return GetPropertyInfoCore(propertyExpression.Body);
        }

        public static PropertyInfo GetPropertyInfo<T>(this Expression<Func<T>> propertyExpression)
        {
            ArgumentChecks.NotNull(propertyExpression, "propertyExpression");

            return GetPropertyInfoCore(propertyExpression.Body);
        }

        private static PropertyInfo GetPropertyInfoCore(Expression propertyExpression)
        {
            var memberExpression = propertyExpression as MemberExpression;

            var unaryExpression = propertyExpression as UnaryExpression;
            if (unaryExpression != null)
            {
                memberExpression = unaryExpression.Operand as MemberExpression;
            }

            if (memberExpression != null)
            {
                return memberExpression.Member as PropertyInfo;
            }

            throw new ArgumentException(InvalidArgumentException, nameof(propertyExpression));
        }
    }
}
