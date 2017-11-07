using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerWindowsApplication
{
   
    public partial class ListAllCustomersForm : Form
    {
        private Form myReturnForm = null;

        //overloaded constructor method
        public ListAllCustomersForm(Form formThatCreatedMe)
        {
            //required for windows form designer support
            InitializeComponent();

            //set the returnForm value
            myReturnForm = formThatCreatedMe;
            displayCustomers();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            myReturnForm.Show();
        }
        //display the customers
        private void displayCustomers()
        {
            //format the header in the text box
            customerList.Text = ""; //Clear the textbox
            customerList.AppendText (
            "-------------------------------------------------- \r\n");
            customerList.AppendText(
            "Name Address Zip \r\n");
            customerList.AppendText(
             "-------------------------------------------------- \r\n");
            //local variables
            String name = "";
            String address = "";
            int zip = 0;
            //get all customers
            Customer[] myCustArray = Customer.getAllCustomers();
            //loop thru the array and display all the data
            for (int k = 0; k < myCustArray.Length; k++)
            {
                if (myCustArray[k] != null)
                {
                    //get the customer attributes for this customer
                    name = myCustArray[k].getCustomerName();
                    address = myCustArray[k].getCustomerAddress();
                    zip = myCustArray[k].getCustomerZip();
                    //format the data
                    name = name.PadRight(20, ' ');
                    address = address.PadRight(23, ' ');
                    //display it to the textBox
                    this.customerList.AppendText(name + " " +
                    address + " " + zip + "\r\n");
                }//end if not null
            }//end for loop
        }//end displayCustomers method
    }


}
