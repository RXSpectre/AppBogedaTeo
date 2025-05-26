using AppBogedaTeo.DTO;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;

namespace AppBogedaTeo.Util
{
    public class SolCompraPDFDocument : IDocument
    {
        //Importante esto , porque sino no funciona la generación
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;
        public readonly SolCompraReportesDTO data;

        public SolCompraPDFDocument(SolCompraReportesDTO data)
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
                    columns.RelativeColumn();
                    columns.RelativeColumn();

                });

                //Paso 2 Definiendo las cabeceras
                float tamanioLetra = 0.6f;
                table.Header(header =>
                {
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("CANTIDAD ANULADOS");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("CANTIDAD TERMINADOS");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("CANTIDAD TERMINADOS OBS.");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("CANTIDAD DE REGISTROS");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("TOTAL PAGADO");


                    IContainer EstiloCelda(IContainer container1)
                    {
                        return container1.Scale(tamanioLetra).DefaultTextStyle(x => x.SemiBold()).PaddingVertical(1).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                tamanioLetra = 0.6f;

                string cantAnulados = "0.00";
                string cantTerminado = "0.00";
                string cantTerminadoObs = "0.00";
                string cantRegistros = "0.00";

                //Paso 3 definiendo los datos
                foreach (var item in data.estadosXCantidad)
                {
                    if (item.DscEstadoSolCompra == "Anulado")
                        cantAnulados = item.Cantidad.ToString();
                    if (item.DscEstadoSolCompra == "Terminado")
                        cantTerminado = item.Cantidad.ToString();
                    if (item.DscEstadoSolCompra == "Terminado con observaciones")
                        cantTerminadoObs = item.Cantidad.ToString();
                    if (item.DscEstadoSolCompra == "Todos")
                        cantRegistros = item.Cantidad.ToString();                    
                }

                table.Cell().Element(EstiloCelda2).AlignCenter().Text(cantAnulados);
                table.Cell().Element(EstiloCelda2).AlignCenter().Text(cantTerminado);
                table.Cell().Element(EstiloCelda2).AlignCenter().Text(cantTerminadoObs);
                table.Cell().Element(EstiloCelda2).AlignCenter().Text(cantRegistros);
                table.Cell().Element(EstiloCelda2).AlignCenter().Text(data.ImporteTotalPagado.ToString());

                IContainer EstiloCelda2(IContainer container1)
                {
                    return container1.Scale(tamanioLetra).BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(2);
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
                    columns.RelativeColumn();
                    columns.RelativeColumn(1.5f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(4f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                    columns.RelativeColumn(2f);
                });

                //Paso 2 Definiendo las cabeceras
                float tamanioLetra = 0.6f;
                table.Header(header =>
                {
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("CÓDIGO");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("RUC");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("RAZÓN SOCIAL");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("ESTADO");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("F. CREACIÓN");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("TOTAL ESPERADO");
                    header.Cell().Element(EstiloCelda).AlignCenter().Text("TOTAL PAGADO");
                    


                    IContainer EstiloCelda(IContainer container1)
                    {
                        return container1.Scale(tamanioLetra).DefaultTextStyle(x => x.SemiBold()).PaddingVertical(1).BorderBottom(1).BorderColor(Colors.Black);
                    }
                });

                tamanioLetra = 0.6f;

                //Paso 3 definiendo los datos
                foreach (var item in data.data)
                {

                    table.Cell().Element(EstiloCelda).AlignCenter().Text(item.CodSolCompra.ToString());
                    table.Cell().Element(EstiloCelda).AlignCenter().Text(item.RucProveedor);
                    table.Cell().Element(EstiloCelda).AlignCenter().Text(item.DscProveedor);
                    table.Cell().Element(EstiloCelda).AlignCenter().Text(item.DscEstadoSolCompra);
                    table.Cell().Element(EstiloCelda).AlignCenter().Text(item.FechaCreacion);
                    table.Cell().Element(EstiloCelda).AlignCenter().Text(item.ImporteTotalEsperado.ToString());
                    table.Cell().Element(EstiloCelda).AlignCenter().Text(item.ImporteTotalPagado.ToString());

                    IContainer EstiloCelda(IContainer container1)
                    {
                        return container1.Scale(tamanioLetra).BorderBottom(1).BorderColor(Colors.Grey.Lighten2).PaddingVertical(2);
                    }
                }
            });
        }

        private void ConstruirCabecera(IContainer container)
        {
            container.Row(row =>
            {
                float tamanioLetra = 0.9f;
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("BODEGA TEO").SemiBold().Underline();
                    column.Item().Text("REPORTES DE SOLICITUD DE COMPRAS").SemiBold();
                    column.Item().Scale(tamanioLetra).Text($"Fecha Emisión : {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")}");
                });

            });
        }
    }
}
