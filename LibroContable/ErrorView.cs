using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroContable
{
    public partial class ErrorView : Form
    {
        public ErrorView()
        {
            InitializeComponent();
        }

        public ErrorView(string errorMsg)
        {
            InitializeComponent();
            lblError.Text = errorMsg;
        }
    }
}
