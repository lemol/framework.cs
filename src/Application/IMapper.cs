using System.Collections.Generic;

namespace Lemolsoft.Framework.Application
{
    public interface IMapper
    {
        TDestination Map<TSource, TDestination>(TSource source);
        IEnumerable<TDestination> Map<TSource, TDestination>(IEnumerable<TSource> source);
    }
}