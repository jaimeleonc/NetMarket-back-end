using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        //Criteria : representa la condición lógica(filtros) que se desea aplicar a una entidad
        Expression<Func<T, bool>> Criteria { get; }
        //Includes : representa las relaciones que se pueden tener en una entidad
        List<Expression<Func<T, object>>> Includes { get; }

        //orden ascendente
        Expression<Func<T, object>> OrderBy { get; }

        //orden descendente
        Expression<Func<T, object>> OrderByDescending { get; }

        //cantidad de registros por pagina
        int Take {  get; }
        //cantidad de paginas
        int Skip { get; }
        //si esta paginado o no
        bool IsPagingEnabled { get; }
    }
}
