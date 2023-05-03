using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tEST_bd.Db;

namespace tEST_bd.Controleer
{
    internal class FormMAinController
    {
        private Form1 _form1;
        private DbManager _dbManager;

        public FormMAinController(Form1 formfirst) 
        {
            _form1 = formfirst;
            _dbManager = DbManager.Instance;    
        }

        public void PrintWorkersToDoDataGritViewWorkers() 
        {
            DataGridView dataGridView = (DataGridView)_form1.Controls["dataGridView1"];

            dataGridView.DataSource = null;
            dataGridView.DataSource = _dbManager.TableWorkers.SelectAllWorkers();

            dataGridView.Columns["Id"].HeaderText = "Ид";
            dataGridView.Columns["Name"].HeaderText = "Имя";
            dataGridView.Columns["Experience"].HeaderText = "Опыт";
        }

        public void PrintWorkersToDoDataGritViewWorkersWhereExpensive(int exr)
        {
            DataGridView dataGridView = (DataGridView)_form1.Controls["dataGridView1"];

            dataGridView.DataSource = null;
            dataGridView.DataSource = _dbManager.TableWorkers.WhereByExpensive(exr);

            dataGridView.Columns["Id"].HeaderText = "Ид";
            dataGridView.Columns["Name"].HeaderText = "Имя";
            dataGridView.Columns["Experience"].HeaderText = "Опыт";
        }
    }
}
