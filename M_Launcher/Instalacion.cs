using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace M_Launcher
{
    public partial class Instalacion : Form
    {   
        private Form1 formPrincipal;
        private int progressBarValue = 0;
        private bool isButtonEnabled = true;
        public Instalacion(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            // Inicializar el estado del formulario
            guna2ProgressBar1.Value = progressBarValue;
            guna2Button1.Enabled = isButtonEnabled;
            guna2Button1.Visible = isButtonEnabled;
        }
        private void SaveState()
        {
            progressBarValue = guna2ProgressBar1.Value;
            isButtonEnabled = guna2Button1.Enabled;
        }


        private async void iconButton1_Click(object sender, EventArgs e)
        {
            //string minecraftFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
            //string modsFolderPath = Path.Combine(minecraftFolderPath, "mods");
            //string forgeDownloadUrl = "https://maven.minecraftforge.net/net/minecraftforge/forge/1.20.1-47.3.5/forge-1.20.1-47.3.5-installer.jar";
            //string modpackDownloadUrl = "https://download1580.mediafire.com/0h91yaa9ghrgMpah-tiWe_bj1gCh7Dpy0L7JSXOpjzKD1P3EPO1u8S7aMgLhiQaEmBI8Z9T1rMlmaBdq2Sb4JjmELkBuJovTOaz4_7_mMAuYeG1svaO4lqE_aqGWGJ2GUk8eoAKDoKMksptSap-b-CFdNjpVUy5h8e49jMnJbt2rjw/muwpk75v2v6pp1n/mods.zip";
            //string forgeInstallerPath = Path.Combine(minecraftFolderPath, "forge-installer.jar");
            //string modpackFilePath = Path.Combine(modsFolderPath, "mods.zip");

            //guna2ProgressBar1.Value = 25;

            //// Descargar e instalar Forge
            //try
            //{
            //    using (var webClient = new WebClient())
            //    {
            //        await webClient.DownloadFileTaskAsync(forgeDownloadUrl, forgeInstallerPath);
            //    }

            //    guna2ProgressBar1.Value = 50;

            //    ProcessStartInfo processStartInfo = new ProcessStartInfo
            //    {
            //        FileName = "java",
            //        Arguments = $"-jar \"{forgeInstallerPath}\" --installClient",
            //        UseShellExecute = false,
            //        CreateNoWindow = true,
            //        RedirectStandardOutput = true,
            //        RedirectStandardError = true
            //    };

            //    using (Process process = new Process())
            //    {
            //        process.StartInfo = processStartInfo;
            //        process.Start();
            //        await process.WaitForExitAsync();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al instalar Forge: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Descargar y extraer mods
            //try
            //{
            //    Directory.CreateDirectory(modsFolderPath); // Crea la carpeta mods si no existe

            //    using (var webClient = new WebClient())
            //    {
            //        await webClient.DownloadFileTaskAsync(modpackDownloadUrl, modpackFilePath);
            //    }

            //    using (ZipArchive archive = ZipFile.OpenRead(modpackFilePath))
            //    {
            //        archive.ExtractToDirectory(modsFolderPath);
            //    }

            //    File.Delete(modpackFilePath);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al descargar o extraer mods: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //guna2ProgressBar1.Value = 100;
            //MessageBox.Show("Forge y los mods se han instalado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
            private async void guna2Button1_Click(object sender, EventArgs e)
            {
                // Desactivar todos los botones en panel2
                TogglePanel2Buttons(false);

                guna2Button1.Enabled = false;

                string minecraftFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");

                string forgeUrl = "https://maven.minecraftforge.net/net/minecraftforge/forge/1.20.1-47.3.5/forge-1.20.1-47.3.5-installer.jar";
                string forgeInstallerPath = Path.Combine(minecraftFolderPath, "forge-installer.jar");

                string modsFolderPath = Path.Combine(minecraftFolderPath, "mods");
                string resourceModsPath = Path.Combine(Application.StartupPath, "Resources", "mods");

                // Inicializar la ProgressBar
                guna2ProgressBar1.Value = 10;

                // Descargar el instalador de Forge
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        using (var response = await client.GetAsync(forgeUrl))
                        {
                            response.EnsureSuccessStatusCode();
                            using (var fileStream = new FileStream(forgeInstallerPath, FileMode.Create, FileAccess.Write))
                            {
                                await response.Content.CopyToAsync(fileStream);
                            }
                        }

                        // Actualizar la ProgressBar después de la descarga de Forge
                        guna2ProgressBar1.Value = 25;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al descargar el instalador de Forge: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TogglePanel2Buttons(true);
                        return;
                    }
                }

                // Ejecutar el instalador de Forge
                try
                {
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "java",
                        Arguments = $"-jar \"{forgeInstallerPath}\"",
                        WorkingDirectory = minecraftFolderPath
                    };
                    using (Process process = Process.Start(psi))
                    {
                        process.WaitForExit();
                    }

                    // Actualizar la ProgressBar después de la instalación de Forge
                    guna2ProgressBar1.Value = 50;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al ejecutar el instalador de Forge: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TogglePanel2Buttons(true);
                    return;
                }

                // Eliminar el instalador de Forge (opcional)
                // File.Delete(forgeInstallerPath);

                // Crear la carpeta de mods si no existe
                if (!Directory.Exists(modsFolderPath))
                {
                    Directory.CreateDirectory(modsFolderPath);
                }

                try
                {
                    // Copiar los archivos de mods a la carpeta .minecraft/mods
                    string[] files = Directory.GetFiles(resourceModsPath);
                    int totalFiles = files.Length;
                    int processedFiles = 0;

                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(modsFolderPath, fileName);
                        File.Copy(file, destFile, true);

                        // Actualizar la ProgressBar después de cada archivo copiado
                        processedFiles++;
                        guna2ProgressBar1.Value = 50 + (processedFiles * 50 / totalFiles);
                    }

                    MessageBox.Show("Mods instalados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al copiar los mods: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Rehabilitar los botones en panel2 después de la instalación
                TogglePanel2Buttons(true);
            }

            // Función para habilitar o deshabilitar los botones en panel2
            private void TogglePanel2Buttons(bool enable)
            {
                foreach (Control control in formPrincipal.Controls)
                {
                    if (control is Panel panel && panel.Name == "panel2")
                    {
                        foreach (Control btn in panel.Controls)
                        {
                            if (btn is Button)
                            {
                                btn.Enabled = enable;
                            }
                        }
                    }
                }
            }
    }
    
}