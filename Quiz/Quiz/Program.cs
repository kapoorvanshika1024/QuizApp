﻿using Quiz.LeaderboardNS;
using Quiz.UserLoginNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SignIn signIn = new SignIn();
            signIn.Show();
            Application.Run();
        }
    }
}
