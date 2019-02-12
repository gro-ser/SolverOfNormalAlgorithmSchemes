using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SolverOfNormalAlgorithmSchemes.Permutation;

namespace SolverOfNormalAlgorithmSchemes
{
    public class VariableConstants
    {
        public string emptyWorld { get; set; } = "(e)";
        public string arrow { get; set; } = "->";
        public string arrowEndig { get; set; } = "->.";
        public int maxRepetitions { get; set; } = 15;
    }
    public class Permutation
    {
        public static VariableConstants vc = new VariableConstants();
        string oldValue, newValue;
        bool ending;

        public Permutation(string oldValue, string newValue, bool ending)
        {
            this.oldValue = oldValue;
            this.newValue = newValue;
            this.ending = ending;
        }

        public static string emptyToString(string str) => str == vc.emptyWorld ? "" : str;
        public static string stringToEmpty(string str) => str == "" ? vc.emptyWorld : str;

        static public Permutation Parse(string str)
        {
            string arr; bool ending = false;
            if (str.Contains(vc.arrowEndig))
            {
                ending = true; arr = vc.arrowEndig;
            }
            else if (!str.Contains(arr = vc.arrow))
                throw new Exception("Permutation hasn't arrow string!");            
            var tmp = str.Split(new string[] { arr }, StringSplitOptions.None);
            if (tmp.Length != 2) throw new Exception("Permutation has a lot of arrow strings!");
            return new Permutation(emptyToString(tmp[0]), emptyToString(tmp[1]), ending);
        }
        static public Permutation[] Parse(params string[] array)
        {
            int len = array.Length;
            var result = new Permutation[len];
            while (len-- > 0) result[len] = Parse(array[len]);
            return result;
        }

        public bool IsUsable(string text) => text.Contains(oldValue);
        public Tuple<string, bool> Apply(string text)
        {
            StringBuilder result = new StringBuilder(text);
            int ind = text.IndexOf(oldValue);
            result.Remove(ind, oldValue.Length);
            result.Insert(ind, newValue);
            return new Tuple<string, bool>(result.ToString(), ending);
        }

        public override string ToString()
        {
            return $"{stringToEmpty(oldValue)}{(ending ? vc.arrowEndig : vc.arrow)}{stringToEmpty(newValue)}";
        }
    }
    public class Scheme
    {
        Permutation[] permutations;
        int length, ind = -1, cnt;

        public Scheme(string[] lines)
        {
            permutations = Permutation.Parse(lines);
            length = permutations.Length;
        }

        public Tuple<string, bool> Apply(string text, TextBox box)
        {
            Tuple<string, bool> tup;
            for (int i = 0; i < length; i++)
                if (permutations[i].IsUsable(text))
                {
                    if (ind == i) cnt++; else { ind = i; cnt = 1; }
                    if (cnt == Permutation.vc.maxRepetitions)
                    {
                        box.AppendText("Maximum count of repeating!");
                        return new Tuple<string, bool>("(...)", true);
                    }
                    tup = permutations[i].Apply(text);
                    box.AppendText($"{stringToEmpty(text)}=>{stringToEmpty(tup.Item1)} // uses permutation#{i + 1}\r\n");
                    if (tup.Item2) box.AppendText("// the final permutation applied.");
                    return tup;
                }
            tup = new Tuple<string, bool>(text, true);
            box.AppendText($"=>{stringToEmpty(text)} // all permutations are not applicable");
            return tup;
        }

        public string ApplyAll(string text, TextBox box)
        {
            Tuple<string, bool> tup;
            do
            {
                tup = Apply(text, box);
                text = tup.Item1;
            } while (!tup.Item2);
            return stringToEmpty(text);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(i + 1).Append(")").AppendLine(permutations[i].ToString());
            return sb.ToString();
        }
    }
}