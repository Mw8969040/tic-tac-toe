using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace pizza_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if(Small.Checked)
            {
                PizzaSize.Text = "Small";
                return;
            }

            if(Medium.Checked)
            {
                PizzaSize.Text = "Medium";
                return;
            }

            if(Large.Checked)
            {
                PizzaSize.Text = "Large";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";

           if(Chess.Checked)
           {
                Toppings+=",Extra Chees";
           }
           if(Onion.Checked)
           {
                Toppings += ",Onion";
           }

           if(mushroom.Checked)
           {
                Toppings += ",Mushroom";
           }

           if(Green_Paper.Checked)
           {
                Toppings += ",Green Paper";
           }

           if(olives.Checked)
           {
                Toppings += ",Olives";
           }

           if(tomatoes.Checked)
           {
                Toppings += ",Tomatoes";
           }

            if (Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }

            Additions.Text = Toppings;

        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if(Thin.Checked)
            {
                Crust.Text = "Thin Crust";
                return;
            }

            if(Think.Checked)
            {
                Crust.Text = "Thick Crust";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if(Eat_in.Checked)
            {
                Where_TO_Eat.Text = "Eat In";
                return;
            }

            if(Take_Out.Checked)
            {
                Where_TO_Eat.Text = "Take Out";
                return;
            }
        }

        float UpdatePriceToppings()
        {
            float totalToppings = 0;

            if (Chess.Checked)
            {
                totalToppings += Convert.ToSingle(Chess.Tag);
            }
            if (Onion.Checked)
            {
                totalToppings += Convert.ToSingle(Onion.Tag);
            }

            if (mushroom.Checked)
            {
                totalToppings += Convert.ToSingle(mushroom.Tag);
            }

            if (Green_Paper.Checked)
            {
                totalToppings += Convert.ToSingle(Green_Paper.Tag);
            }

            if (olives.Checked)
            {
                totalToppings += Convert.ToSingle(olives.Tag);
            }

            if (tomatoes.Checked)
            {
                totalToppings += Convert.ToSingle(tomatoes.Tag);
            }

            return totalToppings;
        }

        float UpdatePriceOfWhereToEat()
        {
            if(Eat_in.Checked)
            
                return Convert.ToSingle(Eat_in.Tag);
            else

                return Convert.ToSingle(Take_Out.Tag);
        }

        float UpdateCrust()
        {
            if (Thin.Checked)
            {
                return Convert.ToSingle(Thin.Tag);
            }

            return Convert.ToSingle(Think.Tag);
        }

        float UpdatePriceOfSize()
        {
            if(Small.Checked)
            
                return Convert.ToSingle(Small.Tag);
            
            else if(Medium.Checked)
            
                return Convert.ToSingle(Medium.Tag);

            else
                return Convert.ToSingle(Large.Tag);

        }

        float  GetTotalPrice()
        {
            return UpdatePriceOfSize() + UpdatePriceToppings() + UpdatePriceOfWhereToEat() +UpdateCrust();
        }

        void UpdateTotalPrice()
        {
           AllPrice.Text= GetTotalPrice().ToString();
        }



        void CheckToppings(string Topping_type)
        {
            if (Additions.Text == "No Topping")
            {
                Additions.Text =Topping_type;
            }
            else
            {
                Additions.Text = Additions.Text + "," +Topping_type;
            }
        }

        void Toppring_Reduction(string Topping_type)
        {
            if (Additions.Text.StartsWith(Topping_type))
            {
                Additions.Text = Additions.Text.Replace(Topping_type + ",", "");
            }
            else
            {
                Additions.Text = Additions.Text.Replace("," + Topping_type, "");
            }
        }


        private void Small_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Medium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Large_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void Thin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void Think_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void Chess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Onion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void mushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void olives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Green_Paper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Eat_in_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Take_Out_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Small.Checked = true;

           Thin.Checked = true;


        }

        private void Order_Pizza_Click(object sender, EventArgs e)
        {
            SizeBox.Enabled = false;
            ToppingBox.Enabled = false;
            CrustBox.Enabled = false;
            WhereToEatBox.Enabled = false;
        }

        private void Reset_Form_Click(object sender, EventArgs e)
        {
            SizeBox.Enabled = true;
            ToppingBox.Enabled = true; 
            CrustBox.Enabled = true;
            WhereToEatBox.Enabled = true ;

            PizzaSize.Text = "";

            Additions.Text = "No Toppings";

            Crust.Text = "";
            Where_TO_Eat.Text = "";
            AllPrice.Text = "0";

            Small.Checked = true;
            Medium.Checked = false;
            Large.Checked = false;
            Thin.Checked = true;
            Think.Checked = false;
            Chess.Checked = false;
            Onion.Checked = false;
            mushroom.Checked = false;
            Green_Paper.Checked = false;
            olives.Checked = false;
            tomatoes.Checked = false;
            Eat_in.Checked = false;
            Take_Out.Checked = false;
        }

    }
}