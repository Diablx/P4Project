namespace MainApp.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.Add_Car = new System.Windows.Forms.Button();
            this.AddAuction_Button = new System.Windows.Forms.Button();
            this.AuctionsView_Button = new System.Windows.Forms.Button();
            this.CarsView_Button = new System.Windows.Forms.Button();
            this.MainView_Button = new System.Windows.Forms.Button();
            this.Cars_Panel = new System.Windows.Forms.Panel();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.Cars_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.MenuPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Cars_Panel, 0, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.Add_Car);
            this.MenuPanel.Controls.Add(this.AddAuction_Button);
            this.MenuPanel.Controls.Add(this.AuctionsView_Button);
            this.MenuPanel.Controls.Add(this.CarsView_Button);
            this.MenuPanel.Controls.Add(this.MainView_Button);
            resources.ApplyResources(this.MenuPanel, "MenuPanel");
            this.MenuPanel.Name = "MenuPanel";
            // 
            // Add_Car
            // 
            resources.ApplyResources(this.Add_Car, "Add_Car");
            this.Add_Car.Name = "Add_Car";
            this.Add_Car.UseVisualStyleBackColor = true;
            this.Add_Car.Click += new System.EventHandler(this.Add_Car_Click);
            // 
            // AddAuction_Button
            // 
            resources.ApplyResources(this.AddAuction_Button, "AddAuction_Button");
            this.AddAuction_Button.Name = "AddAuction_Button";
            this.AddAuction_Button.UseVisualStyleBackColor = true;
            this.AddAuction_Button.Click += new System.EventHandler(this.RentViewButton_Click);
            // 
            // AuctionsView_Button
            // 
            resources.ApplyResources(this.AuctionsView_Button, "AuctionsView_Button");
            this.AuctionsView_Button.Name = "AuctionsView_Button";
            this.AuctionsView_Button.UseVisualStyleBackColor = true;
            this.AuctionsView_Button.Click += new System.EventHandler(this.AuctionsViewButton_Click);
            // 
            // CarsView_Button
            // 
            resources.ApplyResources(this.CarsView_Button, "CarsView_Button");
            this.CarsView_Button.Name = "CarsView_Button";
            this.CarsView_Button.UseVisualStyleBackColor = true;
            this.CarsView_Button.Click += new System.EventHandler(this.CarsViewButton_Click);
            // 
            // MainView_Button
            // 
            resources.ApplyResources(this.MainView_Button, "MainView_Button");
            this.MainView_Button.Name = "MainView_Button";
            this.MainView_Button.UseVisualStyleBackColor = true;
            this.MainView_Button.Click += new System.EventHandler(this.MainViewButton_Click);
            // 
            // Cars_Panel
            // 
            this.Cars_Panel.Controls.Add(this.ListView1);
            resources.ApplyResources(this.Cars_Panel, "Cars_Panel");
            this.Cars_Panel.Name = "Cars_Panel";
            // 
            // ListView1
            // 
            resources.ApplyResources(this.ListView1, "ListView1");
            this.ListView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ListView1.HideSelection = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.List;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.Cars_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button AddAuction_Button;
        private System.Windows.Forms.Button AuctionsView_Button;
        private System.Windows.Forms.Button CarsView_Button;
        private System.Windows.Forms.Button MainView_Button;
        private System.Windows.Forms.Panel Cars_Panel;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.Button Add_Car;
    }
}