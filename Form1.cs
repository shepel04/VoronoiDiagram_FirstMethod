using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voronoi_firs
{
    public partial class Form1 : Form
    {

        private int fieldWidth;
        private int fieldHeight;
        private Random random = new Random();

        private readonly List<Point> _points = new List<Point>();
        private readonly Dictionary<Point, Color> _cellColors = new Dictionary<Point, Color>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the number of points to use
            
        }

        private void DrawVoronoiDiagram()
        {
            // Create a new bitmap
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Loop through each pixel in the bitmap
            for (var x = 0; x < bmp.Width; x++)
            {
                for (var y = 0; y < bmp.Height; y++)
                {
                    // Find the closest point
                    var closestPoint = FindClosestPoint(new Point(x, y));

                    // Set the pixel color to the color of the closest point's Voronoi cell
                    if (closestPoint != null)
                    {
                        bmp.SetPixel(x, y, _cellColors[closestPoint.Value]);
                    }
                }
            }

            // Draw points
            using (var g = Graphics.FromImage(bmp))
            {
                var pointSize = 3;
                foreach (var point in _points)
                {
                    var brush = new SolidBrush(Color.Black);
                    g.FillEllipse(brush, point.X - pointSize / 2, point.Y - pointSize / 2, pointSize, pointSize);
                }
            }

            // Set the PictureBox image to the bitmap
            pictureBox1.Image = bmp;
        }

        private void DrawVoronoiDiagramMultiThread()
        {
            // Create a new bitmap
            var bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // Divide the bitmap into smaller regions
            int numThreads = Environment.ProcessorCount;
            int regionWidth = bmp.Width / numThreads;
            List<Rectangle> regions = new List<Rectangle>();
            for (int i = 0; i < numThreads; i++)
            {
                regions.Add(new Rectangle(i * regionWidth, 0, regionWidth, bmp.Height));
            }

            // Process each region in a separate thread
            var tasks = new List<Task>();
            foreach (var region in regions)
            {
                tasks.Add(Task.Run(() =>
                {
                    // Loop through each pixel in the region
                    for (var x = region.X; x < region.X + region.Width; x++)
                    {
                        for (var y = region.Y; y < region.Y + region.Height; y++)
                        {
                            // Find the closest point
                            var closestPoint = FindClosestPoint(new Point(x, y));

                            // Set the pixel color to the color of the closest point's Voronoi cell
                            if (closestPoint != null)
                            {
                                lock (_cellColors)
                                {
                                    bmp.SetPixel(x, y, _cellColors[closestPoint.Value]);
                                }
                            }
                        }
                    }
                }));
            }

            // Wait for all threads to finish
            Task.WaitAll(tasks.ToArray());

            // Draw points
            using (var g = Graphics.FromImage(bmp))
            {
                var pointSize = 3;
                foreach (var point in _points)
                {
                    var brush = new SolidBrush(Color.Black);
                    g.FillEllipse(brush, point.X - pointSize / 2, point.Y - pointSize / 2, pointSize, pointSize);
                }
            }

            // Set the PictureBox image to the bitmap
            pictureBox1.Image = bmp;
        }

        private Point? FindClosestPoint(Point p)
        {
            // Find the closest point to the given point
            var minDistance = double.MaxValue;
            Point? closestPoint = null;

            foreach (var point in _points)
            {
                var distance = Math.Sqrt(Math.Pow(p.X - point.X, 2) + Math.Pow(p.Y - point.Y, 2));
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestPoint = point;
                }
            }

            return closestPoint;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Add a new point to the list and redraw the Voronoi diagram
            _points.Add(new Point(e.X, e.Y));
            _cellColors.Add(new Point(e.X, e.Y), Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            DrawVoronoiDiagram();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            int numPoints = Int32.Parse(AmountOfPointsTB.Text);
            pictureBox1.Width = Int32.Parse(FieldWidthTB.Text);
            pictureBox1.Height = Int32.Parse(FieldHeightTB.Text);

            // Generate random points and colors
            var rand = new Random();
            for (var i = 0; i < numPoints; i++)
            {
                var point = new Point(rand.Next(pictureBox1.Width), rand.Next(pictureBox1.Height));
                _points.Add(point);

                var color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                _cellColors[point] = color;
            }

            // Draw the Voronoi diagram
            if (singleRadio.Checked)
            {
                DrawVoronoiDiagram();
            }
            else if (multiRadio.Checked)
            {
                DrawVoronoiDiagramMultiThread();
            }
            
        }
    }
}
