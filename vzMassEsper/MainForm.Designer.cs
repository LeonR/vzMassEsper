/*
 * Created by SharpDevelop.
 * User: Leon
 * Date: 13/07/2013
 * Time: 08:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace vzMassEsper
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.commsBufferDgv = new System.Windows.Forms.DataGridView();
			this.allTextTbx = new System.Windows.Forms.TextBox();
			this.macroLbx = new System.Windows.Forms.ListBox();
			this.macroLbxCms = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.macroLbxContextAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.macroLbxContextEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.macroLbxContextDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.contactLbx = new System.Windows.Forms.ListBox();
			this.contactLbxCms = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contactLbxContextAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.contactLbxContextEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.contactLbxContextDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.macrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.espSelectedBtn = new System.Windows.Forms.Button();
			this.espAllBtn = new System.Windows.Forms.Button();
			this.getAllTextBtn = new System.Windows.Forms.Button();
			this.processBufferTmr = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.commsBufferDgv)).BeginInit();
			this.macroLbxCms.SuspendLayout();
			this.contactLbxCms.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// commsBufferDgv
			// 
			this.commsBufferDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.commsBufferDgv.Location = new System.Drawing.Point(140, 62);
			this.commsBufferDgv.Name = "commsBufferDgv";
			this.commsBufferDgv.Size = new System.Drawing.Size(182, 108);
			this.commsBufferDgv.TabIndex = 0;
			// 
			// allTextTbx
			// 
			this.allTextTbx.Location = new System.Drawing.Point(12, 261);
			this.allTextTbx.Multiline = true;
			this.allTextTbx.Name = "allTextTbx";
			this.allTextTbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.allTextTbx.Size = new System.Drawing.Size(406, 156);
			this.allTextTbx.TabIndex = 1;
			this.allTextTbx.TextChanged += new System.EventHandler(this.AllTextTbxTextChanged);
			// 
			// macroLbx
			// 
			this.macroLbx.ContextMenuStrip = this.macroLbxCms;
			this.macroLbx.FormattingEnabled = true;
			this.macroLbx.Location = new System.Drawing.Point(12, 27);
			this.macroLbx.Name = "macroLbx";
			this.macroLbx.Size = new System.Drawing.Size(200, 199);
			this.macroLbx.TabIndex = 2;
			this.macroLbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MacroLbxMouseDown);
			// 
			// macroLbxCms
			// 
			this.macroLbxCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.macroLbxContextAdd,
									this.macroLbxContextEdit,
									this.macroLbxContextDelete});
			this.macroLbxCms.Name = "macroLbxCms";
			this.macroLbxCms.Size = new System.Drawing.Size(153, 92);
			// 
			// macroLbxContextAdd
			// 
			this.macroLbxContextAdd.Name = "macroLbxContextAdd";
			this.macroLbxContextAdd.Size = new System.Drawing.Size(152, 22);
			this.macroLbxContextAdd.Text = "Add..";
			this.macroLbxContextAdd.Click += new System.EventHandler(this.MacroLbxContextAddClick);
			// 
			// macroLbxContextEdit
			// 
			this.macroLbxContextEdit.Name = "macroLbxContextEdit";
			this.macroLbxContextEdit.Size = new System.Drawing.Size(152, 22);
			this.macroLbxContextEdit.Text = "Edit...";
			this.macroLbxContextEdit.Click += new System.EventHandler(this.MacroLbxContextEditClick);
			// 
			// macroLbxContextDelete
			// 
			this.macroLbxContextDelete.Name = "macroLbxContextDelete";
			this.macroLbxContextDelete.Size = new System.Drawing.Size(152, 22);
			this.macroLbxContextDelete.Text = "Delete";
			this.macroLbxContextDelete.Click += new System.EventHandler(this.MacroLbxContextDeleteClick);
			// 
			// contactLbx
			// 
			this.contactLbx.ContextMenuStrip = this.contactLbxCms;
			this.contactLbx.FormattingEnabled = true;
			this.contactLbx.Location = new System.Drawing.Point(218, 27);
			this.contactLbx.Name = "contactLbx";
			this.contactLbx.Size = new System.Drawing.Size(200, 199);
			this.contactLbx.TabIndex = 3;
			this.contactLbx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ContactLbxMouseDown);
			// 
			// contactLbxCms
			// 
			this.contactLbxCms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.contactLbxContextAdd,
									this.contactLbxContextEdit,
									this.contactLbxContextDelete});
			this.contactLbxCms.Name = "contactLbxCms";
			this.contactLbxCms.Size = new System.Drawing.Size(153, 92);
			// 
			// contactLbxContextAdd
			// 
			this.contactLbxContextAdd.Name = "contactLbxContextAdd";
			this.contactLbxContextAdd.Size = new System.Drawing.Size(152, 22);
			this.contactLbxContextAdd.Text = "Add...";
			this.contactLbxContextAdd.Click += new System.EventHandler(this.ContactLbxContextAddClick);
			// 
			// contactLbxContextEdit
			// 
			this.contactLbxContextEdit.Name = "contactLbxContextEdit";
			this.contactLbxContextEdit.Size = new System.Drawing.Size(152, 22);
			this.contactLbxContextEdit.Text = "Edit...";
			this.contactLbxContextEdit.Click += new System.EventHandler(this.ContactLbxContextEditClick);
			// 
			// contactLbxContextDelete
			// 
			this.contactLbxContextDelete.Name = "contactLbxContextDelete";
			this.contactLbxContextDelete.Size = new System.Drawing.Size(152, 22);
			this.contactLbxContextDelete.Text = "Delete";
			this.contactLbxContextDelete.Click += new System.EventHandler(this.ContactLbxContextDeleteClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.macrosToolStripMenuItem,
									this.contactsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(428, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// macrosToolStripMenuItem
			// 
			this.macrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem2,
									this.loadToolStripMenuItem2,
									this.saveToolStripMenuItem2,
									this.saveAsToolStripMenuItem2});
			this.macrosToolStripMenuItem.Name = "macrosToolStripMenuItem";
			this.macrosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.macrosToolStripMenuItem.Text = "Macros";
			// 
			// newToolStripMenuItem2
			// 
			this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
			this.newToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
			this.newToolStripMenuItem2.Text = "New";
			// 
			// loadToolStripMenuItem2
			// 
			this.loadToolStripMenuItem2.Name = "loadToolStripMenuItem2";
			this.loadToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
			this.loadToolStripMenuItem2.Text = "Load...";
			// 
			// saveToolStripMenuItem2
			// 
			this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
			this.saveToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
			this.saveToolStripMenuItem2.Text = "Save";
			// 
			// saveAsToolStripMenuItem2
			// 
			this.saveAsToolStripMenuItem2.Name = "saveAsToolStripMenuItem2";
			this.saveAsToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
			this.saveAsToolStripMenuItem2.Text = "Save As...";
			// 
			// contactsToolStripMenuItem
			// 
			this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem1,
									this.loadToolStripMenuItem1,
									this.saveToolStripMenuItem1,
									this.saveAsToolStripMenuItem1});
			this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
			this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.contactsToolStripMenuItem.Text = "Contacts";
			// 
			// newToolStripMenuItem1
			// 
			this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
			this.newToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
			this.newToolStripMenuItem1.Text = "New";
			// 
			// loadToolStripMenuItem1
			// 
			this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
			this.loadToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
			this.loadToolStripMenuItem1.Text = "Load...";
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			// 
			// saveAsToolStripMenuItem1
			// 
			this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
			this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
			this.saveAsToolStripMenuItem1.Text = "Save As...";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.aboutToolStripMenuItem.Text = "About...";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.loadToolStripMenuItem.Text = "Load...";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			// 
			// espSelectedBtn
			// 
			this.espSelectedBtn.Location = new System.Drawing.Point(218, 232);
			this.espSelectedBtn.Name = "espSelectedBtn";
			this.espSelectedBtn.Size = new System.Drawing.Size(95, 23);
			this.espSelectedBtn.TabIndex = 5;
			this.espSelectedBtn.Text = "ESP Selected";
			this.espSelectedBtn.UseVisualStyleBackColor = true;
			this.espSelectedBtn.Click += new System.EventHandler(this.EspSelectedBtnClick);
			// 
			// espAllBtn
			// 
			this.espAllBtn.Location = new System.Drawing.Point(323, 232);
			this.espAllBtn.Name = "espAllBtn";
			this.espAllBtn.Size = new System.Drawing.Size(95, 23);
			this.espAllBtn.TabIndex = 6;
			this.espAllBtn.Text = "ESP All";
			this.espAllBtn.UseVisualStyleBackColor = true;
			this.espAllBtn.Click += new System.EventHandler(this.EspAllBtnClick);
			// 
			// getAllTextBtn
			// 
			this.getAllTextBtn.Location = new System.Drawing.Point(12, 232);
			this.getAllTextBtn.Name = "getAllTextBtn";
			this.getAllTextBtn.Size = new System.Drawing.Size(199, 23);
			this.getAllTextBtn.TabIndex = 7;
			this.getAllTextBtn.Text = "Get All Text";
			this.getAllTextBtn.UseVisualStyleBackColor = true;
			this.getAllTextBtn.Click += new System.EventHandler(this.GetAllTextBtnClick);
			// 
			// processBufferTmr
			// 
			this.processBufferTmr.Enabled = true;
			this.processBufferTmr.Interval = 200;
			this.processBufferTmr.Tick += new System.EventHandler(this.ProcessBufferTmrTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 429);
			this.Controls.Add(this.contactLbx);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.espAllBtn);
			this.Controls.Add(this.macroLbx);
			this.Controls.Add(this.espSelectedBtn);
			this.Controls.Add(this.getAllTextBtn);
			this.Controls.Add(this.commsBufferDgv);
			this.Controls.Add(this.allTextTbx);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "vzMassEsper";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.commsBufferDgv)).EndInit();
			this.macroLbxCms.ResumeLayout(false);
			this.contactLbxCms.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer processBufferTmr;
		private System.Windows.Forms.Button getAllTextBtn;
		private System.Windows.Forms.Button espAllBtn;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem macrosToolStripMenuItem;
		private System.Windows.Forms.Button espSelectedBtn;
		private System.Windows.Forms.ToolStripMenuItem contactLbxContextDelete;
		private System.Windows.Forms.ToolStripMenuItem contactLbxContextEdit;
		private System.Windows.Forms.ToolStripMenuItem contactLbxContextAdd;
		private System.Windows.Forms.ContextMenuStrip contactLbxCms;
		private System.Windows.Forms.ToolStripMenuItem macroLbxContextDelete;
		private System.Windows.Forms.ToolStripMenuItem macroLbxContextEdit;
		private System.Windows.Forms.ToolStripMenuItem macroLbxContextAdd;
		private System.Windows.Forms.ContextMenuStrip macroLbxCms;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ListBox contactLbx;
		private System.Windows.Forms.ListBox macroLbx;
		private System.Windows.Forms.TextBox allTextTbx;
		private System.Windows.Forms.DataGridView commsBufferDgv;
		
		
		
	}//class MainForm
}//namespace
