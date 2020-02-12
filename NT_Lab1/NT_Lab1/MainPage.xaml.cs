using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Xamarin.Forms;

namespace NT_Lab1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private const int V = 00;
        int count = 0;
        static long dd = 0, hh = 0, mm = 0, ss = 0, ms=0;
        static Stopwatch stopwatch = new Stopwatch();
        System.Timers.Timer Timer1 = new System.Timers.Timer();

        protected override void OnAppearing()
        {
            base.OnAppearing();
            btnIniciarC.Clicked += BtnIniciarC_Clicked;

        }

        private void BtnIniciarC_Clicked(object sender, EventArgs e)
        {
            count++;
            Pconteo.Text = count.ToString();
        }

        
     

        }

       
    }

