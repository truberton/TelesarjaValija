using System.Collections.Generic;
using System.Linq;

namespace ListIsNullOrEmpty
{
    static class Try
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
            {
                return true;
            }
            //See kõik on copy-paste, sain selle siit: https://stackoverflow.com/questions/8582344/does-c-sharp-have-isnullorempty-for-list-ienumerable
            var collection = enumerable as ICollection<T>;
            if (collection != null)
            {
                return collection.Count < 1;
            }
            return !enumerable.Any();
        }
    }
}
