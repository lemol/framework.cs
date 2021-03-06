using System;
using System.Collections.Generic;

namespace Core.Application.Services
{
    public interface IRetrieveService<TIdentity, TQuery>
    {
        IEnumerable<TDto> GetAll<TDto>();
        TDto Find<TDto>(TIdentity id);
        IEnumerable<TDto> GetQuery<TDto>(TQuery query);
        PaggedList<TDto> GetPagged<TDto>(TQuery query, int page, int count, string sorter = null);
    }
}