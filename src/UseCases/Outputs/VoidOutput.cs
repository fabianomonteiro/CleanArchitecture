namespace UseCases.Outputs
{
    public class VoidOutput
    {
        public static VoidOutput Instance { get; private set; }

        static VoidOutput()
        {
            Instance = new VoidOutput();
        }
    }
}
