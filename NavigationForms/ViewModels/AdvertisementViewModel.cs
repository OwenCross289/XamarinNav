using System.Collections.ObjectModel;
using NavigationForms.Helper;
using NavigationForms.Interfaces;
using NavigationForms.Models;

namespace NavigationForms.ViewModels
{
    public class AdvertisementViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Advert> Adverts { get; private set; }

        public AdvertisementViewModel()
        {
            Adverts = CreateAdverts();
        }

        private ObservableCollection<Advert> CreateAdverts()
        {
            var adverts = new ObservableCollection<Advert>();
            Advert kindaFunnyAdvert = new Advert
            {
                Name = "Kinda Funny",
                ImageUrl = "https://pbs.twimg.com/profile_images/1081270685509443584/Dn1t6NrD_400x400.jpg",
                Details = "Find all the best podcasts and news shows to keep you uptodate on games and nerd culture",
                Location = "The Bay Area"
            };

            Advert bladeRunnerAdvert = new Advert
            {
                Name = "Blade Runner 2049",
                ImageUrl = "https://miro.medium.com/max/5760/1*Cg43oYnM3Mfn2TJAxBFvWA.png",
                Details = "Jet to the near future in an adventure of dreams and desperation",
                Location = "The future"
            };

            Advert nvidia3090Advert = new Advert
            {
                Name = "Nvidia RTX 3090",
                ImageUrl = "https://www.nvidia.com/content/dam/en-zz/Solutions/geforce/ampere/rtx-3090/geforce-ampere-rtx-3090-og-1200x630.jpg",
                Details = "The latest inovation in graphics computing",
                Location = "Jensens kitchen"
            };

            Advert m1MacBookAdvert = new Advert
            {
                Name = "Apple M1 MacBook",
                ImageUrl = "https://www.domusweb.it/content/dam/domusweb/en/news/2020/11/11/apple-m1-chip-6-reasons-why-its-gonna-change-your-mac-forever/Apple-m1-chips-1.jpg.foto.rbig.jpg",
                Details = "The latest inovation in mobile computing",
                Location = "Sunny San Diago"
            };

            adverts.Add(m1MacBookAdvert);
            adverts.Add(kindaFunnyAdvert);
            adverts.Add(bladeRunnerAdvert);
            adverts.Add(nvidia3090Advert);

            return adverts;
        }

        public void OnNavigateAway()
        {

        }

        public void OnNavigateTo()
        {

        }

        private string text = "Adverts";
    }
}
