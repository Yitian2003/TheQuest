using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateCharacters()
        {
            // update the player's position and stats
            player.Visible = true;
            player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            // update enemy's location and hit points.
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    batPic.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    ghostPic.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    ghoulPic.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (showBat) batPic.Visible = true;
            else batPic.Visible = false;
            if (showGhost) ghostPic.Visible = true;
            else ghostPic.Visible = false;
            if (showGhoul) ghoulPic.Visible = true;
            else ghoulPic.Visible = false;

            // update weaponInRoom' picturebox
            sword.Visible = false;
            bow.Visible = false;
            redPotion.Visible = false;
            bluePotion.Visible = false;
            mace.Visible = false;
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
                case "Blue Potion":
                    weaponControl = bluePotion;
                    break;
                case "Red Potion":
                    weaponControl = redPotion;
                    break;
            }
             weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp) weaponControl.Visible = false;
            else weaponControl.Visible = true;

            //check inventory picturebox
            if (game.CheckPlayerInventory("Sword")) inventorySword.Visible = true;
            else inventorySword.Visible = false;
            if (game.CheckPlayerInventory("Bow")) inventoryBow.Visible = true;
            else inventoryBow.Visible = false;
            if (game.CheckPlayerInventory("Mace")) inventoryMace.Visible = true;
            else inventoryMace.Visible = false;
            if (game.CheckPlayerInventory("Blue Potion")) inventoryBluePotion.Visible = true;
            else inventoryBluePotion.Visible = false;
            if (game.CheckPlayerInventory("Red Potion")) inventoryRedPotion.Visible = true;
            else inventoryRedPotion.Visible = false;
             switch (game.EquipWeapon())
            {
                case "Sword":
                    inventorySword.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "Bow":
                    inventoryBow.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "Mace":
                    inventoryMace.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "Blue Potion":
                    inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case "Red Potion":
                    inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
                    break;
            }

            //update attack button
            if ((inventoryBluePotion.BorderStyle == BorderStyle.FixedSingle) && inventoryBluePotion.Visible == true)
            {
                attackUp.Text = "Drink";
                attackRight.Visible = false;
                attackLeft.Visible = false;
                attackDown.Visible = false;
            }
            else
            {
                attackUp.Text = "↑";
                attackRight.Visible = true;
                attackLeft.Visible = true;
                attackDown.Visible = true;
            }

            if (game.PlayerHitPoints <=0)
            {
                timer1.Stop();
                MessageBox.Show("You died!");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                timer1.Stop();
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                this.Text = "The Quest - Level " + game.Level;
                timer1.Start();
                UpdateCharacters();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            Text = "The Quest - Level " + game.Level;
            UpdateCharacters();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up,random);
            UpdateCharacters();
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackUp_Click(object sender, EventArgs e)///?
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void attackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void attackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void attackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void inventorySword_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Sword")) game.Equip("Sword");
            inventoryReset();
            inventorySword.BorderStyle = BorderStyle.FixedSingle;
            UpdateCharacters();
        }

        private void inventoryBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow")) game.Equip("Bow");
            inventoryReset();
            inventoryBow.BorderStyle = BorderStyle.FixedSingle;
            UpdateCharacters();
        }

        private void inventoryReset()
        {
            inventorySword.BorderStyle = BorderStyle.None;
            inventoryBluePotion.BorderStyle = BorderStyle.None;
            inventoryBow.BorderStyle = BorderStyle.None;
            inventoryMace.BorderStyle = BorderStyle.None;
            inventoryRedPotion.BorderStyle = BorderStyle.None;
        }

        private void inventoryMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace")) game.Equip("Mace");
            inventoryReset();
            inventoryMace.BorderStyle = BorderStyle.FixedSingle;
            UpdateCharacters();
        }

        private void inventoryBluePotion_Click(object sender, EventArgs e)
        {
            attackUp.Text = "Drink";
            attackRight.Visible = false;
            attackLeft.Visible = false;
            attackDown.Visible = false;
            if (game.CheckPlayerInventory("Blue Potion")) game.Equip("Blue Potion");
            inventoryReset();
            inventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;
            UpdateCharacters();
        }

        private void inventoryRedPotion_Click(object sender, EventArgs e)
        {
            attackUp.Text = "Drink";
            attackRight.Visible = false;
            attackLeft.Visible = false;
            attackDown.Visible = false;
            if (game.CheckPlayerInventory("Red Potion")) game.Equip("Red Potion");
            inventoryReset();
            inventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
            UpdateCharacters();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
             {
                 case Keys.E:
                     game.Move(Direction.Up, random);
                     break;
                 case Keys.S:
                     game.Move(Direction.Left, random);
                     break;
                 case Keys.D:
                     game.Move(Direction.Down, random);
                     break;
                 case Keys.F:
                     game.Move(Direction.Right, random);
                     break;
                case Keys.Up:
                    game.Attack(Direction.Up, random);
                    break;
                case Keys.Down:
                    game.Attack(Direction.Down, random);
                    break;
                case Keys.Left:
                    game.Attack(Direction.Left, random);
                    break;
                case Keys.Right:
                    game.Attack(Direction.Right, random);
                    break;
            }
                 UpdateCharacters();
        }
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                e.IsInputKey = true;
                break;
            }
         }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                 case Keys.Up:
                    game.Attack(Direction.Up, random);
                    UpdateCharacters();
                    return true;
                case Keys.Down:
                    game.Attack(Direction.Down, random);
                    UpdateCharacters();
                    return true;
                case Keys.Left:
                    game.Attack(Direction.Left, random);
                    UpdateCharacters();
                    return true;
                case Keys.Right:
                    game.Attack(Direction.Right, random);
                    UpdateCharacters();
                    return true;
            }
           return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Enemy enemy in game.Enemies) enemy.Move(random);
            UpdateCharacters();
        }
    }
}
