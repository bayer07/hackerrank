using System.Text;

namespace TestProject.Extensions
{
    internal static class ArrayExtensions
    {
        public static string ToLineString(this List<int> array)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < array.Count; i++)
            {
                if (i != array.Count - 1)
                    sb.Append($"{array[i]} ");
                else
                    sb.Append(array[i]);
            }

            return sb.ToString();
        }
    }
}
