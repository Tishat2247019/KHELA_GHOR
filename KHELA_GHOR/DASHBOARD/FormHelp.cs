using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASHBOARD
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
           // InitCustomLabelFont();
        }

        //private void InitCustomLabelFont()
        //{
        //    //Create your private font collection object.
        //    PrivateFontCollection pfc = new PrivateFontCollection();

        //    //Select your font from the resources.
        //    //My font here is "Digireu.ttf"
        //    int fontLength = Properties.Resources.Nunito_Bold.Length;

        //    // create a buffer to read in to
        //    byte[] fontdata = Properties.Resources.Nunito_Bold;

        //    // create an unsafe memory block for the font data
        //    System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

        //    // copy the bytes to the unsafe memory block
        //    Marshal.Copy(fontdata, 0, data, fontLength);

        //    // pass the font to the font collection
        //    pfc.AddMemoryFont(data, fontLength);

        //    //After that we can create font and assign font to label
        //    lbl_contact.Font = new Font(pfc.Families[0], lbl_contact.Font.Size);
        //    lbl_with.Font = new Font(pfc.Families[0], lbl_with.Font.Size);
        //    lbl_the.Font = new Font(pfc.Families[0], lbl_the.Font.Size);
        //    lbl_dev.Font = new Font(pfc.Families[0], lbl_dev.Font.Size);

        //    lbl_Name.Font = new Font(pfc.Families[0], lbl_Name.Font.Size);
        //    label1.Font = new Font(pfc.Families[0], label1.Font.Size);
        //    label2.Font = new Font(pfc.Families[0], label2.Font.Size);
        //    label3.Font = new Font(pfc.Families[0], label3.Font.Size);
        //    label4.Font = new Font(pfc.Families[0], label4.Font.Size);
        //    label5.Font = new Font(pfc.Families[0], label5.Font.Size);
        //    label6.Font = new Font(pfc.Families[0], label6.Font.Size);
        //    label7.Font = new Font(pfc.Families[0], label7.Font.Size);
        //    label8.Font = new Font(pfc.Families[0], label8.Font.Size);

        //    //lbl_contact.Text = "";
        //}
        private void InitCustomLabelFont()
        {
            // Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();
            IntPtr data = IntPtr.Zero;

            try
            {
                // Select your font from the resources.
                // My font here is "Digireu.ttf"
                int fontLength = Properties.Resources.Nunito_Bold.Length;

                // Create a buffer to read into
                byte[] fontdata = Properties.Resources.Nunito_Bold;

                // Create an unsafe memory block for the font data
                 data = Marshal.AllocCoTaskMem(fontLength);

                // Copy the bytes to the unsafe memory block
                Marshal.Copy(fontdata, 0, data, fontLength);

                // Pass the font to the font collection
                pfc.AddMemoryFont(data, fontLength);

                // Check if the font was added successfully
                if (pfc.Families.Length > 0)
                {
                    // Apply the font to labels
                    lbl_contact.Font = new Font(pfc.Families[0], lbl_contact.Font.Size);
                    lbl_with.Font = new Font(pfc.Families[0], lbl_with.Font.Size);
                    lbl_the.Font = new Font(pfc.Families[0], lbl_the.Font.Size);
                    lbl_dev.Font = new Font(pfc.Families[0], lbl_dev.Font.Size);

                    lbl_Name.Font = new Font(pfc.Families[0], lbl_Name.Font.Size);
                    label1.Font = new Font(pfc.Families[0], label1.Font.Size);
                    label2.Font = new Font(pfc.Families[0], label2.Font.Size);
                    label3.Font = new Font(pfc.Families[0], label3.Font.Size);
                    label4.Font = new Font(pfc.Families[0], label4.Font.Size);
                    label5.Font = new Font(pfc.Families[0], label5.Font.Size);
                    label6.Font = new Font(pfc.Families[0], label6.Font.Size);
                    label7.Font = new Font(pfc.Families[0], label7.Font.Size);
                    label8.Font = new Font(pfc.Families[0], label8.Font.Size);
                }
                else
                {
                    // Handle the case where the font couldn't be added
                    MessageBox.Show("Error adding custom font to PrivateFontCollection.");
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always free the allocated memory
                Marshal.FreeCoTaskMem(data);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormHelp_Load(object sender, EventArgs e)
        {
          //  InitCustomLabelFont();
        }
    }
}
