using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACLA
{
    public partial class ACLAmainForm : Form
    {
        private TabPage tp;
        public ACLAmainForm()
        {
            InitializeComponent();
            tp = this.tabPageWaiting;
            HideTabPage(tp);
            StatusLabel.Text = "Waiting for user input.";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            bool connectionOk = InternetConnectivity.CheckForInternetConnection();
            try
            {
                if (connectionOk)
                {
                    StatusLabel.Text = "Internet OK. Working...";
                    ClearLastExecutionData();
                    ShowTabPage(tp);
                    DisableButtons();
                    DoWork();
                    StatusLabel.Text = "Data fetched successfully. Waiting for user input.";
                }
                else
                {
                    StatusLabel.Text = "Internet connectivity error.";
                    HideTabPage(tp);
                    EnableButtons();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                HideTabPage(tp);
                EnableButtons();
            }
        }

        private void DoWork()
        {
            var stories = ApiRequests.GetStoryListFromEpic(txtBoxJiraUrl.Text, txtBoxJiraLogin.Text, txtBoxJiraPassword.Text, txtBoxJiraEpicKey.Text);
            var summaryTable = DataAnalysisAndPresentation.GetTableForSummaryGrid(stories, txtBoxJiraEpicKey.Text);
            var emailTable = DataAnalysisAndPresentation.GetEmailMatrix(stories, txtBoxSignature.Text);

            UiGridFormatting.FormatGrid(dgvSummary, summaryTable);
            UiGridFormatting.FormatGrid(dgvEmailMatrix, emailTable);
        }
        private void ClearLastExecutionData()
        {
            dgvSummary.DataSource = null;
            dgvEmailMatrix.DataSource = null;
        }
        private void DisableButtons()
        {
            btnGo.Enabled = false;
        }
        private void EnableButtons()
        {
            btnGo.Enabled = true;
        }
        private void HideTabPage(TabPage tp)
        {
            if (tabControl1.TabPages.Contains(tp))
            {
                pictureBoxWaiting.Image = null;
                tabControl1.TabPages.Remove(tp);
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }
        }
        private void ShowTabPage(TabPage tp)
        {
            if (tabControl1.TabPages.Contains(tp)) return;
            tabControl1.TabPages.Add(tp);
            tabControl1.SelectedTab = tp;
            pictureBoxWaiting.Image = Properties.Resources.throbber;
        }
        private void HandleException(Exception ex, string additionalMessage = "")
        {
            var message = String.Format("Ooooopppss.. Something went wrong. Details below:\r\n" +
                                        "{0}\r\n" + additionalMessage, (ex.Message));

            MessageBox.Show(message, "Unhandled error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            StatusLabel.Text = "Operation terminated with error. Waiting for user input.";
        }
    }
}
