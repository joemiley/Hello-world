using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsFinalProject
{
    public partial class Form1 : Form
    {

        private bool selectSquareStatus = false;
        private bool selectTriangleStatus = false;
        private bool selectCircleStatus = false;

        private int clicknumber = 0;
        private int shapeCounter = 0;
        private Point one;
        private Point two;

        Shape selectedShape = null;
        List<Shape> shapeList = new List<Shape>();

        Pen penBlack = new Pen(Color.Black);
        Pen penGreen = new Pen(Color.Green);
        Pen penBlue = new Pen(Color.Blue);
        Pen penRed = new Pen(Color.Red);
        Pen penWhite = new Pen(Color.White);
        SolidBrush brushLightGrey = new SolidBrush(Color.LightGray);
        SolidBrush brushWhite = new SolidBrush(Color.White);

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            

            // The following approach uses menu items coupled with mouse clicks
            MainMenu mainMenu = new MainMenu();
            MenuItem createItem = new MenuItem();
            MenuItem transformItem = new MenuItem();
            MenuItem squareItem = new MenuItem();
            MenuItem triangleItem = new MenuItem();
            MenuItem circleItem = new MenuItem();


            createItem.Text = "&Create";
            transformItem.Text = "&Transform";
            squareItem.Text = "&Square";
            triangleItem.Text = "&Triangle";
            circleItem.Text = "&Circle";


            mainMenu.MenuItems.Add(createItem);
            mainMenu.MenuItems.Add(transformItem);
            createItem.MenuItems.Add(squareItem);
            createItem.MenuItems.Add(triangleItem);
            createItem.MenuItems.Add(circleItem);

            transformItem.Click += new System.EventHandler(this.transformShape);
            squareItem.Click += new System.EventHandler(this.selectSquare);
            triangleItem.Click += new System.EventHandler(this.selectTriangle);
            circleItem.Click += new System.EventHandler(this.selectCircle);

            this.Menu = mainMenu;
            this.MouseClick += mouseClick;

            DisplayTimer.Enabled = true;
        }

        // Generally, all methods of the form are usually private
        private void selectSquare(object sender, EventArgs e)
        {
            selectSquareStatus = true;
            MessageBox.Show("Click OK and then click once each at two locations to create a square");
        }

        private void selectTriangle(object sender, EventArgs e)
        {
            selectTriangleStatus = true;
            MessageBox.Show("Click OK and then click once each at two locations to create a triangle");
        }

        private void selectCircle(object sender, EventArgs e)
        {
            selectCircleStatus = true;
            MessageBox.Show("Click OK and then click once each at two locations to create a Circle");
        }

        private void transformShape(object sender, EventArgs e)
        {
            MessageBox.Show("You selected the Transform option...");
        }
        // This method is quite important and detects all mouse clicks - other methods may need
        // to be implemented to detect other kinds of event handling eg keyboard presses.
        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // 'if' statements can distinguish different selected menu operations to implement.
                // There may be other (better, more efficient) approaches to event handling,
                // but this approach works.
                if (selectSquareStatus == true)
                {
                    string name = "square" + shapeCounter;
                    if (clicknumber == 0)
                    {
                        one = new Point(e.X, e.Y);
                        clicknumber = 1;
                    }
                    else
                    {
                        two = new Point(e.X, e.Y);
                        clicknumber = 0;
                        selectSquareStatus = false;

                        Graphics g = this.CreateGraphics();
                        Pen blackpen = new Pen(Color.Black);

                        // This method draws the square by calculating the positions of the other 2 corners
                        double xDiff, yDiff, xMid, yMid;   // range and mid points of x & y  

                        // calculate ranges and mid points
                        xDiff = two.X - one.X;
                        yDiff = two.Y - one.Y;
                        xMid = (two.X + one.X) / 2;
                        yMid = (two.Y + one.Y) / 2;

                        int[] line1 = { (int)one.X, (int)one.Y, (int)(xMid + yDiff / 2), (int)(yMid - xDiff / 2) };
                        int[] line2 = { (int)(xMid + yDiff / 2), (int)(yMid - xDiff / 2), (int)two.X, (int)two.Y };
                        int[] line3 = { (int)two.X, (int)two.Y, (int)(xMid - yDiff / 2), (int)(yMid + xDiff / 2) };
                        int[] line4 = { (int)(xMid - yDiff / 2), (int)(yMid + xDiff / 2), (int)one.X, (int)one.Y };

                        Square aShape = new Square(one, two, name, line1, line2, line3, line4);

                        shapeList.Add(aShape);
                        shapeCounter++;
                        shapeListBox.Items.Add(aShape.nameOfShape);
                    }
                }

                if (selectTriangleStatus == true)
                {
                    string name = "Triangle" + shapeCounter;
                    if (clicknumber == 0)
                    {
                        one = new Point(e.X, e.Y);
                        clicknumber = 1;
                    }
                    else
                    {
                        two = new Point(e.X, e.Y);
                        clicknumber = 0;
                        selectTriangleStatus = false;

                        Graphics g = this.CreateGraphics();
                        Pen blackpen = new Pen(Color.Black);
                        double xDiff, yDiff, xMid, yMid;   // range and mid points of x & y  

                        // calculate ranges and mid points
                        xDiff = two.X - one.X;
                        yDiff = two.Y - one.Y;
                        xMid = (two.X + one.X) / 2;
                        yMid = (two.Y + one.Y) / 2;

                        int[] line1 = { (int)(xMid - yDiff / 2), (int)(yMid + xDiff / 2), (int)one.X, (int)one.Y };
                        int[] line2 = { (int)two.X, (int)two.Y, (int)(xMid - yDiff / 2), (int)(yMid + xDiff / 2) };
                        int[] line3 = { (int)two.X, (int)two.Y, (int)one.X, (int)one.Y };
                        int[] line4 = null;

                        Triangle aShape = new Triangle(one, two, name, line1, line2, line3, line4);
                        shapeList.Add(aShape);
                        shapeCounter++;
                        shapeListBox.Items.Add(aShape.nameOfShape);
                    }
                }

                if (selectCircleStatus == true)
                {
                    string name = "Circle" + shapeCounter;
                    if (clicknumber == 0)
                    {
                        one = new Point(e.X, e.Y);
                        clicknumber = 1;
                    }
                    else
                    {
                        two = new Point(e.X, e.Y);
                        clicknumber = 0;
                        selectCircleStatus = false;

                        Graphics g = this.CreateGraphics();
                        Pen blackpen = new Pen(Color.Black);
                        double xDiff, yDiff, xMid, yMid;   // range and mid points of x & y  

                        // calculate ranges and mid points
                        xDiff = two.X - one.X;
                        yDiff = two.Y - one.Y;
                        xMid = (two.X + one.X) / 2;
                        yMid = (two.Y + one.Y) / 2;

                        int[] line1 = { (int)one.X, (int)one.Y, (int)two.Y - (int)one.Y, (int)two.X - (int)one.X };
                        int[] line2 = null;
                        int[] line3 = null;
                        int[] line4 = null;

                        Circle aShape = new Circle(one, two, name, line1, line2, line3, line4);

                        shapeList.Add(aShape);
                        shapeCounter++;
                        shapeListBox.Items.Add(aShape.nameOfShape);
                    }
                }
            }
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            DrawSidebar();
            panel1EditSizeSquare.Location = new Point(Width - 520, 0);
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < shapeList.Count; i++)
            {
                if (shapeList[i].GetType() == typeof(Square))
                {
                    g.DrawLine(penBlack, shapeList[i].Line1[0], shapeList[i].Line1[1], shapeList[i].Line1[2], shapeList[i].Line1[3]);
                    g.DrawLine(penBlue, shapeList[i].Line2[0], shapeList[i].Line2[1], shapeList[i].Line2[2], shapeList[i].Line2[3]);
                    g.DrawLine(penGreen, shapeList[i].Line3[0], shapeList[i].Line3[1], shapeList[i].Line3[2], shapeList[i].Line3[3]);
                    g.DrawLine(penRed, shapeList[i].Line4[0], shapeList[i].Line4[1], shapeList[i].Line4[2], shapeList[i].Line4[3]);

                }

                if (shapeList[i].GetType() == typeof(Triangle))
                {
                    g.DrawLine(penBlack, shapeList[i].Line1[0], shapeList[i].Line1[1], shapeList[i].Line1[2], shapeList[i].Line1[3]);
                    g.DrawLine(penBlack, shapeList[i].Line2[0], shapeList[i].Line2[1], shapeList[i].Line2[2], shapeList[i].Line2[3]);
                    g.DrawLine(penBlack, shapeList[i].Line3[0], shapeList[i].Line3[1], shapeList[i].Line3[2], shapeList[i].Line3[3]);

                }

                if (shapeList[i].GetType() == typeof(Circle))
                {
                    Rectangle rectBoundForCircle = new Rectangle();
                    rectBoundForCircle.X = shapeList[i].Line1[0];
                    rectBoundForCircle.Y = shapeList[i].Line1[1];
                    rectBoundForCircle.Height = shapeList[i].Line1[2];
                    rectBoundForCircle.Width = shapeList[i].Line1[3];

                    g.DrawEllipse(penBlack, rectBoundForCircle);
                }
            }
        }








        public void DrawSidebar()
        {
            shapeListBox.Visible = true;
            button1Delete.Visible = true;
            button2Resize.Visible = true;

            int windowWidth = ClientRectangle.Width;
            int windowHeight = ClientRectangle.Height;
            int sideBarXCord = windowWidth - 300;

            Graphics g = this.CreateGraphics();
            Rectangle sideBar = new Rectangle(sideBarXCord, 0, windowWidth - sideBarXCord, windowHeight);

            shapeListBox.Size = new Size(windowWidth - sideBarXCord - 10, windowHeight - 70);
            shapeListBox.Location = new Point(sideBarXCord + 5, 70);
            button1Delete.Location = new Point(sideBarXCord + 5, 45);
            button2Resize.Location = new Point(sideBarXCord + button1Delete.Width + 13, 45);

            g.FillRectangle(brushLightGrey, sideBar);


        }

        // edit Square section
        private void button1Delete_Click(object sender, EventArgs e)
        {
            if(shapeListBox.SelectedIndex != -1)
            {
                string name = shapeListBox.SelectedItem.ToString();
                Graphics g = this.CreateGraphics();

                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].nameOfShape == name)
                    {
                        if (shapeList[i].GetType() == typeof(Square))
                        {
                            g.DrawLine(penWhite, shapeList[i].Line1[0], shapeList[i].Line1[1], shapeList[i].Line1[2], shapeList[i].Line1[3]);
                            g.DrawLine(penWhite, shapeList[i].Line2[0], shapeList[i].Line2[1], shapeList[i].Line2[2], shapeList[i].Line2[3]);
                            g.DrawLine(penWhite, shapeList[i].Line3[0], shapeList[i].Line3[1], shapeList[i].Line3[2], shapeList[i].Line3[3]);
                            g.DrawLine(penWhite, shapeList[i].Line4[0], shapeList[i].Line4[1], shapeList[i].Line4[2], shapeList[i].Line4[3]);
                        }

                        if (shapeList[i].GetType() == typeof(Triangle))
                        {
                            g.DrawLine(penWhite, shapeList[i].Line1[0], shapeList[i].Line1[1], shapeList[i].Line1[2], shapeList[i].Line1[3]);
                            g.DrawLine(penWhite, shapeList[i].Line2[0], shapeList[i].Line2[1], shapeList[i].Line2[2], shapeList[i].Line2[3]);
                            g.DrawLine(penWhite, shapeList[i].Line3[0], shapeList[i].Line3[1], shapeList[i].Line3[2], shapeList[i].Line3[3]);
                        }

                        if (shapeList[i].GetType() == typeof(Circle))
                        {
                            Rectangle rectBoundForCircle = new Rectangle();
                            rectBoundForCircle.X = shapeList[i].Line1[0];
                            rectBoundForCircle.Y = shapeList[i].Line1[1];
                            rectBoundForCircle.Height = shapeList[i].Line1[2];
                            rectBoundForCircle.Width = shapeList[i].Line1[3];
                            g.DrawEllipse(penWhite, rectBoundForCircle);
                        }
                        shapeList.Remove(shapeList[i]);
                    }
                }

                shapeListBox.Items.Remove(shapeListBox.SelectedItem);
            }
            
        }

        private void button2Resize_Click(object sender, EventArgs e)
        {

            if (shapeListBox.SelectedIndex != -1)
            {
                string name = shapeListBox.SelectedItem.ToString();
                Graphics g = this.CreateGraphics();

                for (int i = 0; i < shapeList.Count; i++)
                {
                    if (shapeList[i].nameOfShape == name)
                    {
                        if (shapeList[i].GetType() == typeof(Square))
                        {
                            MessageBox.Show("your shape is a Square");
                            panel1EditSizeSquare.Visible = true;

                            selectedShape = shapeList[i];
                            /*
                            g.DrawLine(penWhite, shapeList[i].Line1[0], shapeList[i].Line1[1], shapeList[i].Line1[2], shapeList[i].Line1[3]);
                            g.DrawLine(penWhite, shapeList[i].Line2[0], shapeList[i].Line2[1], shapeList[i].Line2[2], shapeList[i].Line2[3]);
                            g.DrawLine(penWhite, shapeList[i].Line3[0], shapeList[i].Line3[1], shapeList[i].Line3[2], shapeList[i].Line3[3]);
                            g.DrawLine(penWhite, shapeList[i].Line4[0], shapeList[i].Line4[1], shapeList[i].Line4[2], shapeList[i].Line4[3]);
                            */
                        }

                        if (shapeList[i].GetType() == typeof(Triangle))
                        {
                            MessageBox.Show("your shape is a Triangle");
                            /*
                            g.DrawLine(penWhite, shapeList[i].Line1[0], shapeList[i].Line1[1], shapeList[i].Line1[2], shapeList[i].Line1[3]);
                            g.DrawLine(penWhite, shapeList[i].Line2[0], shapeList[i].Line2[1], shapeList[i].Line2[2], shapeList[i].Line2[3]);
                            g.DrawLine(penWhite, shapeList[i].Line3[0], shapeList[i].Line3[1], shapeList[i].Line3[2], shapeList[i].Line3[3]);
                            */
                        }

                        if (shapeList[i].GetType() == typeof(Circle))
                        {
                            MessageBox.Show("your shape is a Circle");
                            /*
                            Rectangle rectBoundForCircle = new Rectangle();
                            rectBoundForCircle.X = shapeList[i].Line1[0];
                            rectBoundForCircle.Y = shapeList[i].Line1[1];
                            rectBoundForCircle.Height = shapeList[i].Line1[2];
                            rectBoundForCircle.Width = shapeList[i].Line1[3];
                            g.DrawEllipse(penWhite, rectBoundForCircle);
                            */
                        }
                    }
                }

            }
        }

        private void panel1EditSizeSquarebtnBIGGER_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.DrawLine(penWhite, selectedShape.Line1[0], selectedShape.Line1[1], selectedShape.Line1[2], selectedShape.Line1[3]);
            g.DrawLine(penWhite, selectedShape.Line2[0], selectedShape.Line2[1], selectedShape.Line2[2], selectedShape.Line2[3]);
            g.DrawLine(penWhite, selectedShape.Line3[0], selectedShape.Line3[1], selectedShape.Line3[2], selectedShape.Line3[3]);
            g.DrawLine(penWhite, selectedShape.Line4[0], selectedShape.Line4[1], selectedShape.Line4[2], selectedShape.Line4[3]);

            //line 1
            selectedShape.Line1[0] = selectedShape.Line1[0] - 10;
            selectedShape.Line1[1] = selectedShape.Line1[1] - 10;
            selectedShape.Line1[2] = selectedShape.Line1[2] + 10;
            selectedShape.Line1[3] = selectedShape.Line1[3] - 10;
            //line 2
            selectedShape.Line2[0] = selectedShape.Line2[0] + 10;
            selectedShape.Line2[1] = selectedShape.Line2[1] - 10;
            selectedShape.Line2[2] = selectedShape.Line2[2] + 10;
            selectedShape.Line2[3] = selectedShape.Line2[3] + 10;
            //line 3
            selectedShape.Line3[0] = selectedShape.Line3[0] + 10;
            selectedShape.Line3[1] = selectedShape.Line3[1] + 10;
            selectedShape.Line3[2] = selectedShape.Line3[2] - 10;
            selectedShape.Line3[3] = selectedShape.Line3[3] + 10;
            //line 4
            selectedShape.Line4[0] = selectedShape.Line4[0] - 10;
            selectedShape.Line4[1] = selectedShape.Line4[1] + 10;
            selectedShape.Line4[2] = selectedShape.Line4[2] - 10;
            selectedShape.Line4[3] = selectedShape.Line4[3] - 10;
            
            g.DrawLine(penBlack, selectedShape.Line1[0], selectedShape.Line1[1], selectedShape.Line1[2], selectedShape.Line1[3]);
            g.DrawLine(penBlue, selectedShape.Line2[0], selectedShape.Line2[1], selectedShape.Line2[2], selectedShape.Line2[3]);
            g.DrawLine(penGreen, selectedShape.Line3[0], selectedShape.Line3[1], selectedShape.Line3[2], selectedShape.Line3[3]);
            g.DrawLine(penRed, selectedShape.Line4[0], selectedShape.Line4[1], selectedShape.Line4[2], selectedShape.Line4[3]);

        }

        private void panel1EditSizeSquarebtnSMALLER_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.DrawLine(penWhite, selectedShape.Line1[0], selectedShape.Line1[1], selectedShape.Line1[2], selectedShape.Line1[3]);
            g.DrawLine(penWhite, selectedShape.Line2[0], selectedShape.Line2[1], selectedShape.Line2[2], selectedShape.Line2[3]);
            g.DrawLine(penWhite, selectedShape.Line3[0], selectedShape.Line3[1], selectedShape.Line3[2], selectedShape.Line3[3]);
            g.DrawLine(penWhite, selectedShape.Line4[0], selectedShape.Line4[1], selectedShape.Line4[2], selectedShape.Line4[3]);

            //line 1
            selectedShape.Line1[0] = selectedShape.Line1[0] + 10;
            selectedShape.Line1[1] = selectedShape.Line1[1] + 10;
            selectedShape.Line1[2] = selectedShape.Line1[2] - 10;
            selectedShape.Line1[3] = selectedShape.Line1[3] + 10;
            //line 2
            selectedShape.Line2[0] = selectedShape.Line2[0] - 10;
            selectedShape.Line2[1] = selectedShape.Line2[1] + 10;
            selectedShape.Line2[2] = selectedShape.Line2[2] - 10;
            selectedShape.Line2[3] = selectedShape.Line2[3] - 10;
            //line 3
            selectedShape.Line3[0] = selectedShape.Line3[0] - 10;
            selectedShape.Line3[1] = selectedShape.Line3[1] - 10;
            selectedShape.Line3[2] = selectedShape.Line3[2] + 10;
            selectedShape.Line3[3] = selectedShape.Line3[3] - 10;
            //line 4
            selectedShape.Line4[0] = selectedShape.Line4[0] + 10;
            selectedShape.Line4[1] = selectedShape.Line4[1] - 10;
            selectedShape.Line4[2] = selectedShape.Line4[2] + 10;
            selectedShape.Line4[3] = selectedShape.Line4[3] + 10;

            g.DrawLine(penBlack, selectedShape.Line1[0], selectedShape.Line1[1], selectedShape.Line1[2], selectedShape.Line1[3]);
            g.DrawLine(penBlue, selectedShape.Line2[0], selectedShape.Line2[1], selectedShape.Line2[2], selectedShape.Line2[3]);
            g.DrawLine(penGreen, selectedShape.Line3[0], selectedShape.Line3[1], selectedShape.Line3[2], selectedShape.Line3[3]);
            g.DrawLine(penRed, selectedShape.Line4[0], selectedShape.Line4[1], selectedShape.Line4[2], selectedShape.Line4[3]);
        }

        private void panel1EditSizeSquarebtnEXIT_Click(object sender, EventArgs e)
        {
            panel1EditSizeSquare.Visible = false;
            for(int i = 0; i < shapeList.Count; i++)
            {
                if(selectedShape.nameOfShape == shapeList[i].nameOfShape)
                {
                    shapeList[i] = selectedShape;
                    shapeList[i].nameOfShape = shapeList[i].nameOfShape + " (Edited)";
                }
            }
        }


    }































    abstract class Shape
    {
        // This is the base class for Shapes in the application. It should allow an array or LL
        // to be created containing different kinds of shapes.
        public string nameOfShape { get; set; }
        public int[] Line1 { get; set; }
        public int[] Line2 { get; set; }
        public int[] Line3 { get; set; }
        public int[] Line4 { get; set; }

        public Shape(string N, int[] L1, int[] L2, int[] L3, int[] L4)   // constructor
        {
            nameOfShape = N;
            Line1 = L1;
            Line2 = L2;
            Line3 = L3;
            Line4 = L4;
        }
    }

    class Square : Shape
    {
        //This class contains the specific details for a square defined in terms of opposite corners
        Point clickPt1, clickPt2;      // these points identify opposite corners of the square


        public Square(Point clickPt1, Point clickPt2, string N, int[] L1, int[] L2, int[] L3, int[] L4) : base(N, L1, L2, L3, L4)   // constructor
        {
            this.clickPt1 = clickPt1;
            this.clickPt2 = clickPt2;
            Line1 = L1;
            Line2 = L2;
            Line3 = L3;
            Line4 = L4;

        }

        // You will need a different draw method for each kind of shape. Note the square is drawn
        // from first principles. All other shapes should similarly be drawn from first principles. 
        // Ideally no C# standard library class or method should be used to create, draw or transform a shape
        // and instead should utilse user-developed code.


    }

    class Triangle : Shape
    {
        //This class contains the specific details for a triangle defined in terms of opposite corners
        Point clickPt1, clickPt2;      // these points identify opposite corners of the square

        public Triangle(Point clickPt1, Point clickPt2, string N, int[] L1, int[] L2, int[] L3, int[] L4) : base(N, L1, L2, L3, L4)   // constructor
        {
            this.clickPt1 = clickPt1;
            this.clickPt2 = clickPt2;
            Line1 = L1;
            Line2 = L2;
            Line3 = L3;
            Line4 = L4;

        }

        // You will need a different draw method for each kind of shape. Note the triangle is drawn
        // from first principles. All other shapes should similarly be drawn from first principles. 
        // Ideally no C# standard library class or method should be used to create, draw or transform a shape
        // and instead should utilse user-developed code.
        public void draw(Graphics g, Pen blackPen)
        {
            // This method draws the triangle by calculating the positions of the other 2 corners
            double xDiff, yDiff, xMid, yMid;   // range and mid points of x & y  

            // calculate ranges and mid points
            xDiff = clickPt2.X - clickPt1.X;
            yDiff = clickPt2.Y - clickPt1.Y;
            xMid = (clickPt2.X + clickPt1.X) / 2;
            yMid = (clickPt2.Y + clickPt1.Y) / 2;

            // draw triangle
            // side line 
            g.DrawLine(blackPen, (int)(xMid - yDiff / 2), (int)(yMid + xDiff / 2), (int)clickPt1.X, (int)clickPt1.Y);
            // bottom line
            g.DrawLine(blackPen, (int)clickPt2.X, (int)clickPt2.Y, (int)(xMid - yDiff / 2), (int)(yMid + xDiff / 2));
            // diagonal line
            g.DrawLine(blackPen, (int)clickPt2.X, (int)clickPt2.Y, (int)clickPt1.X, (int)clickPt1.Y);


        }

    }

    class Circle : Shape
    {
        //This class contains the specific details for a circle defined in terms of opposite corners
        Point clickPt1, clickPt2;      // these points identify opposite corners of the square

        public Circle(Point clickPt1, Point clickPt2, string N, int[] L1, int[] L2, int[] L3, int[] L4) : base(N, L1, L2, L3, L4)   // constructor
        {
            this.clickPt1 = clickPt1;
            this.clickPt2 = clickPt2;
            Line1 = L1;
            Line2 = L2;
            Line3 = L3;
            Line4 = L4;

        }

        // You will need a different draw method for each kind of shape. Note the circle is drawn
        // from first principles. All other shapes should similarly be drawn from first principles. 
        // Ideally no C# standard library class or method should be used to create, draw or transform a shape
        // and instead should utilse user-developed code.
        public void draw(Graphics g, Pen blackPen)
        {
            // This method draws the square by calculating the positions of the other 2 corners
            double xDiff, yDiff, xMid, yMid;   // range and mid points of x & y  

            // calculate ranges and mid points
            xDiff = clickPt2.X - clickPt1.X;
            yDiff = clickPt2.Y - clickPt1.Y;
            xMid = (clickPt2.X + clickPt1.X) / 2;
            yMid = (clickPt2.Y + clickPt1.Y) / 2;

            Point topLeftOfRect = new Point((int)clickPt1.X, (int)clickPt1.Y);
            Point bottomLeftOfRect = new Point((int)(xMid - yDiff / 2), (int)(yMid + xDiff / 2));
            Point bottomRightOfRect = new Point((int)clickPt2.X, (int)clickPt2.Y);
            Point topRightOfRect = new Point((int)(xMid + yDiff / 2), (int)(yMid - xDiff / 2));

            // needs to be changed because its code from "draw a square" so it always tries to draw a square
            Rectangle rectBoundForCircle = new Rectangle();
            rectBoundForCircle.X = (int)clickPt1.X;
            rectBoundForCircle.Y = (int)clickPt1.Y;
            rectBoundForCircle.Height = (int)clickPt2.Y - (int)clickPt1.Y;
            rectBoundForCircle.Width = (int)clickPt2.X - (int)clickPt1.X;
            //g.DrawRectangle(blackPen, rectBoundForCircle);
            g.DrawEllipse(blackPen, rectBoundForCircle);


        }
    }
}

/* ok so i have them all feeding into a list. 
 * next stop to show the list down the side of the form maybe in buttons that the user can 
 * click on and highlight that drawing(maybe by changing colour?)
 */