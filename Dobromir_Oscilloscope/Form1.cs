using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dobromir_Oscilloscope
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        static bool isGraphDrawn = false;
        static byte point_Count = 1;
        static Graphics g_new = null;
        static Rectangle pointRectOld = Rectangle.Empty;
        static Point pt1Old,pt2Old;
        static double total_distance = -1;

        private void Draw_Click(object sender, EventArgs e)
        {
            // Get the rectangle and point coordinates from the form
            var x_Min = this.numericUpDown_X_Min.Value;
            var x_Max = this.numericUpDown_X_Max.Value;
            var y_Min = this.numericUpDown_Y_Min.Value;
            var y_Max = this.numericUpDown_Y_Max.Value;
            var x = this.numericUpDown_X.Value;
            var y = this.numericUpDown_Y.Value;

            var minX = x_Min;
            var maxX = x_Max;
            var minY = y_Min;
            var maxY = y_Max;
            var diagramWidth = maxX - minX;
            var diagramHeight = maxY - minY;
            var ratio = 1.0m;
            var ratioX = 1.0m;
            var ratioY = 1.0m;
            var offset = 10;
            if (diagramWidth != 0 && diagramHeight != 0)
            {
                ratioX = (pictureBox.Width - 2 * offset - 1) / diagramWidth;
                ratioY = (pictureBox.Height - 2 * offset - 1) / diagramHeight;
                ratio = Math.Min(ratioX, ratioY);
            }


            // Calculate the rectangle coordinates
            var rectLeft = offset + (int)Math.Round(x_Min * ratio);
            var rectTop = offset + (int)Math.Round(y_Min * ratio);
            var rectWidth = (int)Math.Round(Math.Abs(x_Min + x_Max) * ratio);
            var rectHeight = (int)Math.Round(Math.Abs(y_Min + y_Max) * ratio);
            var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            // Calculate the point coordinates
            var pointX = offset + (int)Math.Round(x * ratio);
            var pointY = offset + (int)Math.Round((y_Max - y) * ratio);
            var pointRect = new Rectangle(pointX - 3, pointY - 3, 5, 5);


            // Draw the rectangle and point
            var g = pictureBox.CreateGraphics();

            if (g_new != null)
            {
                g = g_new;
            }

            if (!isGraphDrawn)
                Draw_Graph(ratio, offset, x_Max, x_Min, y_Max, y_Min, rectLeft, rect, g);
            isGraphDrawn = true;
            Draw_Point(pointRect, g);
            Draw_Line(pointRect, g, ratio, ratioX, ratioY, rect);
            g_new = g;
        }

        private void Draw_Graph(decimal ratio, int offset, decimal x_Max, decimal x_Min, decimal y_Max, decimal y_Min, int rectLeft, Rectangle rect, Graphics g)
        {

            // Draw the rectangle (scaled to the picture box size)
            var pen = new Pen(Color.Black, 1);
            g.DrawRectangle(pen, rect);

            //Draw the X lines
            var pt_x_x1 = rectLeft;
            var pt_x_y1 = offset + (int)Math.Round(Math.Abs(y_Max + y_Min) * ratio);
            var pt_x_x2 = pt_x_x1;
            var pt_x_y2 = offset + pt_x_y1;

            for (int i = 0; i < x_Max / 5; i++)
            {
                var pt_x_1 = new Point(pt_x_x1, pt_x_y1);
                var pt_x_2 = new Point(pt_x_x2, pt_x_y2);
                g.DrawLine(pen, pt_x_1, pt_x_2);
                pt_x_x1 += (int)(5 * ratio);
                pt_x_x2 += (int)(5 * ratio);
            }

            //Draw the Y lines
            var pt_y_x1 = rectLeft;
            var pt_y_y1 = offset + (int)Math.Round(Math.Abs(y_Max + y_Min) * ratio);
            var pt_y_x2 = pt_y_x1 - offset;
            var pt_y_y2 = pt_y_y1;

            for (int i = 0; i < y_Max / 5; i++)
            {
                var pt_y_1 = new Point(pt_y_x1, pt_y_y1);
                var pt_y_2 = new Point(pt_y_x2, pt_y_y2);
                g.DrawLine(pen, pt_y_1, pt_y_2);
                pt_y_y1 -= (int)(5 * ratio);
                pt_y_y2 -= (int)(5 * ratio);
            }

        }

        private void Draw_Point(Rectangle pointRect, Graphics g)
        {
            // Draw over the OLD point
            var penOld = new Pen(Color.Black, 2);
            if (!pointRectOld.IsEmpty)
                g.DrawEllipse(penOld, pointRectOld);

            // Draw the point
            var pen = new Pen(Color.Green, 2);
            g.DrawEllipse(pen, pointRect);


            point_Count++;
            label_Point_Count.Text = "point #: " + (point_Count - 1);
        }

        private void Draw_Line(Rectangle pointRect, Graphics g, decimal ratio, decimal ratioX, decimal ratioY, Rectangle rect)
        {
            // Draw over the OLD line to connect the points 
            var penOld = new Pen(Color.Black, 1);
            if (!pt1Old.IsEmpty)
                g.DrawLine(penOld, pt1Old, pt2Old);

            // Draw the line to connect the points 
            var pen = new Pen(Color.Green, 1);
            Point pt1 = (pointRectOld.Location + pointRectOld.Size / 2);
            if (pointRectOld.IsEmpty)
                pt1 = new Point(rect.Left, rect.Bottom);
            Point pt2 = (pointRect.Location + pointRect.Size / 2);
            g.DrawLine(pen, pt1, pt2);
            var x1 = pointRect.X;
            var x2 = pointRectOld.X;
            var y1 = pointRect.Y;
            var y2 = pointRectOld.Y;
            if (pointRectOld.IsEmpty)
            {
                x2 = rect.Left;
                y2 = rect.Bottom;
            }
            // Calculate the distance between points
            double distance = (int)Math.Round(Math.Sqrt((double)((((Math.Pow(x1 / (double)ratioX - x2 / (double)ratioX, 2))) + (Math.Pow(y1 / (double)ratioX - y2 / (double)ratioX, 2)))))); //(int)Math.Round(Math.Sqrt((double)((((decimal)(Math.Pow(x1 - x2, 2))/ratioX) + (decimal)(Math.Pow(y1 - y2, 2))/ratioY) ) ) );
            label_Distance_Current.Text = (distance).ToString();
            total_distance += distance;
            label_Distance_Total.Text = total_distance.ToString();
            pointRectOld = pointRect;
            pt1Old = pt1;
            pt2Old = pt2;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Invalidate();
            label_Distance_Current.Text = "N/A";
            label_Distance_Total.Text = "N/A";
            isGraphDrawn = false;
            total_distance = -1;
            point_Count = 1;
            pointRectOld = Rectangle.Empty;
            g_new = null;
            pt1Old = pt2Old = Point.Empty;
        }

    }
}
