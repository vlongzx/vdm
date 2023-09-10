
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.vdm.AutoUpdater
{
    public interface IAutoUpdater
    {
        void Update();

        int CheckUpdaterFileCount();

        void RollBack();
    }
}
