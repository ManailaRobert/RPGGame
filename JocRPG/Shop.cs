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
        //GameManager gameManager=new GameManager();

        List<Item> shopList = new List<Item>();
        //update list and lisbox
        public void UpdateList()
        {
            LB_ShopList.Items.Clear();
            for (int i = 0; i < shopList.Count; i++)
            {
                if (shopList[i].Quantity != 0)
                    LB_ShopList.Items.Add(shopList[i].Id + " " + shopList[i].Name);
                else
                    shopList.RemoveAt(i);
            }
        }
        //update detalii 
        public void UpdateDetalii()
        {
            for (int i = 0; i < LB_ShopList.Items.Count; i++)
            {
                if (LB_ShopList.GetSelected(i))
                {
                    TB_Detalii.Text = $"" + Environment.NewLine +
                        $"\t{shopList[i].Name}\n" + Environment.NewLine +
                        $"\nType: {shopList[i].Type}\n" + Environment.NewLine +
                        $"\nPret: {shopList[i].Price}\n" + Environment.NewLine +
                        $"\nQuantity: {shopList[i].Quantity}\n" + Environment.NewLine +
                        $"\nClass: {shopList[i].AvailableClass} \n" + Environment.NewLine +
                        $"\nRequired Stats: {shopList[i].Requirement + " " + shopList[i].RequirementStat} ";
                }
            }
        }
        //load list from file
        public void LoadListOfItemsFromFile()
        {
            StreamReader In = new StreamReader(@"..\..\Resources\items.txt");
            int numberItems = Convert.ToInt32(In.ReadLine());

            for (int i = 0; i < numberItems; i++)
            {
                string line = In.ReadLine();
                string[] arr1 = line.Split(';');

                Item item = new Item(Convert.ToInt32(arr1[0]), arr1[1], arr1[2], Convert.ToInt32(arr1[3]), Convert.ToInt32(arr1[4]), arr1[5], arr1[6], Convert.ToInt32(arr1[7]), Convert.ToInt32(arr1[8]), Convert.ToInt32(arr1[9]), Convert.ToInt32(arr1[10]), Convert.ToInt32(arr1[11]), Convert.ToInt32(arr1[12]),Convert.ToInt32(arr1[13]));
                shopList.Add(item);
            }

           

            In.Close();
        }
        //save list of items in a file
        public void SaveListOfItems()
        {
            StreamWriter Out = new StreamWriter(@"..\..\Resources\items.txt");
            Out.WriteLine(shopList.Count);
            foreach( Item item in shopList)//id,name,type,quantity,price,availableClass,requirementStat,requirement,addedMXH,addedATK,addedSTR,addedDEX,addedSPD,addedDEF
                Out.WriteLine($"{item.Id};{item.Name};{item.Type};{item.Quantity};{item.Price};{item.AvailableClass};{item.RequirementStat};{item.Requirement};{item.AddedMXH};{item.AddedATK};{item.AddedSTR};{item.AddedDEX};{item.AddedSPD};{item.AddedDEF}");
            Out.Close();
        }
        public Shop()
        {
            InitializeComponent();
        }
        //events
        private void Shop_Load(object sender, EventArgs e)
        {
            //gameManager.CreatePlayer();
            LB_Bani.Text = "Bani: " + FightingScene.date.GameManager.Player.Money.ToString();
            LoadListOfItemsFromFile();
            UpdateList();

        }
        private void BTN_Cumparare_Click(object sender, EventArgs e)
        {
            
            for (int i = 0 ;i< LB_ShopList.Items.Count; i++)
            {
                if(LB_ShopList.GetSelected(i))
                {
                    if(FightingScene.date.GameManager.Player.Money>= shopList[i].Price)
                    {
                        FightingScene.date.GameManager.Player.Money-= shopList[i].Price;
                        LB_Bani.Text = FightingScene.date.GameManager.Player.Money.ToString();
                        LB_Bani.Text = "Bani: " + FightingScene.date.GameManager.Player.Money.ToString();
                        shopList[i].Quantity--;
                        UpdateDetalii();
                        
                        //gameManager.Player.InventoryList.Items.Add(shopList[i]);// adaugare item cumparat in inventar

                    }
                }
                
            }
            UpdateList();
        }
        private void LB_ShopList_SelectedValueChanged(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            UpdateDetalii();
        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveListOfItems();
        }
    }
}
