using System.Linq;

namespace CS_ClassLibrary
{
    public class MathMaster
    {
        public int Add(params int[] values)
        {
            return values.Sum();
        }
    }
}
