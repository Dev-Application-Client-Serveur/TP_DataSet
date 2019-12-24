using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_DataSet.dbTableAdapters;

namespace TP_DataSet
{
    public partial class TraineeManager : Form
    {
        public TraineeManager()
        {
            InitializeComponent();
        }

        private void TraineeManager_Load(object sender, EventArgs e)
        {

        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            this.traineesByNameRowBindingSource.DataSource =
                new TraineesByNameTableAdapter()
                .GetDataByName(this.txt_firstname.Text);
        }
    }
}
