using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Sumator
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly FourBitAdder _adder = new FourBitAdder();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            Calculate();
        }

        public void Calculate()
        {
            try
            {
                if (Convert.ToInt32(BoxNumber0.Text) > 15 || Convert.ToInt32(BoxNumber0.Text) < 0 ||
                    Convert.ToInt32(BoxNumber1.Text) > 15 || Convert.ToInt32(BoxNumber1.Text) < 0)
                {
                    MessageBox.Show("Numbers out of range. Numbers have to be:" +
                                    Environment.NewLine + "   1. Less than 15" + Environment.NewLine +
                                    "   2. More than 0");
                    throw new Exception();
                }
                _adder.SetValues(Convert.ToInt32(BoxNumber0.Text), Convert.ToInt32(BoxNumber1.Text));
                BoxBinNumber0.Text = new string(BinaryLogic.IntToBin(Convert.ToInt32(BoxNumber0.Text)));
                BoxBinNumber1.Text = new string(BinaryLogic.IntToBin(Convert.ToInt32(BoxNumber1.Text)));
                BoxOutputBin.Text = new string(_adder.ReturnSum());
                BoxOutputDec.Text = Convert.ToInt32(BoxOutputBin.Text, 2).ToString();
                SetColours();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public void SetColours()
        {
            #region Buttons for Adder0

            ButtonA0.Background = _adder.Add0.Ai ? Brushes.Lime : Brushes.Red;
            ButtonB0.Background = _adder.Add0.Bi ? Brushes.Lime : Brushes.Red;
            ButtonS0.Background = _adder.Add0.Si ? Brushes.Lime : Brushes.Red;
            ButtonC0.Background = _adder.Add0.Ci ? Brushes.Lime : Brushes.Red;
            ButtonFalseC.Background = _adder.Add0.Ci1 ? Brushes.Lime : Brushes.Red;

            #endregion

            #region Buttons for Adder1

            ButtonA1.Background = _adder.Add1.Ai ? Brushes.Lime : Brushes.Red;
            ButtonB1.Background = _adder.Add1.Bi ? Brushes.Lime : Brushes.Red;
            ButtonS1.Background = _adder.Add1.Si ? Brushes.Lime : Brushes.Red;
            ButtonC1.Background = _adder.Add1.Ci ? Brushes.Lime : Brushes.Red;

            #endregion

            #region Buttons for Adder2

            ButtonA2.Background = _adder.Add2.Ai ? Brushes.Lime : Brushes.Red;
            ButtonB2.Background = _adder.Add2.Bi ? Brushes.Lime : Brushes.Red;
            ButtonS2.Background = _adder.Add2.Si ? Brushes.Lime : Brushes.Red;
            ButtonC2.Background = _adder.Add2.Ci ? Brushes.Lime : Brushes.Red;

            #endregion

            #region Buttons for Adder3

            ButtonA3.Background = _adder.Add3.Ai ? Brushes.Lime : Brushes.Red;
            ButtonB3.Background = _adder.Add3.Bi ? Brushes.Lime : Brushes.Red;
            ButtonS3.Background = _adder.Add3.Si ? Brushes.Lime : Brushes.Red;
            ButtonC3.Background = _adder.Add3.Ci ? Brushes.Lime : Brushes.Red;

            #endregion
        }

        private void BoxNumber0_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Return) Calculate();
        }

        private void BoxNumber1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) Calculate();
        }
    }
}