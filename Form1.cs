using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Reository;
using Test.Repository;

namespace Test
{
    public partial class Form1 : Form
    {
        ITestTable TestTable = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestTable = new TestTableRepository();
            dataGridView.DataSource = TestTable.AllTests();

        }
    }
}
