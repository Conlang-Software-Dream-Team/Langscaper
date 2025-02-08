using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Langscaper.ViewModels;
using System.Collections.Generic;

namespace Langscaper.Views;

public partial class PhonemicInventoryView : UserControl
{
    public PhonemicInventoryView()
    {
        InitializeComponent();
        DataContextChanged += (s, e) => SetupGrids();
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
            var textBlock = new TextBlock
            {
                Text = string.Join(", ", phonemeList),
                FontSize = 12,
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(5)
            };

            Grid.SetRow(textBlock, position.Item1);
            Grid.SetColumn(textBlock, position.Item2);
            grid.Children.Add(textBlock);
        }
    }
    private void SetupGrids()
    {
        if (DataContext is not PhonemicInventoryViewModel vm) return;

        ClearGrid(VowelGrid);
        ClearGrid(ConsonantGrid);

        SetupPhonemeGrid(VowelGrid, vm.Vowels);
        SetupPhonemeGrid(ConsonantGrid, vm.Consonants, skipZeroIndexes: true);

        GenerateGridLabels(VowelGrid,
                           ["Close", "Near-close", "Close-mid", "Mid", "Open-mid", "Near-open", "Open"],
                           ["Front", "Central", "Back"]);
        GenerateGridLabels(ConsonantGrid,
                           ["Plosive", "Nasal", "Trill", "Tap/Flap", "Fricative", "Lateral fricative", "Approximant", "Lateral approximant", "Click", "Ejective", "Implosive"],
                           ["Bialabial", "Labiodental", "Dental", "Alveolar", "Postalveolar", "Retroflex", "Palatal", "Velar", "Uvular", "Pharyngeal", "Glottal"]);
       

    }
}