﻿using ObjectOrientedPractics.Services;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Serializer.IsCreateFolderAndFile();
        }
    }
}
