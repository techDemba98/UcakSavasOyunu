using Savas.Library.Concrete;
using System.Windows.Forms;
using Savas.Library.Enum;

namespace UcakSavasOyunu
{
    public partial class AnaForm : Form
    {
        private readonly Oyun _oyun=new Oyun();
        public AnaForm()   
        {
            InitializeComponent();
        }

        private void AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
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
    }
}
 
