using System;
using System.IO;
using Microsoft.Win32;

namespace MRM.Ibis.VirginRadioTour.Core.Tools
{
    /// <summary>
    /// Fournit des propriétés et des méthodes pour manipuler des fichiers
    /// </summary>
    public static class File
    {
        /// <summary>
        /// Obtient le Type MIME à partir d'un FileInfo
        /// </summary>
        /// <param name="fileInfo">FileInfo à partir duquel retrouvé le Type MIME</param>
        /// <returns>Chaine de caractères spécifiant le Type MIME du fichier</returns>
        public static string GetMimeType(this FileInfo fileInfo)
        {
            var contentType = "application/octet-stream";
            try
            {
                var fileClass = Registry.ClassesRoot.OpenSubKey(fileInfo.Extension);
                contentType = fileClass.GetValue("Content Type").ToString();
            }
            catch { }
            return contentType;
        }

        /// <summary>
        /// Cré un fichier au chemin définit à partir d'une chaine en Base64
        /// </summary>
        /// <param name="fullName">Chemin d'accès de destination du fichier</param>
        /// <param name="base64String">Chaine en Base64 représentant le fichier</param>
        public static void FileFromBase64(string fullName, string base64String)
        {
            using (FileStream fs = new FileStream(fullName, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                byte[] filebytes = Convert.FromBase64String(base64String);
                fs.Write(filebytes, 0, filebytes.Length);
            }
        }

        /// <summary>
        /// Cré un fichier au chemin définit à partir d'un objet MemoryStream
        /// </summary>
        /// <param name="fullName">Chemin d'accès de destination du fichier</param>
        /// <param name="memoryStream">Objet MemoryStream représentant le fichier en mémoire</param>
        public static void FileFromMemory(string fullName, MemoryStream memoryStream)
        {
            using (FileStream fs = new FileStream(fullName, FileMode.CreateNew, FileAccess.Write, FileShare.None))
            {
                byte[] filebytes = memoryStream.ToArray();
                fs.Write(filebytes, 0, filebytes.Length);
            }
        }
    }
}
