using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace LBracket
{
    public partial class Min_t : Form
    {
        public Min_t()
        {
            InitializeComponent();
        }

        private void uxCompute_Click(object sender, EventArgs e)
        {
            uxIDText.Text = "";
            uxMassText.Text = "";
            if (uxSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(uxSaveFileDialog.FileName))
                    {
                        double OD = Double.Parse(uxODText.Text);
                        double L1 = Double.Parse(uxL1Text.Text);
                        double L2 = Double.Parse(uxL2Text.Text);
                        double Sy = Double.Parse(uxSyText.Text);
                        double F = Double.Parse(uxFText.Text);
                        double ID = 0.0;
                        double sig = 0.0;
                        double tau = 0.0;
                        double sig1 = 0.0;
                        double sig3 = 0.0;
                        double sigVM = 0.0;
                        double FOS = 0.0;
                        double p = Math.PI;
                        sw.WriteLine("Thickness(in.)" + "\t\t\tID (in.)" + "\t\tOD (in.)" + "\t\tF.O.S" + "\t\t\tSig1 (psi)" + "\t\tSig2 (psi)" + "\tSigVM (psi)" + "\t\tSig (psi)");
                        for (double i = 0; i < 0.75; i = i + 0.001)
                        {
                            ID = i;
                            sig = (F * L1 * (OD / 2)) / ((p / 64) * (Math.Pow(OD, 4) - Math.Pow(ID, 4)));
                            tau = (F * L2 * (OD / 2)) / ((p / 32) * (Math.Pow(OD, 4) - Math.Pow(ID, 4)));
                            sig1 = (sig / 2) + Math.Sqrt(Math.Pow((sig / 2), 2) + Math.Pow(tau, 2));
                            sig3 = (sig / 2) - Math.Sqrt(Math.Pow((sig / 2), 2) + Math.Pow(tau, 2));
                            sigVM = Math.Sqrt(Math.Pow(sig1, 2) + Math.Pow(sig3, 2) - (sig1 * sig3));
                            FOS = Sy / sigVM;
                            if (FOS - 0.01 <= Double.Parse(uxFOStext.Text) && FOS + 0.01 > Double.Parse(uxFOStext.Text))
                            {
                                uxIDText.Text = String.Format("{0:0.000}", ID.ToString());
                                uxMassText.Text = ((((OD * OD * p / 4 * L1) - (ID * ID * p / 4 * L1)) + ((OD * OD * p / 4 * (L2 - OD)) - (ID * ID * p / 4 * (L2 - OD)))) * 1.3 * 16.871).ToString();

                            }
                            sw.WriteLine("{0:E}   	|{1:E}   |\t{2:E}   |\t{3:E}   |\t{4:E}   |\t{5:E}    |\t{6:E}   |\t{7:E}\n", (OD - ID), ID, OD, FOS, sig1, sig3, sigVM, sig);
                            //CLEAR PW BUFFER
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}