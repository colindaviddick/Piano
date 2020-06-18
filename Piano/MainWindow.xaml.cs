using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Threading;

namespace Piano
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task PlayNote(Key key)
        {
            switch (key)
            {
                case Key.A:
                    Uri aUri = new Uri("sounds/a.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayera = new MediaPlayer();
                    mediaPlayera.Open(aUri);
                    C3.Background = Brushes.Blue;
                    mediaPlayera.Play();                     
                    await Task.Delay(500);
                    C3.Background = Brushes.FloralWhite;

                    break;
                case Key.S:
                    Uri sUri = new Uri("sounds/s.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayers = new MediaPlayer();
                    mediaPlayers.Open(sUri);
                    D3.Background = Brushes.Red;
                    mediaPlayers.Play();                     await Task.Delay(500);
                    D3.Background = Brushes.FloralWhite;

                    break;
                case Key.D:
                    Uri dUri = new Uri("sounds/d.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerd = new MediaPlayer();
                    mediaPlayerd.Open(dUri);
                    E3.Background = Brushes.Green;
                    mediaPlayerd.Play();                     await Task.Delay(500);
                    E3.Background = Brushes.FloralWhite;

                    break;
                case Key.F:
                    Uri fUri = new Uri("sounds/f.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerf = new MediaPlayer();
                    mediaPlayerf.Open(fUri);
                    F3.Background = Brushes.Purple;
                    mediaPlayerf.Play();                     await Task.Delay(500);
                    F3.Background = Brushes.FloralWhite;

                    break;
                case Key.G:
                    Uri gUri = new Uri("sounds/g.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerg = new MediaPlayer();
                    mediaPlayerg.Open(gUri);
                    G3.Background = Brushes.Aqua;
                    mediaPlayerg.Play();                     await Task.Delay(500);
                    G3.Background = Brushes.FloralWhite;

                    break;
                case Key.H:
                    Uri hUri = new Uri("sounds/h.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerh = new MediaPlayer();
                    mediaPlayerh.Open(hUri);
                    A4.Background = Brushes.Chartreuse;
                    mediaPlayerh.Play();                     await Task.Delay(500);
                    A4.Background = Brushes.FloralWhite;

                    break;
                case Key.J:
                    Uri jUri = new Uri("sounds/j.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerj = new MediaPlayer();
                    mediaPlayerj.Open(jUri);
                    B4.Background = Brushes.DarkOrchid;
                    mediaPlayerj.Play();                     await Task.Delay(500);
                    B4.Background = Brushes.FloralWhite;

                    break;
                case Key.K:
                    Uri kUri = new Uri("sounds/k.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerk = new MediaPlayer();
                    mediaPlayerk.Open(kUri);
                    C4.Background = Brushes.Orange;
                    mediaPlayerk.Play();                     await Task.Delay(500);
                    C4.Background = Brushes.FloralWhite;

                    break;
                case Key.L:
                    Uri lUri = new Uri("sounds/l.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerl = new MediaPlayer();
                    mediaPlayerl.Open(lUri);
                    D4.Background = Brushes.Thistle;
                    mediaPlayerl.Play();                     await Task.Delay(500);
                    D4.Background = Brushes.FloralWhite;
                    break;
                //case Key.OemSemicolon:
                //    Uri scUri = new Uri("sounds/sc.wav", UriKind.RelativeOrAbsolute);
                //    MediaPlayer mediaPlayersc = new MediaPlayer();
                //    mediaPlayersc.Open(scUri);
                //    mediaPlayersc.Play();                     await Task.Delay(500);
                //    break;
                case Key.W:
                    Uri wUri = new Uri("sounds/w.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerw = new MediaPlayer();
                    mediaPlayerw.Open(wUri);
                    Cs3.Background = Brushes.Coral;
                    mediaPlayerw.Play();                     await Task.Delay(500);
                    Cs3.Background = Brushes.Black;
                    break;
                case Key.E:
                    Uri eUri = new Uri("sounds/e.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayere = new MediaPlayer();
                    mediaPlayere.Open(eUri);
                    Ds3.Background = Brushes.PaleGreen;
                    mediaPlayere.Play();                     await Task.Delay(500);
                    Ds3.Background = Brushes.Black;
                    break;
                case Key.T:
                    Uri tUri = new Uri("sounds/t.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayert = new MediaPlayer();
                    mediaPlayert.Open(tUri);
                    Fs3.Background = Brushes.PaleTurquoise;
                    mediaPlayert.Play();                     await Task.Delay(500);
                    Fs3.Background = Brushes.Black;
                    break;
                case Key.Y:
                    Uri yUri = new Uri("sounds/y.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayery = new MediaPlayer();
                    mediaPlayery.Open(yUri);
                    Gs3.Background = Brushes.PaleVioletRed;
                    mediaPlayery.Play();                     await Task.Delay(500);
                    Gs3.Background = Brushes.Black;
                    break;
                case Key.U:
                    Uri uUri = new Uri("sounds/u.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayeru = new MediaPlayer();
                    mediaPlayeru.Open(uUri);
                    As4.Background = Brushes.LightSeaGreen;
                    mediaPlayeru.Play();                     await Task.Delay(500);
                    As4.Background = Brushes.Black;
                    break;
                case Key.O:
                    Uri oUri = new Uri("sounds/o.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayero = new MediaPlayer();
                    mediaPlayero.Open(oUri);
                    Cs4.Background = Brushes.LightPink;
                    mediaPlayero.Play();                     await Task.Delay(500);
                    Cs4.Background = Brushes.Black;
                    break;
                case Key.P:
                    Uri pUri = new Uri("sounds/p.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerp = new MediaPlayer();
                    mediaPlayerp.Open(pUri);
                    Ds4.Background = Brushes.PaleGoldenrod;
                    mediaPlayerp.Play();                     await Task.Delay(500);
                    Ds4.Background = Brushes.Black;
                    break;
            }
        }

        private async void C3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.A);
        }

        private async void D3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.S);
        }

        private async void E3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.D);
        }

        private async void F3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.F);
        }

        private async void G3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.G);
        }

        private async void A4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.H);
        }

        private async void B4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.J);
        }

        private async void C4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.K);
        }

        private async void D4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.L);
        }

        private async void E4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.OemSemicolon);
        }

        private async void Window_KeyDown(object sender, KeyEventArgs e)
        {

            if (
                //White Keys
                e.Key == Key.A || e.Key == Key.S ||
                e.Key == Key.D || e.Key == Key.F ||
                e.Key == Key.G || e.Key == Key.H ||
                e.Key == Key.J || e.Key == Key.K ||
                e.Key == Key.L ||
                // Black keys
                e.Key == Key.W || e.Key == Key.E ||
                e.Key == Key.T || e.Key == Key.Y ||
                e.Key == Key.U || e.Key == Key.O ||
                e.Key == Key.P)
                await PlayNote(e.Key);
        }

        private async void Cs3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.W);
        }

        private async void Ds3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.E);
        }

        private async void Fs3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.T);
        }

        private async void Gs3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.Y);
        }

        private async void As4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.U);
        }

        private async void Cs4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.O);
        }

        private async void Ds4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.P);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to exit?", "Confirm exit?", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if(messageBoxResult == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}