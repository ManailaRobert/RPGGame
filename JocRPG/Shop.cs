using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocRPG
{
    public partial class Shop : Form
    {
        GameManager gameManager=new GameManager();
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            gameManager.CreatePlayer();
           LB_Bani.Text= gameManager.Player.Money.ToString();
            List<string> shopList = new List<string>();

        }
    }
}
