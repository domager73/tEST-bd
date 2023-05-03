using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tEST_bd.Controleer;

namespace tEST_bd
{
    public partial class Form1 : Form
    {
        private FormMAinController _formMainController;

        public Form1()
        {
            InitializeComponent();

            _formMainController = new FormMAinController(this);
        }

        private void AddWorkers_Click(object sender, EventArgs e)
        {
            _formMainController.PrintWorkersToDoDataGritViewWorkers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _formMainController.PrintWorkersToDoDataGritViewWorkersWhereExpensive((int)numericUpDown1.Value);
        }
    }
}
