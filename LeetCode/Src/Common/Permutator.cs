using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Src.Common {
    class Permutator {
        public static List<T[]> Permutate<T> (T[] source) {
            if (source.Length == 0) {
                return new List<T[]>();
            }
            if (source.Length == 1) {
                return new List<T[]> { source };
            }
            var indices = Enumerable.Range(0, source.Length).ToArray();
            return indices
                .SelectMany(
                    i => Permutate(indices.Where(j => j != i).Select(j => source[j]).ToArray()),
                    (i, arr) => arr.Append(source[i]).ToArray())
                .ToList();
        }
    }
}
