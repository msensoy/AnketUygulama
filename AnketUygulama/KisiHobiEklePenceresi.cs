using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AnketUygulama
{
    public partial class KisiHobiEklePenceresi : Form
    {
        List<Hobby> _hobbies;
        string[] _personHobbies;
        public string[] _personHobbiesNew;
        private List<string> _personHobbiesNewList;
        public KisiHobiEklePenceresi(List<Hobby> hobbies, string[] personHobbies)
        {
            InitializeComponent();
            _hobbies = hobbies;
            _personHobbies = personHobbies;
            HobileriCheckBoxYap();
        }

        private void HobileriCheckBoxYap()
        {
            flwPanel.Controls.Clear();
            for (int i = 0; i < _hobbies.Count; i++)
            {
                CheckBox checkBox = new CheckBox
                {
                    Height = 20,
                    Width = 80,
                    Checked = _personHobbies.Any(x => x == _hobbies[i].HobbyName) ? true : false,
                    Text = _hobbies[i].HobbyName
                };
                flwPanel.Controls.Add(checkBox);
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _personHobbiesNewList = new List<string>();
            foreach (CheckBox item in flwPanel.Controls)
            {
                if (item.Checked)
                {
                    _personHobbiesNewList.Add(item.Text);
                }
            }
            _personHobbiesNew = _personHobbiesNewList.ToArray();

        }
    }
}
