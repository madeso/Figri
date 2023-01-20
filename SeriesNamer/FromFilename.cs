using Figri;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeriesNamer
{
    public partial class FromFilename : Form
    {
        static Dictionary<string, int> widths = new Dictionary<string, int>();
        ShowListUtil lu;
        public FromFilename(List<FileEntry> infos)
        {
            InitializeComponent();

            lu = new ShowListUtil(dResult, widths, 120);
            lu.addSeveral(infos);

            lu.removeAllHeaders();
            lu.addHeadersFromFirst();
            lu.updateAllText();
        }

        private void dPattern_TextChanged(object sender, EventArgs e)
        {
            applyPattern(dPattern.Text);
            lu.removeAllHeaders();
            lu.addHeadersFromFirst();
            lu.updateAllText();
        }

        private void applyPattern(string p)
        {
            foreach (FileEntry info in lu.AllInfos)
            {
                info.setupAttributes(p);
            }
        }

        private void dDone_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
