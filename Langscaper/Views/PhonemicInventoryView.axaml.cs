using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Layout;
using Avalonia.Media;
using Langscaper.ViewModels;
using Langscaper_Core.Phonology;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Langscaper.Views;

public partial class PhonemicInventoryView : UserControl
{
    public PhonemicInventoryView()
    {
        InitializeComponent();
        DataContextChanged += (s, e) => 
        {
            if (DataContext is not PhonemicInventoryViewModel vm) return;
            vm.RefreshGrids += SetupGrids;
            SetupGrids();
        };

    }



    private void ClearGrid(Grid grid)
    {
        grid.Children.Clear();
        grid.RowDefinitions.Clear();
        grid.ColumnDefinitions.Clear();
    }
    private void GenerateGridLabels(Grid grid, string[] rowLabels, string[] columnLabels)
    {
        int rowCount = rowLabels.Length;
        int colCount = columnLabels.Length;

        for (int i = 0; i <= rowCount; i++)
            grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

        for (int j = 0; j <= columnLabels.Length; j++)
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });


        for (int j = 0; j < columnLabels.Length; j++)
        {
            var textBlock = new TextBlock
            {
                Text = columnLabels[j],
                FontSize = 14,
                FontWeight = FontWeight.Bold,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(5),
                MinWidth = 30
            };

            Grid.SetRow(textBlock, 0);
            Grid.SetColumn(textBlock, j + 1);
            grid.Children.Add(textBlock);
        }

        for (int i = 0; i < rowLabels.Length; i++)
        {
            var textBlock = new TextBlock
            {
                Text = rowLabels[i],
                FontSize = 14,
                FontWeight = FontWeight.Bold,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(5),
                MinWidth = 30
            };

            Grid.SetRow(textBlock, i + 1);
            Grid.SetColumn(textBlock, 0);
            grid.Children.Add(textBlock);
        }

    }
    private void SetupPhonemeGrid(Grid grid, IEnumerable<PhonemTemplate> phonemViews, bool skipZeroIndexes = false)
    {
        var cellData = new Dictionary<(int, int), List<string>>();

        foreach (var phonem in phonemViews)
        {
            int row = phonem.Row, col = phonem.Column;
            if (skipZeroIndexes && (row == 0 || col == 0)) continue;

            if (!cellData.ContainsKey((row, col)))
                cellData[(row, col)] = new List<string>();

            cellData[(row, col)].Add(phonem.Ipa);
        }

        foreach (var (position, phonemeList) in cellData)
        {
            var stackPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(5)
            };

            foreach (var phonemeIpa in phonemeList)
            {
                var phoneme = phonemViews.FirstOrDefault(p => p.Ipa == phonemeIpa);
                if (phoneme == null) continue;

                var textBlock = new TextBlock
                {
                    Text = phonemeIpa,
                    FontSize = 12,
                    Foreground = GetFilterForgroundColor(phoneme),
                    Background = GetFilterColor(phoneme),
                    Margin = new Thickness(1),
                    Padding = new Thickness(3)
                };

                textBlock.DataContext = phoneme;
                textBlock.PointerPressed += OnPhonemePointerPressed;

                stackPanel.Children.Add(textBlock);
            }

            Grid.SetRow(stackPanel, position.Item1);
            Grid.SetColumn(stackPanel, position.Item2);
            grid.Children.Add(stackPanel);
        }
    }

 
    private void OnPhonemePointerPressed(object sender, PointerPressedEventArgs e)
    {
        if (!e.GetCurrentPoint(this).Properties.IsRightButtonPressed) return;

        var phoneme = (sender as TextBlock)?.DataContext as PhonemTemplate;
        phoneme?.PlaySoundCommand.Execute(null);
    }
    private void SetupGrids()
    {
        if (DataContext is not PhonemicInventoryViewModel vm) return;

        isRarityFilterActive = vm.IsRarityEnabled;
        isSonorantFilterActive = vm.IsSonorantEnabled;

        ClearGrid(VowelGrid);
        ClearGrid(ConsonantGrid);

        SetupPhonemeGrid(VowelGrid, vm.Vowels);
        SetupPhonemeGrid(ConsonantGrid, vm.Consonants, skipZeroIndexes: true);

        GenerateGridLabels(VowelGrid,
                           ["Close", "Near-close", "Close-mid", "Mid", "Open-mid", "Near-open", "Open"],
                           ["Front", "Central", "Back"]);
        GenerateGridLabels(ConsonantGrid,
                           ["Plosive", "Nasals", "Trill", "Tap/Flap", "Fricative", "Lateral fricative", "Approximant", "Lateral approximant", "Click", "Ejective", "Implosive"],
                           ["Bialabial", "Labiodental", "Dental", "Alveolar", "Postalveolar", "Retroflex", "Palatal", "Velar", "Uvular", "Pharyngeal", "Glottal"]);


    }

    #region Filters

     bool isRarityFilterActive;
     bool isSonorantFilterActive;
    private IBrush GetRarityColor(byte rarity)
    {
        Color color;

        if (rarity <= 8)
        {
            // 🔴 Rouge vif → Rouge foncé
            double t = rarity / 8.0;
            color = Color.FromRgb(255, (byte)(50 + 100 * t), (byte)(50 + 100 * t));
        }
        else if (rarity <= 18)
        {
            // 🟠 Orange vif → Orange foncé
            double t = (rarity - 10) / 8.0;
            color = Color.FromRgb(255, (byte)(150 + 50 * (1 - t)), 0);
        }
        else if (rarity <= 45)
        {
            // 🟡 Jaune vif → Jaune foncé
            double t = (rarity - 32) / 13.0;
            color = Color.FromRgb(255, (byte)(255 - 100 * t), 0);
        }
        else
        {
            // 🟢 Vert clair → Vert foncé
            double t = (rarity - 75) / 23.0;
            color = Color.FromRgb((byte)(50 * (1 - t)), (byte)(200 - 50 * t), 0);
        }

        return new SolidColorBrush(color);
    }

    private IBrush GetFilterForgroundColor(PhonemTemplate phoneme)
    {
        if (isSonorantFilterActive && phoneme.IsSonorant)
            return Brushes.Fuchsia;

        return Brushes.Black;
    }


    private IBrush GetFilterColor(PhonemTemplate p)
    {
        if(isRarityFilterActive)
            return GetRarityColor(p.Rarity);

        return Brushes.Transparent; 

    }

    #endregion
}