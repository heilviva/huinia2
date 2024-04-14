using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace huinia2
{

    public partial class FirstGrid : Page
    {
        private ITCompanyEntities context = new ITCompanyEntities();

        public FirstGrid()
        {
            InitializeComponent();
            EmployeesDataGrid.ItemsSource = context.Employees.ToList();
        }
    }
}