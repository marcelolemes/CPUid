using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace CPUid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = getCPUID();
            //MessageBox.Show(getCPUID());
        }
        
        
        private String getCPUID()
   {
        String cpuInfo = String.Empty;
        ManagementClass mc = new ManagementClass("win32_processor");
        ManagementObjectCollection moc = mc.GetInstances();
    
        foreach (ManagementObject mo in moc)
        {
         if (cpuInfo == "")
         {
              //Pegar o ID do primeiro processador encontrado
              cpuInfo = mo.Properties["processorID"].Value.ToString();
              break;
         }
        }
        return cpuInfo;
   }
    }
}
