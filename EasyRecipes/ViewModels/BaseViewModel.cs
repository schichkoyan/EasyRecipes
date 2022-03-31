using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EasyRecipes.ViewModels
{
    public abstract class BaseViewModel
    {
        protected event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public abstract Task Initialise();

    }
}
