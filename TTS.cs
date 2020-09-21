using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace TTS
{
    public partial class TTS : Form
    {
        public class Mp3Members
        {
            public string strPythonWithPath { get; set; }
            public string strScriptWithPath { get; set; }
            public string strText { get; set; }
            public string strLanguage { get; set; }
            public int nSampleRate { get; set; }
            public decimal dSpeedRate { get; set; }
            public string strFilePath { get; set; }
            public string strFileName { get; set; }
            public int nListenSpeech { get; set; }
        }


        public TTS()
        {
            InitializeComponent();
        }

        private void TTS_Load(object sender, EventArgs e)
        {
            txtFilePath.Text = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Audio";
        }

        private void btnFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FobjFBD = new FolderBrowserDialog();

            if (FobjFBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFolderName = FobjFBD.SelectedPath;
                txtFilePath.Text = strFolderName;
            }
        }

        private void btnGenMp3_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;

                rtxtText.BackColor = System.Drawing.Color.White;
                txtFileName.BackColor = System.Drawing.Color.White;
                txtFilePath.BackColor = System.Drawing.Color.White;
                lblMessage.Text = "";

                string strPythonWithPath = ConfigurationManager.AppSettings["PythonPath"];
                string strScriptWithPath = ConfigurationManager.AppSettings["TtsScriptPath"];
                string strText = rtxtText.Text;
                string strFileName = txtFileName.Text;
                string strLanguage = (rbArabic.Checked == true) ? "ar" : "en";
                int nSampleRate = Convert.ToInt32(nudPitch.Value);
                decimal dSpeedRate = Convert.ToDecimal(nudSpeed.Value);
                string strFilePath = txtFilePath.Text;

                if (string.IsNullOrWhiteSpace(strPythonWithPath))
                    throw new ApplicationException("Please configure PythonPath in App.Config");

                if (string.IsNullOrWhiteSpace(strScriptWithPath))
                {
                    strScriptWithPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TTS.py";

                    if (!File.Exists(strScriptWithPath))
                        throw new ApplicationException("Please configure TtsScriptPath in App.Config");
                }

                if (string.IsNullOrWhiteSpace(strText))
                {
                    rtxtText.BackColor = System.Drawing.ColorTranslator.FromHtml("#F7EFAC"); ;
                    throw new ApplicationException("Please provide Text.");
                }

                if (string.IsNullOrWhiteSpace(strFileName))
                {
                    txtFileName.BackColor = System.Drawing.ColorTranslator.FromHtml("#F7EFAC"); ;
                    throw new ApplicationException("Please provide File Name.");
                }

                if (string.IsNullOrWhiteSpace(strFilePath))
                {
                    txtFilePath.BackColor = System.Drawing.ColorTranslator.FromHtml("#F7EFAC"); ;
                    throw new ApplicationException("Please provide File Path.");
                }

                Mp3Members objMp3 = new Mp3Members();
                objMp3.strPythonWithPath = strPythonWithPath;
                objMp3.strScriptWithPath = strScriptWithPath;
                objMp3.strText = strText;
                objMp3.strFileName = strFileName;
                objMp3.strLanguage = strLanguage;
                objMp3.nSampleRate = nSampleRate;
                objMp3.dSpeedRate = dSpeedRate;
                objMp3.strFilePath = strFilePath;
                objMp3.nListenSpeech = 0;

                GenerateMp3File(objMp3, lblMessage);

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = ex.Message;
            }
        }

        private void btnGenAndLstn_Click(object sender, EventArgs e)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;

                rtxtText.BackColor = System.Drawing.Color.White;
                txtFileName.BackColor = System.Drawing.Color.White;
                txtFilePath.BackColor = System.Drawing.Color.White;
                lblMessage.Text = "";

                string strPythonWithPath = ConfigurationManager.AppSettings["PythonPath"];
                string strScriptWithPath = ConfigurationManager.AppSettings["TtsScriptPath"];
                string strText = rtxtText.Text;
                string strFileName = txtFileName.Text;
                string strLanguage = (rbArabic.Checked == true) ? "ar" : "en";
                int nSampleRate = Convert.ToInt32(nudPitch.Value);
                decimal dSpeedRate = Convert.ToDecimal(nudSpeed.Value);
                string strFilePath = txtFilePath.Text;

                if (string.IsNullOrWhiteSpace(strPythonWithPath))
                    throw new ApplicationException("Please configure PythonPath in App.Config");

                if (string.IsNullOrWhiteSpace(strScriptWithPath))
                {
                    strScriptWithPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\TTS.py";

                    if (!File.Exists(strScriptWithPath))
                        throw new ApplicationException("Please configure TtsScriptPath in App.Config");
                }

                if (string.IsNullOrWhiteSpace(strText))
                {
                    rtxtText.BackColor = System.Drawing.ColorTranslator.FromHtml("#F7EFAC");
                    throw new ApplicationException("Please provide Text.");
                }

                if (string.IsNullOrWhiteSpace(strFileName))
                {
                    txtFileName.BackColor = System.Drawing.ColorTranslator.FromHtml("#F7EFAC");
                    throw new ApplicationException("Please provide File Name.");
                }

                if (string.IsNullOrWhiteSpace(strFilePath))
                {
                    txtFilePath.BackColor = System.Drawing.ColorTranslator.FromHtml("#F7EFAC");
                    throw new ApplicationException("Please provide File Path.");
                }

                Mp3Members objMp3 = new Mp3Members();
                objMp3.strPythonWithPath = strPythonWithPath;
                objMp3.strScriptWithPath = strScriptWithPath;
                objMp3.strText = strText;
                objMp3.strFileName = strFileName;
                objMp3.strLanguage = strLanguage;
                objMp3.nSampleRate = nSampleRate;
                objMp3.dSpeedRate = dSpeedRate;
                objMp3.strFilePath = strFilePath;
                objMp3.nListenSpeech = 1;

                GenerateMp3File(objMp3, lblMessage);

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = ex.Message;
            }
        }

        public static void GenerateMp3File(Mp3Members objMp3, Label lblMessage)
        {
            try
            {
                var objPsi = new ProcessStartInfo();
                objPsi.FileName = objMp3.strPythonWithPath;
                objPsi.Arguments = $"\"{objMp3.strScriptWithPath}\" \"{objMp3.strText}\" \"{objMp3.strLanguage}\" \"{objMp3.nSampleRate}\" \"{objMp3.dSpeedRate}\" \"{objMp3.strFilePath}\" \"{objMp3.strFileName}\" \"{objMp3.nListenSpeech}\"";
                objPsi.UseShellExecute = false;
                objPsi.CreateNoWindow = true;
                objPsi.RedirectStandardOutput = true;
                objPsi.RedirectStandardError = true;

                #region Process Credentials
                //objPsi.LoadUserProfile = true;
                //NetworkCredential objNC = new NetworkCredential("shahab", "", "itdev");
                //objPsi.UserName = objNC.UserName;
                //objPsi.Password = objNC.SecurePassword;
                //objPsi.Domain = objNC.Domain;
                //objPsi.Verb = "runas";
                #endregion


                Process objProcess = new Process { StartInfo = objPsi, EnableRaisingEvents = true };
                objProcess.Start();

                #region Process Waiting
                //if (objProcess != null)
                //{
                //    objProcess.WaitForExit();
                //}
                #endregion

                #region Process Reading
                using (objProcess)
                {
                    string strErrors = "";
                    if (objProcess.StandardError.Peek() != -1)
                        strErrors = objProcess.StandardError.ReadToEnd();

                    if (!string.IsNullOrEmpty(strErrors))
                        throw new ApplicationException(strErrors);

                    //string strResults = "";
                    //if (objProcess.StandardOutput.Peek() != -1)
                    //    strResults = objProcess.StandardOutput.ReadToEnd();
                }
                #endregion

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Generated Successfully";

            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = ex.Message;
            }
        }

    }
}
