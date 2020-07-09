using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace log4net_study
{
    static class Program
    {
        //log4net
        private static log4net.ILog _logger = log4net.LogManager
                                            .GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _logger.Debug("デバッグ");
            _logger.Info("インフォ");
            _logger.Warn("警告");
            _logger.Error("エラー");
            _logger.Fatal("致命的");

            Application.Run(new Form1());
        }
    }
}
