using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdminPanelUI.Views.Pages
{

    public class ListingItem
    {
        public string ItemName { get; set; } = "";

        public string Category { get; set; } = "";

        public string Price { get; set; } = "";

        public string Status { get; set; } = "";

        public string Views { get; set; } = "";

        public string Date { get; set; } = "";

        public FontAwesome.Sharp.IconChar Icon { get; set; } = FontAwesome.Sharp.IconChar.None;
    }


    /// <summary>
    /// Interaction logic for Listing.xaml
    /// </summary>
    public partial class Listing : UserControl
    {
        public ObservableCollection<ListingItem> Items { get; set; }

        public Listing()
        {
            InitializeComponent();

            this.Items = new ObservableCollection<ListingItem>
            {
                new ListingItem
                {
                    ItemName = "T-Shirt Embrace",
                    Category = "Clothing",
                    Price = "$25.00",
                    Status = "Active",
                    Views = "1,245",
                    Date = "May 21, 2026",
                    Icon = FontAwesome.Sharp.IconChar.Tshirt
                },

                new ListingItem
                {
                    ItemName = "Shoes Kamoin",
                    Category = "Footwear",
                    Price = "$85.00",
                    Status = "Active",
                    Views = "2,034",
                    Date = "May 20, 2026",
                    Icon = FontAwesome.Sharp.IconChar.ShoePrints
                },

                new ListingItem
                {
                    ItemName = "Socks Beraze",
                    Category = "Accessories",
                    Price = "$10.00",
                    Status = "Inactive",
                    Views = "543",
                    Date = "May 19, 2026",
                    Icon = FontAwesome.Sharp.IconChar.Socks
                },

                new ListingItem
                {
                    ItemName = "T-Shirt Angick",
                    Category = "Clothing",
                    Price = "$22.00",
                    Status = "Active",
                    Views = "1,109",
                    Date = "May 18, 2026",
                    Icon = FontAwesome.Sharp.IconChar.Tshirt
                },

                new ListingItem
                {
                    ItemName = "Hat Jackman",
                    Category = "Accessories",
                    Price = "$18.00",
                    Status = "Active",
                    Views = "987",
                    Date = "May 17, 2026",
                    Icon = FontAwesome.Sharp.IconChar.HatCowboy
                }
            };

            this.DataContext = this;
        }

    }


}
