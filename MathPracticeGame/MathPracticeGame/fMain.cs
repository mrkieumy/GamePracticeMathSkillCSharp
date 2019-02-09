using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCombobox;
using MathServices;

namespace MathPracticeGame
{
    public partial class fStart : Form
    {
        ComboboxItem[] listdata;
        public fStart()
        {
            InitializeComponent();
            InitCombobox();
        }
        public void InitCombobox()
        {
            //String[] listdata = new string[] { "Easy", "Medium", "Hard", "Expert" };
            listdata = new ComboboxItem[]
                {
                    new ComboboxItem() {Text="Easy",Value=0 },
                    new ComboboxItem() {Text="Medium",Value=1 },
                    new ComboboxItem() {Text="Hard",Value=2 },
                    new ComboboxItem() {Text="Expert",Value=3 }
                };

            cmbLevel.Items.AddRange(listdata);
            cmbLevel.SelectedIndex = 0;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            fQuestions newform = new fQuestions();
            newform.Show();
            newform.levelgame = cmbLevel.SelectedIndex;
            this.Hide();
        }

        private void fStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
