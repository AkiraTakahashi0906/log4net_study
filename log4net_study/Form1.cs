using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log4net_study
{
    public partial class Form1 : Form
    {
        //log4net
        private static log4net.ILog _logger = log4net.LogManager
                                            .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
            _logger.Info("InitializeComponent");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var array = new int[5];

            try
            {
                array[6] = 1;
            }
            catch(Exception ex)
            {
                _logger.Error(ex.ToString());
            }
        }
    }
}
