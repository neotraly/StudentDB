using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace StudendDB
{
    
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            // установка начального адреса 
            webBrowser1.Url = new Uri("https://app.powerbi.com/view?r=eyJrIjoiOWY4MGU3YTUtMDM5Yi00ZjYwLWE5NjYtZjY1MTYyYjllZmM1IiwidCI6IjUyYjkyMzYyLWNiMmYtNDdlYy1iOTBjLTkxNWQ1ZjBmMzcxNyIsImMiOjl9");
            
        }


        private void Form7_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
