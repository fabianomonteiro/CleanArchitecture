using System.Collections.Generic;
using System.Threading.Tasks;

namespace Facade.Interfaces
{
    public interface ICrudActivableFacadeAsync<
        TInsertInput, 
        TInsertOutput, 
        TUpdateInput, 
        TUpdateOutput, 
        TDeleteByIdOutput,
        TListActiveOutput, 
        TGetByIdOutput> : IFacade
    {
        Task<IEnumerable<TListActiveOutput>> ListActiveAsync();

        Task<TGetByIdOutput> GetByIdAsync(int id);

        Task<TInsertOutput> InsertAsync(TInsertInput input);

        Task<TUpdateOutput> UpdateAsync(TUpdateInput input);

        Task<TDeleteByIdOutput> DeleteByIdAsync(int id);
    }
}
