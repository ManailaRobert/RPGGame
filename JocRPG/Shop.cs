﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
                        $"Type: {shopList[id].ItemType}" + Environment.NewLine +
                        $"Pret: {shopList[id].Price}" + Environment.NewLine +
                        $"Quantity: {shopList[id].Quantity}" + Environment.NewLine +
                        $"Class: {shopList[id].AvailableClass} " + Environment.NewLine +
                        $"Required Level: {shopList[id].RequiredLevel}" + Environment.NewLine;

                    if (shopList[id].AddedDEF != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $"DEF: {shopList[id].AddedDEF}" + Environment.NewLine;
                    if (shopList[id].AddedATK != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $"ATK: {shopList[id].AddedATK}";

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

                Item item = new Item(arr1[1], arr1[2], arr1[3], Convert.ToInt32(arr1[4]), Convert.ToInt32(arr1[5]), arr1[6], Convert.ToInt32(arr1[7]),Convert.ToInt32(arr1[8]), Convert.ToInt32(arr1[9]));
                shopList.Add(Convert.ToInt32(arr1[0]),item);
            }
            In.Close();
        }
        //save list of items in a file
        public void SaveListOfItems()
        {
            StreamWriter Out = new StreamWriter(@"..\..\Resources\items.txt");
            Out.WriteLine(shopList.Count);
            foreach( var item in shopList) //id - 0,name - 1,itemClass - 2,type - 3,quantity - 4,price - 5,availableClass - 6,requiredLevel - 7,addedDEF - 8
                Out.WriteLine($"{item.Key};{item.Value.Name};{item.Value.ItemClass};{item.Value.ItemType};{item.Value.Quantity};{item.Value.Price};{item.Value.AvailableClass};{item.Value.RequiredLevel};{item.Value.AddedATK};{item.Value.AddedDEF}");
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
