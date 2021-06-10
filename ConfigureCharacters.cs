using Quiccent.Constants;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Quiccent
{
    public partial class ConfigureCharacters : Form
    {
        protected Accents Accents { get; set; } 

        protected object SelectedComboBoxItem { get; set; }

        public ConfigureCharacters(Accents accents)
        {
            InitializeComponent();

            InitializeAccents(accents);

            InitializeCharacterComboBox();

            InitializeSelectorLists();
        }

        private void InitializeSelectorLists()
        {
            CharacterSelector.AllowDrop = true;
            RemovedCharactersSelector.AllowDrop = true;
        }

        private void InitializeCharacterComboBox()
        {
            foreach (var character in Accents.Mappings.Keys)
            {
                if (!string.IsNullOrWhiteSpace(character))
                {
                    CharacterComboBox.Items.Add(character);
                }
            }

            CharacterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CharacterComboBox.SelectedItem = CharacterComboBox.Items[0];
            SelectedComboBoxItem = CharacterComboBox.SelectedItem;
        }

        private void InitializeAccents(Accents accents)
        {
            Accents = accents;
        }

        private void CharacterSelector_MouseDown(object sender, MouseEventArgs e)
        {
            if (CharacterSelector.SelectedItem == null)
            {
                return;
            }

            CharacterSelector.DoDragDrop(CharacterSelector.SelectedItem, DragDropEffects.Move);
        }

        private void CharacterSelector_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void CharacterSelector_DragDrop(object sender, DragEventArgs e)
        {
            var point = CharacterSelector.PointToClient(new Point(e.X, e.Y));
            var index = CharacterSelector.IndexFromPoint(point);

            if (index < 0)
            {
                index = CharacterSelector.Items.Count - 1;
            }
            
            var data = CharacterSelector.SelectedItem;

            CharacterSelector.Items.Remove(data);
            CharacterSelector.Items.Insert(index, data);
        }

        private void CharacterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CharacterSelector.Items.Count > 0 || RemovedCharactersSelector.Items.Count > 0)
            {
                SaveCurrentSelector();
            }

            SelectedComboBoxItem = CharacterComboBox.SelectedItem;

            RemovedCharactersSelector.Items.Clear();
            RemovedCharactersSelector.Items.AddRange(Accents.Mappings_Removed[(string)SelectedComboBoxItem].ToArray());

            CharacterSelector.Items.Clear();
            CharacterSelector.Items.AddRange(Accents.Mappings[(string)SelectedComboBoxItem].ToArray());
            CharacterSelector.Items.Remove((string)SelectedComboBoxItem);
        }

        private void SaveCurrentSelector()
        {
            Accents.Mappings[(string)SelectedComboBoxItem] = CharacterSelector.Items.Cast<string>().Concat(new List<string>() { (string)SelectedComboBoxItem }).ToList();
            Accents.Mappings_Removed[(string)SelectedComboBoxItem] = RemovedCharactersSelector.Items.Cast<string>().ToList();
        }

        private void SaveChangesToDisk()
        {
            Accents.Save();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var selectedItem = RemovedCharactersSelector.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            RemovedCharactersSelector.Items.Remove(selectedItem);

            CharacterSelector.Items.Add(selectedItem);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var selectedItem = CharacterSelector.SelectedItem;
            if (selectedItem == null)
            {
                return;
            }

            CharacterSelector.Items.Remove(selectedItem);

            RemovedCharactersSelector.Items.Add(selectedItem);
        }

        private void ConfigureCharacters_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CharacterSelector.Items.Count > 0 || RemovedCharactersSelector.Items.Count > 0)
            {
                SaveCurrentSelector();
            }

            SaveChangesToDisk();
        }
    }
}
