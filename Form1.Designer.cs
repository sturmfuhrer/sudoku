namespace Sudoku
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MaindataGridView = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.новаГраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складністьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.легкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.середняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaindataGridView
            // 
            this.MaindataGridView.AllowUserToAddRows = false;
            this.MaindataGridView.AllowUserToDeleteRows = false;
            this.MaindataGridView.AllowUserToResizeColumns = false;
            this.MaindataGridView.AllowUserToResizeRows = false;
            this.MaindataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MaindataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaindataGridView.ColumnHeadersVisible = false;
            this.MaindataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaindataGridView.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MaindataGridView.Location = new System.Drawing.Point(0, 29);
            this.MaindataGridView.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaindataGridView.Name = "MaindataGridView";
            this.MaindataGridView.RowHeadersVisible = false;
            this.MaindataGridView.Size = new System.Drawing.Size(316, 317);
            this.MaindataGridView.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаГраToolStripMenuItem,
            this.складністьToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(18, 5, 0, 5);
            this.MainMenu.Size = new System.Drawing.Size(316, 29);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // новаГраToolStripMenuItem
            // 
            this.новаГраToolStripMenuItem.Name = "новаГраToolStripMenuItem";
            this.новаГраToolStripMenuItem.Size = new System.Drawing.Size(71, 19);
            this.новаГраToolStripMenuItem.Text = "Нова гра ";
            // 
            // складністьToolStripMenuItem
            // 
            this.складністьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.легкаToolStripMenuItem,
            this.середняToolStripMenuItem,
            this.складнаToolStripMenuItem});
            this.складністьToolStripMenuItem.Name = "складністьToolStripMenuItem";
            this.складністьToolStripMenuItem.Size = new System.Drawing.Size(79, 19);
            this.складністьToolStripMenuItem.Text = "Складність";
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // легкаToolStripMenuItem
            // 
            this.легкаToolStripMenuItem.Name = "легкаToolStripMenuItem";
            this.легкаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.легкаToolStripMenuItem.Text = "Легка";
            // 
            // середняToolStripMenuItem
            // 
            this.середняToolStripMenuItem.Name = "середняToolStripMenuItem";
            this.середняToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.середняToolStripMenuItem.Text = "Середня";
            // 
            // складнаToolStripMenuItem
            // 
            this.складнаToolStripMenuItem.Name = "складнаToolStripMenuItem";
            this.складнаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.складнаToolStripMenuItem.Text = "Складна";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 346);
            this.Controls.Add(this.MaindataGridView);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Судоку";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaindataGridView)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MaindataGridView;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem новаГраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складністьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem легкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem середняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складнаToolStripMenuItem;
    }
}

