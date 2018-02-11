using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma
{
    public partial class Form1 : Form
    {
        private EnigmaMachine enigmaMachine;
        private int lastLength = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enigmaMachine = new EnigmaMachine();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            int length = inputTextBox.Text.Length;
            outputTextBox.Text = enigmaMachine.Translate(inputTextBox.Text);

            bool controlsEnabled = length == 0;

            rotorPos1.Enabled = controlsEnabled;
            rotorPos2.Enabled = controlsEnabled;
            rotorPos3.Enabled = controlsEnabled;
            rotorBar1.Enabled = controlsEnabled;
            rotorBar2.Enabled = controlsEnabled;
            rotorBar3.Enabled = controlsEnabled;
            connectButton.Enabled = controlsEnabled;
            removeButton.Enabled = controlsEnabled;
        }

        private void rotorBar1_Scroll(object sender, EventArgs e)
        {
            enigmaMachine.SetRotor1(rotorBar1.Value);
        }

        private void rotorBar2_Scroll(object sender, EventArgs e)
        {
            enigmaMachine.SetRotor2(rotorBar2.Value);
        }

        private void rotorBar3_Scroll(object sender, EventArgs e)
        {
            enigmaMachine.SetRotor3(rotorBar3.Value);
        }

        private void rotorPos1_ValueChanged(object sender, EventArgs e)
        {
            enigmaMachine.SetRotorPosition((int)rotorPos3.Value, (int)rotorPos2.Value, (int)rotorPos1.Value);
        }

        private void rotorPos2_ValueChanged(object sender, EventArgs e)
        {
            enigmaMachine.SetRotorPosition((int)rotorPos3.Value, (int)rotorPos2.Value, (int)rotorPos1.Value);
        }

        private void rotorPos3_ValueChanged(object sender, EventArgs e)
        {
            enigmaMachine.SetRotorPosition((int)rotorPos3.Value, (int)rotorPos2.Value, (int)rotorPos1.Value);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            enigmaMachine.AddPlugboardConnection(leftPlugcomboBox.Text, rightPlugComboBox.Text);
            UpdateConnections();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            enigmaMachine.RemovePlugboardConnection((string)connectionListBox.SelectedItem);
            UpdateConnections();
        }

        private void UpdateConnections ()
        {
            connectionListBox.Items.Clear();
            foreach (string item in enigmaMachine.GetPlugboardConnections())
            {
                connectionListBox.Items.Add(item);
            }
        }
    }
}
