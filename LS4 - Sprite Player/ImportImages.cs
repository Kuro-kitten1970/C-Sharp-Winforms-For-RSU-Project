using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Lab_Sheet_04
{
    public partial class ImportImages : Form
    {
        public string FilePath, FileName;
        public string loadDir;

        public List<Image> upIMG = new List<Image>();
        public List<Image> downIMG = new List<Image>();
        public List<Image> rightIMG = new List<Image>();
        public List<Image> leftIMG = new List<Image>();

        public ImportImages()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnImportUp_Click(object sender, EventArgs e)
        {
            AddItemToLists(0);
        }

        private void btnImportDown_Click(object sender, EventArgs e)
        {
            AddItemToLists(1);
        }

        private void btnImportRight_Click(object sender, EventArgs e)
        {
            AddItemToLists(2);
        }

        private void btnImportLeft_Click(object sender, EventArgs e)
        {
            AddItemToLists(3);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbxUp.Items.Count > 0 && lbxDown.Items.Count > 0 && lbxRight.Items.Count > 0 && lbxLeft.Items.Count > 0)
            {
                Saves();
            }
            else
            {
                MessageBox.Show("You must import all of content first!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddItemToLists(byte mode)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Images Files|*.PNG;*.JPG;";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] filesName = ofd.SafeFileNames;
                string[] filesPath = ofd.FileNames;

                switch (mode)
                {
                    case 0:
                        upIMG.Clear();
                        lbxUp.Items.Clear();

                        for (int i = 0; i < filesName.Length; i++)
                        {
                            try
                            {
                                upIMG.Add(Image.FromFile(filesPath[i]));
                                lbxUp.Items.Add(filesName[i]);
                            }
                            catch (OutOfMemoryException)
                            {
                                MessageBox.Show("Cannot Import this image file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        break;
                    case 1:
                        downIMG.Clear();
                        lbxDown.Items.Clear();

                        for (int i = 0; i < filesName.Length; i++)
                        {
                            try
                            {
                                downIMG.Add(Image.FromFile(filesPath[i]));
                                lbxDown.Items.Add(filesName[i]);
                            }
                            catch (OutOfMemoryException)
                            {
                                MessageBox.Show("Cannot Import this image file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        
                        break;
                    case 2:
                        rightIMG.Clear();
                        lbxRight.Items.Clear();

                        for (int i = 0; i < filesName.Length; i++)
                        {
                            try
                            {
                                rightIMG.Add(Image.FromFile(filesPath[i]));
                                lbxRight.Items.Add(filesName[i]);
                            }
                            catch (OutOfMemoryException)
                            {
                                MessageBox.Show("Cannot Import this image file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        break;
                    case 3:
                        leftIMG.Clear();
                        lbxLeft.Items.Clear();

                        for (int i = 0; i < filesName.Length; i++)
                        {
                            try
                            {
                                leftIMG.Add(Image.FromFile(filesPath[i]));
                                lbxLeft.Items.Add(filesName[i]);
                            }
                            catch (OutOfMemoryException)
                            {
                                MessageBox.Show("Cannot Import this image file.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        break;
                    default: return;
                }
            }
        }

        private void Saves()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary Files (*.bin)|*.bin";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;

                ImageData imageData = new ImageData();

                imageData.UpImages = upIMG;
                imageData.DownImages = downIMG;
                imageData.RightImages = rightIMG;
                imageData.LeftImages = leftIMG;

                using (Stream stream = File.Open(savePath, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, imageData);
                }
            }
        }

        private void btnLoadSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary Files (*.bin)|*.bin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadDir = openFileDialog.FileName;

                ImageData imageData = LoadSaves();

                if (imageData == null) 
                {
                    MessageBox.Show("Something went wrong with your file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                upIMG = imageData.UpImages;
                downIMG = imageData.DownImages;
                rightIMG = imageData.RightImages;
                leftIMG = imageData.LeftImages;

                for (int i = 0; i < upIMG.Count; i++)
                {
                    lbxUp.Items.Add(upIMG[i]);
                }

                for (int i = 0; i < downIMG.Count; i++)
                {
                    lbxDown.Items.Add(downIMG[i]);
                }

                for (int i = 0; i < rightIMG.Count; i++)
                {
                    lbxRight.Items.Add(rightIMG[i]);
                }

                for (int i = 0; i < rightIMG.Count; i++)
                {
                    lbxLeft.Items.Add(rightIMG[i]);
                }
            }
        }

        private ImageData LoadSaves()
        {
            string serializationFile = Path.Combine(loadDir);

            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    return (ImageData)binaryFormatter.Deserialize(stream);
                }
                catch (SerializationException)
                {
                    return null;
                }
            }
        }
    }

    [Serializable]
    public class ImageData
    {
        public List<Image> UpImages = new List<Image>();
        public List<Image> DownImages = new List<Image>();
        public List<Image> RightImages = new List<Image>();
        public List<Image> LeftImages = new List<Image>();
    }
}