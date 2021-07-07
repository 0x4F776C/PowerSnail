/*
 * PowerShell Alternative - Executable
 * Created:
 *  By:         Lee Chun Hao
 *  On:         11th August 2020
 *  Purpose:    Run PowerShell commands/scripts even when PowerShell was blacklisted
 * Link:
 *  Linkedin:   https://sg.linkedin.com/in/lee-chun-hao-602ba670
 *  GitHub:     https://github.com/0x4F776C
 *  HackTheBox: https://www.hackthebox.eu/profile/152036
 */

using System;
using System.Text;
using System.Windows.Forms;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace PowerSnail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string RunCommand(string script)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();

            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(script);
            pipeline.Commands.Add("Out-String");

            Collection<PSObject> results = pipeline.Invoke();

            runspace.Close();

            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject psObject in results)
                stringBuilder.AppendLine(psObject.ToString());
            return stringBuilder.ToString();
        }

        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            String policyBypass = "Set-ExecutionPolicy Unrestricted -Scope CurrentUser;";

            cmdOutput.Clear();
            cmdOutput.Text = RunCommand(policyBypass + cmdInput.Text);
        }
    }
}
