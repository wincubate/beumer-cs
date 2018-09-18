using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wincubate.Module07.Slide19
{
    public partial class Form1 : Form
    {
        TaskCompletionSource<DateTime> _tcs;

        public Form1()
        {
            InitializeComponent();

            _tcs = new TaskCompletionSource<DateTime>();
        }

        async private void OnClick(object sender, EventArgs e)
        {
            DateTime dt = await _tcs.Task;

            MessageBox.Show( $"MouseOver at {dt}");
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            _tcs.TrySetResult(DateTime.Now);
        }
    }
}
