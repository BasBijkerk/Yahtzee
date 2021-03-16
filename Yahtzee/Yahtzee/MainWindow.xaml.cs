using System;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;
using System.IO;

namespace Yahtzee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private bool roll = false;
        private bool Started = false;

        private Random rng = new Random();

        private int PlayerTurn = 0;
        private int PlayerCount = 0;

        private int RollCount = 0;

        private int cDelay = 0;

        private int Memval = 0;
        private int Memval2 = 0;

        private int pval1 = 0;
        private int pval2 = 0;
        private int pval3 = 0;
        private int pval4 = 0;

        private bool bonus1 = false;
        private bool bonus2 = false;
        private bool bonus3 = false;
        private bool bonus4 = false;

        private bool RolledOnce = false;

        private List<Label> DiceLabel = new List<Label>();
        private List<Image> DiceImg = new List<Image>();
        private List<Label> ScoreLabels = new List<Label>();

        private List<int> multiCount = new List<int>();
        private Dictionary<string, int> multiCountDupe = new Dictionary<string, int>();

        private bool CanRoll = false;



        private bool D1Lock = false;
        private bool D2Lock = false;
        private bool D3Lock = false;
        private bool D4Lock = false;
        private bool D5Lock = false;

        public MainWindow()
        {
            InitializeComponent();


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += OnUpdate;
            timer.Start();

            DiceLabel.Add(Dice1);
            DiceLabel.Add(Dice2);
            DiceLabel.Add(Dice3);
            DiceLabel.Add(Dice4);
            DiceLabel.Add(Dice5);
            DiceImg.Add(tDice1);
            DiceImg.Add(tDice2);
            DiceImg.Add(tDice3);
            DiceImg.Add(tDice4);
            DiceImg.Add(tDice5);
            DiceImg.Add(tDice6);

        }
        private void CleanBoard()
        {
            if(ScoreLabels.Count <= 0)
            {
            foreach (UIElement uie in YaGrid.Children)
            {
                    if(uie.GetType() == typeof(Label))
                    {
                        Label label = (Label)uie;
                        ScoreLabels.Add(label);
                    }
                        
            }
            }
            if(ScoreLabels.Count > 0)
            {
                foreach (Label label in ScoreLabels)
                {
                    if (label.Name.StartsWith("P") && label.Content.ToString() != "")
                    {
                        label.Content = "";
                    }
                }
            }

            P1Tot.Content = "0";
            P2Tot.Content = "0";
            P3Tot.Content = "0";
            P4Tot.Content = "0";

            P1Total.Content = "0";
            P2Total.Content = "0";
            P3Total.Content = "0";
            P4Total.Content = "0";

            P1TotalAll.Content = "0";
            P2TotalAll.Content = "0";
            P3TotalAll.Content = "0";
            P4TotalAll.Content = "0";

        }
        private void OnUpdate(Object sender, EventArgs e)
        {
            if (!D1Lock)
            {
                DiceS1.Fill = Brushes.PaleGreen;
            }
            else
            {
                DiceS1.Fill = Brushes.MistyRose;
            }
            if (!D2Lock)
            {
                DiceS2.Fill = Brushes.PaleGreen;
            }
            else
            {
                DiceS2.Fill = Brushes.MistyRose;
            }
            if (!D3Lock)
            {
                DiceS3.Fill = Brushes.PaleGreen;
            }
            else
            {
                DiceS3.Fill = Brushes.MistyRose;
            }
            if (!D4Lock)
            {
                DiceS4.Fill = Brushes.PaleGreen;
            }
            else
            {
                DiceS4.Fill = Brushes.MistyRose;
            }
            if (!D5Lock)
            {
                DiceS5.Fill = Brushes.PaleGreen;
            }
            else
            {
                DiceS5.Fill = Brushes.MistyRose;
            }


            if (Started)
            {
                if(P1Name.Text == "Player1")
                {
                    P1Name.Visibility = Visibility.Hidden;
                    P1Name.IsEnabled = false;
                    P1Border.Visibility = Visibility.Hidden;
                }
                else
                {
                    if(PlayerCount == 0)
                    {
                     PlayerCount += 1;
                    }
                    P1Name.IsEnabled = false;
                }
                if (P2Name.Text == "Player2")
                {
                    P2Name.Visibility = Visibility.Hidden;
                    P2Name.IsEnabled = false;
                    P2Border.Visibility = Visibility.Hidden;
                }
                else
                {
                    if (PlayerCount == 1)
                    {
                        PlayerCount += 1;
                    }
                    P2Name.IsEnabled = false;
                }
                if (P3Name.Text == "Player3")
                {
                    P3Name.Visibility = Visibility.Hidden;
                    P3Name.IsEnabled = false;
                    P3Border.Visibility = Visibility.Hidden;
                }
                else
                {
                    if (PlayerCount == 2)
                    {
                        PlayerCount += 1;
                    }
                    P3Name.IsEnabled = false;
                }
                if (P4Name.Text == "Player4")
                {
                    P4Name.Visibility = Visibility.Hidden;
                    P4Name.IsEnabled = false;
                    P4Border.Visibility = Visibility.Hidden;
                }
                else
                {
                    if (PlayerCount == 3)
                    {
                        PlayerCount += 1;
                    }
                    P4Name.IsEnabled = false;
                }
                if(PlayerTurn == 1)
                {
                    P1Name.Background = Brushes.PaleGreen;
                    P1Bord.Fill = Brushes.PaleGreen;
                }
                else
                {
                    P1Name.Background = Brushes.White;
                    P1Bord.Fill = Brushes.AliceBlue;
                }
                if (PlayerTurn == 2)
                {
                    P2Name.Background = Brushes.PaleGreen;
                    P2Bord.Fill = Brushes.PaleGreen;
                }
                else
                {
                    P2Name.Background = Brushes.White;
                    P2Bord.Fill = Brushes.AliceBlue;
                }
                if (PlayerTurn == 3)
                {
                    P3Name.Background = Brushes.PaleGreen;
                    P3Bord.Fill = Brushes.PaleGreen;
                }
                else
                {
                    P3Name.Background = Brushes.White;
                    P3Bord.Fill = Brushes.AliceBlue;
                }
                if (PlayerTurn == 4)
                {
                    P4Name.Background = Brushes.PaleGreen;
                    P4Bord.Fill = Brushes.PaleGreen;
                }
                else
                {
                    P4Name.Background = Brushes.White;
                    P4Bord.Fill = Brushes.AliceBlue;
                }

            }
            if (!Started)
            {
                    P1Name.Visibility = Visibility.Visible;
                    P1Name.IsEnabled = true;
                    P1Border.Visibility = Visibility.Visible;

                    P2Name.Visibility = Visibility.Visible;
                    P2Name.IsEnabled = true;
                    P2Border.Visibility = Visibility.Visible;

                    P3Name.Visibility = Visibility.Visible;
                    P3Name.IsEnabled = true;
                    P3Border.Visibility = Visibility.Visible;

                    P4Name.Visibility = Visibility.Visible;
                    P4Name.IsEnabled = true;
                    P4Border.Visibility = Visibility.Visible;
                if (!P1Name.IsFocused && P1Name.Text == "")
                {
                    P1Name.Text = "Player1";
                }
                if (!P2Name.IsFocused && P2Name.Text == "")
                {
                    P2Name.Text = "Player2";
                }
                if (!P3Name.IsFocused && P3Name.Text == "")
                {
                    P3Name.Text = "Player3";
                }
                if (!P4Name.IsFocused && P4Name.Text == "")
                {
                    P4Name.Text = "Player4";
                }
            }
            if (roll)
            {
               int CountRoll1 = rng.Next(15, 60);
               int CountRoll2 = rng.Next(15, 60);
               int CountRoll3 = rng.Next(15, 60);
               int CountRoll4 = rng.Next(15, 60);
               int CountRoll5 = rng.Next(15, 60);
                if (cDelay < CountRoll1)
                {
                    cDelay++;
                    if (!D1Lock)
                    {
                        var TempRng = rng.Next(1, 7);
                        Dice1.Content = "D" + TempRng;
                        if(TempRng > 0 && TempRng < 7)
                        {
                            zDice1.Source = DiceImg[TempRng - 1].Source;
                        }
                        
                    }
                }
                if(cDelay < CountRoll2)
                {
                    cDelay++;
                    if (!D2Lock)
                    {
                        var TempRng = rng.Next(1, 7);
                        Dice2.Content = "D" + TempRng;
                        if (TempRng > 0 && TempRng < 7)
                        {
                            zDice2.Source = DiceImg[TempRng - 1].Source;
                        }
                    }
                }
                if (cDelay < CountRoll3)
                {
                    cDelay++;
                    if (!D3Lock)
                    {
                        var TempRng = rng.Next(1, 7);
                        Dice3.Content = "D" + TempRng;
                        if (TempRng > 0 && TempRng < 7)
                        {
                            zDice3.Source = DiceImg[TempRng - 1].Source;
                        }
                    }
                }
                if (cDelay < CountRoll4)
                {
                    cDelay++;
                    if (!D4Lock)
                    {
                        var TempRng = rng.Next(1, 7);
                        Dice4.Content = "D" + TempRng;
                        if (TempRng > 0 && TempRng < 7)
                        {
                            zDice4.Source = DiceImg[TempRng - 1].Source;
                        }
                    }
                }
                if (cDelay < CountRoll5)
                {
                    cDelay++;
                    if (!D5Lock)
                    {
                        var TempRng = rng.Next(1, 7);
                        Dice5.Content = "D" + TempRng;
                        if (TempRng > 0 && TempRng < 7)
                        {
                            zDice5.Source = DiceImg[TempRng - 1].Source;
                        }
                    }
                }
                if(cDelay >= CountRoll1 && cDelay >= CountRoll2 && cDelay >= CountRoll3 && cDelay >= CountRoll4 && cDelay >= CountRoll5)
                {
                    roll = false;
                    cDelay = 0;
                }
            }


        }
        private void LockDice(Object sender, EventArgs e)
        {
            if (!roll && RolledOnce)
            {

            
            if(zDice1 == sender)
            {
                D1Lock = !D1Lock;
            }
            if (zDice2 == sender)
            {
                D2Lock = !D2Lock;
            }
            if (zDice3 == sender)
            {
                D3Lock = !D3Lock;
            }
            if (zDice4 == sender)
            {
                D4Lock = !D4Lock;
            }
            if (zDice5 == sender)
            {
                D5Lock = !D5Lock;
            }
            }
        }
        private void UnlockDice()
        {
            CanRoll = true;
            D1Lock = false;
            D2Lock = false;
            D3Lock = false;
            D4Lock = false;
            D5Lock = false;
            Dice1.Content = "D0";
            Dice2.Content = "D0";
            Dice3.Content = "D0";
            Dice4.Content = "D0";
            Dice5.Content = "D0";
        }

        private void UpdateScore(int PNumb, int Score, bool top)
        {
            if(PNumb == 1)
            {
                if(top == true)
                {
                    P1Tot.Content = Convert.ToInt32(P1Tot.Content) + Score;
                    if (Convert.ToInt32(P1Tot.Content) >= 63 && bonus1 == false)
                    {
                        bonus1 = true;
                        P1Bon.Content = "35";
                        P1Tot.Content = Convert.ToInt32(P1Tot.Content) + 35;
                    }
                    P1Total.Content = P1Tot.Content;
                }
                
                if (top == false)
                {
                    pval1 = pval1 + Score;
                }
                P1TotalAll.Content = pval1 + Convert.ToInt32(P1Total.Content);
                
                
                
            }
            if (PNumb == 2)
            {
                if (top == true)
                {
                    P2Tot.Content = Convert.ToInt32(P2Tot.Content) + Score;
                    if (Convert.ToInt32(P2Tot.Content) >= 63 && bonus2 == false)
                    {
                        bonus2 = true;
                        P2Bon.Content = "35";
                        P2Tot.Content = Convert.ToInt32(P2Tot.Content) + 35;
                    }
                    P2Total.Content = P2Tot.Content;
                }

                if (top == false)
                {
                    pval2 = pval2 + Score;
                }
                P2TotalAll.Content = pval2 + Convert.ToInt32(P2Total.Content);


            }
            if (PNumb == 3)
            {
                                if (top == true)
                {
                    P3Tot.Content = Convert.ToInt32(P3Tot.Content) + Score;
                    if (Convert.ToInt32(P3Tot.Content) >= 63 && bonus3 == false)
                    {
                        bonus3 = true;
                        P3Bon.Content = "35";
                        P3Tot.Content = Convert.ToInt32(P3Tot.Content) + 35;
                    }
                    P3Total.Content = P3Tot.Content;
                }

                if (top == false)
                {
                    pval3 = pval3 + Score;
                }
                P3TotalAll.Content = pval3 + Convert.ToInt32(P3Total.Content);


            }
            if (PNumb == 4)
            {
                if (top == true)
                {
                    P4Tot.Content = Convert.ToInt32(P4Tot.Content) + Score;
                    if (Convert.ToInt32(P4Tot.Content) >= 63 && bonus4 == false)
                    {
                        bonus4 = true;
                        P4Bon.Content = "35";
                        P4Tot.Content = Convert.ToInt32(P4Tot.Content) + 35;
                    }
                    P4Total.Content = P4Tot.Content;
                }

                if (top == false)
                {
                    pval4 = pval4 + Score;
                }
                P4TotalAll.Content = pval4 + Convert.ToInt32(P4Total.Content);

            }
        }

        private void LabelClick(Object sender, MouseButtonEventArgs e)
        {
            if (Dice1.Content.ToString() == "D0" || Dice2.Content.ToString() == "D0" || Dice3.Content.ToString() == "D0" || Dice4.Content.ToString() == "D0" || Dice5.Content.ToString() == "D0")
            {
                return;
            }
            if (roll)
            {
                return;
            }
            if(sender is Label label)
            {
                if (label.Name.StartsWith("P1") && PlayerTurn == 1 && label.Content.ToString() == "")
                {
                    if (label.Name.EndsWith("1") || label.Name.EndsWith("2") || label.Name.EndsWith("3") || label.Name.EndsWith("4") || label.Name.EndsWith("5") || label.Name.EndsWith("6"))
                    {
                        for (int i = 0; i < DiceLabel.Count; i++)
                        {
                            var DiceVal = DiceLabel[i].Content.ToString()[DiceLabel[i].Content.ToString().Length - 1].ToString();
                            if (label.Name.EndsWith(DiceVal))
                            {
                                if (label.Content.ToString() != "")
                                {
                                    label.Content = Convert.ToInt32(label.Content.ToString()) + Convert.ToInt32(DiceVal);
                                }
                                else
                                {
                                    label.Content += DiceVal;
                                }

                            }
                        }
                        if (label.Content.ToString() == "")
                        {
                            return;
                        }
                        var Scre = Convert.ToInt32(label.Content.ToString());
                        UpdateScore(1, Scre, true);

                    }
                    if (label.Name.EndsWith("3K"))
                    {

                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            
                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 3)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(1, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }

                    }
                    if (label.Name.EndsWith("4K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            
                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 4)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(1, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("5K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            
                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 5)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(1, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("FH"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            
                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 2)
                                    {
                                        Memval = Convert.ToInt32(entry.Key);
                                    }
                                    if (entry.Value == 3)
                                    {
                                        Memval2 = Convert.ToInt32(entry.Key);
                                    }
                                    if (Memval2 != 0 && Memval != 0)
                                    {
                                        label.Content = Memval * 2 + Memval2 * 3;
                                        UpdateScore(1, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("SST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4))
                        {
                            label.Content = 10;
                            UpdateScore(1, 10, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 14;
                            UpdateScore(1, 14, false);
                        }
                        if (multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 18;
                            UpdateScore(1, 18, false);
                        }
                    }
                    if (label.Name.EndsWith("LST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 15;
                            UpdateScore(1, 15, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 20;
                            UpdateScore(1, 20, false);
                        }
                    }
                    if (label.Name.EndsWith("Any"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }

                        label.Content = multiCount[0] + multiCount[1] + multiCount[2] + multiCount[3] + multiCount[4];
                        UpdateScore(1, Convert.ToInt32(label.Content), false);
                    }
                    if (label.Content.ToString().Length > 0)
                    {
                        if (PlayerTurn < PlayerCount)
                        {
                            PlayerTurn += 1;
                        }
                        else
                        {
                            PlayerTurn = 1;
                        }
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        RollCount = 0;
                        UnlockDice();
                    }
                }
                if (label.Name.StartsWith("P2") && PlayerTurn == 2)
                {
                    if (label.Name.EndsWith("1") || label.Name.EndsWith("2") || label.Name.EndsWith("3") || label.Name.EndsWith("4") || label.Name.EndsWith("5") || label.Name.EndsWith("6"))
                    {
                        for (int i = 0; i < DiceLabel.Count; i++)
                        {
                            var DiceVal = DiceLabel[i].Content.ToString()[DiceLabel[i].Content.ToString().Length - 1].ToString();
                            if (label.Name.EndsWith(DiceVal))
                            {
                                if (label.Content.ToString() != "")
                                {
                                    label.Content = Convert.ToInt32(label.Content.ToString()) + Convert.ToInt32(DiceVal);
                                }
                                else
                                {
                                    label.Content += DiceVal;
                                }

                            }
                        }
                        if (label.Content.ToString() == "")
                        {
                            return;
                        }
                        var Scre = Convert.ToInt32(label.Content.ToString());
                        UpdateScore(2, Scre, true);

                    }
                    if (label.Name.EndsWith("3K"))
                    {

                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 3)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(2, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }

                    }
                    if (label.Name.EndsWith("4K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 4)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(2, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("5K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 5)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(2, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("FH"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 2)
                                    {
                                        Memval = Convert.ToInt32(entry.Key);
                                    }
                                    if (entry.Value == 3)
                                    {
                                        Memval2 = Convert.ToInt32(entry.Key);
                                    }
                                    if (Memval2 != 0 && Memval != 0)
                                    {
                                        label.Content = Memval * 2 + Memval2 * 3;
                                        UpdateScore(2, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("SST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4))
                        {
                            label.Content = 10;
                            UpdateScore(2, 10, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 14;
                            UpdateScore(2, 14, false);
                        }
                        if (multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 18;
                            UpdateScore(2, 18, false);
                        }
                    }
                    if (label.Name.EndsWith("LST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 15;
                            UpdateScore(2, 15, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 20;
                            UpdateScore(2, 20, false);
                        }
                    }
                    if (label.Name.EndsWith("Any"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }

                        label.Content = multiCount[0] + multiCount[1] + multiCount[2] + multiCount[3] + multiCount[4];
                        UpdateScore(2, Convert.ToInt32(label.Content), false);
                    }
                    if (label.Content.ToString().Length > 0)
                    {
                        if (PlayerTurn < PlayerCount)
                        {
                            PlayerTurn += 1;
                        }
                        else
                        {
                            PlayerTurn = 1;
                        }
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        RollCount = 0;
                        UnlockDice();
                    }
                }
                if (label.Name.StartsWith("P3") && PlayerTurn == 3)
                {
                    if (label.Name.EndsWith("1") || label.Name.EndsWith("2") || label.Name.EndsWith("3") || label.Name.EndsWith("4") || label.Name.EndsWith("5") || label.Name.EndsWith("6"))
                    {
                        for (int i = 0; i < DiceLabel.Count; i++)
                        {
                            var DiceVal = DiceLabel[i].Content.ToString()[DiceLabel[i].Content.ToString().Length - 1].ToString();
                            if (label.Name.EndsWith(DiceVal))
                            {
                                if (label.Content.ToString() != "")
                                {
                                    label.Content = Convert.ToInt32(label.Content.ToString()) + Convert.ToInt32(DiceVal);
                                }
                                else
                                {
                                    label.Content += DiceVal;
                                }

                            }
                        }
                        if (label.Content.ToString() == "")
                        {
                            return;
                        }
                        var Scre = Convert.ToInt32(label.Content.ToString());
                        UpdateScore(3, Scre, true);

                    }
                    if (label.Name.EndsWith("3K"))
                    {

                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 3)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(3, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }

                    }
                    if (label.Name.EndsWith("4K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 4)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(3, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("5K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 5)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(3, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("FH"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 2)
                                    {
                                        Memval = Convert.ToInt32(entry.Key);
                                    }
                                    if (entry.Value == 3)
                                    {
                                        Memval2 = Convert.ToInt32(entry.Key);
                                    }
                                    if (Memval2 != 0 && Memval != 0)
                                    {
                                        label.Content = Memval * 2 + Memval2 * 3;
                                        UpdateScore(3, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("SST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4))
                        {
                            label.Content = 10;
                            UpdateScore(3, 10, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 14;
                            UpdateScore(3, 14, false);
                        }
                        if (multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 18;
                            UpdateScore(3, 18, false);
                        }
                    }
                    if (label.Name.EndsWith("LST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 15;
                            UpdateScore(3, 15, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 20;
                            UpdateScore(3, 20, false);
                        }
                    }
                    if (label.Name.EndsWith("Any"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }

                        label.Content = multiCount[0] + multiCount[1] + multiCount[2] + multiCount[3] + multiCount[4];
                        UpdateScore(3, Convert.ToInt32(label.Content), false);
                    }
                    if (label.Content.ToString().Length > 0)
                    {
                        if (PlayerTurn < PlayerCount)
                        {
                            PlayerTurn += 1;
                        }
                        else
                        {
                            PlayerTurn = 1;
                        }
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        RollCount = 0;
                        UnlockDice();
                    }
                }
                if (label.Name.StartsWith("P4") && PlayerTurn == 4)
                {
                    if (label.Name.EndsWith("1") || label.Name.EndsWith("2") || label.Name.EndsWith("3") || label.Name.EndsWith("4") || label.Name.EndsWith("5") || label.Name.EndsWith("6"))
                    {
                        for (int i = 0; i < DiceLabel.Count; i++)
                        {
                            var DiceVal = DiceLabel[i].Content.ToString()[DiceLabel[i].Content.ToString().Length - 1].ToString();
                            if (label.Name.EndsWith(DiceVal))
                            {
                                if (label.Content.ToString() != "")
                                {
                                    label.Content = Convert.ToInt32(label.Content.ToString()) + Convert.ToInt32(DiceVal);
                                }
                                else
                                {
                                    label.Content += DiceVal;
                                }

                            }
                        }
                        if (label.Content.ToString() == "")
                        {
                            return;
                        }
                        var Scre = Convert.ToInt32(label.Content.ToString());
                        UpdateScore(4, Scre, true);

                    }
                    if (label.Name.EndsWith("3K"))
                    {

                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 3)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(4, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }

                    }
                    if (label.Name.EndsWith("4K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value >= 4)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(4, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("5K"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 5)
                                    {
                                        label.Content = label.Content.ToString() + Convert.ToInt32(entry.Key) * Convert.ToInt32(entry.Value);
                                        UpdateScore(4, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("FH"))
                    {
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        foreach (Label zlabel in DiceLabel)
                        {

                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();

                            multiCount.Add(Convert.ToInt32(DiceVal));
                            if (multiCount.Count == 5)
                            {
                                foreach (int i in multiCount)
                                {
                                    if (!multiCountDupe.ContainsKey(i.ToString()))
                                    {
                                        multiCountDupe.Add(i.ToString(), 1);
                                    }
                                    else
                                    {
                                        int count = 0;
                                        multiCountDupe.TryGetValue(i.ToString(), out count);
                                        multiCountDupe.Remove(i.ToString());
                                        multiCountDupe.Add(i.ToString(), count + 1);
                                    }
                                }
                                foreach (KeyValuePair<string, int> entry in multiCountDupe)
                                {
                                    if (entry.Value == 2)
                                    {
                                        Memval = Convert.ToInt32(entry.Key);
                                    }
                                    if (entry.Value == 3)
                                    {
                                        Memval2 = Convert.ToInt32(entry.Key);
                                    }
                                    if (Memval2 != 0 && Memval != 0)
                                    {
                                        label.Content = Memval * 2 + Memval2 * 3;
                                        UpdateScore(4, Convert.ToInt32(label.Content), false);
                                    }
                                }

                            }
                        }
                    }
                    if (label.Name.EndsWith("SST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4))
                        {
                            label.Content = 10;
                            UpdateScore(4, 10, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 14;
                            UpdateScore(4, 14, false);
                        }
                        if (multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 18;
                            UpdateScore(4, 18, false);
                        }
                    }
                    if (label.Name.EndsWith("LST"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }
                        if (multiCount.Contains(1) && multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5))
                        {
                            label.Content = 15;
                            UpdateScore(4, 15, false);
                        }
                        if (multiCount.Contains(2) && multiCount.Contains(3) && multiCount.Contains(4) && multiCount.Contains(5) && multiCount.Contains(6))
                        {
                            label.Content = 20;
                            UpdateScore(4, 20, false);
                        }
                    }
                    if (label.Name.EndsWith("Any"))
                    {
                        foreach (Label zlabel in DiceLabel)
                        {
                            var DiceVal = zlabel.Content.ToString()[zlabel.Content.ToString().Length - 1].ToString();
                            multiCount.Add(Convert.ToInt32(DiceVal));
                        }

                        label.Content = multiCount[0] + multiCount[1] + multiCount[2] + multiCount[3] + multiCount[4];
                        UpdateScore(4, Convert.ToInt32(label.Content), false);
                    }
                    if (label.Content.ToString().Length > 0)
                    {
                        if (PlayerTurn < PlayerCount)
                        {
                            PlayerTurn += 1;
                        }
                        else
                        {
                            PlayerTurn = 1;
                        }
                        multiCount.Clear();
                        multiCountDupe.Clear();
                        RollCount = 0;
                        UnlockDice();
                    }
                }
            }
        }
        private void Roll_Click(object sender, RoutedEventArgs e)
        {

                if(CanRoll && RollCount < 3)
                {
                      roll = true;
                      RolledOnce = true;
                      RollCount++;
                      if (RollCount == 3)
                      {
                         RollCount = 0;
                         CanRoll = false;
                      }
                }
            
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Started = !Started;
            if (Started)
            {
                RolledOnce = false;
                UnlockDice();
                PlayerTurn = 1;
                Start.Content = "Stop";
            }
            if (!Started)
            {
                RolledOnce = false;
                roll = false;
                CanRoll = false;
                bonus1 = false;
                bonus2 = false;
                bonus3 = false;
                bonus4 = false;
                Dice1.Content = "D0";
                Dice2.Content = "D0";
                Dice3.Content = "D0";
                Dice4.Content = "D0";
                Dice5.Content = "D0";
                pval1 = 0;
                pval2 = 0;
                pval3 = 0;
                pval4 = 0;
                multiCount.Clear();
                multiCountDupe.Clear();
                PlayerTurn = 0;
                Start.Content = "Start";
                CleanBoard();
            }
        }


    }
}
