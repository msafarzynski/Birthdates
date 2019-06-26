using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Birthdate.Domain;
using Xamarin.Forms;

namespace Birthdate
{
    public partial class GiftIdeasPage : ContentPage
    {
        public GiftIdeasPage()
        {
            InitializeComponent();
            _allGroups = OccasionsGifts.ListOfAllOccasionsAndGifts;
            UpdateListContent();
        }

        private ObservableCollection<OccasionGiftGroup> _allGroups;
        private ObservableCollection<OccasionGiftGroup> _expandedGroups;

        private void HeaderTapped(object sender, EventArgs args)
        {
            int selectedIndex = _expandedGroups.IndexOf(
                ((OccasionGiftGroup)((Button)sender).CommandParameter));
            _allGroups[selectedIndex].Expanded = !_allGroups[selectedIndex].Expanded;
            UpdateListContent();
        }

        private void UpdateListContent()
        {
            _expandedGroups = new ObservableCollection<OccasionGiftGroup>();
            foreach (OccasionGiftGroup group in _allGroups)
            {
                OccasionGiftGroup newGroup = new OccasionGiftGroup(group.Occasion, group.Expanded);
                
                newGroup.GiftCount = group.Count;
                if (group.Expanded)
                {
                    foreach (Gift gift in group)
                    {
                        newGroup.Add(gift);
                    }
                }
                _expandedGroups.Add(newGroup);
            }
            OccasionsGiftss.ItemsSource = _expandedGroups;
        }
    }
}
