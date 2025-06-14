using AppBogedaTeo.DTO;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;


namespace AppBogedaTeo.Util
{
    public class ExcelUtil
    {

        public static string GenerarReporteVentasXls(List<VentasDTO> data, string[] columnas,string nombreReporte, string rutaDestino)
        {
            string result = String.Empty;
            string nombreArchivo = nombreReporte + DateTime.Now.Millisecond.ToString();
            nombreArchivo = @"\" + nombreArchivo + ".xlsx";
            rutaDestino = rutaDestino + nombreArchivo;
            try
            {
                XLWorkbook wk = new XLWorkbook();
                IXLWorksheet ws = wk.AddWorksheet(nombreReporte);

                int x = 1;
                int y = 1;

                //Nombres de Columnas
                foreach (var c in columnas) {
                    ws.Cell(y, x++).Value = c;
                }
             
                ws.Range(1,1,1,x).Style.Font.SetBold();
                ws.Range(1, 1, 1, x).Style.Alignment.SetWrapText(true);

                y++;
                //Filas
                foreach (var r in data)
                {
                    x = 1;
                    ws.Cell(y, x++).Value = r.Cod_Venta.ToString();
                    ws.Cell(y, x++).Value = r.DscTipoComp;
                    ws.Cell(y, x++).Value = r.Nro_Doc;
                    ws.Cell(y, x++).Value = r.NombresCompletos;
                    ws.Cell(y, x++).Value = r.DscMetodoPago;
                    ws.Cell(y, x++).Value = r.DscEstado;
                    ws.Cell(y, x++).Value = r.FechaCreacion;
                    //ws.Cell(y, x++).Value = r.FechaLimitePago;
                    ws.Cell(y, x++).Value = r.ImporteTotal.ToString();
               
                    y++;
                }

                int cantFilas = y - 1;
                int cantColumnas = columnas.Length ;
                //Centramos el contenido
                ws.Range(1, 1, cantFilas, cantColumnas).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                //Ajustamos texto en caso supere el tamaño establecido de la celda
                ws.Range(1, 1, cantFilas, cantColumnas).Style.Alignment.SetWrapText(true);

                //Crear Tabla
                IXLTable table = ws.Range(1, 1, cantFilas, cantColumnas).CreateTable();

                table.Theme = XLTableTheme.TableStyleLight9;
                ws.ColumnWidth = 25;
              
                wk.SaveAs(rutaDestino);

                wk.Dispose();
                result = "ok";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }


        public static string GenerarReporteSolCompraXls(List<SolCompraRepDTO> data, string[] columnas, string nombreReporte, string rutaDestino)
        {
            string result = String.Empty;
            string nombreArchivo = nombreReporte + DateTime.Now.Millisecond.ToString();
            nombreArchivo = @"\" + nombreArchivo + ".xlsx";
            rutaDestino = rutaDestino + nombreArchivo;
            try
            {
                XLWorkbook wk = new XLWorkbook();
                IXLWorksheet ws = wk.AddWorksheet(nombreReporte);

                int x = 1;
                int y = 1;

                //Nombres de Columnas
                foreach (var c in columnas)
                {
                    ws.Cell(y, x++).Value = c;
                }

                ws.Range(1, 1, 1, x).Style.Font.SetBold();
                ws.Range(1, 1, 1, x).Style.Alignment.SetWrapText(true);

                y++;
                //Filas
                foreach (var r in data)
                {
                    x = 1;
                    ws.Cell(y, x++).Value = r.CodSolCompra.ToString();
                    ws.Cell(y, x++).Value = r.RucProveedor;
                    ws.Cell(y, x++).Value = r.DscProveedor;
                    ws.Cell(y, x++).Value = r.DscEstadoSolCompra;
                    ws.Cell(y, x++).Value = r.FechaCreacion;
                    ws.Cell(y, x++).Value = r.ImporteTotalEsperado.ToString();
                    ws.Cell(y, x++).Value = r.ImporteTotalPagado.ToString();
                    y++;
                }

                int cantFilas = y - 1;
                int cantColumnas = columnas.Length;
                //Centramos el contenido
                ws.Range(1, 1, cantFilas, cantColumnas).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                //Ajustamos texto en caso supere el tamaño establecido de la celda
                ws.Range(1, 1, cantFilas, cantColumnas).Style.Alignment.SetWrapText(true);

                //Crear Tabla
                IXLTable table = ws.Range(1, 1, cantFilas, cantColumnas).CreateTable();

                table.Theme = XLTableTheme.TableStyleLight9;
                ws.ColumnWidth = 25;

                wk.SaveAs(rutaDestino);

                wk.Dispose();
                result = "ok";
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            return result;
        }

    }
}
