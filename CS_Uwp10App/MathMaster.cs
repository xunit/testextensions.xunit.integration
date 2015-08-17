using System.Linq;

namespace CS_Uwp10App
{
    public class MathMaster
    {
        public int Add(params int[] values)
        {
            return values.Sum();
        }
    }
}
