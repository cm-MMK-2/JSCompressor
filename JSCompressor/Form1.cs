using Dean.Edwards;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JSCompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select folder for source";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Select folder for target";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.SelectedPath;
            }
        }

        private List<string> GetAllFileInfo(DirectoryInfo folder)
        {
            List<string> fileList = new List<string>();
            DirectoryInfo[] dirinfo = folder.GetDirectories();

            FileInfo[] files = folder.GetFiles();

            foreach (FileInfo f in files)
            {
                fileList.Add(f.FullName);
            }

            foreach (DirectoryInfo d in dirinfo)
            {
                fileList = fileList.Concat(GetAllFileInfo(d)).ToList();
            }
            return fileList;
        }

        private void PackerThread(Object stateInfo)
        {
            string targetfile = (string)stateInfo;
            while (!File.Exists(targetfile))
            {
                Thread.Sleep(25);
            }
            string source = File.ReadAllText(targetfile);
            ECMAScriptPacker p = new ECMAScriptPacker(ECMAScriptPacker.PackerEncoding.Normal, true, false);
            string result = p.Pack(source);

            File.WriteAllText(targetfile, result);
        }

        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            if (rbUglify.Checked)
            {
                string ExecutableFilePath = @"uglify/uglify.bat";
                string tempFolder = @"uglify/temp";
                string Arguments = @"";
                if (Directory.Exists(tempFolder))
                {
                    Directory.Delete(tempFolder, true); 
                }
                Directory.CreateDirectory(tempFolder);
                DirectoryInfo tempDir = new DirectoryInfo(tempFolder);
                CopyAll(new DirectoryInfo(textBox1.Text), tempDir);
                List<string> fileList = GetAllFileInfo(tempDir);
                if (File.Exists(ExecutableFilePath))
                {
                    ProcessStartInfo psi = new ProcessStartInfo(ExecutableFilePath, Arguments);
                    psi.UseShellExecute = false;
                    var process = new Process() { StartInfo = psi };
                    process.Start();
                    process.WaitForExit();
                    foreach(string f in fileList)
                    {
                        //MessageBox.Show(f);
                        if (f.EndsWith(".js"))
                        {
                            //JavaScriptCompressor compressor = new JavaScriptCompressor();
                            //result = p.Pack(source);
                            //MessageBox.Show(f + "  " + textBox1.Text);
                            string targetfile = string.Empty;
                            if (!checkCompressInSource.Enabled)
                            {
                                targetfile = f.Replace(tempDir.FullName, textBox2.Text);
                                string dirPath = dirPath = f.Remove(f.LastIndexOf('\\')).Replace(tempDir.FullName, textBox2.Text);

                                if (!Directory.Exists(dirPath))
                                {
                                    Directory.CreateDirectory(dirPath);
                                    //label3.Text = "create path:" + dirPath;
                                }
                            }
                            else
                            {
                                targetfile = f.Replace(tempDir.FullName, textBox1.Text);
                            }

                            string source = File.ReadAllText(f);
                            ECMAScriptPacker p = new ECMAScriptPacker(ECMAScriptPacker.PackerEncoding.Normal, true, false);
                            string result = p.Pack(source);

                            File.WriteAllText(targetfile, result);
                        }
                    }
                }
            }
            else if(rbGoogle.Checked)
            {
                List<string>fileList = GetAllFileInfo(new DirectoryInfo(textBox1.Text));
                GoogleClosure googleClosure = new GoogleClosure();
                fileList.ForEach(f => {
                    //MessageBox.Show(f);
                    if (f.EndsWith(".js"))
                    {
                        string targetfile = string.Empty;
                        if (!checkCompressInSource.Enabled)
                        {
                            targetfile = f.Replace(textBox1.Text, textBox2.Text);

                            string dirPath = f.Remove(f.LastIndexOf('\\')).Replace(textBox1.Text, textBox2.Text);

                            if (!Directory.Exists(dirPath))
                            {
                                Directory.CreateDirectory(dirPath);
                                //label3.Text = "create:" + dirPath;
                            }
                        }
                        else
                        {
                            targetfile = f;
                        }
                        string source = File.ReadAllText(f);
                        ECMAScriptPacker p = new ECMAScriptPacker(ECMAScriptPacker.PackerEncoding.Normal, true, false);

                        string result = p.Pack(googleClosure.Compress(source));

                        File.WriteAllText(targetfile, result);


                        //ThreadPool.QueueUserWorkItem(new WaitCallback(PackerThread), targetfile);
                    }
                });
            }
            MessageBox.Show("Success!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = !checkCompressInSource.Checked;
            selbutton2.Enabled = textBox2.Enabled;
        }
    }
}
