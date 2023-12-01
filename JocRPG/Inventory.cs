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
                        $"Type: {FightingScene.date.GameManager.InventoryItemList[id].Type}" + Environment.NewLine +
                        $"Class: {FightingScene.date.GameManager.InventoryItemList[id].AvailableClass} " + Environment.NewLine +
                        $"Required Level: {FightingScene.date.GameManager.InventoryItemList[id].RequiredLevel}" + Environment.NewLine+
                        $"Required Stats: {FightingScene.date.GameManager.InventoryItemList[id].Requirement + " " + FightingScene.date.GameManager.InventoryItemList[id].RequiredStat} " + Environment.NewLine;
                        

                    TB_Detalii.Text = TB_Detalii.Text + "(";
                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedMXH != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{FightingScene.date.GameManager.InventoryItemList[id].AddedMXH} MaxHealth";
                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedATK != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{FightingScene.date.GameManager.InventoryItemList[id].AddedATK} ATK";
                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedSTR != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{FightingScene.date.GameManager.InventoryItemList[id].AddedSTR} STR";
                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedDEX != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{FightingScene.date.GameManager.InventoryItemList[id].AddedDEX} DEX";
                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedSPD != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{FightingScene.date.GameManager.InventoryItemList[id].AddedSPD} SPD";
                    if (FightingScene.date.GameManager.InventoryItemList[id].AddedDEF != 0)
                        TB_Detalii.Text = TB_Detalii.Text + $" +{FightingScene.date.GameManager.InventoryItemList[id].AddedDEF} DEF";
                    TB_Detalii.Text = TB_Detalii.Text + " )";
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
               FightingScene.date.GameManager.InventoryItemList.Add(item.Key, item.Value);
            }
        }
        public void LoadInventory()
        {
            foreach (var item in FightingScene.date.GameManager.InventoryItemList)
            {
                LB_Inventory.Items.Add($"{item.Key} {item.Value.Name}");
            }
        }
        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadInventoryList();
            LoadInventory();
        }
        private void LB_Inventory_SelectedValueChanged(object sender, EventArgs e)
        {
            TB_Detalii.Visible = true;
            UpdateDetalii();
        }

        //BTN Clicks
        private void BTN_Equip_Click(object sender, EventArgs e)
        {

        }
        private void BTN_Unequip_Click(object sender, EventArgs e)
        {

        }
    }
}
