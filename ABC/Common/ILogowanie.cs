using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ILogowanie
    {
        //członkowie interfejsu nie wymagają podania modyfikatora dostępu; są domyślnie public
        //tylko definiujemy członków, ale ich nie implementujemy (np. nie piszemy kodu dla metody)
        string Log();
    }
}
