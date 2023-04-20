using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{

    /* Interface Segregation Principle */

    /*  The interface segregation principle (ISP) states that no code should be forced to depend on methods it does not use. */

    // *********************************************************************************
    interface IPrintTask
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);

    }

    interface IFaxContent
    {
        bool FaxContent(string content);
    }

    interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
}
