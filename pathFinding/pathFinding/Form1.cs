using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pathFinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool startingPointExists = false;
        bool endingPointExists = false;
        bool holdingLC = false;

        public void PictureBoxClicked(object sender, EventArgs e)
        {
            // The picturebox that was clicked
            PictureBox pB = sender as PictureBox;

            // Check if walls should be placed, then place the wall if so.
            if (radioWalls.Checked)
            {
                pB.BackColor = radioWalls.Checked && pB.BackColor == Color.White ? Color.BlueViolet : Color.White;
                return;
            }
            
            // Check if starting point should be placed, remove the other starting point (if exists) and add another point if so.
            if (radioStart.Checked)
            {
                foreach (Control control in Controls)
                {
                    if (control.GetType() == typeof(PictureBox) && control.BackColor == Color.ForestGreen) 
                    {
                        control.BackColor = Color.White;
                        break;
                    }
                }
                pB.BackColor = Color.ForestGreen;
                return;
            }

            // Check if ending point should be placed, remove the other starting point (if exists) and add another point if so.
            if (radioEnd.Checked)
            {
                foreach (Control control in Controls)
                {
                    if (control.GetType() == typeof(PictureBox) && control.BackColor == Color.Red)
                    {
                        control.BackColor = Color.White;
                        break;
                    }
                }
                pB.BackColor = Color.Red;
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int locX = 12;
            int locY = 8;

            for (int i = 1; i <= 192; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(locX, locY);
                pictureBox.BackColor= Color.White;
                pictureBox.Click += PictureBoxClicked;
                pictureBox.Size = new Size(20,20);
                pictureBox.Name = "p" + i;
                locX += 21;
                if (i % 24 == 0)
                {
                    locX = 12;
                    locY += 22;
                }
                Controls.Add(pictureBox);
            }
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text += richTextBox1.Text==""?"":"\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (Control control in Controls)
            {
                if (control.BackColor == Color.Brown)
                {
                    control.BackColor = Color.White;
                }
            }

            if (!FindStartAndEnd(out PictureBox start, out PictureBox end))
            {
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text = "Error: Choose a valid starting and ending point.";
                return;
            }

            Queue<PictureBox> queue = new Queue<PictureBox>();
            Dictionary<PictureBox, PictureBox> cameFrom = new Dictionary<PictureBox, PictureBox>();

            queue.Enqueue(start);
            cameFrom[start] = null;

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == end)
                {
                    MarkPath(cameFrom, end);
                    end.BackColor = Color.Red;
                    richTextBox1.ForeColor = Color.Green;
                    richTextBox1.Text = "The ending point was found successfully!";
                    return;
                }

                foreach (var neighbor in GetNeighbouringBoxes(current))
                {
                    if (neighbor != null && neighbor.BackColor != Color.BlueViolet && !cameFrom.ContainsKey(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        cameFrom[neighbor] = current;
                    }
                }
            }

            richTextBox1.ForeColor = Color.Red;
            richTextBox1.Text = "No path found.";
        }

        private void MarkPath(Dictionary<PictureBox, PictureBox> cameFrom, PictureBox end)
        {
            var current = end;
            while (cameFrom[current] != null)
            {
                current.BackColor = Color.Brown;
                current = cameFrom[current];
            }
        }

        private bool FindStartAndEnd(out PictureBox start, out PictureBox end)
        {
            start = null;
            end = null;
            foreach (Control control in Controls)
            {
                if (control.GetType() == typeof(PictureBox))
                {
                    if (control.BackColor == Color.ForestGreen) start = (PictureBox)control;
                    if (control.BackColor == Color.Red) end = (PictureBox)control;
                }
            }
            return start != null && end != null;
        }


        // [0]: Right, [1]: Up, [2]: Left, [3]: Down
        List<PictureBox> GetNeighbouringBoxes(PictureBox pictureBox)
        {
            List<PictureBox> NeighbouringBoxes= new List<PictureBox>();
            int pB_Loc = Convert.ToInt32(pictureBox.Name.Remove(0, 1));

            if (pB_Loc%24== 0)
            {
                NeighbouringBoxes.Add(null);
            }
            else
            {
                foreach (Control control in Controls)
                {
                    if(control.GetType() == typeof(PictureBox))
                    {
                        if (control.Name == "p" + (pB_Loc + 1))
                        {
                            NeighbouringBoxes.Add(control as PictureBox);
                            break;
                        }
                    } 
                }
            }
            if(NeighbouringBoxes.Count == 0) {
                richTextBox1.Clear();
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text += "Error: Couldn't find the box on the right.";
                return NeighbouringBoxes;
            }



            if (pB_Loc<25)
            {
                NeighbouringBoxes.Add(null);
            }
            else
            {
                foreach (Control control in Controls)
                {
                    if (control.GetType() == typeof(PictureBox))
                    {
                        if (control.Name == "p" + (pB_Loc - 24))
                        {
                            NeighbouringBoxes.Add(control as PictureBox);
                            break;
                        }
                    }
                }
            }
            if (NeighbouringBoxes.Count == 1)
            {
                richTextBox1.Clear();
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text += "Error: Couldn't find the upper box.";
                return NeighbouringBoxes;
            }



            if (pB_Loc % 24 == 1)
            {
                NeighbouringBoxes.Add(null);
            }
            else
            {
                foreach (Control control in Controls)
                {
                    if (control.GetType() == typeof(PictureBox))
                    {
                        if (control.Name == "p" + (pB_Loc - 1))
                        {
                            NeighbouringBoxes.Add(control as PictureBox);
                            break;
                        }
                    }
                }
            }
            if (NeighbouringBoxes.Count == 2)
            {
                richTextBox1.Clear();
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text += "Error: Couldn't find the box on the left.";
                return NeighbouringBoxes;
            }



            if (pB_Loc <= 192 && pB_Loc>168)
            {
                NeighbouringBoxes.Add(null);
            }
            else
            {
                foreach (Control control in Controls)
                {
                    if (control.GetType() == typeof(PictureBox))
                    {
                        if (control.Name == "p" + (pB_Loc + 24))
                        {
                            NeighbouringBoxes.Add(control as PictureBox);
                            break;
                        }
                    }
                }
            }
            if (NeighbouringBoxes.Count == 3)
            {
                richTextBox1.Clear();
                richTextBox1.ForeColor = Color.Red;
                richTextBox1.Text += "Error: Couldn't find the down box.";
                return NeighbouringBoxes;
            }

            return NeighbouringBoxes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= "";
            foreach (Control control in Controls)
            {
                control.BackColor = (control.BackColor == Color.Red || control.BackColor == Color.ForestGreen || control.BackColor == Color.Brown|| control.BackColor ==Color.BlueViolet) ? Color.White:control.BackColor;
            }
        }

        private void button2_Click_1(object sender, EventArgs e) //randomize
        {
        startPoint:
            bool sRed = false;
            bool sGreen = false;
            button2_Click(sender, e);
            Random rand = new Random();
            foreach (Control control in Controls)
            {
                if(control.GetType() == typeof(PictureBox))
                {
                    if (rand.Next(1, 11) < 3) control.BackColor = Color.BlueViolet;
                    if(rand.Next(1,101)<5&&!sGreen){ control.BackColor = Color.ForestGreen; sGreen = true; }
                    if (rand.Next(1, 101) < 5&&!sRed) { control.BackColor = Color.Red;sRed = true; }
                }
            }



            if (!FindStartAndEnd(out PictureBox start, out PictureBox end))
            {
                goto startPoint;
            }

            Queue<PictureBox> queue = new Queue<PictureBox>();
            Dictionary<PictureBox, PictureBox> cameFrom = new Dictionary<PictureBox, PictureBox>();

            queue.Enqueue(start);
            cameFrom[start] = null;
            int i = 0;
            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current == end)
                {
                    // maze possible
                    return;
                }

                foreach (var neighbor in GetNeighbouringBoxes(current))
                {
                    if (neighbor != null && neighbor.BackColor != Color.BlueViolet && !cameFrom.ContainsKey(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        cameFrom[neighbor] = current;
                        
                    }
                }
                
            }
            goto startPoint;
        }
    }
}
