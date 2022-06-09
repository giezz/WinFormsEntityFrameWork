using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace WinFormsEntityFrameWork
{
    
    public static class LINQExtensions
    {
        /// <summary>
        /// Cлегка переделан метод Where под использование фильтров
        /// </summary>
        public static IQueryable<TSource> Where<TSource>(this IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate, bool isNeeded)
        {
            if (!isNeeded)
                return source;
            else
            {
                return source.Provider.CreateQuery<TSource>(Expression.Call(null, GetMethodInfo<IQueryable<TSource>,
                    Expression<Func<TSource, bool>>, IQueryable<TSource>>(Queryable.Where), new[]
                {
                    source.Expression,
                    Expression.Quote(predicate)
                }));
            }
        }
        
        private static MethodInfo GetMethodInfo<T1, T2, T3>(
            Func<T1, T2, T3> f)
        {
            return f.Method;
        }
    }
}