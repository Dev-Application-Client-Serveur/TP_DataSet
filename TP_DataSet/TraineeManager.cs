using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DataSet
{
    public partial class TraineeManager : Form
    {
        public TraineeManager()
        {
            InitializeComponent();
        }

        private void traineesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.traineesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db);

        }

        private void TraineeManager_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'db.Trainees'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.traineesTableAdapter.Fill(this.db.Trainees);

        }
    }
}
