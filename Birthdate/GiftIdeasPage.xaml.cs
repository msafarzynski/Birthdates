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

        private OccasionsGifts _allGroups;
        private OccasionsGifts _expandedGroups;

        private void HeaderTapped(object sender, EventArgs args)
        {
            int selectedIndex = _expandedGroups.IndexOf(
                ((OccasionsGifts)((Button)sender).CommandParameter));
            _allGroups[selectedIndex].Expanded = !_allGroups[selectedIndex].Expanded;
            UpdateListContent();
        }

        private void UpdateListContent()
        {
            _expandedGroups = new ObservableCollection<FoodGroup>();
            foreach (FoodGroup group in _allGroups)
            {
                //Create new FoodGroups so we do not alter original list
                FoodGroup newGroup = new FoodGroup(group.Title, group.ShortName, group.Expanded);
                //Add the count of food items for Lits Header Titles to use
                newGroup.FoodCount = group.Count;
                if (group.Expanded)
                {
                    foreach (Food food in group)
                    {
                        newGroup.Add(food);
                    }
                }
                _expandedGroups.Add(newGroup);
            }
            GroupedView.ItemsSource = _expandedGroups;
        }
    }
}
