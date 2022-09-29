using NASAApi.Models;
using NASAApi.Services;

namespace NASAApi
{
    public partial class Form1 : Form
    {
        #region Private Methods

        private void SetScreenState()
        {
            chkThumbs.Checked = false;
            chkUseEndDate.Checked = false;
            chkUseStartDate.Checked = false;
            chkUseEndDate.Checked = false;

        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetScreenState();
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            string todaysDate=$"{ dtpTodaysDate.Value.Year.ToString()}-{ dtpTodaysDate.Value.Month.ToString("d2")}-{ dtpTodaysDate.Value.Day.ToString()}";
            string startDate = $"{dtpStartDate.Value.Year.ToString()}-{dtpStartDate.Value.Month.ToString("d2")}-{dtpStartDate.Value.Day.ToString()}";
            string endDate = $"{dtpEndDate.Value.Year.ToString()}-{dtpEndDate.Value.Month.ToString("d2")}-{dtpEndDate.Value.Day.ToString("d2")}";

            NasaInformation nasaInformation = new NasaInformation();

            RequestData requestData = new RequestData { date= chkUseTodaysDate.Checked ? todaysDate : String.Empty,start_date = chkUseStartDate.Checked ? startDate : String.Empty, end_date = chkUseEndDate.Checked ? endDate : String.Empty, count=(int)nudCount.Value,thumbs=chkThumbs.Checked };

            ResponseData responseData = await nasaInformation.GetNasaInformation(requestData);

            if(responseData.ErrorMessage != null)
            {
                MessageBox.Show(responseData.ErrorMessage);
            }

            txtExplanation.Text = responseData.explanation;
            pbImageReturned.Load(responseData.url);
            pbHdUrl.Load(responseData.hdurl);

            toolStripStatusLabel1.Text = "Data Returned from NASA....";
        }
    }
}