using System;
using System.Windows.Forms;

namespace NinjaTurtles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Leonardo_Click(object sender, EventArgs e)
        {
            LeonardoProperties Leo = new LeonardoProperties();
            textBox1.Text = "Turtle Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + Leo.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + Leo.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string canFight = "Can Fight: " + Leo.canFight.ToString();
            textBox1.AppendText(canFight + Environment.NewLine);
            string species = "Species: " + Leo.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Leo Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + Leo.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = Leo.weapon;
            textBox1.AppendText("Weapon: " + Leo.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + Leo.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_leo;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Michelangelo_Click(object sender, EventArgs e)
        {
            MichelangeloProperties Mikey = new MichelangeloProperties();
            textBox1.Text = "Turtle Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + Mikey.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + Mikey.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string canFight = "Can Fight: " + Mikey.canFight.ToString();
            textBox1.AppendText(canFight + Environment.NewLine);
            string species = "Species: " + Mikey.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Mikey Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + Mikey.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = Mikey.weapon;
            textBox1.AppendText("Weapon: " + Mikey.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + Mikey.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_mikey;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Raphael_Click(object sender, EventArgs e)
        {
            RaphaelProperties Raph = new RaphaelProperties();
            textBox1.Text = "Turtle Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + Raph.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + Raph.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string canFight = "Can Fight: " + Raph.canFight.ToString();
            textBox1.AppendText(canFight + Environment.NewLine);
            string species = "Species: " + Raph.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Raph Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + Raph.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = Raph.weapon;
            textBox1.AppendText("Weapon: " + Raph.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + Raph.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_raph;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Donatello_Click(object sender, EventArgs e)
        {
            DonatelloProperties Donny = new DonatelloProperties();
            textBox1.Text = "Turtle Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + Donny.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + Donny.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string canFight = "Can Fight: " + Donny.canFight.ToString();
            textBox1.AppendText(canFight + Environment.NewLine);
            string species = "Species: " + Donny.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Donny Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + Donny.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = Donny.weapon;
            textBox1.AppendText("Weapon: " + Donny.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + Donny.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_donny;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void April_Click(object sender, EventArgs e)
        {
            AprilProperties April = new AprilProperties();
            textBox1.Text = "Human Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + April.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + April.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string species = "Species: " + April.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "April Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + April.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = April.weapon;
            textBox1.AppendText("Weapon: " + April.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + April.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_april;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Shredder_Click(object sender, EventArgs e)
        {
            ShredderProperties Shredder = new ShredderProperties();
            textBox1.Text = "Human Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + Shredder.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + Shredder.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string species = "Species: " + Shredder.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Shredder Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + Shredder.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = Shredder.weapon;
            textBox1.AppendText("Weapon: " + Shredder.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + Shredder.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_shredder;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Krang_Click(object sender, EventArgs e)
        {
            KrangProperties Krang = new KrangProperties();
            textBox1.Text = "Alien Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + Krang.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + Krang.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string species = "Species: " + Krang.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Krang Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + Krang.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = Krang.weapon;
            textBox1.AppendText("Weapon: " + Krang.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + Krang.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_krang;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Splinter_Click(object sender, EventArgs e)
        {
            SplinterProperties Splinter = new SplinterProperties();
            textBox1.Text = "Rat Class";
            textBox1.AppendText(Environment.NewLine);
            string hasShell = "Has Shell: " + Splinter.hasShell.ToString();
            textBox1.AppendText(hasShell + Environment.NewLine);
            string isGreen = "Is Green: " + Splinter.isGreen.ToString();
            textBox1.AppendText(isGreen + Environment.NewLine);
            string species = "Species: " + Splinter.species.ToString();
            textBox1.AppendText(species + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine + "Splinter Class" + Environment.NewLine);
            string isLeader = "Is Leader: " + Splinter.isLeader;
            textBox1.AppendText(isLeader + Environment.NewLine);
            string weapon = Splinter.weapon;
            textBox1.AppendText("Weapon: " + Splinter.weapon + Environment.NewLine);
            textBox1.AppendText("Color: " + Splinter.color + Environment.NewLine);

            pictureBox1.Image = NinjaTurtles.Properties.Resources.tmnt_splinter;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
