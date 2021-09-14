using AOP.Aspects;
using UseCases;

namespace API.Aspects
{
    public class AuthorizingAspect : IAuthorizingAspect
    {
        public bool IsMatch<TInput>(IInteractor interactor, TInput input)
        {
            return true;
        }

        public bool Authorize()
        {
            // Lógica de Autorização

            return true;
        }
    }
}
