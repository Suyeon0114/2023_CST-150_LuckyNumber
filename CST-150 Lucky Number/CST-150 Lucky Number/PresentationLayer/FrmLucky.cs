/* Suyeon Park
 * CST-150
 * 04/30/23
 * Activity 15
 * Alli Adam
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Lucky_Number.PresentationLayer
{
    public partial class FrmLucky : Form
    {
        public FrmLucky()
        {
            InitializeComponent();

            // Display the calculated Lucky Number
            lblResult.Text = FrmInfo.luckyNum.ToString();
        }
    }
}
