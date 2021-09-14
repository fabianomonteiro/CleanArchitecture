namespace AOP.Aspects
{
    public interface IAuthorizingAspect : IAspect
    {
        bool Authorize();
    }
}
