using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Information_Management_System
{
    class UserClass
    {
        int userId = 301594;
        string userName = "Jerenze Levi Arlecchino T. Omandam";
        int userAge = 18;
        string userAddress = "Osaka, Japan";

        public void displayInfo()
        {
            MessageBox.Show("\t=== Your Personal Information ===\nUser ID: " + userId + "\nName: " + userName + "\nAge: " + userAge + "\nAddress: " + userAddress);
        }
    }
}
