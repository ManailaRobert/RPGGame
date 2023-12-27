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
    public partial class Inventory : Form
    {

        public void UpdateDetalii()
        {
            for (int i = 0; i < LB_Inventory.Items.Count; i++)
            {
                if (LB_Inventory.GetSelected(i))
                {
                    string selectedElement = LB_Inventory.Items[i].ToString();
                    string[] details = selectedElement.Split(' ');
                    int id = Convert.ToInt32(details[0]);

                    TB_Detalii.Text = $"" +
                        $"\t{FightingScene.date.GameManager.InventoryItemList[id].Name}" + Environment.NewLine +
                        $"Type: {FightingScene.date.GameManager.InventoryItemList[id].ItemType}" + Environment.NewLine +
                        $"Class: {FightingScene.date.GameManager.InventoryItemList[id].AvailableClass} " + Environment.NewLine +
                        $"Required Level: {FightingScene.date.GameManager.InventoryItemList[id].RequiredLevel}" + Environment.NewLine;

                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedDEF != 0)
                    TB_Detalii.Text = TB_Detalii.Text + $"DEF: {FightingScene.date.GameManager.InventoryItemList[id].AddedDEF}" + Environment.NewLine;
                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedATK != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $"ATK: {FightingScene.date.GameManager.InventoryItemList[id].AddedATK}";
                }
            }
        }
        public Inventory()
        {
            InitializeComponent();
        }
        public void LoadInventoryList()
        {
            foreach (var item in FightingScene.date.GameManager.Player.InventoryList)
            {
                try
                {
                    FightingScene.date.GameManager.InventoryItemList.Add(item.Key, item.Value);
                }
                catch { }
            }
        }
        public void LoadInventory()
        {
            foreach (var item in FightingScene.date.GameManager.InventoryItemList)
            {
                LB_Inventory.Items.Add($"{item.Key} {item.Value.Name}");
            }
        }
        private void ShowEquippedItems()
        {
            //HeadGear,ChestPiece,Leggings,Boots
            if (FightingScene.date.GameManager.Player.Equipment["HeadGear"] != 0)
            {
                int id = FightingScene.date.GameManager.Player.Equipment["HeadGear"];
                LB_HeadGear.Text = FightingScene.date.GameManager.Player.InventoryList[id].Name;
            }
            else LB_HeadGear.Text = "Empty";

            if (FightingScene.date.GameManager.Player.Equipment["ChestPiece"] != 0)
            {
                int id = FightingScene.date.GameManager.Player.Equipment["ChestPiece"];
                LB_ChestPiece.Text = FightingScene.date.GameManager.Player.InventoryList[id].Name;
            }
            else LB_ChestPiece.Text = "Empty";

            if (FightingScene.date.GameManager.Player.Equipment["Leggings"] != 0)
            {
                int id = FightingScene.date.GameManager.Player.Equipment["Leggings"];
                LB_Leggings.Text = FightingScene.date.GameManager.Player.InventoryList[id].Name;
            }
            else LB_Leggings.Text = "Empty";

            if (FightingScene.date.GameManager.Player.Equipment["Boots"] != 0)
            {
                int id = FightingScene.date.GameManager.Player.Equipment["Boots"];
                LB_Boots.Text = FightingScene.date.GameManager.Player.InventoryList[id].Name;
            }
            else LB_Boots.Text = "Empty";

            if (FightingScene.date.GameManager.Player.Equipment["Main"] != 0)
            {
                int id = FightingScene.date.GameManager.Player.Equipment["Main"];
                LB_Main.Text = FightingScene.date.GameManager.Player.InventoryList[id].Name;
            }
            else LB_Main.Text = "Empty";

            if (FightingScene.date.GameManager.Player.Equipment["OffHand"] != 0)
            {
                int id = FightingScene.date.GameManager.Player.Equipment["OffHand"];
                LB_OffHand.Text = FightingScene.date.GameManager.Player.InventoryList[id].Name;
            }
            else LB_OffHand.Text = "Empty";
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryList();
            LoadInventory();
            ShowEquippedItems();
        }
        private void LB_Inventory_SelectedValueChanged(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            UpdateDetalii();
        }

        //BTN Clicks
        private void BTN_Equip_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LB_Inventory.Items.Count; i++)
            {
                if(LB_Inventory.GetSelected(i))
                {
                    string[] item = LB_Inventory.Items[i].ToString().Split();
                    int id = Convert.ToInt32(item[0]);
                    //itemClass = Armor,Weapon(1H),Weapon(2H),OffHand
                    //type = HeadGear,ChestPiece,Leggings,Boots,Sword / GreatSword(2H) / Bow(2) / Axe(2H),Shield(OffHand)
                    switch (FightingScene.date.GameManager.Player.InventoryList[id].ItemClass)
                    {
                        case "Armor":
                            //checks if an item is equipped in that slot
                            //level check
                            if (FightingScene.date.GameManager.Player.Level >= FightingScene.date.GameManager.Player.InventoryList[id].RequiredLevel)
                            {
                                if (FightingScene.date.GameManager.Player.Equipment[FightingScene.date.GameManager.Player.InventoryList[id].ItemType] != 0)
                                    if (MessageBox.Show("Atentie itemele deja echipate vor fi date jos. Doriti sa continuati", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                        break;
                                    else
                                    {
                                        int curentId = FightingScene.date.GameManager.Player.Equipment[FightingScene.date.GameManager.Player.InventoryList[id].ItemType];
                                        FightingScene.date.GameManager.Player.AddedDEF -= FightingScene.date.GameManager.Player.InventoryList[curentId].AddedDEF;
                                    }
                                //equippes the item
                                FightingScene.date.GameManager.Player.Equipment[FightingScene.date.GameManager.Player.InventoryList[id].ItemType] = id;
                                //changes stats addedMXH;addedATK;addedSTR;addedDEX;addedSPD;addedDEF;
                                FightingScene.date.GameManager.Player.AddedDEF += FightingScene.date.GameManager.Player.InventoryList[id].AddedDEF;
                                //show items in labels
                                ShowEquippedItems();
                            }
                            else MessageBox.Show("Your level is too low for this item");
                            break;
                        case "Weapon(2H)": // for 2handers and 1h weapons
                                           //level check
                            if (FightingScene.date.GameManager.Player.Level >= FightingScene.date.GameManager.Player.InventoryList[id].RequiredLevel)
                            {
                                //checks if an item is equipped in that slot
                                if (FightingScene.date.GameManager.Player.Equipment["Main"] != 0 || FightingScene.date.GameManager.Player.Equipment["OffHand"] != 0)
                                    if (MessageBox.Show("Atentie itemele deja echipate vor fi date jos. Doriti sa continuati", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                        break;
                                    else
                                    {
                                        // deletes the added stats from Main and OffHand
                                        int curentId;
                                        if (FightingScene.date.GameManager.Player.Equipment["OffHand"] != 0)
                                        {
                                            curentId = FightingScene.date.GameManager.Player.Equipment["Main"];
                                            FightingScene.date.GameManager.Player.Attack -= FightingScene.date.GameManager.Player.InventoryList[curentId].AddedATK;
                                        }

                                        if (FightingScene.date.GameManager.Player.Equipment["OffHand"] != 0)
                                        {
                                            curentId = FightingScene.date.GameManager.Player.Equipment["OffHand"];
                                            FightingScene.date.GameManager.Player.Attack -= FightingScene.date.GameManager.Player.InventoryList[curentId].AddedATK;
                                        }
                                    }
                                //equippes the item
                                FightingScene.date.GameManager.Player.Equipment["Main"] = id;
                                FightingScene.date.GameManager.Player.Equipment["OffHand"] = id;
                                //changes stats addedMXH;addedATK;addedSTR;addedDEX;addedSPD;addedDEF;

                                FightingScene.date.GameManager.Player.Attack += FightingScene.date.GameManager.Player.InventoryList[id].AddedATK;
                                //show items in labels
                                ShowEquippedItems();
                            }
                            else MessageBox.Show($"Your level is too low for this item. Your level is{FightingScene.date.GameManager.Player.Level}");

                            break;
                        case "Weapon(1H)": // for 1h weapons
                                           //level check
                            if (FightingScene.date.GameManager.Player.Level >= FightingScene.date.GameManager.Player.InventoryList[id].RequiredLevel)
                            {
                                //checks if an item is equipped in that slot
                                if (FightingScene.date.GameManager.Player.Equipment["Main"] != 0)
                                    if (MessageBox.Show("Atentie itemele deja echipate vor fi date jos. Doriti sa continuati", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                        break;
                                    else
                                    {
                                        int curentId = FightingScene.date.GameManager.Player.Equipment["Main"];
                                        FightingScene.date.GameManager.Player.Attack -= FightingScene.date.GameManager.Player.InventoryList[curentId].AddedATK;
                                    }

                                //equippes the item
                                // if ids are similar desequipes the offhand 
                                if (FightingScene.date.GameManager.Player.Equipment["OffHand"] == FightingScene.date.GameManager.Player.Equipment["Main"])
                                    FightingScene.date.GameManager.Player.Equipment["OffHand"] = 0;

                                FightingScene.date.GameManager.Player.Equipment["Main"] = id;
                                //changes stats addedMXH;addedATK;addedSTR;addedDEX;addedSPD;addedDEF;
                                FightingScene.date.GameManager.Player.Attack += FightingScene.date.GameManager.Player.InventoryList[id].AddedATK;
                                //show items in labels
                                ShowEquippedItems();
                            }
                            else MessageBox.Show("Your level is too low for this item");

                            break;
                        case "OffHand": // for offhands
                                        //level check
                            if (FightingScene.date.GameManager.Player.Level >= FightingScene.date.GameManager.Player.InventoryList[id].RequiredLevel)
                            {
                                //checks if an item is equipped in that slot
                                if (FightingScene.date.GameManager.Player.Equipment["OffHand"] != 0)
                                    if (MessageBox.Show("Atentie itemele deja echipate vor fi date jos. Doriti sa continuati", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                        break;
                                    else
                                    {
                                        int curentId = FightingScene.date.GameManager.Player.Equipment["OffHand"];
                                        FightingScene.date.GameManager.Player.AddedDEF -= FightingScene.date.GameManager.Player.InventoryList[curentId].AddedDEF;
                                    }
                                //equippes the item
                                if (FightingScene.date.GameManager.Player.Equipment["OffHand"] == FightingScene.date.GameManager.Player.Equipment["Main"])
                                    FightingScene.date.GameManager.Player.Equipment["Main"] = 0;

                                FightingScene.date.GameManager.Player.Equipment["OffHand"] = id;
                                //changes stats addedMXH;addedATK;addedSTR;addedDEX;addedSPD;addedDEF;
                                FightingScene.date.GameManager.Player.AddedDEF += FightingScene.date.GameManager.Player.InventoryList[id].AddedDEF;
                                //show items in labels
                                ShowEquippedItems();
                            }
                            else MessageBox.Show("Your level is too low for this item");
                            break;
                    }
                       
                }
            }
        }

    }
}
