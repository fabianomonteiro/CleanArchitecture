using System.Collections.Generic;
using UseCases;
using UseCases.Inputs;

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
        IQuery<VoidInput, IEnumerable<TListActiveOutput>> ListActive();

        IQuery<int, TGetByIdOutput> GetById();

        IUseCase<TInsertInput, TInsertOutput> Insert();

        IUseCase<TUpdateInput , TUpdateOutput> Update();

        IUseCase<int, TDeleteByIdOutput> DeleteById();
    }
}
