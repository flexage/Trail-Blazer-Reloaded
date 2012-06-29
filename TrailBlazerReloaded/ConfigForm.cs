using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrailBlazerReloaded
{
    public partial class ConfigForm : Form
    {
        public Config ConfigFile;
        private readonly List<string> _folderpath = new List<string>();
        private readonly List<Config.Definition> _def = new List<Config.Definition>(); 
        /*
                private readonly string[] _defaultPath = new string [1] { "C:\\thereisnowaythispathexists\\" };
        */


        public ConfigForm(Config config)
        {
            InitializeComponent();
            ConfigFile = config;
            NewInstance();
            CheckConfig();
            //messages
        }

        private void NewInstance()
        {
            ConfigFile = new Config();
        }

        private void SaveCollection()
        {
            foreach (string item in listboxCollectionFolders.Items)
            {
                _folderpath.Add(item);
            }

            ConfigFile.CollectionPaths = _folderpath.ToArray();
        }

        private void SaveDefintion()
        {
            for (var i = 0; i < checkedlistboxDefinitions.Items.Count; i++)
            {
                var def = new Config.Definition
                              {
                                  Type = checkedlistboxDefinitions.Items[i].ToString(),
                                  Active = checkedlistboxDefinitions.GetItemChecked(i)
                              };

                _def.Add(def);
            }

            ConfigFile.DefinitionsCollection = _def.ToArray();

            //_configFile.DefinitionsCollection = _definitions;
        }

        private void SaveTrailerFolder()
        {
            ConfigFile.TrailerPath = txtTop10.Text;
        }

        private void CheckConfig()
        {
            ConfigFile = ConfigFile.ReadConfig();

            if (ConfigFile == null)
                return;

            if (ConfigFile.CollectionPaths != null && ConfigFile.CollectionPaths.Count() != 0)
            {
                foreach (var collectionPath in ConfigFile.CollectionPaths.Where(collectionPath => collectionPath != ""))
                {
                    listboxCollectionFolders.Items.Add(collectionPath);
                }
            }

            if (ConfigFile.TrailerPath != null && ConfigFile.TrailerPath != "")
            {
                txtTop10.Text = ConfigFile.TrailerPath;
            }

            foreach (var def in ConfigFile.DefinitionsCollection)
            {
                checkedlistboxDefinitions.Items.Add(def.Type, def.Active);
            }
        }

        private void BtnSaveConfigClick(object sender, EventArgs e)
        {

            SaveCollection();
            SaveDefintion();
            SaveTrailerFolder();
            ConfigFile.WriteConfig(ConfigFile);
            Close();
            Dispose();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            var folderResult = folderBrowserDialog1.ShowDialog();
            if (folderResult == DialogResult.OK)
            {
                listboxCollectionFolders.Items.Add(folderBrowserDialog1.SelectedPath);
            }
        }

        private void BtnTop10BrowseClick(object sender, EventArgs e)
        {
            var top10Result = folderTop10.ShowDialog();
            if (top10Result == DialogResult.OK)
            {
                txtTop10.Text = folderTop10.SelectedPath;
            }
        }

        private void Button2Click(object sender, EventArgs e)
        {
            var index = listboxCollectionFolders.SelectedIndex;

            if (index != -1)
            {
                listboxCollectionFolders.Items.RemoveAt(index);
            }
        }

        

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (checkedlistboxDefinitions.SelectedItem == null || checkedlistboxDefinitions.SelectedIndex < 0)
                return; // No selected item - nothing to do

            //Check for checked
            var _checked = checkedlistboxDefinitions.GetItemChecked(checkedlistboxDefinitions.SelectedIndex);

            // Calculate new index using move direction
            int newIndex = checkedlistboxDefinitions.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= checkedlistboxDefinitions.Items.Count)
                return; // Index out of range - nothing to do

            object selected = checkedlistboxDefinitions.SelectedItem;

            // Removing removable element
            checkedlistboxDefinitions.Items.Remove(selected);
            // Insert it in new position
            checkedlistboxDefinitions.Items.Insert(newIndex, selected);
            // Restore selection
            checkedlistboxDefinitions.SetSelected(newIndex, true);

            if (_checked)
                checkedlistboxDefinitions.SetItemCheckState(newIndex,CheckState.Checked);
        }

        public void MoveItemWebsite(int direction)
        {
            // Checking selected item
            if (checkedlistboxDefinitions.SelectedItem == null || checkedlistboxDefinitions.SelectedIndex < 0)
                return; // No selected item - nothing to do

            //Check for checked
            var _checked = checkedlistboxDefinitions.GetItemChecked(checkedlistboxDefinitions.SelectedIndex);

            // Calculate new index using move direction
            int newIndex = checkedlistboxDefinitions.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= checkedlistboxDefinitions.Items.Count)
                return; // Index out of range - nothing to do

            object selected = checkedlistboxDefinitions.SelectedItem;

            // Removing removable element
            checkedlistboxDefinitions.Items.Remove(selected);
            // Insert it in new position
            checkedlistboxDefinitions.Items.Insert(newIndex, selected);
            // Restore selection
            checkedlistboxDefinitions.SetSelected(newIndex, true);

            if (_checked)
                checkedlistboxDefinitions.SetItemCheckState(newIndex, CheckState.Checked);
        }

        private void DownBtnClick(object sender, EventArgs e)
        {
            MoveItem(+1);
        }
        private void UpBtnClick(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void MoveDownWebsite_Click(object sender, EventArgs e)
        {
            MoveItemWebsite(+1);
        }

        private void MoveUpWebsite_Click(object sender, EventArgs e)
        {
            MoveItemWebsite(-1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
    

