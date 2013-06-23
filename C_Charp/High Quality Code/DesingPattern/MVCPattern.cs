//View:

namespace WinFormMVC
{
    public partial class Form1 : Form
    {
        controller cont = new controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = cont.checkPermissionsAndGetFirstPerson();
        }
    }
}

//Controller:

public class controller
    {
        public string checkPermissionsAndGetFirstPerson()
        {
            string returnValue = "";
            if (checkPermissions())
            {
                model m = new model();
                returnValue =  m.getFirstPerson();
            }

            return returnValue;

        }

        public bool checkPermissions()
        {
            return true;
        }
    }
	
//Model:

public class model
    {
        public string getFirstPerson()
        {
            return "Bill Smith";
        }
    }	