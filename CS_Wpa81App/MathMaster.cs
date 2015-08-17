using System.Linq;

namespace CS_Wpa81App
{
    public class MathMaster
    {
        public int Add(params int[] values)
        {
            return values.Sum();
        }
    }
}
