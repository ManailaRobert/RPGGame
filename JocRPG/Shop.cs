using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JocRPG
{
    public partial class Shop : Form
    {
        GameManager gameManager=new GameManager();

        List<Item> shopList = new List<Item>();

        public void UpdateList()
        {
            LB_ShopList.Items.Clear();
            for (int i = 0; i < shopList.Count; i++)
            {
                if (shopList[i].Quantity != 0)
                    LB_ShopList.Items.Add(shopList[i].Id + ' ' + shopList[i].Name);
                else
                    shopList.RemoveAt(i);
            }
        }
        public void LoadListOfItemsFromFile()
        {
            StreamReader In = new StreamReader("items.txt");
            int numberItems = Convert.ToInt32(In.ReadLine());

            for (int i = 0; i < numberItems; i++)
            {
                string line = In.ReadLine();
                string[] arr = line.Split(';');
                Item item = new Item(Convert.ToInt32(arr[0]), arr[1], arr[2], Convert.ToInt32(arr[3]), Convert.ToInt32(arr[4]), arr[5], arr[6], Convert.ToInt32(arr[7]));
                shopList.Add(item);
            }

           

            In.Close();
        }
        public void SaveListOfItems()
        {
            StreamWriter Out = new StreamWriter("items.txt");
            Out.Write(shopList.Count);
            foreach( Item item in shopList)
                Out.WriteLine($"{item.Id};{item.Name};{item.Type};{item.Quantity};{item.Price};{item.AvailableClass};{item.RequirementStat};{item.Requirement};");
        }
        public Shop()
        {
            InitializeComponent();

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            gameManager.CreatePlayer();
            LB_Bani.Text = gameManager.Player.Money.ToString();
            LoadListOfItemsFromFile();
            UpdateList();

        }

        private void BTN_Cumparare_Click(object sender, EventArgs e)
        {
            
            for (int i = LB_ShopList.Items.Count ;i<=1;i--)
            {
                if(LB_ShopList.GetSelected(i))
                {
                    if(gameManager.Player.Money>= shopList[i].Price)
                    {
                        gameManager.Player.Money-= shopList[i].Price;
                        LB_Bani.Text = gameManager.Player.Money.ToString();
                        shopList[i].Quantity--;
                        
                        //gameManager.Player.InventoryList.Items.Add(shopList[i]);// adaugare item cumparat in inventar

                    }
                }
                
            }
            UpdateList();
        }

        private void Shop_Leave(object sender, EventArgs e)
        {
            SaveListOfItems();
        }

        private void LB_ShopList_SelectedValueChanged(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            for (int i = LB_ShopList.Items.Count; i <= 1; i++)
            {
                if (LB_ShopList.GetSelected(i))
                    TB_Detalii.Text = $"\t{shopList[i].Name}" +
                        $"\nType:{shopList[i].Type}" +
                        $"\nPret:{shopList[i].Price}" +
                        $"\nQuantity:{shopList[i].Quantity}" +
                        $"\nClass:{shopList[i].AvailableClass}" +
                        $"\nRequired Stats:{shopList[i].Requirement+ shopList[i].RequirementStat} ";
            }
        }
    }
}
