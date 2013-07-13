/*
 * Created by SharpDevelop.
 * User: Leon
 * Date: 13/07/2013
 * Time: 08:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace vzMassEsper
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public static List<string> macroList = new List<string>();
		public static List<string> contactList = new List<string>();
		
		public static string MACROFILE = "macros.txt";
		public static string CONTACTFILE = "contacts.txt";
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			waSetup();
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			// Populate macros:
			loadMacrosFromTextFile();
			macroLbx.DataSource = macroList;
			
			loadContactsFromTextFile();
			contactLbx.DataSource = contactList;
			
			// Set tooltips:
			System.Windows.Forms.ToolTip macroLbxTtp = new System.Windows.Forms.ToolTip();
   			macroLbxTtp.SetToolTip(this.macroLbx, "This is the macro list. Single-click to select. Right-click to edit.");
   			
   			System.Windows.Forms.ToolTip contactLbxTtp = new System.Windows.Forms.ToolTip();
   			contactLbxTtp.SetToolTip(this.contactLbx, "This is the contacts list. Single-click to select. Right-click to edit.");
   			
   			System.Windows.Forms.ToolTip allTextTbxTtp = new System.Windows.Forms.ToolTip();
   			allTextTbxTtp.SetToolTip(this.allTextTbx, "When you click the Get All Text button, the text from the VZones client will appear here.");
   			
		}
		
		private void loadMacrosFromTextFile() {
			if ( File.Exists(MACROFILE) ){
				var macroFile = File.ReadAllLines(MACROFILE);
				List<string> tempMacroList = new List<string>(macroFile);
				foreach (string macro in tempMacroList) {
					macroList.Add(macro);
				}
			}		
		}// loadMacrosFromTextFile
		
		private void loadContactsFromTextFile() {
			if ( File.Exists(CONTACTFILE) ){
				var contactFile = File.ReadAllLines(CONTACTFILE);
				List<string> tempContactList = new List<string>(contactFile);
				foreach (string macro in tempContactList) {
					contactList.Add(macro);
				}
			}		
		}// loadMacrosFromTextFile
		
		void MainFormActivated(object sender, EventArgs e)
		{
			macroLbx.DataSource = null;
			macroLbx.DataSource = macroList;
			
			contactLbx.DataSource = null;
			contactLbx.DataSource = contactList;
		}
		
		void MacroLbxContextAddClick(object sender, System.EventArgs e)
		{
			MacroEditorForm myMacroEditorForm = new MacroEditorForm();
			myMacroEditorForm.itemToEdit = -1;
			myMacroEditorForm.ShowDialog();
		}
		
		void ContactLbxContextAddClick(object sender, EventArgs e)
		{
			string dialogPrompt = "Enter name of new contact";
			string inputText = "";
			if (GenericDialogs.InputBox("Add contact", dialogPrompt, ref inputText) == DialogResult.OK) {
				
				contactList.Add(inputText);
				File.WriteAllLines(CONTACTFILE, contactList);
				
				contactLbx.DataSource = null;
				contactLbx.DataSource = contactList;

			}
		}
		
		void MacroLbxContextDeleteClick(object sender, System.EventArgs e)
		{
			Int32 macroIndex = macroLbx.SelectedIndex;
			
			macroList.RemoveAt(macroIndex);
			File.WriteAllLines(MainForm.MACROFILE, MainForm.macroList);	
			if (macroList.Count > 0) {
				macroLbx.SelectedIndex = 0;
			} else {
				macroLbx.ClearSelected();
			}
			macroLbx.DataSource = null;
			if (macroList.Count > 0) {
				macroLbx.DataSource = macroList;
			}
		}
		
		void ContactLbxContextDeleteClick(object sender, EventArgs e)
		{
			Int32 contactIndex = contactLbx.SelectedIndex;
			
			contactList.RemoveAt(contactIndex);
			File.WriteAllLines(MainForm.CONTACTFILE, MainForm.contactList);	
			if (contactList.Count > 0) {
				contactLbx.SelectedIndex = 0;
			} else {
				contactLbx.ClearSelected();
			}
			contactLbx.DataSource = null;
			if (contactList.Count > 0) {
				contactLbx.DataSource = contactList;
			}
		}
		
		void MacroLbxContextEditClick(object sender, System.EventArgs e)
		{
			MacroEditorForm myMacroEditorForm = new MacroEditorForm();
			myMacroEditorForm.itemToEdit = macroLbx.SelectedIndex;
			myMacroEditorForm.ShowDialog();
		}

		void ContactLbxContextEditClick(object sender, EventArgs e)
		{
			if (contactList.Count > 0) {
				Int32 contactToEditIndex = contactLbx.SelectedIndex;
				string inputText = contactLbx.SelectedItem.ToString();
				string dialogPrompt = "Change contact name";
				if (GenericDialogs.InputBox("Edit contact", dialogPrompt, ref inputText) == DialogResult.OK) {
					
					contactList[contactToEditIndex] = inputText;
					File.WriteAllLines(CONTACTFILE, contactList);
					
					contactLbx.DataSource = null;
					contactLbx.DataSource = contactList;
	
				}

				
			}
		}

		void EspSelectedBtnClick(object sender, System.EventArgs e)
		{
			if ( macroLbx.SelectedItem != null && contactLbx.SelectedItem != null) {
				string macroString = macroLbx.SelectedItem.ToString();
				string recipient = contactLbx.SelectedItem.ToString();
				if ( macroString.Contains("//") ) {
					// Split macroLines into a list, using "//" as the split string:
			    	string[] macroLines = macroString.Split(new string[] { "//" }, StringSplitOptions.None);
			    	foreach (string macroLine in macroLines) {
			    		waEspChunked(macroLine, recipient);
			    	}
				} else {
					waEspChunked(macroString, recipient);
				}
			}
		}//EspBtnClick
		

		
		void EspAllBtnClick(object sender, EventArgs e)
		{
			if ( macroLbx.SelectedItem != null ) {			
				string macroString = macroLbx.SelectedItem.ToString();
				foreach (string recipient in contactList) {
					if (recipient != "") {
						if ( macroString.Contains("//") ) {
							// Split macroLines into a list, using "//" as the split string:
				    		string[] macroLines = macroString.Split(new string[] { "//" }, StringSplitOptions.None);
				    		foreach (string macroLine in macroLines) {
				    			waEspChunked(macroLine, recipient);
				    		}
						} else {
							waEspChunked(macroString, recipient);
						}
					}//if (recipient != "")
				}//foreach...
			}//if ( macroLbx.SelectedItem != null )
		}//EspAllBtnClick
		
		void ProcessBufferTmrTick(object sender, EventArgs e)
		{
			processBufferItem();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				waWrapup();
				for (double myOpacity = 1.00; myOpacity >= 0.08; myOpacity = myOpacity - 0.04) {
					this.Opacity = myOpacity;
					this.Refresh();
					System.Threading.Thread.Sleep(20);
				}
			} else {
				e.Cancel = true;	
			}
		}//MainFormFormClosing
		
		void GetAllTextBtnClick(object sender, EventArgs e)
		{
			waGet();
		}
		
		void AllTextTbxTextChanged(object sender, EventArgs e)
		{
			allTextTbx.SelectionStart = allTextTbx.Text.Length;
			allTextTbx.ScrollToCaret();
            allTextTbx.Refresh();
		}
	}
}
