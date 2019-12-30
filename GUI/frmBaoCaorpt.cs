using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBaoCaorpt : Form
    {
        public TcpClient client1;
        public NetworkStream clientstrem;
        public frmBaoCaorpt()
        {
            InitializeComponent();
        }

        Server_Client.Client cl;
    }
   
}
      
