using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public class MainScreen : Form
    {
        public Button btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnAdd, btnSub, btnMul, btnDiv, btnEqu, btnClr;
        public TextBox txt;
        public string process;
        public List<Int32> numberList = new List<int>();
        public MainScreen()
        {
            BackColor = Color.LightGray;
            Width = 330;
            Height = 380;

            txt = new TextBox()
            {
                Width = 290,
                Height = 600,
                Top = 10,
                Left = 10,
                Font = new Font(new FontFamily("Arial"),20F),
                TextAlign = HorizontalAlignment.Right
            };

            btn9 = new Button() 
            { 
                Text = "9",
                Width = 50,
                Height = 50,
                Top = 60,
                Left = 10

            };

            btn8 = new Button()
            {
                Text = "8",
                Width = 50,
                Height = 50,
                Top = 60,
                Left = 70
            };

            btn7 = new Button()
            {
                Text = "7",
                Width = 50,
                Height = 50,
                Top = 60,
                Left = 130
            };

            btn6 = new Button()
            {
                Text = "6",
                Width = 50,
                Height = 50,
                Top = 120,
                Left = 10

            };

            btn5 = new Button()
            {
                Text = "5",
                Width = 50,
                Height = 50,
                Top = 120,
                Left = 70
            };

            btn4 = new Button()
            {
                Text = "4",
                Width = 50,
                Height = 50,
                Top = 120,
                Left = 130
            };

            btn3 = new Button()
            {
                Text = "3",
                Width = 50,
                Height = 50,
                Top = 180,
                Left = 10

            };

            btn2 = new Button()
            {
                Text = "2",
                Width = 50,
                Height = 50,
                Top = 180,
                Left = 70
            };

            btn1 = new Button()
            {
                Text = "1",
                Width = 50,
                Height = 50,
                Top = 180,
                Left = 130
            };

            btn0 = new Button()
            {
                Text = "0",
                Width = 170,
                Height = 50,
                Top = 240,
                Left = 10
            };


            btnAdd = new Button()
            {
                Text = "+",
                Width = 50,
                Height = 50,
                Top = 60,
                Left = 190
            };

            btnSub = new Button()
            {
                Text = "-",
                Width = 50,
                Height = 50,
                Top = 120,
                Left = 190
            };

            btnDiv = new Button()
            {
                Text = "/",
                Width = 50,
                Height = 50,
                Top = 180,
                Left = 190
            };

            btnMul = new Button()
            {
                Text = "*",
                Width = 50,
                Height = 50,
                Top = 240,
                Left = 190
            };

            btnEqu = new Button()
            {
                Text = "=",
                Width = 50,
                Height = 110,
                Top = 60,
                Left = 250
            };

            btnClr = new Button()
            {
                Text = "CLR",
                Width = 50,
                Height = 110,
                Top = 180,
                Left = 250
            };

            this.Controls.Add(txt);
            this.Controls.Add(btn9);
            this.Controls.Add(btn8);
            this.Controls.Add(btn7); 
            this.Controls.Add(btn6);
            this.Controls.Add(btn5);
            this.Controls.Add(btn4);
            this.Controls.Add(btn3);
            this.Controls.Add(btn2);
            this.Controls.Add(btn1);
            this.Controls.Add(btn0);
            this.Controls.Add(btnAdd);
            this.Controls.Add(btnSub);
            this.Controls.Add(btnDiv);
            this.Controls.Add(btnMul);
            this.Controls.Add(btnEqu);
            this.Controls.Add(btnClr);




            btn9.Click += new EventHandler(Btn_Click);
            btn8.Click += new EventHandler(Btn_Click);
            btn7.Click += new EventHandler(Btn_Click);
            btn6.Click += new EventHandler(Btn_Click);
            btn5.Click += new EventHandler(Btn_Click);
            btn4.Click += new EventHandler(Btn_Click); 
            btn3.Click += new EventHandler(Btn_Click);
            btn2.Click += new EventHandler(Btn_Click);
            btn1.Click += new EventHandler(Btn_Click);
            btn0.Click += new EventHandler(Btn_Click);

            btnAdd.Click += new EventHandler(Btn_Precess);
            btnSub.Click += new EventHandler(Btn_Precess);
            btnDiv.Click += new EventHandler(Btn_Precess);
            btnMul.Click += new EventHandler(Btn_Precess);
            btnEqu.Click += new EventHandler(BtnEqu_Click);
            btnClr.Click += new EventHandler(BtnClr_Click);



        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            txt.Text = "";
        }

        private void BtnEqu_Click(object sender, EventArgs e)
        {
            var flag =  txt.Text.Split(process[0]);
            long n1 = Convert.ToInt64(flag[0]);
            long n2 = Convert.ToInt64(flag[1]);

            switch (process)
            {
                case "+":
                    txt.Text = (n1 + n2).ToString();
                    break;
                case "*":
                    txt.Text = (n1 * n2).ToString();
                    break;
                case "/":
                    txt.Text = (n1 / n2).ToString();
                    break;
                case "-":
                    txt.Text = (n1 - n2).ToString();
                    break;
                default:
                    break;
            }

        }

        private void Btn_Precess(object sender, EventArgs e)
        {
            process = ((Button)sender).Text;
            txt.Text += process;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            txt.Text += ((Button)sender).Text;
            if (txt.Text[0] == '0')
            {
                txt.Text = txt.Text.Remove(0, 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MainScreen mainScreen = new MainScreen();
            Application.Run(mainScreen); 
        }
    }
}
