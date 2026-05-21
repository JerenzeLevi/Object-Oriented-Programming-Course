using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Omandam
{
    class CarClass
    {
        string carModel = "Lamborghini Sesto Elemento";
        string carBrand = "Lamborghini";
        string carColor = "Pink";
        string carWeight = "999kg";

        public void accelerate()
        {

            MessageBox.Show("The car is accelerating");
        }
    }
}
