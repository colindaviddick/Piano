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
                    Uri aUri = new Uri("a.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayera = new MediaPlayer();
                    mediaPlayera.Open(aUri);
                    mediaPlayera.Play();
                    break;
                case Key.S:
                    Uri sUri = new Uri("s.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayers = new MediaPlayer();
                    mediaPlayers.Open(sUri);
                    mediaPlayers.Play();
                    break;
                case Key.D:
                    Uri dUri = new Uri("d.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerd = new MediaPlayer();
                    mediaPlayerd.Open(dUri);
                    mediaPlayerd.Play();
                    break;
                case Key.F:
                    Uri fUri = new Uri("f.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerf = new MediaPlayer();
                    mediaPlayerf.Open(fUri);
                    mediaPlayerf.Play();
                    break;
                case Key.G:
                    Uri gUri = new Uri("g.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerg = new MediaPlayer();
                    mediaPlayerg.Open(gUri);
                    mediaPlayerg.Play();
                    break;
                case Key.H:
                    Uri hUri = new Uri("h.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerh = new MediaPlayer();
                    mediaPlayerh.Open(hUri);
                    mediaPlayerh.Play();
                    break;
                case Key.J:
                    Uri jUri = new Uri("j.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerj = new MediaPlayer();
                    mediaPlayerj.Open(jUri);
                    mediaPlayerj.Play();
                    break;
                case Key.K:
                    Uri kUri = new Uri("k.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerk = new MediaPlayer();
                    mediaPlayerk.Open(kUri);
                    mediaPlayerk.Play();
                    break;
                case Key.L:
                    Uri lUri = new Uri("l.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerl = new MediaPlayer();
                    mediaPlayerl.Open(lUri);
                    mediaPlayerl.Play();
                    break;
                case Key.OemSemicolon:
                    Uri scUri = new Uri("sc.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayersc = new MediaPlayer();
                    mediaPlayersc.Open(scUri);
                    mediaPlayersc.Play();
                    break;
                case Key.W:
                    Uri wUri = new Uri("w.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerw = new MediaPlayer();
                    mediaPlayerw.Open(wUri);
                    mediaPlayerw.Play();
                    break;
                case Key.E:
                    Uri eUri = new Uri("e.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayere = new MediaPlayer();
                    mediaPlayere.Open(eUri);
                    mediaPlayere.Play();
                    break;
                case Key.T:
                    Uri tUri = new Uri("t.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayert = new MediaPlayer();
                    mediaPlayert.Open(tUri);
                    mediaPlayert.Play();
                    break;
                case Key.Y:
                    Uri yUri = new Uri("y.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayery = new MediaPlayer();
                    mediaPlayery.Open(yUri);
                    mediaPlayery.Play();
                    break;
                case Key.U:
                    Uri uUri = new Uri("u.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayeru = new MediaPlayer();
                    mediaPlayeru.Open(uUri);
                    mediaPlayeru.Play();
                    break;
                case Key.O:
                    Uri oUri = new Uri("o.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayero = new MediaPlayer();
                    mediaPlayero.Open(oUri);
                    mediaPlayero.Play();
                    break;
                case Key.P:
                    Uri pUri = new Uri("p.wav", UriKind.RelativeOrAbsolute);
                    MediaPlayer mediaPlayerp = new MediaPlayer();
                    mediaPlayerp.Open(pUri);
                    mediaPlayerp.Play();
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

        private async void Gs3_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.T);
        }

        private async void As4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.Y);
        }

        private async void Bs4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.U);
        }

        private async void Ds4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.O);
        }

        private async void Es4_Click(object sender, RoutedEventArgs e)
        {
            await PlayNote(Key.P);
        }
    }
}