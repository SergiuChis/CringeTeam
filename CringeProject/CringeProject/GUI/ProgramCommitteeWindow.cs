using CringeProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CringeProject.GUI
{
    public partial class ProgramCommitteeWindow : Form
    {
        public User User { get; private set; }
        public ProgramCommitteeWindow(User user)
        {
            User = user;
            InitializeComponent();
        }
    }
}
