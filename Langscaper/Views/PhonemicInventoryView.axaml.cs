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
        DataContextChanged += (s, e) => SetupVowelGrid();
        DataContextChanged += (s, e) => SetupPulmonicConsonantGrid();
    }

    private void SetupVowelGrid()
    {
        if (DataContext is not PhonemicInventoryViewModel vm) return;

        VowelGrid.Children.Clear();
        VowelGrid.RowDefinitions.Clear();
        VowelGrid.ColumnDefinitions.Clear();

        string[] columnLabels = { "Front", "Central", "Back" };
        string[] rowLabels = { "Close","Near-close", "Close-mid", "Mid", "Open-mid", "Near-open","Open" };

        int rowCount = rowLabels.Length;
        int colCount = columnLabels.Length;

        for (int i = 0; i <= rowCount; i++)
            VowelGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });

        for (int j = 0; j <= columnLabels.Length; j++)
            VowelGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });


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
            VowelGrid.Children.Add(textBlock);
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
            VowelGrid.Children.Add(textBlock);
        }

        var cellData = new Dictionary<(int, int), List<string>>();

        foreach (var phonem in vm.Vowels)
        {
            int row = phonem.Row;
            int col = phonem.Column;

            if (!cellData.ContainsKey((row, col)))
            {
                cellData[(row, col)] = new List<string>();
            }

            cellData[(row, col)].Add(phonem.Ipa);
        }

        foreach (var (position, phonemes) in cellData)
        {
            var textBlock = new TextBlock
            {
                Text = string.Join(", ", phonemes),
                FontSize = 12,
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(5)
            };

            Grid.SetRow(textBlock, position.Item1);
            Grid.SetColumn(textBlock, position.Item2);
            VowelGrid.Children.Add(textBlock);
        }
    }

    private void SetupPulmonicConsonantGrid()
    {
        if (DataContext is not PhonemicInventoryViewModel vm) return;

        PulmonicConsonantGrid.Children.Clear();
        PulmonicConsonantGrid.RowDefinitions.Clear();
        PulmonicConsonantGrid.ColumnDefinitions.Clear();

        string[] columnLabels = { "Bialabial", "Labiodental", "Dental", "Alveolar", "Postalveolar", "Retroflex", "Palatal", "Velar", "Uvular", "Pharyngeal", "Glottal" };
        string[] rowLabels = { "Plosive", "Nasal", "Trill", "Tap/Flap", "Fricative", "Lateral fricative", "Approximant", "Lateral approximant" };

        int rowCount = rowLabels.Length;
        int colCount = columnLabels.Length;

        for (int i = 0; i <= rowCount; i++)
            PulmonicConsonantGrid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Auto });


        for (int j = 0; j <= colCount; j++)
            PulmonicConsonantGrid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });

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
            PulmonicConsonantGrid.Children.Add(textBlock);
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
            PulmonicConsonantGrid.Children.Add(textBlock);
        }

        var cellData = new Dictionary<(int, int), List<string>>();

        foreach (var phonem in vm.PulmonicConsonants)
        {
            int row = phonem.Row;
            int col = phonem.Column;


            if (!cellData.ContainsKey((row, col)))
            {
                cellData[(row, col)] = new List<string>();
            }

            cellData[(row, col)].Add(phonem.Ipa);
        }

        foreach (var (position, phonemes) in cellData)
        {
            if (position.Item1 == 0 || position.Item2 == 0) continue;
            var textBlock = new TextBlock
            {
                Text = string.Join(", ", phonemes),
                FontSize = 12,
                Foreground = Brushes.Black,
                HorizontalAlignment = HorizontalAlignment.Center,
                Margin = new Thickness(5)
            };

            Grid.SetRow(textBlock, position.Item1);
            Grid.SetColumn(textBlock, position.Item2);
            PulmonicConsonantGrid.Children.Add(textBlock);

        }
    }
}