using Savas.Library.Concrete;
using System.Windows.Forms;
using Savas.Library.Enum;
using System;

namespace UcakSavasOyunu
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun;
        public AnaForm()   
        {
            InitializeComponent();
            _oyun = new Oyun(ucaksavarPanel,savasAlaniPanel);
            _oyun.GecenSureDegisti += TimerinGecenSuresiDegisti;
        }   
        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.UcaksavariHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.UcaksavariHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
            }
        }
        private void TimerinGecenSuresiDegisti(object sender, EventArgs e)
        {
            sureLabel.Text = $"{_oyun.GecenSure.Minutes:D2}:{_oyun.GecenSure.Seconds:D2}"; 
            //sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss");
        }
    }
}
 
