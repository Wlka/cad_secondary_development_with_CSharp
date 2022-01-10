using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebugDllWithoutCloseCad
{
    public class NetloadX
    {
        [CommandMethod("NLX")]
        public void NLX()
        {
            string dllPath = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "dll文件(*.dll)|*.dll";
            fileDialog.Title = "打开dll文件";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                dllPath = fileDialog.FileName;
            }
            else
            {
                return;
            }
            byte[] buffer = System.IO.File.ReadAllBytes(dllPath);
            Assembly assembly = Assembly.Load(buffer);
        }
    }
}
