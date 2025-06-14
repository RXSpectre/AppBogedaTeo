using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using AppBogedaTeo.DTO;
using System;
using QuestPDF.Helpers;

namespace AppBogedaTeo.Util
{
    public class VentasPDFDocument : IDocument
    {
        //Importante esto , porque sino no funciona la generación
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;



        public readonly VentasReportesDTO data;
        public VentasPDFDocument(VentasReportesDTO data)
        {
            this.data = data;
        }
        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(20);
                
                //pagina.Header().Element(ConstruirCabecera) //  
                page.Header().Height(70).Background(Colors.Grey.Lighten1).Padding(5).Element(ConstruirCabecera);
                page.Content().Element(ConstruirContenido);
            });
        }

        private void ConstruirCabecera(IContainer container)
        {
            container.Row(row =>
            {
                float tamanioLetra =0.9f;
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("BODEGA TEO").SemiBold().Underline();
                    column.Item().Text("REPORTES DE VENTAS").SemiBold();
                    column.Item().Scale(tamanioLetra).Text($"Fecha Emisión : {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}");
                });

            });
        }

        private void ConstruirContenido(IContainer container)
        {
            container.PaddingVertical(30).Column(columna =>
            {
                columna.Spacing(5);

                columna.Item().Element(ConstruirTablaContenido);
                columna.Item().Text(" ");
                columna.Item().Scale(0.6f).Text("RESUMEN").Bold();
                columna.Item().AlignCenter().Element(ConstruirTablaResumen);

            });
        }

        private void ConstruirTablaResumen(IContainer container)
        {
            container.Table(table =>
            {
                //Paso 1 Definiendo las columnas
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                    columns.RelativeColumn();
                
                });

                //Paso 2 Definiendo las cabeceras
                float tamanioLetra = 0.6f;
                table.Header(header =>
                {
                    header.Cell().Element(EstiloCelda).Text("MÉTODO DE PAGO");
                    header.Cell().Element(EstiloCelda).Text("CANTIDAD");
                    header.Cell().Element(EstiloCelda).Text("TOTALES");
                 

                    IContainer EstiloCelda(IContainer container1)
                    {
                        return container1.Scale(tamanioLetra).DefaultTextStyle(x => x.SemiBold()).PaddingVertical(1).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                tamanioLetra = 0.6f;

                //Paso 3 definiendo los datos
                foreach (var item in data.resumen)
                {
                    table.Cell().Element(EstiloCelda).Text(item.Descripcion);
                    table.Cell().Element(EstiloCelda).Text(item.Cantidad.ToString());
                    table.Cell().Element(EstiloCelda).Text(item.ImporteTotal.ToString());

                    IContainer EstiloCelda(IContainer container1)
                    {
                        return container1.Scale(tamanioLetra).BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(2);
                    }
                }
            });
        }

        private void ConstruirTablaContenido(IContainer container)
        {
            container.Table(table => 
            {
                //Paso 1 Definiendo las columnas
                table.ColumnsDefinition(columns =>
                {
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                });

                //Paso 2 Definiendo las cabeceras
                float tamanioLetra = 0.6f;
                table.Header(header =>
                {
                    header.Cell().Element(EstiloCelda).Text("COD. VENTA");
                    header.Cell().Element(EstiloCelda).Text("TIPO DE COMPROBANTE");
                    header.Cell().Element(EstiloCelda).Text("DNI");
                    header.Cell().Element(EstiloCelda).Text("CLIENTE");
                    header.Cell().Element(EstiloCelda).Text("MÉTODO DE PAGO");
                    header.Cell().Element(EstiloCelda).Text("ESTADO");
                    header.Cell().Element(EstiloCelda).Text("F. CREACIÓN");
                    //header.Cell().Element(EstiloCelda).Text("F. LIMITE DE\nPAGO");
                    header.Cell().Element(EstiloCelda).Text("TOTAL");

                    IContainer EstiloCelda(IContainer container1)
                    {
                        return container1.Scale(tamanioLetra).DefaultTextStyle(x => x.SemiBold()).PaddingVertical(1).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                tamanioLetra = 0.6f;

                //Paso 3 definiendo los datos
                foreach (var item in data.data)
                {

                    table.Cell().Element(EstiloCelda).Text(item.Cod_Venta.ToString());
                    table.Cell().Element(EstiloCelda).Text(item.DscTipoComp);
                    table.Cell().Element(EstiloCelda).Text(item.Nro_Doc);
                    table.Cell().Element(EstiloCelda).Text(item.NombresCompletos);
                    table.Cell().Element(EstiloCelda).Text(item.DscMetodoPago);
                    table.Cell().Element(EstiloCelda).Text(item.DscEstado);
                    table.Cell().Element(EstiloCelda).Text(item.FechaCreacion);
                    //table.Cell().Element(EstiloCelda).Text(item.FechaLimitePago);
                    table.Cell().Element(EstiloCelda).Text($"{item.ImporteTotal:N}");


                    IContainer EstiloCelda(IContainer container1)
                    {
                        return container1.Scale(tamanioLetra).BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(2);
                    }
                }
            });
        }

      
       
    }
}
