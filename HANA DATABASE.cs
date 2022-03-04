using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;


namespace NewEmail
{
    public partial class Mail : Form
    {
        SAPbobsCOM.Company oCompany;

        public Mail()
        {
            // I use SAPHANA database
            oCompany = new SAPbobsCOM.Company();

            String sqlServer = System.Configuration.ConfigurationManager.AppSettings["SS"];
            if (sqlServer == "SQL2012") oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2012;
            else if (sqlServer == "SQL2014") oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2014;
            else if (sqlServer == "SQL2016") oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2016;
            else if (sqlServer == "HANA") oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_HANADB;
            else oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL;

            oCompany.Server = ConfigurationManager.AppSettings["DS"];
            oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English;
            oCompany.UseTrusted = Convert.ToBoolean(ConfigurationManager.AppSettings["AU"]);
            oCompany.DbUserName = ConfigurationManager.AppSettings["UN"];
            oCompany.DbPassword = ConfigurationManager.AppSettings["PW"];
            oCompany.CompanyDB = ConfigurationManager.AppSettings["DB"];
            oCompany.UserName = ConfigurationManager.AppSettings["SAPUN"];
            oCompany.Password = ConfigurationManager.AppSettings["SAPPW"];

            int con = oCompany.Connect();
            string error = oCompany.GetLastErrorDescription();
            //end
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }
        
        private void lblAttachments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        
        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
           

        }

        private void btnSend_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }

}

