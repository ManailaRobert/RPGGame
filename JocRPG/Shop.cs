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
        Dictionary<int, Item> shopList = new Dictionary<int, Item>();

        public static Shop dateShop;
        //update list and listbox
        public void UpdateList()
        {
            LB_ShopList.Items.Clear();
            foreach(var item in shopList)
            {
                if (item.Value.Quantity != 0)
                    LB_ShopList.Items.Add(item.Key + " " + item.Value.Name);
            }
        }
        //update detalii 
        public void UpdateDetalii()
        {
            for (int i = 0; i < LB_ShopList.Items.Count; i++)
            {
                if (LB_ShopList.GetSelected(i))
                {
                    string selectedElement = LB_ShopList.Items[i].ToString();
                    string[] details = selectedElement.Split(' ');
                    int id = Convert.ToInt32(details[0]);

                    TB_Detalii.Text = $"" +
                        $"\t{shopList[id].Name}" + Environment.NewLine +
                        $"\nType: {shopList[id].Type}" + Environment.NewLine +
                        $"\nPret: {shopList[id].Price}" + Environment.NewLine +
                        $"\nQuantity: {shopList[id].Quantity}" + Environment.NewLine +
                        $"\nClass: {shopList[id].AvailableClass} " + Environment.NewLine +
                        $"\nRequired Stats: {shopList[id].Requirement + " " + shopList[id].RequirementStat} "+ Environment.NewLine;

                    TB_Detalii.Text = TB_Detalii.Text + "(";
                    if (shopList[id].AddedMXH != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{shopList[id].AddedMXH} MaxHealth";
                    if (shopList[id].AddedATK != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{shopList[id].AddedATK} ATK";
                    if (shopList[id].AddedSTR != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{shopList[id].AddedSTR} STR";
                    if (shopList[id].AddedDEX != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{shopList[id].AddedDEX} DEX";
                    if (shopList[id].AddedSPD != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{shopList[id].AddedSPD} SPD";
                    if (shopList[id].AddedDEF != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{shopList[id].AddedDEF} DEF";
                    TB_Detalii.Text = TB_Detalii.Text + " )";
                }
            }
        }
        //load list from file
        public void LoadShopListFromFile()
        {
            StreamReader In = new StreamReader(@"..\..\Resources\items.txt");
            int numberItems = Convert.ToInt32(In.ReadLine());

            for (int i = 0; i < numberItems; i++)
            {
                string line = In.ReadLine();
                string[] arr1 = line.Split(';');

                Item item = new Item(arr1[1], arr1[2], arr1[3], Convert.ToInt32(arr1[4]), Convert.ToInt32(arr1[5]), arr1[6], arr1[7], Convert.ToInt32(arr1[8]), Convert.ToInt32(arr1[9]), Convert.ToInt32(arr1[10]), Convert.ToInt32(arr1[11]), Convert.ToInt32(arr1[12]), Convert.ToInt32(arr1[13]),Convert.ToInt32(arr1[14]));
                shopList.Add(Convert.ToInt32(arr1[0]),item);
            }
            In.Close();
        }
        //save list of items in a file
        public void SaveListOfItems()
        {
            StreamWriter Out = new StreamWriter(@"..\..\Resources\items.txt");
            Out.WriteLine(shopList.Count);
            foreach( var item in shopList)//id,name,type,quantity,price,availableClass,requirementStat,requirement,addedMXH,addedATK,addedSTR,addedDEX,addedSPD,addedDEF
                Out.WriteLine($"{item.Key};{item.Value.Name};{item.Value.ItemType};{item.Value.Type};{item.Value.Quantity};{item.Value.Price};{item.Value.AvailableClass};{item.Value.RequirementStat};{item.Value.Requirement};{item.Value.AddedMXH};{item.Value.AddedATK};{item.Value.AddedSTR};{item.Value.AddedDEX};{item.Value.AddedSPD};{item.Value.AddedDEF}");
            Out.Close();
        }
        public Shop()
        {
            InitializeComponent();
        }
        //events
        private void Shop_Load(object sender, EventArgs e)
        {
            LB_Bani.Text = "Bani: " + FightingScene.date.GameManager.Player.Money.ToString();
            LoadShopListFromFile();
            UpdateList();

        }
        private void BTN_Cumparare_Click(object sender, EventArgs e)
        {
            for (int i = 0 ;i< LB_ShopList.Items.Count; i++)
            {
                if(LB_ShopList.GetSelected(i))
                {
                    string selectedElement = LB_ShopList.Items[i].ToString();
                    string[] details = selectedElement.Split(' ');
                    int id = Convert.ToInt32(details[0]);

                    if (FightingScene.date.GameManager.Player.Money >= shopList[id].Price)
                        if (FightingScene.date.GameManager.Player.InventoryList.ContainsKey(id) == false)
                        {
                            FightingScene.date.GameManager.Player.Money -= shopList[id].Price;
                            LB_Bani.Text = FightingScene.date.GameManager.Player.Money.ToString();
                            LB_Bani.Text = "Bani: " + FightingScene.date.GameManager.Player.Money.ToString();
                            shopList[id].Quantity--;
                            UpdateDetalii();
                            FightingScene.date.GameManager.Player.InventoryList.Add(id, shopList[id]);// adaugare item cumparat in inventar
                        } else MessageBox.Show("You already bought this item");
                    else MessageBox.Show("You dont have enough gold.");
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
