using System;
using System.Windows.Forms;

namespace SolverOfNormalAlgorithmSchemes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = Permutation.vc;
            example1.Tag = "aabbaa\0*a->.\r\n*b->.\r\n->*";
            example2.Tag = "baba\0*a->a*\r\n*b->b*\r\na*->.\r\nb*->.\r\n->*";
            example3.Tag = "|||\0*|->||*\r\n*->.\r\n->*";
            example4.Tag = "|||\0||->(e)";
            example5.Tag = "aacbb\0a->\r\nb->\r\nc->";
            example6.Tag = "\0->+";
        }

        private void ApplyScheme(object sender, EventArgs e)
        {
            var Scheme = new Scheme(scheme.Lines);
            stages.Text = Scheme.ToString();
            stages.AppendText("\r\n");
            result.Text = Scheme.ApplyAll(word.Text, stages);
        }

        private void ExampleCliked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var tmp = ((sender as Control).Tag as string).Split('\0');
            word.Text = tmp[0];
            scheme.Text = tmp[1];
        }
    }
}
