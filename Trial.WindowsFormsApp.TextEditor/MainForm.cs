using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Trial.WindowsFormsApp.TextEditor
{
    public partial class MainForm : Form
    {
        private readonly List<IPlugin> plugins;

        public MainForm(IEnumerable<IPlugin> plugins)
        {
            InitializeComponent();
            this.plugins = plugins.ToList();
            //this.plugins.ForEach()
        }
    }
}
