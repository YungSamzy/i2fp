using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPhone2FrozenPeas
{
    public partial class i2fp : Form
    {
        public i2fp() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {
            try{ MessageBox.Show($"The selected iPhone is worth: {PriceConverter.ConvertToPea(PriceConverter.iPhonePrice(comboBox1.SelectedItem.ToString()))} frozen peas!", "iPhone To Frozen Peas", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch(NullReferenceException) { MessageBox.Show("Please select an iPhone model to convert!", "iPhone To Frozen Peas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch(Exception ex) { File.WriteAllText("./log.txt", ex.ToString()); MessageBox.Show("Errror! A log has been created.", "iPhone To Frozen Peas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
    }
}
