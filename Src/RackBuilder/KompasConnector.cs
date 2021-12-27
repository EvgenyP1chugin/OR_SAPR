using System;
using System.Runtime.InteropServices;
using Kompas6Constants3D;
using Kompas6API5;
using RackBuilder.Service;

namespace RackBuilder
{
    ///<summary>
    /// класс для работы с Компас 3D
    /// </summary>
    public class KompasConnector
    {
        ///<summary>
        /// объект Компас 3D
        /// </summary>
        public KompasObject KompasObject { get; }

        ///<summary>
        /// часть документа
        /// </summary>
        public ksPart Part { get; set; }

        ///<summary>
        /// подключение САПР Компас 3D
        /// </summary>
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

        ///<summary>
        /// создание новой части документа Компас 3D
        /// </summary>
        public void GetNewPart()
        {
            var ksDoc = (ksDocument3D)KompasObject.Document3D();
            ksDoc.Create(false, true);
            Part = (ksPart)ksDoc.GetPart((short)Part_Type.pTop_Part);
        }
    }
}
