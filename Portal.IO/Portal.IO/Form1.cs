using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Portal.IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void TopPnl_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LOLbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Riot Games\League of Legends\LeagueClient");
        }

        private void Playlistbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.youtube.com/watch?v=SXF-Eu8XwC8&list=PLQEgoqAxuULrgl8QTy9_Q9kxUa1AaIdMo");
        }

        private void BlackBoardbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://iqra.blackboard.com/webapps/portal/execute/tabs/tabAction?tab_tab_group_id=_1_1");
        }
        private void Blitzbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Hisam\AppData\Local\Programs\Blitz\Blitz");
        }

        private void FBbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.facebook.com/");
        }
        private void Openallbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.youtube.com/watch?v=SXF-Eu8XwC8&list=PLQEgoqAxuULrgl8QTy9_Q9kxUa1AaIdMo");
            System.Diagnostics.Process.Start(@"C:\Windows\System32\Taskmgr");
            System.Diagnostics.Process.Start(@"C:\Users\Hisam\AppData\Local\Programs\Blitz\Blitz");
            System.Diagnostics.Process.Start(@"C:\Riot Games\League of Legends\LeagueClient");
        }

        private void Taskbtn_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\Windows\System32\Taskmgr");
        }

        private void Shutbtn_Click(object sender, EventArgs e)
        {

        }

        

    }
}
