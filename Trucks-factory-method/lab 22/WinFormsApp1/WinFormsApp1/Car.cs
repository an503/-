using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    abstract class Trucks
    {
        public abstract void Length();
        public abstract void Weight();
        public abstract void Height();
        public abstract void Parameters();
    }

    class Gazel : Trucks
    {
        public override void Length()
        {
            MessageBox.Show("Length: 1m");

        }

        public override void Weight()
        {
            MessageBox.Show("Weight: 1m");
        }
        public override void Height()
        {
            MessageBox.Show("Height: 1m");
        }
        public override void Parameters()
        {
            MessageBox.Show("Parameters: Length 1m, Weight 1m, Height 1m");

        }

    }

    class Microbus : Trucks
    {
        public override void Length()
        {
            MessageBox.Show("Length: 2m");

        }

        public override void Weight()
        {
            MessageBox.Show("Weight: 2m");
        }
        public override void Height()
        {
            MessageBox.Show("Height: 2m");
        }
        public override void Parameters()
        {
            MessageBox.Show("Parameters: Length 2m, Weight 2m, Height 2m");
        }
        class Autotrain : Trucks
        {
            public override void Length()
            {
                MessageBox.Show("Length: 3m");

            }

            public override void Weight()
            {
                MessageBox.Show("Weight: 3m");
            }
            public override void Height()
            {
                MessageBox.Show("Height: 3m");
            }
            public override void Parameters()
            {
                MessageBox.Show("Parameters: Length 3m, Weight 3m, Height 3m");
            }
        }



        class TrucksFactory
        {
            public static Trucks CreateTrucks(string type)
            {
                switch (type)
                {
                    case "Gazel":
                        return new Gazel();
                    case "Microbus":
                        return new Microbus();
                    case "Autotrain":
                        return new Autotrain();
                    default:
                        return null;
                }
            }
        }

        class TrucksForm : Form
        {
            private ComboBox TrucksComboBox;
            private Button createButton;

            public TrucksForm()
            {
                this.TrucksComboBox = new ComboBox();
                this.TrucksComboBox.Items.AddRange(new object[] { "Gazel", "Microbus", "Autotrain", "Car" });
                this.TrucksComboBox.Location = new Point(10, 10);
                this.Controls.Add(this.TrucksComboBox);

                this.createButton = new Button();
                this.createButton.Text = "Сreate trucks";
                this.createButton.Location = new Point(10, 40);
                this.createButton.Click += new EventHandler(this.CreateButton_Click);
                this.Controls.Add(this.createButton);
            }

            private void CreateButton_Click(object sender, EventArgs e)
            {
                if (this.TrucksComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Choose trucks, please.");
                    return;
                }

                string TrucksBrand = this.TrucksComboBox.SelectedItem.ToString();
                Trucks Trucks = TrucksFactory.CreateTrucks(TrucksBrand);
                if (Trucks == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                MessageBox.Show("Сreate trucks.");
                Trucks.Length();
                Trucks.Height();
                Trucks.Weight();
                Trucks.Parameters();
            }
        }
    }
}

