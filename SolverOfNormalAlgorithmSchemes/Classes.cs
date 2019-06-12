using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using static SolverOfNormalAlgorithmSchemes.Permutation;

namespace SolverOfNormalAlgorithmSchemes
{
    public class Settings
    {
        [Description("The strings describing the empty word.")]
        public string EmptyWord { get; set; } = "(e)";

        [Description("Non ending permutation declaration.")]
        public string Arrow { get; set; } = "->";

        [Description("Ending (final) permutation declaration.")]
        public string ArrowEndig { get; set; } = "->.";

        [Description("Count of the maximun repeats in apply.")]
        public int MaxRepetitions { get; set; } = 15;

        [Description("Displays whether to print a detailed description of the application of the scheme.")]
        public bool PrintLogs { get; set; } = true;
    }

    public class Permutation
    {
        public static Settings settings = new Settings();

        private readonly string oldValue;
        private readonly string newValue;
        readonly bool ending;

        public Permutation(string oldValue, string newValue, bool ending)
        {
            this.oldValue = oldValue;
            this.newValue = newValue;
            this.ending = ending;
        }

        public static string EmptyToString(string str) => str == settings.EmptyWord ? "" : str;
        public static string StringToEmpty(string str) => str == "" ? settings.EmptyWord : str;

        static public Permutation Parse(string str)
        {
            string arrow;
            bool ending = false;
            if (str.Contains(settings.ArrowEndig))
            {
                ending = true;
                arrow = settings.ArrowEndig;
            }
            else if (!str.Contains(arrow = settings.Arrow))
                throw new Exception("Permutation hasn't arrow string!");
            var temp = str.Split(new string[] { arrow }, StringSplitOptions.None);
            if (temp.Length != 2)
                throw new Exception("Permutation has a lot of arrow strings!");
            return new Permutation(EmptyToString(temp[0]), EmptyToString(temp[1]), ending);
        }
        static public Permutation[] Parse(params string[] array)
        {
            int len = array.Length;
            var result = new Permutation[len];
            while (len-- > 0)
                result[len] = Parse(array[len]);
            return result;
        }

        public bool IsUsable(string text) => text.Contains(oldValue);
        public (string, bool) Apply(string text)
        {
            StringBuilder result = new StringBuilder(text);
            int index = text.IndexOf(oldValue);
            result.Remove(index, oldValue.Length);
            result.Insert(index, newValue);
            return (result.ToString(), ending);
        }

        public override string ToString()
        {
            return $"{StringToEmpty(oldValue)}{(ending ? settings.ArrowEndig : settings.Arrow)}{StringToEmpty(newValue)}";
        }
    }

    public class Scheme
    {
        readonly Permutation[] permutations;
        private readonly int length;
        private int index = -1;
        private int count;

        public Scheme(string[] lines)
        {
            permutations = Parse(lines);
            length = permutations.Length;
        }

        public (string, bool) Apply(string text, TextBox box)
        {
            (string, bool) tuple;
            for (int i = 0; i < length; i++)
                if (permutations[i].IsUsable(text))
                {
                    if (index == i) count++; else { index = i; count = 1; }
                    if (count == settings.MaxRepetitions)
                    {
                        if (settings.PrintLogs)
                            box.AppendText("Maximum count of repeating!");
                        return ("(...)", true);
                    }
                    tuple = permutations[i].Apply(text);
                    if (settings.PrintLogs)
                        box.AppendText($"{StringToEmpty(text)}=>{StringToEmpty(tuple.Item1)} // uses permutation#{i + 1}\r\n");
                    if (tuple.Item2 && settings.PrintLogs)
                        box.AppendText("// the final permutation applied.");
                    return tuple;
                }
            tuple = (text, true);
            if (settings.PrintLogs)
                box.AppendText($"=>{StringToEmpty(text)} // all permutations are not applicable");
            return tuple;
        }

        public string ApplyAll(string text, TextBox box)
        {
            (string, bool) tup;
            do
            {
                tup = Apply(text, box);
                text = tup.Item1;
            } while (!tup.Item2);
            return StringToEmpty(text);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
                sb.Append(i + 1).Append(")").AppendLine(permutations[i].ToString());
            return sb.ToString();
        }
    }
    
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}