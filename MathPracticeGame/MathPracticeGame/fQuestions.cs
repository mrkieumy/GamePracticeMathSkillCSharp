using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathServices;

namespace MathPracticeGame
{
    public partial class fQuestions : Form
    {
        public int levelgame;
        int true_answer = 0, false_answer = 0;
        public fQuestions()
        {
            InitializeComponent();
        }
        int res;
        private void fQuestions_Load(object sender, EventArgs e)
        {
            LoadCalculation();
            lblResult2.Text = String.Empty;
            lblResultFalse.Text = String.Empty;
            lblResultTrue.Text = String.Empty;
            timer1.Start();
        }
        private void LoadCalculation()
        {
            Services mservice = new Services();
            mservice.RandomLevel(levelgame);
            mservice.RandomCalculation();
            lblNum1.Text = mservice.Number1.ToString();
            lblNum2.Text = mservice.Number2.ToString();
            lblOper.Text = mservice.GetOperator();
            
            res = mservice.Result;
        }

        private void txtRes_TextChanged(object sender, EventArgs e) { } 

        private void txtRes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                int user_res;
                Int32.TryParse(txtRes.Text, out user_res);
                if (user_res == res)
                {
                    true_answer++;
                    lblResultTrue.Text = "True:  "+true_answer.ToString();
                }
                else
                {
                    false_answer++;
                    lblResultFalse.Text = "Wrong: "+false_answer.ToString();
                }
                lblResult2.Text = "Result: " + lblNum1.Text + "  " + lblOper.Text + "  " + lblNum2.Text + "  =  " + res.ToString();
                txtRes.Text = String.Empty;
                LoadCalculation();
            }
        }

        private void fQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lblmilisecond.Text);
            int b = Int32.Parse(lblsecond.Text);
            a--;
            if (a < 0)
            {
                a = 59;
                b--;
                if (b < 0)
                {
                    b = 59;
                }
            }

            if (a < 10)
            {
                lblmilisecond.Text = "0" + a;
            }
            else
                lblmilisecond.Text = a + "";
            if (b < 10)
            {
                lblsecond.Text = "0" + b;
            }
            else
                lblsecond.Text = b + "";
          
            if (a == 0 && b == 0)
            {
                String endgame="";
                timer1.Stop();
                if (true_answer>0)
                    endgame= "Congratulations, You won "+true_answer.ToString()+" scores. Let's try another game to get higher score. Click Yes to play again";
                else
                    endgame= "Oh oh, Good luck next time. Let's practice again to get better score, You can do that. Click Yes to play again.";
                DialogResult dlr = MessageBox.Show(endgame, "End game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.Yes)
                {
                    fStart formmain = new fStart();
                    formmain.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult dllr2 = MessageBox.Show("Are you sure to quit game? click No to go back game", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dllr2 == DialogResult.No)
                    {
                        fStart formmain = new fStart();
                        formmain.Show();
                        this.Hide();
                    }
                    else
                        Application.Exit();
                }
            }
        }

        private void lblResult2_Click(object sender, EventArgs e)
        {

        }
    }
}
