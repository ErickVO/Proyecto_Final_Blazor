using iTextSharp.text;
using iTextSharp.text.pdf;
using StudioEF.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudioEF.Reportes
{
    public class ReporteUsuario
    {
        int columnas = 5;

        Document document = new Document();
        PdfPTable pdfTable;
        PdfPCell pdfCell = new PdfPCell();
        Font fontStyle, fontFecha, fontTitulo;

        MemoryStream memoryStream = new MemoryStream();

        List<Usuarios> listaUsuarios = new List<Usuarios>();

        public byte[] Reporte(List<Usuarios> lista)
        {
            listaUsuarios = lista;

            document = new Document(PageSize.LETTER, 25f, 25f, 20f, 20f);
            pdfTable = new PdfPTable(columnas);

            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            fontStyle = FontFactory.GetFont("Calibri", 8f, 1);

            PdfWriter.GetInstance(document, memoryStream);
            document.Open();

            float[] anchoColumnas = new float[columnas];

            anchoColumnas[0] = 130; //Esta sera la fila 0 usuarioId
            anchoColumnas[1] = 130; //Esta sera la fila 1 Nombre
            anchoColumnas[2] = 130; //Esta sera la fila 2 Nombre Usuario
            anchoColumnas[3] = 130; //Esta sera la fila 3 Contrasena
            anchoColumnas[4] = 130; //Esta sera la fila 4 Email


            pdfTable.SetWidths(anchoColumnas);

            this.ReportHeader();
            this.ReportBody();

            pdfTable.HeaderRows = 1;
            document.Add(pdfTable);
            document.Close();

            return memoryStream.ToArray();
        }
        private void ReportHeader()
        {
            pdfCell = new PdfPCell(this.AddLogo());
            pdfCell.Colspan = 1;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(this.setPageTitle());
            pdfCell.Colspan = columnas;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();
        }

        private PdfPTable AddLogo()
        {
            int maxColumn = 1;
            PdfPTable pdfPTable = new PdfPTable(maxColumn);
           
            pdfCell.Colspan = maxColumn;
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfPTable.AddCell(pdfCell);

            pdfPTable.CompleteRow();

            return pdfPTable;
        }

        private PdfPTable setPageTitle()
        {
            PdfPTable pdfTable = new PdfPTable(2);

            fontStyle = FontFactory.GetFont("Calibri", 18f, 1);
            fontFecha = FontFactory.GetFont("Calibri", 10f, 1);
            fontTitulo = FontFactory.GetFont("Calibri", 25f, 1);

            pdfCell = new PdfPCell(new Phrase("Foto Estudio EF", fontTitulo));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Colspan = 2;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();

            pdfCell = new PdfPCell(new Phrase("Reporte de Usuarios", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Colspan = 2;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();

            pdfCell = new PdfPCell(new Phrase(DateTime.Now.ToString("dd/MM/yyyy"), fontFecha));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Colspan = 2;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();

            //Una fila en blanco
            pdfCell = new PdfPCell(new Phrase(" ", fontStyle));
            pdfCell.Colspan = 2;
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.Border = 0;
            pdfCell.ExtraParagraphSpace = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();

            return pdfTable;
        }

        private void ReportBody()
        {
            fontStyle = FontFactory.GetFont("Calibri", 9f, 1);
            var _fontStyle = FontFactory.GetFont("Calibri", 9f, 0);

            #region Table Header
            pdfCell = new PdfPCell(new Phrase("UsuarioId", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Nombres", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Nombre Usuario", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Contraseña", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("Email", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.LIGHT_GRAY;
            pdfTable.AddCell(pdfCell);


            pdfTable.CompleteRow();
            #endregion

            #region Table Body
            int num = 0;

            foreach (var item in listaUsuarios)
            {
                num++;
                pdfCell = new PdfPCell(new Phrase(item.UsuarioId.ToString(), _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.WHITE;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.Nombres.ToString(), _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.WHITE;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.NombreUsuario, _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.WHITE;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.Contrasena, _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.WHITE;
                pdfTable.AddCell(pdfCell);

                pdfCell = new PdfPCell(new Phrase(item.Email, _fontStyle));
                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                pdfCell.BackgroundColor = BaseColor.WHITE;
                pdfTable.AddCell(pdfCell);


                pdfTable.CompleteRow();
            }

            pdfCell = new PdfPCell(new Phrase("Total de Registros", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase(num++.ToString(), fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfCell = new PdfPCell(new Phrase("            ", fontStyle));
            pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell.BackgroundColor = BaseColor.WHITE;
            pdfCell.Border = 0;
            pdfTable.AddCell(pdfCell);

            pdfTable.CompleteRow();
            #endregion
        }
    }
}
