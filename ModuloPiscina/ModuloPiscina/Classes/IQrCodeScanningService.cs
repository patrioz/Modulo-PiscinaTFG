﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

namespace ModuloPiscina.QR
{
   public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
