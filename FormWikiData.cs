using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
/* Chris Prickett 31/08/2022
   Wiki Data project build. Taking input from user in text box, radio button, combo box and multi line text box,
   adding that data to a list of type class and displaying the Name and Category in a ListView. Data can be added,
   edited, deleted, saved, opened and searched for. Clicking an item in the ListView will display the info to the
   correct area, and double clicking the Name text box will clear all info.*/

namespace WikiData
{
    public partial class FormWikiData : Form
    {
        public FormWikiData()
        {
            InitializeComponent();
        }
        //6.2 Create a global List<T> of type Information called Wiki. 
        List<Information> Wiki = new List<Information>();
        private string defaultSave = "definitions.bin";

        #region Utilities
        private void Status(int msg)
        {
            StatusStripMsg.Items.Clear();
            switch (msg)
            {
                case 0:
                    StatusStripMsg.Items.Add("Information Cleared");
                    break;
                case 1:
                    StatusStripMsg.Items.Add("Information missing or incorrectly entered");
                    break;
                case 2:
                    StatusStripMsg.Items.Add("Data not added. Please try again");
                    break;
                case 3:
                    StatusStripMsg.Items.Add("Combobox not populated. Error occured");
                    break;
                case 4:
                    StatusStripMsg.Items.Add("Save Successful");
                    break;
                case 5:
                    StatusStripMsg.Items.Add("Save Unsuccessful");
                    break;
                case 6:
                    StatusStripMsg.Items.Add("Open Successful");
                    break;
                case 7:
                    StatusStripMsg.Items.Add("Open Unsuccessful");
                    break;
                case 8:
                    StatusStripMsg.Items.Add("Data not displayed correctly.");
                    break;
                case 9:
                    StatusStripMsg.Items.Add("Edit Successful.");
                    break;
                case 10:
                    StatusStripMsg.Items.Add("Edit Unsuccessful");
                    break;
                case 11:
                    StatusStripMsg.Items.Add("Data Deleted");
                    break;
                case 12:
                    StatusStripMsg.Items.Add("Data NOT Deleted");
                    break;
                case 13:
                    StatusStripMsg.Items.Add("No item in search box.");
                    break;
                case 14:
                    StatusStripMsg.Items.Add("Target not found. Try again.");
                    break;
                case 15:
                    StatusStripMsg.Items.Add("Search failed. Try again.");
                    break;
                case 16:
                    StatusStripMsg.Items.Add("Duplicate name. Data not added.");
                    break;
            }
        }
        //6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button 
        private void ClearData()
        {
            TextBoxName.Clear();
            ComboBoxCategory.Text = "";
            RadioButtonLinear.Checked = false;
            RadioButtonNonLinear.Checked = false;
            TextBoxDefinition.Clear();
            TextBoxName.Focus();
        }
        /*6.9 Create a single custom method that will sort and then display the Name and
        Category from the wiki information in the list. */
        private void DisplayAllData()
        {
            ListViewData.Items.Clear();
            Wiki.Sort();
            foreach (var Information in Wiki)
            {
                ListViewItem item = new ListViewItem(Information.GetName());
                item.SubItems.Add(Information.GetCategory());
                ListViewData.Items.Add(item);
            }
        }
        /*6.4 Create a custom method to populate the ComboBox when the Form Load method is called.
        The six categories must be read from a simple text file. */
        private void FormWikiData_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader stream = new StreamReader(@".\Categories.txt");
                string line = stream.ReadLine();
                while (line != null)
                {
                    ComboBoxCategory.Items.Add(line);
                    line = stream.ReadLine();
                }
            }
            catch
            {
                Status(3);
            }
            TextBoxName.KeyPress += KeyLog;
            ComboBoxCategory.KeyPress += KeyLog;
            TextBoxDefinition.KeyPress += KeyLog;
            TextBoxSearch.KeyPress += KeyLog;
        }
        private void KeyLog(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
                if (!Char.IsControl(e.KeyChar))
                    if (!Char.IsWhiteSpace(e.KeyChar))
                        e.Handled = true;
        }
        /*6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        The first method must return a string value from the selected radio button (Linear or Non-Linear).
        The second method must send an integer index which will highlight an appropriate radio button. */
        private string Structure()
        {
            string radio = "";
            foreach (RadioButton rb in GroupBoxStructure.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    radio = rb.Text;
                    break;
                }
                else
                {
                    radio = "Other";
                }
            }
            return radio;
        }
        private void StructureInt(int var)
        {
            foreach (RadioButton rb in GroupBoxStructure.Controls.OfType<RadioButton>())
            {
                if (rb.Text == Wiki[var].GetStructure())
                {
                    rb.Checked = true;
                }
                else
                {
                    rb.Checked = false;
                }
            }
        }
        private void SaveRecord(string saveFileName)
        {
            try
            {
                using (Stream stream = File.Open(saveFileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var x in Wiki)
                        {
                            writer.Write(x.GetName());
                            writer.Write(x.GetStructure());
                            writer.Write(x.GetCategory());
                            writer.Write(x.GetDefinition());
                        }
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
                Status(5);
            }
        }
        private void OpenRecord(string loadFileName)
        {
            try
            {
                using (Stream stream = File.Open(loadFileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        Wiki.Clear();
                        while (stream.Position < stream.Length)
                        {
                            Information readWiki = new Information();
                            readWiki.SetName(reader.ReadString());
                            readWiki.SetCategory(reader.ReadString());
                            readWiki.SetStructure(reader.ReadString());
                            readWiki.SetDefinition(reader.ReadString());
                            Wiki.Add(readWiki);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.ToString());
                Status(7);
            }
            DisplayAllData();
        }
        /*6.5 Create a custom ValidName method which will take a parameter string value from the
        Textbox Name and returns a Boolean after checking for duplicates. Use the built in
        List<T> method “Exists” to answer this requirement. */
        private Boolean ValidName(string name)
        {
            return !Wiki.Exists(check => check.GetName().Equals(name));
        }
        #endregion Utilities
        #region GUI Interaction
        //6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button. 
        private void TextBoxName_DoubleClick(object sender, EventArgs e)
        {
            ClearData();
        }
        /*6.11 Create a ListView event so a user can select a Data Structure Name from the list of
        Names and the associated information will be displayed in the related text boxes combo box and radio button. */
        private void ListViewData_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int indx = ListViewData.SelectedIndices[0];
                TextBoxName.Text = Wiki[indx].GetName();
                StructureInt(indx);
                ComboBoxCategory.Text = Wiki[indx].GetCategory();
                TextBoxDefinition.Text = Wiki[indx].GetDefinition();
            }
            catch
            {
                Status(8);
            }
        }
        //6.15 The Wiki application will save data when the form closes.
        private void FormWikiData_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to save your data?", "Save Data?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SaveRecord(defaultSave);
            }
        }
        #endregion GUI Interaction
        #region Buttons
        /*6.3 Create a button method to ADD a new item to the list.
        Use a TextBox for the Name input, ComboBox for the Category, Radio group for the Structure and
        Multiline TextBox for the Definition. */
        private void ButtonAdd_MouseClick(object sender, MouseEventArgs e)
        {
            bool Valid = ValidName(TextBoxName.Text);
            if (Valid)
            {
                try
                {
                    if (TextBoxName.Text != string.Empty)
                    {
                        Information addInfo = new Information();
                        addInfo.SetName(TextBoxName.Text);
                        addInfo.SetCategory(ComboBoxCategory.Text);
                        addInfo.SetDefinition(TextBoxDefinition.Text);
                        addInfo.SetStructure(Structure());
                        Wiki.Add(addInfo);
                    }
                    else
                    {
                        Status(1);
                    }
                    ClearData();
                    DisplayAllData();
                }
                catch
                {
                    Status(2);
                }
            }
            else
            {
                Status(16);
            }
        }
        /*6.14 Create two buttons for the manual open and save option;
        this must use a dialog box to select a file or rename a saved file.
        All Wiki data is stored/retrieved using a binary reader/writer file format. */
        private void ButtonSave_MouseClick(object sender, MouseEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "bin file|*.bin";
            saveFileDialog.Title = "Save a BIN file";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.DefaultExt = "bin";
            saveFileDialog.ShowDialog();
            string fileName = saveFileDialog.FileName;
            if (saveFileDialog.FileName != "")
            {
                SaveRecord(fileName);
                Status(4);
            }
            else
            {
                SaveRecord(defaultSave);
                Status(4);
            }
        }
        private void ButtonOpen_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "BIN FILES|*.bin";
            openFileDialog.Title = "Open a BIN file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenRecord(openFileDialog.FileName);
                Status(6);
            }
        }
        /* 6.7 Create a button method that will delete the currently selected record in the ListView.
        Ensure the user has the option to backout of this action by using a dialog box.
        Display an updated version of the sorted list at the end of this process. */
        private void ButtonDelete_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int record = ListViewData.SelectedIndices[0];
                DialogResult del = MessageBox.Show("Delete selected data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    Wiki.Remove(Wiki[record]);
                    ClearData();
                    Status(11);
                }
                else
                {
                    MessageBox.Show("Data NOT Deleted", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Status(12);
                }
            }
            catch
            {
                Status(12);
            }
            ClearData();
            DisplayAllData();
        }
        /*6.8 Create a button method that will save the edited record of the currently
        selected item in the ListView. All the changes in the input controls will be
        written back to the list. Display an updated version of the sorted
        list at the end of this process. */
        private void ButtonEdit_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int edit = ListViewData.SelectedIndices[0];
                if (edit >= 0)
                {
                    if (!string.Equals(Wiki[edit], TextBoxName.Text)
                            || !string.Equals(Wiki[edit], ComboBoxCategory.Text)
                            || !string.Equals(Wiki[edit], Structure())
                            || !string.Equals(Wiki[edit], TextBoxDefinition.Text))
                    {
                        var res = MessageBox.Show("Edit Data?", "Edit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            Wiki[edit].SetName(TextBoxName.Text);
                            Wiki[edit].SetCategory(ComboBoxCategory.Text);
                            Wiki[edit].SetDefinition(TextBoxDefinition.Text);
                            Wiki[edit].SetStructure(Structure());
                            DisplayAllData();
                            ClearData();
                            Status(9);
                        }
                        else
                        {
                            Status(10);
                        }
                    }
                    else
                    {
                        Status(10);
                    }
                }
            }
            catch
            {
                Status(10);
            }
            ClearData();
            DisplayAllData();
        }
        /*6.10 Create a button method that will use the builtin binary search to find a Data Structure name.
        If the record is found the associated details will populate the appropriate input controls
        and highlight the name in the ListView. At the end of the search process the search
        input TextBox must be cleared. */
        private void ButtonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TextBoxSearch.Text))
                {
                    Information find = new Information();
                    find.SetName(TextBoxSearch.Text);
                    int found = Wiki.BinarySearch(find);
                    if (found >= 0)
                    {
                        ListViewData.SelectedItems.Clear();
                        ListViewData.Items[found].Selected = true;
                        ListViewData.Focus();
                        TextBoxName.Text = Wiki[found].GetName();
                        StructureInt(found);
                        ComboBoxCategory.Text = Wiki[found].GetCategory();
                        TextBoxDefinition.Text = Wiki[found].GetDefinition();
                    }
                    else
                    {
                        Status(14);
                    }
                }
            }
            catch
            {
                Status(15);
            }
            TextBoxSearch.Clear();
        }
        #endregion Buttons
    }
}
