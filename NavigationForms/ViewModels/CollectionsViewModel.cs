using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using NavigationForms.Helper;
using NavigationForms.Interfaces;
using NavigationForms.Models;

namespace NavigationForms.ViewModels
{
    public class CollectionsViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public ObservableCollection<NavigationCollection> Cars { get; private set; }

        public NavigationCollection SelectedCar
        {
            get { return selectedCar; }
            set
            {
                selectedCar = value;
                OnPropertyChanged();
            }
        }

        public CollectionsViewModel()
        {


            Cars = new ObservableCollection<NavigationCollection>();
        }

        public void OnNavigateAway()
        {
            SelectedCar = null;
        }

        public void OnNavigateTo()
        {
            Task.Run(() => AddCars());
        }

        private void AddCars()
        {
            var tesla = new NavigationCollection()
            {
                Title = "Tesla Model S",
                SubTitle = "Has a new facelift",
                ImageUrl = "https://media.autoexpress.co.uk/image/private/s--mXIuUVkh--/f_auto,t_content-image-full-mobile@1/v1611832929/autoexpress/2021/01/Tesla%20Model%20s%20facelift%202021-14.jpg"
            };

            var GrYaris = new NavigationCollection()
            {
                Title = "GR Yaris",
                SubTitle = "Not really a yaris",
                ImageUrl = "https://media.caradvice.com.au/image/private/q_auto/v1601510819/lmiu0qqfg76xtqbu3sex.jpg"
            };

            var BmwM4 = new NavigationCollection()
            {
                Title = "BMW M4",
                SubTitle = "It's an auto...",
                ImageUrl = "https://cdn.bmwblog.com/wp-content/uploads/2020/11/2021-bmw-m4-toronto-red-08.jpg"
            };

            var Golf = new NavigationCollection()
            {
                Title = "Golf",
                SubTitle = "A boring box",
                ImageUrl = "https://www.carscoops.com/wp-content/uploads/2020/03/2021-VW-Golf-GTI-0.jpg"
            };

            var FocusSt = new NavigationCollection()
            {
                Title = "Ford Focus ST",
                SubTitle = "The affordable B road killer",
                ImageUrl = "https://www.irishtimes.com/polopoly_fs/1.3960687.1563467404!/image/image.jpg_gen/derivatives/landscape_620/image.jpg"
            };

            var Fairlady = new NavigationCollection()
            {
                Title = "Nissan Fairlady Z",
                SubTitle = "An iconic Japanese beauty",
                ImageUrl = "https://drivetribe.imgix.net/epZHuDL3TEOfuR367f_I8Q"
            };

            Cars.Add(tesla);
            Cars.Add(GrYaris);
            Cars.Add(BmwM4);
            Cars.Add(Golf);
            Cars.Add(FocusSt);
            Cars.Add(Fairlady);
        }

        private NavigationCollection selectedCar;
    }
}
