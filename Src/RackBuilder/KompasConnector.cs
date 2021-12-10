using System;
using System.Runtime.InteropServices;
using Kompas6Constants3D;
using Kompas6API5;
using RackBuilder.Service;

namespace RackBuilder
{
    class KompasConnector
    {
        public KompasObject KompasObject { get; }
        public ksPart Part { get; set; }

        public KompasConnector()
        {
            var progId = "KOMPAS.Application.5";
            try
            {
                KompasObject = 
                    (KompasObject)Marshal2.GetActiveObject(progId);
            }
            catch (COMException)
            {
                KompasObject = (KompasObject)Activator.
                    CreateInstance(Type.GetTypeFromProgID(progId));
            }

            KompasObject.Visible = true;
            KompasObject.ActivateControllerAPI();
        }


        public void GetNewPart()
        {
            var ksDoc = (ksDocument3D)KompasObject.Document3D();
            ksDoc.Create(false, true);
            Part = (ksPart)ksDoc.GetPart((short)Part_Type.pTop_Part);
        }
    }
}
