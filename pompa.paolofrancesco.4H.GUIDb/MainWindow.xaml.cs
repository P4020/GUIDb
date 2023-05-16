using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using SQLite;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pompa.paolofrancesco._4H.GUIDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
            var tblArtists = cn1.Query<Artist>("select * from artists");
            Console.WriteLine($"In questa tabella ci sono {tblArtists.Count} record!");

            tblArtists = tblArtists.OrderByDescending(x=>x.Name).ToList();
            foreach(var artista in tblArtists)
            {
                Console.WriteLine($"{artista.Name}");
            }          
            
        }
    }
}
