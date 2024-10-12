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
        public dynamic Post(string url, object body)
        {
            string responseContent = string.Empty;
            try
            {
                string jsonBody = JsonConvert.SerializeObject(body);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
                myWebRequest.Method = "POST";
                myWebRequest.ContentType = "application/json";
                myWebRequest.UserAgent = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9";
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;

                using (var streamWriter = new StreamWriter(myWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonBody);
                    streamWriter.Flush();
                }

                using (HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse())
                using (Stream myStream = myHttpWebResponse.GetResponseStream())
                using (StreamReader myStreamReader = new StreamReader(myStream))
                {
                    responseContent = myStreamReader.ReadToEnd();
                }

                if (string.IsNullOrWhiteSpace(responseContent))
                {
                    throw new Exception("La respuesta del servidor está vacía.");
                }

                // Intentar decodificar la respuesta
                string decodedResponse = DecodeResponse(responseContent);

                return JsonConvert.DeserializeObject<dynamic>(decodedResponse);
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
            catch (JsonException ex)
            {
                throw new Exception($"Error al deserializar la respuesta JSON: {ex.Message}. Contenido de la respuesta: {responseContent}");
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inesperado: {ex.Message}. Contenido de la respuesta: {responseContent}");
            }
        }

        private string DecodeResponse(string response)
        {
            try
            {
                // Primero, intentamos decodificar como JSON
                return JsonConvert.DeserializeObject<dynamic>(response).ToString();
            }
            catch
            {
                try
                {
                    // Si falla, intentamos decodificar como XML
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(response);
                    return JsonConvert.SerializeXmlNode(doc);
                }
                catch
                {
                    try
                    {
                        // Si ambos fallan, intentamos decodificar de base64
                        byte[] data = Convert.FromBase64String(response);
                        return Encoding.UTF8.GetString(data);
                    }
                    catch
                    {
                        // Si todo falla, devolvemos la respuesta original
                        return response;
                    }
                }
            }
        }
    }
}

