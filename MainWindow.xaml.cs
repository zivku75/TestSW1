using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace SystemInfoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            // Set up the timer to update time every second
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            // Initialize system info displays
            UpdateSystemInfo();

            // Initialize color dropdown
            InitializeColorDropdown();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTimeDisplay();
        }

        private void UpdateTimeDisplay()
        {
            TimeDisplay.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void UpdateSystemInfo()
        {
            // Update Time
            UpdateTimeDisplay();

            // Update Day
            DayDisplay.Text = DateTime.Now.ToString("dddd");

            // Update Year
            YearDisplay.Text = DateTime.Now.Year.ToString();

            // Update Local IP Address
            IPDisplay.Text = SystemInfoHelper.GetLocalIPAddress();
        }

        private void InitializeColorDropdown()
        {
            // Create a collection of suggested colors
            ObservableCollection<ColorItem> colors = new ObservableCollection<ColorItem>
            {
                new ColorItem("Red", "#FF0000"),
                new ColorItem("Green", "#00AA00"),
                new ColorItem("Blue", "#0078D4"),
                new ColorItem("Yellow", "#FFFF00"),
                new ColorItem("Purple", "#800080"),
                new ColorItem("Orange", "#FFA500")
            };

            // Shuffle the colors for randomness
            ShuffleColors(colors);

            ColorComboBox.ItemsSource = colors;
            ColorComboBox.DisplayMemberPath = "Name";
            ColorComboBox.SelectedIndex = 0;
        }

        private void ShuffleColors(ObservableCollection<ColorItem> colors)
        {
            int n = colors.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int randomIndex = random.Next(0, i + 1);
                // Swap
                var temp = colors[i];
                colors[i] = colors[randomIndex];
                colors[randomIndex] = temp;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Stop the timer
            if (timer != null)
            {
                timer.Stop();
                timer = null;
            }

            // Close the application
            this.Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (timer != null)
            {
                timer.Stop();
            }
        }
    }

    /// <summary>
    /// Helper class for color items in the dropdown
    /// </summary>
    public class ColorItem
    {
        public string Name { get; set; }
        public string HexColor { get; set; }

        public ColorItem(string name, string hexColor)
        {
            Name = name;
            HexColor = hexColor;
        }
    }
}