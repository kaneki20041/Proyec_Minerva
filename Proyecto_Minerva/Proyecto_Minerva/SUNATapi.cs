using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;

using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace CapaPresentacion
{
    public class FacturacionApi
    {
        private readonly string token;

        public FacturacionApi(string token)
        {
            this.token = token;
        }

        public dynamic Post(string url, object body)
        {
            string responseContent = string.Empty;
            try
            {
                string jsonBody = JsonConvert.SerializeObject(body);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
                myWebRequest.Method = "POST";
                myWebRequest.ContentType = "application/json";
                myWebRequest.Headers["Authorization"] = $"Bearer {token}";
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;

                using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonBody);
                    streamWriter.Flush();
                }

                using (HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse())
                using (Stream myStream = myHttpWebResponse.GetResponseStream())
                {
                    if (myHttpWebResponse.ContentType == "application/pdf")
                    {
                        // Guardar el PDF en la carpeta de Documentos del usuario
                        string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Factura.pdf");
                        using (var fileStream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write))
                        {
                            myStream.CopyTo(fileStream);
                        }
                        return new { pdf_url = pdfPath };
                    }
                    else
                    {
                        using (StreamReader myStreamReader = new StreamReader(myStream))
                        {
                            responseContent = myStreamReader.ReadToEnd();
                        }
                        if (string.IsNullOrWhiteSpace(responseContent))
                        {
                            throw new Exception("La respuesta del servidor está vacía.");
                        }
                        return JsonConvert.DeserializeObject<dynamic>(responseContent);
                    }
                }
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response?.GetResponseStream())
                using (var reader = new StreamReader(stream ?? Stream.Null))
                {
                    responseContent = reader.ReadToEnd();
                }
                throw new Exception($"Error de red: {ex.Message}. Respuesta del servidor: {responseContent}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}. Contenido de la respuesta: {responseContent}");
            }
        }
    }
}

