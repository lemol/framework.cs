using System.Collections.Generic;

namespace Core.Infrastructure
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
        IEnumerable<TDestination> Map<TSource, TDestination>(IEnumerable<TSource> source);
    }
}