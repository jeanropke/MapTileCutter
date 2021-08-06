using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTileCutter
{

    public partial class Form1 : Form
    {

        public static Bitmap MapImage;
        public static string ExportPathValue, BackgroundColor, SaveFormat;
        private static int MaxZoomLevel, MinZoomLevel, TileSize;
        private static ColorConverter ColorConverter = new ColorConverter();

        private static int TotalOfTilesToGenerate;
        private static int CurrentAmountOfTilesGenerated;

        public Form1()
        {
            InitializeComponent();
            structureComboBox.SelectedIndex = structureComboBox.Items.Count-1;
            TileFormat.SelectedIndex = TileFormat.Items.Count-1;

        }

        private void SelectMapImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MapImage?.Dispose();

                    MapImagePath.Text = openFileDialog.FileName;
                }
            }    
        }

        private void ShowTooltip_MouseHover(object sender, EventArgs e)
        {
            BackgroundColorTooltip.Show("Color format: #ARGB (Alpha, Red, Green, Blue)", BackgroundColorLabel);
        }

        private void MakeTilesButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(MaxZoomTextBox.Text, out MaxZoomLevel))
            {
                MessageBox.Show("Max Zoom is not a integer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(MinZoomTextBox.Text, out MinZoomLevel))
            {
                MessageBox.Show("Min Zoom is not a integer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(TileSizeTextBox.Text, out TileSize))
            {
                MessageBox.Show("Tile size is not a integer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MapImagePath.Text.Length == 0 || !File.Exists(MapImagePath.Text))
            {
                MessageBox.Show("Map image path is empty or files does not exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(ExportPath.Text.Length == 0 || !Directory.Exists(ExportPath.Text))
            {
                MessageBox.Show("Export path is empty or does not exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ColorConverter.IsValid(BackgroundColorTextBox.Text))
            {
                MessageBox.Show("Background color is invalid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                return;
            }

            MakeTilesButton.Enabled = false;

            TotalOfTilesToGenerate = 0;
            CurrentAmountOfTilesGenerated = 0;

            string StructureFormat = structureComboBox.Text;
            BackgroundColor = BackgroundColorTextBox.Text;

            var image = (Bitmap)Bitmap.FromFile(MapImagePath.Text);
            MapImage = CropImage(image, new Rectangle(0, 0, image.Width, image.Height), new Rectangle(0, 0, image.Width, image.Height));
            image.Dispose();

            SaveFormat = TileFormat.Text;

            ExportPathValue = ExportPath.Text;

            double _width = MapImage.Width;
            double _height = MapImage.Height;

            for (int i = MinZoomLevel; i <= MaxZoomLevel; i++)
            {
                TotalOfTilesToGenerate += int.Parse((Math.Ceiling(_width / TileSize) * Math.Ceiling(_height / TileSize)).ToString());

                _width /= 2;
                _height /= 2;
            }

            Task.Run(() =>
            {
                for (int zoomLevel = MaxZoomLevel; zoomLevel <= MaxZoomLevel; zoomLevel--)
                {
                    if (zoomLevel < MinZoomLevel)
                        break;

                    for (int x = 0; x < Math.Ceiling((double)MapImage.Width / TileSize); x++)
                    {
                        for (int y = 0; y < Math.Ceiling((double)MapImage.Height / TileSize); y++)
                        {
                            var rectangle = new Rectangle(x * TileSize, y * TileSize, TileSize, TileSize);
                
                            Tile tile = new Tile(rectangle, PixelFormat.Format32bppArgb)
                            {
                                Name = $"{StructureFormat.Replace("x", x.ToString()).Replace("y", y.ToString()).Replace("z", zoomLevel.ToString()).Split('.')[0]}.{SaveFormat.ToLower()}",
                                Format = SaveFormat == "PNG" ? ImageFormat.Png : ImageFormat.Jpeg
                            };
                
                            tile.TileSaved += Tile_TileSaved;
                            tile.Save();
                        }
                    }

                    MapImage = CropImage(MapImage, new Rectangle(0, 0, MapImage.Width, MapImage.Height), new Rectangle(0, 0, MapImage.Width / 2, MapImage.Height / 2));
                }
                MakeTilesButton.Invoke(new MethodInvoker(delegate { MakeTilesButton.Enabled = true; }));
                MapImage.Dispose();
                GC.Collect();
            });
            

        }

        private void Tile_TileSaved(object sender, TileSavedEventArgs e)
        {
            CurrentAmountOfTilesGenerated++;
            ProgressLabel.Invoke(new MethodInvoker(delegate { ProgressLabel.Text = $"Tile {e.Tile.Name} saved (Took {(e.SavedAt - e.Tile.StartAt).TotalMilliseconds}ms) ({CurrentAmountOfTilesGenerated} of {TotalOfTilesToGenerate})"; }));
        }

        private void ExportPathButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                if (openFolderDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportPath.Text = openFolderDialog.SelectedPath;
                }
            }
        }

        Bitmap CropImage(Image originalImage, Rectangle sourceRectangle, Rectangle destinationRectangle)
        {
            Rectangle _destRectancle = destinationRectangle;
            if (destinationRectangle.Width % TileSize != 0)
                _destRectancle.Width += destinationRectangle.Width % 256;

            if (destinationRectangle.Height % TileSize != 0)
                _destRectancle.Height += destinationRectangle.Height % 256;


            var croppedImage = new Bitmap(_destRectancle.Width, _destRectancle.Height);

            using (var graphics = Graphics.FromImage(croppedImage))
            {
                graphics.Clear((Color)ColorConverter.ConvertFromString(BackgroundColor));
                graphics.DrawImage(originalImage, destinationRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }

            return croppedImage;
        }
    }
}
