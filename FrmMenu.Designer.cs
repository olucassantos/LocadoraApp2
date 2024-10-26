namespace LocadoraApp2
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            stripMenu = new MenuStrip();
            midiasToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem = new ToolStripMenuItem();
            listaToolStripMenuItem = new ToolStripMenuItem();
            locaçõesToolStripMenuItem = new ToolStripMenuItem();
            novoToolStripMenuItem1 = new ToolStripMenuItem();
            listaToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            stripMenu.SuspendLayout();
            SuspendLayout();
            // 
            // stripMenu
            // 
            stripMenu.ImageScalingSize = new Size(20, 20);
            stripMenu.Items.AddRange(new ToolStripItem[] { midiasToolStripMenuItem, locaçõesToolStripMenuItem, sairToolStripMenuItem });
            stripMenu.Location = new Point(0, 0);
            stripMenu.Name = "stripMenu";
            stripMenu.Size = new Size(800, 28);
            stripMenu.TabIndex = 0;
            stripMenu.Text = "menuStrip1";
            // 
            // midiasToolStripMenuItem
            // 
            midiasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem, listaToolStripMenuItem });
            midiasToolStripMenuItem.Name = "midiasToolStripMenuItem";
            midiasToolStripMenuItem.Size = new Size(67, 24);
            midiasToolStripMenuItem.Text = "Midias";
            // 
            // novoToolStripMenuItem
            // 
            novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            novoToolStripMenuItem.Size = new Size(127, 26);
            novoToolStripMenuItem.Text = "Nova";
            novoToolStripMenuItem.Click += novoToolStripMenuItem_Click;
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Size = new Size(127, 26);
            listaToolStripMenuItem.Text = "Lista";
            listaToolStripMenuItem.Click += listaToolStripMenuItem_Click;
            // 
            // locaçõesToolStripMenuItem
            // 
            locaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoToolStripMenuItem1, listaToolStripMenuItem1 });
            locaçõesToolStripMenuItem.Name = "locaçõesToolStripMenuItem";
            locaçõesToolStripMenuItem.Size = new Size(84, 24);
            locaçõesToolStripMenuItem.Text = "Locações";
            // 
            // novoToolStripMenuItem1
            // 
            novoToolStripMenuItem1.Name = "novoToolStripMenuItem1";
            novoToolStripMenuItem1.Size = new Size(224, 26);
            novoToolStripMenuItem1.Text = "Nova";
            novoToolStripMenuItem1.Click += novoToolStripMenuItem1_Click;
            // 
            // listaToolStripMenuItem1
            // 
            listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            listaToolStripMenuItem1.Size = new Size(224, 26);
            listaToolStripMenuItem1.Text = "Lista";
            listaToolStripMenuItem1.Click += listaToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(48, 24);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stripMenu);
            MainMenuStrip = stripMenu;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Locadora App";
            stripMenu.ResumeLayout(false);
            stripMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip stripMenu;
        private ToolStripMenuItem midiasToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem;
        private ToolStripMenuItem locaçõesToolStripMenuItem;
        private ToolStripMenuItem novoToolStripMenuItem1;
        private ToolStripMenuItem listaToolStripMenuItem1;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}
