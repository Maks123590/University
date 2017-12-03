using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordInteractionLab8.Models;

namespace WordInteractionLab8
{
    public partial class AddOrganizetionForm : Form
    {
        public AddOrganizetionForm()
        {
            InitializeComponent();

            var preview = new PreviewPayment(10, 10);

            this.Controls.Add(preview);
        }
    }
}
