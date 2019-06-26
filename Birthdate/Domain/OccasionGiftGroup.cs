using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Birthdate.Domain.Occasions;

namespace Birthdate.Domain
{
    public class OccasionGiftGroup : ObservableCollection<Gift>, INotifyPropertyChanged
    {
        private bool _expanded;

        public string Title { get; set; }
        public Occasion Occasion { get; set; }
        public int GiftCount { get; set; }


        public string TitleWithGiftCount {
            get { return string.Format($"{Title} ({GiftCount})"); }
        }

        public bool Expanded
        {
            get{ return _expanded;}
            set{ if (_expanded != value){
                    _expanded = value;
                    OnPropertyChanged("Expanded");
                    //OnPropertyChanged("StateIcon");
                }
            }
        }

        public OccasionGiftGroup(Occasion occasion, bool expanded = false)
        {
            Title = occasion.Person.Name + " " + occasion.Name;
            Occasion = occasion;
            Expanded = expanded;
        }

        protected override event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
