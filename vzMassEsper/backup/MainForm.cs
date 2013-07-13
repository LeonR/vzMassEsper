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
using System.Timers;
using System.Diagnostics;

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
		private string initialisationString = "vzMassEsper initialised!";
		private string hostAvatarName;
		private static List<string> yoMamaList = new List<string>(); 
		private static List<string> yoMamaPhrases = new List<string>(); 
		
		private System.Timers.Timer postInitTmr = new System.Timers.Timer();
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			waSetup();
			announceInitialisation();
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
   			
   			yoMamaList.Add("Wort");
   			
   			yoMamaPhrases.Add("Yo mama's teeth so yellow, traffic slows down when she smiles!");
   			yoMamaPhrases.Add("Yo mama so ugly, when she joined an ugly contest, they said, 'Sorry, no professionals!'");
   			yoMamaPhrases.Add("Yo mama so stupid, she returned her ice cream because it was cold!");
   			yoMamaPhrases.Add("Yo mama so ugly, she made an onion cry!");
   			yoMamaPhrases.Add("Yo mama so stupid, she thought a quarterback was a refund.");
   			yoMamaPhrases.Add("Yo mama so fat, I took a picture of her last Christmas and it's still printing!");
   			yoMamaPhrases.Add("Yo mama so fat, she got arrested at the airport for having ten pounds of crack");
   			yoMamaPhrases.Add("Yo mama so fat, she wore a yellow raincoat and people yelled, 'Taxi!'");
   			yoMamaPhrases.Add("Yo mama so fat, she put on her lipstick with a paint-roller!");
   			yoMamaPhrases.Add("Yo mama so fat, her beeper went off and people thought she was backing up!");
   			
		}// MainFormLoad
		
		private void announceInitialisation() {
        	waSay(initialisationString);
        	waGet();
        	
			// Set up a timer, which, when elapsed, will call getHostName().
			// The timer allows waGet() to finish processing.
        	// postInitTmr has been declared at the class level so that its state can be changed in its event handler.
			postInitTmr.Interval = 1000; // Interval in milliseconds
			postInitTmr.AutoReset = true; // If false, stops it from repeating
			postInitTmr.Elapsed += new ElapsedEventHandler(postInitTmrElapsed);
			postInitTmr.Enabled = true;
			postInitTmr.Start();
        }
        
		void postInitTmrElapsed(object sender, ElapsedEventArgs e)
		{
			// Only attempt to grab the host if the comms buffer is quiet, meaning that waGet() has finished processing.
			if(commsBufferTable.Rows.Count == 0) {
				postInitTmr.AutoReset = false;
				postInitTmr.Enabled = false;
				getHostName();
			}
		}
		
		private void getHostName() {
        	hostAvatarName = GetHostNameByInitString(allText, initialisationString);
        	if(hostAvatarName != "") {
        		if(DEBUG_ON) {
					Debug.WriteLine("I think the host is: " + hostAvatarName);
        		}
				//waSay("Your spammer is " + hostAvatarName + ".");
        	}
        }
		
		public static string GetHostNameByInitString(string allText, string initString) {
			string initLine = FindFirstLineInMessagesContaining(allText, initString);
			string hostName = "";
			if(initLine != "") {
				Int32 posOfInitString = initLine.IndexOf(initString);
				if(posOfInitString > -1) {
					hostName = initLine.Substring(0, posOfInitString - 2);
				}
			}
			return hostName;
		}
		
		protected static string FindFirstLineInMessagesContaining(string allText, string matchText) {
			string[] messagesArray = allText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			string matchingLine = "";
			foreach (string message in messagesArray) {
				if( message.Contains(matchText) ) {
					matchingLine = message;
				}
			}
			if(matchingLine != "") {
				return matchingLine;
			} else {
				return "";  // We might want to give this a different return value later.
			}
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
						bool addYoMamaBool = yoMamaList.Contains(hostAvatarName);
						if ( macroString.Contains("//") ) {
							// Split macroLines into a list, using "//" as the split string:
				    		string[] macroLines = macroString.Split(new string[] { "//" }, StringSplitOptions.None);
				    		foreach (string macroLine in macroLines) {
				    			waEspChunked(macroLine, recipient);
				    			if(addYoMamaBool) {
				    				addYoMama(recipient);
				    			}
				    		}
						} else {
							waEspChunked(macroString, recipient);
							if(addYoMamaBool) {
				    			addYoMama(recipient);
				    		}
						}
					}//if (recipient != "")
				}//foreach...
			}//if ( macroLbx.SelectedItem != null )
		}//EspAllBtnClick
		
		private void addYoMama(string recipient) {
			string yoMamaPhrase = getYoMamaPhrase();
			waEspChunked(yoMamaPhrase, recipient);
		}
		
		private string getYoMamaPhrase() {
			yoMamaPhrases.FisherYatesShuffle();
			string chosenPhrase = yoMamaPhrases[0];
			return chosenPhrase;
		}
		
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
		
		private void ContactLbxMouseDown(object sender, MouseEventArgs e)
		{
			// Select the item under the mouse when clicked (including right-clicks).
			// If that selected nothing, select the first item.
			contactLbx.SelectedIndex = contactLbx.IndexFromPoint(e.X, e.Y);
			 if (contactLbx.SelectedIndex == -1 && contactList.Count > 0) {
			 	contactLbx.SelectedIndex = 0;
			 }
		}
		
		void MacroLbxMouseDown(object sender, MouseEventArgs e)
		{
			// Select the item under the mouse when clicked (including right-clicks).
			// If that selected nothing, select the first item.
			macroLbx.SelectedIndex = macroLbx.IndexFromPoint(e.X, e.Y);
			if (macroLbx.SelectedIndex == -1 && macroList.Count > 0) {
			 	macroLbx.SelectedIndex = 0;
			}
		}
	}
}
