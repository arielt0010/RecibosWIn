using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf.Extgstate;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font;

namespace RecibosWin
{
    public class DocumentoPDF
    {
        //directorio donde estan las imagenes
        //public static readonly string BACKGROUNDPIC = "../../../Resources/background2.jpg";
        //public static readonly string FIRMA = "../../../Resources/firma.png";
        //public static readonly string LOGOSUPERIOR = "../../../Resources/logoReducido.jpg";

        public void generatePDF(string nro, string name, string cash, string day, string month, string year,
                                string codigo_alumno, string curso_alumno, string anioseguro,
                                string ruta)
        {
            //DECLARACION CLASES
            ConversorNumeros cn = new ConversorNumeros(); ;

            //DECLARACION VARIABLES CONVERSOR PDF
            PdfWriter pdfWriter;
            PdfDocument pdfDoc;
            Document document;
            Paragraph cabecera;
            Paragraph cabecera2;
            Paragraph numeroRecibo;
            PageSize pageSize = PageSize.LETTER;
            PdfCanvas canvas;
            LineSeparator ls;
            iText.Kernel.Colors.Color rEd = new iText.Kernel.Colors.DeviceRgb(255, 29, 13);
            iText.Kernel.Colors.Color bluE = new iText.Kernel.Colors.DeviceRgb(11, 65, 156);
            //iText.Kernel.Colors.Color blAck = new iText.Kernel.Colors.DeviceRgb(0, 0, 0);


            //INICIALIZACION VARIABLES CONVERSOR PDF
            pdfWriter = new PdfWriter(ruta);
            pdfDoc = new PdfDocument(pdfWriter);
            document = new Document(pdfDoc, pageSize);
            ls = new LineSeparator(new SolidLine());

            //MODIFICANDO DOCUMENTO       
            //background
            canvas = new PdfCanvas(pdfDoc.AddNewPage());
            canvas.SaveState();
            PdfExtGState state = new PdfExtGState().SetFillOpacity(0.8f);
            canvas.SetExtGState(state);
            //canvas.AddImageFittedIntoRectangle(ImageDataFactory.Create(BACKGROUNDPIC), pageSize, false);

            //logo principal
            //ImageData logoSuperior = ImageDataFactory.Create(LOGOSUPERIOR);
            //iText.Layout.Element.Image logoSuperiorImagen = new iText.Layout.Element.Image(logoSuperior);
            //logoSuperiorImagen.SetTextAlignment(TextAlignment.LEFT).ScaleToFit(250, 339).SetRelativePosition(0, 0, 0, 0).SetPaddings(0, 0, 0, 0).SetMargins(0, 0, 0, 0);
            //document.Add(logoSuperiorImagen);

            //texto



            //Paragraph vacio = new Paragraph("");

            //add firma
            //iText.Layout.Element.Image firma = new iText.Layout.Element.Image(ImageDataFactory.Create(FIRMA)).SetTextAlignment(TextAlignment.LEFT);

            //anadir los elementos
            try
            {
                cabecera = new Paragraph("COMPROBANTE").SetPaddings(0, 0, 0, 0).SetMargins(0, 0, 0, 0).SetTextAlignment(TextAlignment.RIGHT)
           .SetVerticalAlignment(VerticalAlignment.TOP).SetFontSize(22).SetBold().SetFontColor(bluE);
                cabecera2 = new Paragraph("DE PAGO").SetPaddings(0, 0, 0, 0).SetMargins(0, 0, 0, 0).SetTextAlignment(TextAlignment.RIGHT)
                            .SetVerticalAlignment(VerticalAlignment.TOP).SetFontSize(22).SetBold().SetWordSpacing(0).SetFontColor(bluE);
                numeroRecibo = new Paragraph("Nro. " + nro).SetTextAlignment(TextAlignment.LEFT)
                            .SetVerticalAlignment(VerticalAlignment.TOP).SetFontSize(15).SetFontColor(rEd).SetBold();

                //texto per se
                Paragraph dia = new Paragraph("Fecha: ").SetFontColor(bluE);
                dia.Add(new Text(day + " de " + month + " del " + year).SetBold().SetFontColor(bluE));
                Paragraph senior = new Paragraph("He recibido del Alumno(a): ").SetFontColor(bluE);
                senior.Add(new Text(name.ToUpper()).SetBold().SetFontColor(bluE));
                Paragraph suma = new Paragraph("La suma de: ").SetFontColor(bluE);
                suma.Add(new Text(cn.Convertir(cash, true)).SetBold().SetFontColor(bluE));
                Paragraph concepto = new Paragraph("Por concepto de: ").SetFontColor(bluE);
                concepto.Add(new Text("ASISTENCIA MEDICA DE EMERGENCIA").SetBold().SetFontColor(bluE));
                concepto.Add(new Text("\t\t\tGestion: ")).SetFontColor(bluE);
                concepto.Add(new Text(anioseguro).SetBold().SetFontColor(bluE));
                Paragraph codigo = new Paragraph("Codigo del alumno: ").SetFontColor(bluE);
                codigo.Add(new Text(codigo_alumno.ToUpper()).SetBold().SetFontColor(bluE));
                codigo.Add(new Text("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t  Curso: ").SetFontColor(bluE));
                codigo.Add(new Text(curso_alumno.ToUpper()).SetBold().SetFontColor(bluE));
                document.Add(cabecera);
                document.Add(cabecera2);
                document.Add(numeroRecibo);
                document.Add(ls);
                document.Add(dia);
                document.Add(senior);
                document.Add(suma);
                document.Add(concepto);
                document.Add(codigo);
                // document.Add(vacio);
                //document.Add(vacio);
                //document.Add(vacio);
                //document.Add(vacio);
                //document.Add(vacio);
                //document.Add(vacio);

                //cerrar documento
                document.Close();
            }
            catch(Exception e23) { MessageBox.Show(e23.Message.ToString()); }

        }
    }
}
