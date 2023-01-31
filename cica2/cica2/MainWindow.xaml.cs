using System;
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
using System.IO;
using System.ComponentModel;
using System.Threading;
using System.Runtime.CompilerServices;

namespace cica2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        // Objets, lists, variables

        Random r = new Random();

        List<string> deck = new List<string>();
        List<string> player1 = new List<string>();
        List<string> player2 = new List<string>();

        string kival = string.Empty;

        string p1Name, p2Name;

        bool bg = false;

        bool p1Ok = false;
        bool p2Ok = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Adding cards to the deck

            player1.Add("-Hatástalanító-");

            player2.Add("-Hatástalanító-");

            for (int i = 0; i < 4; i++)
            {
                deck.Add("-Hatástalanító-");
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    deck.Add("Nope");
            //}
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Támadás");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Újrakeverés");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Ugrás");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Szívesség");
            }
            for (int i = 0; i < 5; i++)
            {
                deck.Add("Jövőbe látás");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Taco macska");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Krumpli macska");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Ször macska");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Szivárvány macska");
            }
            for (int i = 0; i < 4; i++)
            {
                deck.Add("Dinnye macska");
            }

            Shuffle();

            for (int i = 0; i < 7; i++)
            {
                player1.Add(deck[0]);
                deck.Remove(deck[0]);

                player2.Add(deck[1]);
                deck.Remove(deck[1]);
            }

            deck.Add("Bomba");

            // Hiding labels for more interactive user interface

            player1Li.ItemsSource = player1;
            player2Li.ItemsSource = player2;

            down1B.IsEnabled = false;
            down2B.IsEnabled = false;

            startL.Visibility = Visibility.Collapsed;

            up1B.Visibility = Visibility.Collapsed;
            up2B.Visibility = Visibility.Collapsed;

            selectedItem1L.Visibility = Visibility.Collapsed;
            selectedItem2L.Visibility = Visibility.Collapsed;

            p1TL.Visibility = Visibility.Collapsed;
            p2TL.Visibility = Visibility.Collapsed;

            player1L.Visibility = Visibility.Collapsed;
            player2L.Visibility = Visibility.Collapsed;

            current1L.Visibility = Visibility.Collapsed;
            current2L.Visibility = Visibility.Collapsed;

            down1B.Visibility = Visibility.Collapsed;
            down2B.Visibility = Visibility.Collapsed;

            namesL.Visibility = Visibility.Visible;

            // Shuffling the deck and filling up the ListBoxes

            Shuffle();

            Refresh();
        }

        // Fisher-Yates Shuffle

        private void Shuffle()
        {
            int lastIndex = deck.Count() - 1;
            while (lastIndex > 0)
            {
                string tempValue = deck[lastIndex];
                int randomIndex = r.Next(0, lastIndex);
                deck[lastIndex] = deck[randomIndex];
                deck[randomIndex] = tempValue;
                lastIndex--;

            }
        }

        // Refresh information to current state

        private void Refresh()
        {
            deckL.Content = deck.Count();
            player1L.Content = player1.Count();
            player2L.Content = player2.Count();

            player1Li.Items.Refresh();
            player2Li.Items.Refresh();

            player1.Sort();
            player2.Sort();

            textL.Background = Brushes.White;
            textL.Foreground = Brushes.Black;

            down1B.IsEnabled = false;
            down2B.IsEnabled = false;

            bg = false;
        }

        // Advanced use of "macska" cards Player1

        private bool Tita1(string nev)
        {
            int num = 0;
            foreach (string item in player1)
            {
                if (item == "Taco macska" || item == "Dinnye macska" || item == "Ször macska" || item == "Krumpli macska" || item == "Szivárvány macska")
                {
                    if (nev == item)
                    {
                        num++;
                    }
                }
            }

            if (num >= 2)
            {
                int num1 = 0;
                for (int i = 0; i < player1.Count(); i++)
                {
                    if (player1[i] == nev)
                    {
                        num1++;
                        if (num1 == 2)
                        {
                            Refresh();
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // Advanced use of "macska" cards Player1

        private bool Tita2(string nev)
        {
            int num = 0;
            foreach (string item in player2)
            {
                if (item == "Taco macska" || item == "Dinnye macska" || item == "Ször macska" || item == "Krumpli macska" || item == "Szivárvány macska")
                {
                    if (nev == item)
                    {
                        num++;
                    }
                }
            }

            if (num >= 2)
            {
                int num1 = 0;
                for (int i = 0; i < player2.Count(); i++)
                {
                    if (player2[i] == nev)
                    {
                        num1++;
                        if (num1 == 2)
                        {
                            Refresh();
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        // Picking up cards

        public void up1B_Click(object sender, RoutedEventArgs e)
        {
            p1Name = p1T.Text;
            p2Name = p2T.Text;

            p1T.IsReadOnly = true;
            p2T.IsReadOnly = true;

            p1TL.Visibility = Visibility.Visible;
            p1TL.Content = $"{p1Name} lapjainak száma:";

            p2TL.Visibility = Visibility.Visible;
            p2TL.Content = $"{p2Name} lapjainak száma:";

            down1B.Visibility = Visibility.Visible;
            down2B.Visibility = Visibility.Visible;

            selectedItem1L.Visibility = Visibility.Visible;
            selectedItem2L.Visibility = Visibility.Visible;

            current1L.Visibility = Visibility.Visible;
            current2L.Visibility = Visibility.Visible;

            down1B.Visibility = Visibility.Visible;
            down2B.Visibility = Visibility.Visible;

            startL.Visibility = Visibility.Collapsed;

            textL.Content = "";

            if (deck[0] == "Bomba")
            {
                if (deck[0] == "Bomba" && player1.Contains("-Hatástalanító-") && deck.Count > 1)
                {
                    current1L.Content = deck[0];
                    player1.Remove("-Hatástalanító-");
                    textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p1Name} megúszta meow ;)";
                    deck.Remove(deck[0]);

                    int rand = r.Next(1, deck.Count);
                    deck.Insert(rand, "Bomba");

                    up1B.IsEnabled = false;
                    up2B.IsEnabled = true;

                    Refresh();
                }
                else if (deck[0] == "Bomba" && player1.Contains("-Hatástalanító-") && deck.Count == 1)
                {
                    player1.Remove("-Hatástalanító-");
                    textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p1Name} megúszta meow ;)";
                    up1B.IsEnabled = false;
                    up2B.IsEnabled = true;

                    Refresh();
                }
                else if (deck[0] == "Bomba" && !player1.Contains("-Hatástalanító-"))
                {
                    MessageBox.Show($"{p1Name} cica felrobbant!\n{p2Name} nyert! :)");
                    this.Close();
                }
            }
            else
            {
                current1L.Content = deck[0];
                player1.Add(deck[0]);
                deck.Remove(deck[0]);

                up1B.IsEnabled = false;
                up2B.IsEnabled = true;

                Refresh();
            }
        }

        public void up2B_Click(object sender, RoutedEventArgs e)
        {
            p1Name = p1T.Text;
            p2Name = p2T.Text;

            p1T.IsReadOnly = true;
            p2T.IsReadOnly = true;

            p1TL.Visibility = Visibility.Visible;
            p1TL.Content = $"{p1Name} lapjainak száma:";

            p2TL.Visibility = Visibility.Visible;
            p2TL.Content = $"{p2Name} lapjainak száma:";

            down1B.Visibility = Visibility.Visible;
            down2B.Visibility = Visibility.Visible;

            selectedItem1L.Visibility = Visibility.Visible;
            selectedItem2L.Visibility = Visibility.Visible;

            current1L.Visibility = Visibility.Visible;
            current2L.Visibility = Visibility.Visible;

            down1B.Visibility = Visibility.Visible;
            down2B.Visibility = Visibility.Visible;

            startL.Visibility = Visibility.Collapsed;

            textL.Content = "";

            if (deck[0] == "Bomba")
            {
                if (deck[0] == "Bomba" && player2.Contains("-Hatástalanító-") && deck.Count > 1)
                {
                    current2L.Content = deck[0];
                    player2.Remove("-Hatástalanító-");
                    textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p2Name} megúszta meow ;)";
                    deck.Remove(deck[0]);

                    int rand = r.Next(1, deck.Count);
                    deck.Insert(rand, "Bomba");

                    up1B.IsEnabled = true;
                    up2B.IsEnabled = false;

                    Refresh();
                }
                else if (deck[0] == "Bomba" && player2.Contains("-Hatástalanító-") && deck.Count == 1)
                {
                    player2.Remove("-Hatástalanító-");
                    textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p2Name} megúszta meow ;)";
                    up1B.IsEnabled = true;
                    up2B.IsEnabled = false;

                    Refresh();
                }
                else if (deck[0] == "Bomba" && !player2.Contains("-Hatástalanító-"))
                {
                    MessageBox.Show($"{p2Name} cica felrobbant!\n{p1Name} nyert! :)");
                    this.Close();
                }
            }
            else
            {
                current2L.Content = deck[0];
                player2.Add(deck[0]);
                deck.Remove(deck[0]);

                up1B.IsEnabled = true;
                up2B.IsEnabled = false;

                Refresh();
            }
        }

        // Putting down cards

        private void down1B_Click(object sender, RoutedEventArgs e)
        {
            if (kival == "Újrakeverés")
            {
                player1.Remove(kival);
                textL.Content = "";
                Shuffle();
                Refresh();
            }
            if (kival == "Ugrás")
            {
                textL.Content = "";
                player1.Remove(kival);
                up1B.IsEnabled = false;
                up2B.IsEnabled = true;
                down1B.IsEnabled = false;
                Refresh();
                textL.Content = "";
            }
            if (kival == "Szívesség")
            {
                textL.Content = "";
                player1.Remove(kival);
                int player2szam = r.Next(player2.Count() - 1);
                player1.Add(player2[player2szam]);
                player2.RemoveAt(player2szam);
                Refresh();
            }
            if (kival == "Jövőbe látás")
            {
                textL.Content = "";
                switch (deck.Count())
                {
                    case 1:
                        textL.Content = "1:  " + deck[0];
                        break;
                    case 2:
                        textL.Content = "1:  " + deck[0] + "   2:  " + deck[1];
                        break;
                    default:
                        textL.Content = "1:  " + deck[0] + "   2:  " + deck[1] + "   3:  " + deck[2];
                        break;
                }

                player1.Remove(kival);

                Refresh();

                textL.Foreground = Brushes.Black;
                textL.Background = Brushes.Black;

                bg = true;
            }
            if (kival == "Támadás")
            {
                textL.Content = "";
                player1.Remove(kival);
                if (deck[0] == "Bomba")
                {
                    if (deck[0] == "Bomba" && player2.Contains("-Hatástalanító-") && deck.Count > 1)
                    {
                        current1L.Content = deck[0];
                        player2.Remove("-Hatástalanító-");
                        textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p2Name} megúszta meow ;)";
                        deck.Remove(deck[0]);

                        int rand = r.Next(1, deck.Count);
                        deck.Insert(rand, "Bomba");

                        up1B.IsEnabled = true;
                        up2B.IsEnabled = false;

                        Refresh();
                    }
                    else if (deck[0] == "Bomba" && player2.Contains("-Hatástalanító-") && deck.Count == 1)
                    {
                        player2.Remove("-Hatástalanító-");
                        textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p2Name} megúszta meow ;)";
                        up1B.IsEnabled = true;
                        up2B.IsEnabled = false;

                        Refresh();
                    }
                    else if (deck[0] == "Bomba" && !player2.Contains("-Hatástalanító-"))
                    {
                        MessageBox.Show($"{p2Name} cica felrobbant!\n{p1Name} nyert! :)");
                        this.Close();
                    }
                }
                else
                {
                    player2.Add(deck[0]);
                    deck.Remove(deck[0]);
                    down1B.IsEnabled = false;

                    up1B.IsEnabled = true;
                    up2B.IsEnabled = false;

                    Refresh();
                }
            }
            if (kival == "Nope")
            {
                // Out of order
            }
            if (kival == "Taco macska")
            {
                textL.Content = "";
                if (Tita1("Taco macska") == true)
                {
                    player1.Remove(kival);
                    player1.Remove(kival);
                    Random r = new Random();
                    int ellenfel = r.Next(player2.Count - 1);
                    player1.Add(player2[ellenfel]);
                    player2.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Dinnye macska")
            {
                textL.Content = "";
                if (Tita1("Dinnye macska") == true)
                {
                    player1.Remove(kival);
                    player1.Remove(kival);
                    Random r = new Random();
                    int ellenfel = r.Next(player2.Count - 1);
                    player1.Add(player2[ellenfel]);
                    player2.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Ször macska")
            {
                textL.Content = "";
                if (Tita1("Ször macska") == true)
                {
                    player1.Remove(kival);
                    player1.Remove(kival);
                    Random r = new Random();
                    int ellenfel = r.Next(player2.Count - 1);
                    player1.Add(player2[ellenfel]);
                    player2.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Krumpli macska")
            {
                textL.Content = "";
                if (Tita1("Krumpli macska") == true)
                {
                    player1.Remove(kival);
                    player1.Remove(kival);
                    Random r = new Random();
                    int ellenfel = r.Next(player2.Count - 1);
                    player1.Add(player2[ellenfel]);
                    player2.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Szivárvány macska")
            {
                textL.Content = "";
                if (Tita1("Szivárvány macska") == true)
                {
                    player1.Remove(kival);
                    player1.Remove(kival);
                    Random r = new Random();
                    int ellenfel = r.Next(player2.Count - 1);
                    player1.Add(player2[ellenfel]);
                    player2.RemoveAt(ellenfel);
                    Refresh();
                }
            }
        }

        private void down2B_Click(object sender, RoutedEventArgs e)
        {
            if (kival == "Újrakeverés")
            {
                textL.Content = "";
                player2.Remove(kival);
                Shuffle();
                Refresh();
            }
            if (kival == "Ugrás")
            {
                textL.Content = "";
                player2.Remove(kival);
                up1B.IsEnabled = true;
                up2B.IsEnabled = false;
                down2B.IsEnabled = false;
                Refresh();
            }
            if (kival == "Szívesség")
            {
                textL.Content = "";
                player2.Remove(kival);
                int player2szam = r.Next(player1.Count() - 1);
                player2.Add(player2[player2szam]);
                player1.RemoveAt(player2szam);
                Refresh();
            }
            if (kival == "Jövőbe látás")
            {
                textL.Content = "";
                switch (deck.Count())
                {
                    case 1:
                        textL.Content = "1:  " + deck[0];
                        break;
                    case 2:
                        textL.Content = "1:  " + deck[0] + "   2:  " + deck[1];
                        break;
                    default:
                        textL.Content = "1:  " + deck[0] + "   2:  " + deck[1] + "   3:  " + deck[2];
                        break;
                }

                player2.Remove(kival);

                Refresh();

                textL.Foreground = Brushes.Black;
                textL.Background = Brushes.Black;

                bg = true;
            }
            if (kival == "Támadás")
            {
                textL.Content = "";
                player2.Remove(kival);
                if (deck[0] == "Bomba")
                {
                    if (deck[0] == "Bomba" && player1.Contains("-Hatástalanító-") && deck.Count > 1)
                    {
                        current1L.Content = deck[0];
                        player1.Remove("-Hatástalanító-");
                        textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p1Name} megúszta meow ;)";
                        deck.Remove(deck[0]);

                        int rand = r.Next(1, deck.Count);
                        deck.Insert(rand, "Bomba");

                        up1B.IsEnabled = false;
                        up2B.IsEnabled = true;

                        Refresh();
                    }
                    else if (deck[0] == "Bomba" && player1.Contains("-Hatástalanító-") && deck.Count == 1)
                    {
                        player1.Remove("-Hatástalanító-");
                        textL.Content = $"Volt -Hatástalanító- a kártyáid közt! {p1Name} megúszta meow ;)";
                        up1B.IsEnabled = false;
                        up2B.IsEnabled = true;

                        Refresh();
                    }
                    else if (deck[0] == "Bomba" && !player1.Contains("-Hatástalanító-"))
                    {
                        MessageBox.Show($"{p1Name} cica felrobbant!\n{p2Name} nyert! :)");
                        this.Close();
                    }
                }
                else
                {
                    player1.Add(deck[0]);
                    deck.Remove(deck[0]);
                    down2B.IsEnabled = false;

                    up1B.IsEnabled = true;
                    up2B.IsEnabled = false;

                    Refresh();
                }
            }
            if (kival == "Nope")
            {
                // Out of order
            }

            if (kival == "Taco macska")
            {
                textL.Content = "";
                if (Tita2("Taco macska") == true)
                {
                    player2.Remove(kival);
                    player2.Remove(kival);
                    int ellenfel = r.Next(player1.Count - 1);
                    player2.Add(player1[ellenfel]);
                    player1.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Dinnye macska")
            {
                textL.Content = "";
                if (Tita2("Dinnye macska") == true)
                {
                    player2.Remove(kival);
                    player2.Remove(kival);
                    int ellenfel = r.Next(player1.Count - 1);
                    player2.Add(player1[ellenfel]);
                    player1.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Ször macska")
            {
                textL.Content = "";
                if (Tita2("Ször macska") == true)
                {
                    player2.Remove(kival);
                    player2.Remove(kival);
                    int ellenfel = r.Next(player1.Count - 1);
                    player2.Add(player1[ellenfel]);
                    player1.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Krumpli macska")
            {
                textL.Content = "";
                if (Tita2("Krumpli macska") == true)
                {
                    player2.Remove(kival);
                    player2.Remove(kival);
                    int ellenfel = r.Next(player1.Count - 1);
                    player2.Add(player1[ellenfel]);
                    player1.RemoveAt(ellenfel);
                    Refresh();
                }
            }
            if (kival == "Szivárvány macska")
            {
                textL.Content = "";
                if (Tita2("Szivárvány macska") == true)
                {
                    player2.Remove(kival);
                    player2.Remove(kival);
                    int ellenfel = r.Next(player1.Count - 1);
                    player2.Add(player1[ellenfel]);
                    player1.RemoveAt(ellenfel);
                    Refresh();
                }
            }
        }

        // Selected cards from ListBoxes

        private void player1Li_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (player1Li.SelectedItem != null && up1B.IsEnabled == true)
            {
                kival = player1Li.SelectedItem.ToString();
                selectedItem1L.Content = kival;
                down1B.IsEnabled = true;
            }

            if (player1Li.SelectedItem == null)
            {
                selectedItem1L.Content = "Kiválasztott kártya";
            }
        }

        private void player2Li_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (player2Li.SelectedItem != null && up2B.IsEnabled == true)
            {
                kival = player2Li.SelectedItem.ToString();
                selectedItem2L.Content = kival;
                down2B.IsEnabled = true;
            }

            if (player1Li.SelectedItem == null)
            {
                selectedItem2L.Content = "Kiválasztott kártya";
            }
        }

        // Fancy anonymity when "Jövőbe látás" is used

        private void textL_MouseEnter(object sender, MouseEventArgs e)
        {
            if (bg)
            {
                textL.Background = Brushes.White;
                textL.Foreground = Brushes.Black;
            }
        }

        private void textL_MouseLeave(object sender, MouseEventArgs e)
        {
            if (bg)
            {
                textL.Background = Brushes.Black;
                textL.Foreground = Brushes.Black;
            }
        }

        // Normal player names, or at least not empty strings

        private void p1T_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (p1T.Text != "Player 1" && p1T.Text != "" && p1T.Text != p2T.Text)
            {
                p1Ok = true;
            }

            if (p1Ok && p2Ok)
            {
                namesL.Visibility = Visibility.Collapsed;

                startL.Visibility = Visibility.Visible;

                down1B.Visibility = Visibility.Collapsed;
                down2B.Visibility = Visibility.Collapsed;

                up1B.Visibility = Visibility.Visible;
                up2B.Visibility = Visibility.Visible;

                player1L.Visibility = Visibility.Visible;
                player2L.Visibility = Visibility.Visible;
            }
        }

        private void p2T_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (p2T.Text != "Player 2" && p2T.Text != "" && p2T.Text != p1T.Text)
            {
                p2Ok = true;
            }

            if (p1Ok && p2Ok)
            {
                namesL.Visibility = Visibility.Collapsed;

                startL.Visibility = Visibility.Visible;

                down1B.Visibility = Visibility.Collapsed;
                down2B.Visibility = Visibility.Collapsed;

                up1B.Visibility = Visibility.Visible;
                up2B.Visibility = Visibility.Visible;

                player1L.Visibility = Visibility.Visible;
                player2L.Visibility = Visibility.Visible;
            }
        }

        private void p1T_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (p1T.Text == "Player 1")
            {
                p1T.Clear();
            }
        }

        private void p2T_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (p2T.Text == "Player 2")
            {
                p2T.Clear();
            }
        }

        private void xL_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}