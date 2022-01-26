using QRCoder;
using System.Drawing;

QRCodeGenerator qrGenerator = new QRCodeGenerator();
QRCodeData qrCodeData = qrGenerator.CreateQrCode("Benjami Camacho", QRCodeGenerator.ECCLevel.Q);
PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
byte[] qrCodeImage = qrCode.GetGraphic(20);
using var stream = new MemoryStream(qrCodeImage);
Bitmap bitmap = new Bitmap(stream);
bitmap.Save("qr.png");
Console.WriteLine("Se guardo la imagen");