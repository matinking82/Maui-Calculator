using MauiApp1.ViewModels;
using System.Data;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        #region Buttons
        BtnOne.Clicked += BtnOne_Clicked;
        BtnTwo.Clicked += BtnTwo_Clicked;
        BtnThree.Clicked += BtnThree_Clicked;
        BtnFour.Clicked += BtnFour_Clicked;
        BtnFive.Clicked += BtnFive_Clicked;
        BtnSix.Clicked += BtnSix_Clicked;
        BtnSeven.Clicked += BtnSeven_Clicked;
        BtnEight.Clicked += BtnEight_Clicked;
        BtnNine.Clicked += BtnNine_Clicked;
        BtnZero.Clicked += BtnZero_Clicked;
        Btn2Zero.Clicked += Btn2Zero_Clicked;
        Btn3Zero.Clicked += Btn3Zero_Clicked;
        BtnClear.Clicked += BtnClear_Clicked;
        BtnPowerTwo.Clicked += BtnPowerTwo_Clicked;
        BtnDot.Clicked += BtnDot_Clicked;
        BtnPlus.Clicked += BtnPlus_Clicked;
        BtnMinus.Clicked += BtnMinus_Clicked;
        BtnMultiply.Clicked += BtnMultiply_Clicked;
        BtnDivide.Clicked += BtnDivide_Clicked;
        BtnShowResult.Clicked += BtnShowResult_Clicked;
        #endregion
    }

    private string Calc(string problem)
    {
        string ans = new DataTable().Compute(problem, null).ToString();
        return ans;
    }

    #region Buttons
    private void BtnShowResult_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text = Calc(ResultTxt.Text);
    }

    private void BtnDivide_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "/";
    }

    private void BtnMultiply_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "*";
    }

    private void BtnMinus_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "-";
    }

    private void BtnPlus_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "+";
    }

    private void BtnDot_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += ".";
    }

    private void BtnPowerTwo_Clicked(object sender, EventArgs e)
    {
        double number = double.Parse(ResultTxt.Text);

        ResultTxt.Text = Math.Pow(number, 2).ToString();
    }

    private void BtnClear_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text = "";
    }

    private void BtnOne_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "1";
    }

    private void BtnTwo_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "2";
    }

    private void BtnThree_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "3";
    }

    private void BtnFour_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "4";
    }

    private void BtnFive_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "5";
    }

    private void BtnSix_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "6";
    }

    private void BtnSeven_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "7";
    }

    private void BtnEight_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "8";
    }

    private void BtnNine_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "9";
    }

    private void BtnZero_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "0";
    }

    private void Btn2Zero_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "00";
    }

    private void Btn3Zero_Clicked(object sender, EventArgs e)
    {
        ResultTxt.Text += "000";
    }
    #endregion
}

