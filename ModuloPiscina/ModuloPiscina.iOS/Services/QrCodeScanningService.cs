using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;


using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;
using ModuloPiscina.QR;

[assembly: Dependency(typeof(LecturaBarcode.iOS.Services.QrCodeScanningService))]
namespace LecturaBarcode.iOS.Services
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {
            var scanner = new MobileBarcodeScanner();
            var scanResult = await scanner.Scan();
            //Fix by Ale
            return (scanResult != null) ? scanResult.Text : string.Empty;

        }
    }
}