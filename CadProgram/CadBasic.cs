using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadProgram
{
    public class CadBasic
    {
        [CommandMethod("Test")]
        public void Test()
        {
            Database database = HostApplicationServices.WorkingDatabase;
            Document document = Application.DocumentManager.MdiActiveDocument;
            Editor editor = document.Editor;
            editor.WriteMessage("Waaaaa");
        }

        [CommandMethod("Test2")]
        public void Test2()
        {
            Database database = HostApplicationServices.WorkingDatabase;
            Document document = Application.DocumentManager.MdiActiveDocument;
            Circle circle = new Circle(new Point3d(0, 0, 0), Vector3d.ZAxis, 100);
            using(Transaction transaction = database.TransactionManager.StartTransaction())
            {
                BlockTable blockTable = transaction.GetObject(database.BlockTableId, OpenMode.ForRead) as BlockTable;
                BlockTableRecord blockTableRecord = transaction.GetObject(blockTable[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;
                blockTableRecord.AppendEntity(circle);
                transaction.AddNewlyCreatedDBObject(circle, true);
                transaction.Commit();
            }
        }
    }
}
