using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronBarCode;

namespace BarcodeGenerator
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//Generating Barcode
			var barcode = BarcodeWriter.CreateBarcode("This sample barcode for Patika" , BarcodeEncoding.Code128);
			barcode.AddBarcodeValueTextBelowBarcode();
			barcode.SaveAsPng("Barcode.png");

			//Reading Barcode
			BarcodeResult barcodeResult = BarcodeReader.QuicklyReadOneBarcode("Barcode.png");
			Console.WriteLine(barcodeResult.Text);

			//Generating QR Code
			GeneratedBarcode QRCode = IronBarCode.BarcodeWriter.CreateBarcode("https://academy.patika.dev/tr/dashboard" ,BarcodeEncoding.QRCode);
			QRCode.SaveAsPng("PatikaWebSiteQRCode.png");

			//Bu QR Code Patika'nın web sayfasını açar

			Console.ReadKey();
		}
	}
}
